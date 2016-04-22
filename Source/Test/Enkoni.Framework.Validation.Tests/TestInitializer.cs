﻿using Microsoft.SqlServer.Dac;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Enkoni.Framework.Validation.Tests {
  /// <summary>Contains the initialization logic for the unit tests in this assembly.</summary>
  [TestClass]
  public class TestInitializer {
    /// <summary>The connection string that is used by the test cases.</summary>
    public const string ConnectionString = @"Data Source=(LocalDB)\v11.0;Initial Catalog=Enkoni_Validation_Tests;Integrated Security=True;Connect Timeout=30";

    /// <summary>Initializes the unit tests.</summary>
    /// <param name="context"></param>
    //[AssemblyInitialize]
    public static void Initialize(TestContext context) {
      DacPackage package = DacPackage.Load("Enkoni.Framework.Validation.Tests.Database.dacpac");
      DacDeployOptions deployOptions = new DacDeployOptions {
        BlockOnPossibleDataLoss = false,
        CreateNewDatabase = true,
        DeployDatabaseInSingleUserMode = true
      };

      DacServices dacServices = new DacServices(@"Data Source=(LocalDB)\v11.0;Integrated Security=True;Connect Timeout=30");
      dacServices.Deploy(package, "Enkoni_Validation_Tests", true, deployOptions);
    }
  }
}
