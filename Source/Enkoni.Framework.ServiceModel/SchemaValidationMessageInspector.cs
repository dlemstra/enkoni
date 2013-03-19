﻿//---------------------------------------------------------------------------------------------------------------------------------------------------
// <copyright file="SchemaValidationMessageInspector.cs" company="Oscar Brouwer">
//     Copyright (c) Oscar Brouwer 2012. All rights reserved.
// </copyright>
// <summary>
//   Implementatie van een inspector die ontvangen berichten kan valideren tegen een XSD schema.
// </summary>
// <remark>
//   Implementatie gebaseerd op de code van Microsoft (http://msdn.microsoft.com/en-us/library/ff647820.aspx)
// </remark>
// --------------------------------------------------------------------------------------------------------------------------------------------------

using System.Globalization;
using System.IO;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Dispatcher;
using System.Xml;
using System.Xml.Schema;

using Enkoni.Framework.Logging;
using Enkoni.Framework.ServiceModel.Properties;

namespace Enkoni.Framework.ServiceModel {
  /// <summary>Implements a message inspector that inspects a received message.</summary>
  public class SchemaValidationMessageInspector : IDispatchMessageInspector {
    #region Instance variables
    /// <summary>The schemas that are used to validate the messages.</summary>
    private readonly XmlSchemaSet schemas;
    #endregion

    #region Constructor
    /// <summary>Initializes a new instance of the <see cref="SchemaValidationMessageInspector"/> class.</summary>
    /// <param name="schemas">The schemas that are to be used.</param>
    public SchemaValidationMessageInspector(XmlSchemaSet schemas) {
      this.schemas = schemas;
    }
    #endregion

    #region IDispatchMessageInspector implementation
    /// <summary>Called after an inbound message has been received but before the message is dispatched to the intended operation.</summary>
    /// <param name="request">The request message.</param>
    /// <param name="channel">The incoming channel.</param>
    /// <param name="instanceContext">The current service instance.</param>
    /// <returns>The object used to correlate state. This object is passed back in the BeforeSendReply(Message@,object) method.</returns>
    public object AfterReceiveRequest(ref Message request, IClientChannel channel, InstanceContext instanceContext) {
      if(request == null) {
        return null;
      }

      /* Create a buffer in order to make it possible to work with copies of the message */
      MessageBuffer buffer = request.CreateBufferedCopy(int.MaxValue);

      /* Create a copy of the message and send it to the validation */
      request = buffer.CreateMessage();
      try {
        this.ValidateMessage(request);
      }
      catch(XmlSchemaValidationException ex) {
        Logger logger = LogManager.CreateLogger();
        logger.Warn(LogMessages.WarningReceivedMessageIsInvalid, "enkoni.framework", ex);

        FaultReasonText reasonText = new FaultReasonText(Resources.MessageDoesNotComplyWithSchema, CultureInfo.InvariantCulture);
        throw new FaultException<string>(ex.Message, new FaultReason(reasonText), FaultCode.CreateSenderFaultCode(new FaultCode("InvalidMessage")));
      }

      /* Validation was succesfull. Create a new copy of the message and pass it to the WCF process. */
      request = buffer.CreateMessage();

      /* There is no need to correlate the AfterReceiveRequest en BeforeSendReply calls, so simply return null */
      return null;
    }

    /// <summary>Called after the operation has returned but before the reply message is sent.</summary>
    /// <param name="reply">The reply message. This value is null if the operation is one way.</param>
    /// <param name="correlationState">The correlation object returned from the AfterReceiveRequest(Message@,IClientChannel,InstanceContext) method.
    /// </param>
    public void BeforeSendReply(ref Message reply, object correlationState) {
      /* Nothing to do */
    }
    #endregion

    #region Private methods
    /// <summary>Validates the message using the supplied XSD-schemas.</summary>
    /// <param name="message">The message that is to be validated.</param>
    /// <exception cref="XmlSchemaValidationException">The body of the message does not comply with the schema.</exception>
    private void ValidateMessage(Message message) {
      XmlDocument bodyDoc = new XmlDocument();

      /* Write the contents (body) of the message to a memorystream */
      using(Stream stream = new MemoryStream()) {
        using(XmlWriter writer = XmlWriter.Create(stream)) {
          message.WriteBody(writer);
          writer.Flush();
          stream.Position = 0;

          /* Laad de inhoud van de memorystream in een Xmldocument */
          bodyDoc.Load(stream);
        }
      }

      /* Valideer de inhoud van het document */
      XmlReaderSettings settings = new XmlReaderSettings();
      settings.Schemas.Add(this.schemas);
      settings.ValidationType = ValidationType.Schema;

      using(XmlReader reader = XmlReader.Create(new XmlNodeReader(bodyDoc), settings)) {
        /* Within this while-loop the actual validation is executed. If the validation fails, a XmlSchemaValidationException will be thrown */
        while(reader.Read()) {
          /* Nothing specific to do, just keep reading */
        }
      }
    }
    #endregion
  }
}