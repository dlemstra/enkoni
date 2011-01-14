﻿//--------------------------------------------------------------------------------------------------------------------------
// <copyright file="GlobalSuppressions.cs" company="Oscar Brouwer">
//     Copyright (c) Oscar Brouwer 2010. All rights reserved.
// </copyright>
// <summary>
//     Holds the project's suppressions.
// </summary>
//--------------------------------------------------------------------------------------------------------------------------

using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member", Target = "OscarBrouwer.Framework.Entities.Repository`1.#OscarBrouwer.Framework.ISpecificationVisitor`1<!0>.CreateAndExpression(OscarBrouwer.Framework.ISpecification`1<!0>,OscarBrouwer.Framework.ISpecification`1<!0>)", Justification = "Intentionally implemented interface explicitely to keep the API clean")]
[assembly: SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member", Target = "OscarBrouwer.Framework.Entities.Repository`1.#OscarBrouwer.Framework.ISpecificationVisitor`1<!0>.CreateCustomExpression(OscarBrouwer.Framework.ISpecification`1<!0>)", Justification = "Intentionally implemented interface explicitely to keep the API clean")]
[assembly: SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member", Target = "OscarBrouwer.Framework.Entities.Repository`1.#OscarBrouwer.Framework.ISpecificationVisitor`1<!0>.CreateLambdaExpression(System.Func`2<!0,System.Boolean>)", Justification = "Intentionally implemented interface explicitely to keep the API clean")]
[assembly: SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member", Target = "OscarBrouwer.Framework.Entities.Repository`1.#OscarBrouwer.Framework.ISpecificationVisitor`1<!0>.CreateLikeExpression(System.Func`2<!0,System.String>,System.String)", Justification = "Intentionally implemented interface explicitely to keep the API clean")]
[assembly: SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member", Target = "OscarBrouwer.Framework.Entities.Repository`1.#OscarBrouwer.Framework.ISpecificationVisitor`1<!0>.CreateOrExpression(OscarBrouwer.Framework.ISpecification`1<!0>,OscarBrouwer.Framework.ISpecification`1<!0>)", Justification = "Intentionally implemented interface explicitely to keep the API clean")]

[assembly: SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0", Scope = "member", Target = "OscarBrouwer.Framework.Entities.DatabaseSourceInfo.#SelectDbContext(OscarBrouwer.Framework.Entities.DataSourceInfo)", Justification = "The parameter is checked through the Is*Specified method")]
[assembly: SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0", Scope = "member", Target = "OscarBrouwer.Framework.Entities.DatabaseSourceInfo.#.ctor(System.Collections.Generic.Dictionary`2<System.String,System.Object>)", Justification = "Validation is done by the base constructor.")]
[assembly: SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0", Scope = "member", Target = "OscarBrouwer.Framework.Entities.FileSourceInfo.#SelectMonitorSourceFile(OscarBrouwer.Framework.Entities.DataSourceInfo)", Justification = "The parameter is checked through the Is*Specified method")]
[assembly: SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0", Scope = "member", Target = "OscarBrouwer.Framework.Entities.FileSourceInfo.#SelectSourceFileInfo(OscarBrouwer.Framework.Entities.DataSourceInfo)", Justification = "The parameter is checked through the Is*Specified method")]
[assembly: SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0", Scope = "member", Target = "OscarBrouwer.Framework.Entities.FileSourceInfo.#SelectChangeCompleteTimeout(OscarBrouwer.Framework.Entities.DataSourceInfo)", Justification = "The parameter is checked through the Is*Specified method")]
[assembly: SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0", Scope = "member", Target = "OscarBrouwer.Framework.Entities.FileSourceInfo.#.ctor(System.Collections.Generic.Dictionary`2<System.String,System.Object>)", Justification = "Validation is done by the base constructor.")]
[assembly: SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0", Scope = "member", Target = "OscarBrouwer.Framework.Entities.CsvFileSourceInfo.#SelectSourceFileEncoding(OscarBrouwer.Framework.Entities.DataSourceInfo)", Justification = "The parameter is checked through the Is*Specified method")]
[assembly: SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0", Scope = "member", Target = "OscarBrouwer.Framework.Entities.CsvFileSourceInfo.#.ctor(System.Collections.Generic.Dictionary`2<System.String,System.Object>)", Justification = "Validation is done by the base constructor.")]
[assembly: SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0", Scope = "member", Target = "OscarBrouwer.Framework.Entities.CsvFileRepository`1.#ReadAllRecordsFromFile(System.IO.FileInfo,OscarBrouwer.Framework.Entities.DataSourceInfo)", Justification = "Validation is done by the baseclass")]
[assembly: SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0", Scope = "member", Target = "OscarBrouwer.Framework.Entities.CsvFileRepository`1.#WriteAllRecordsToFile(System.IO.FileInfo,OscarBrouwer.Framework.Entities.DataSourceInfo,System.Collections.Generic.IEnumerable`1<!0>)", Justification = "Validation is done by the baseclass")]
[assembly: SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0", Scope = "member", Target = "OscarBrouwer.Framework.Entities.XmlFileRepository`1.#ReadAllRecordsFromFile(System.IO.FileInfo,OscarBrouwer.Framework.Entities.DataSourceInfo)", Justification = "Validation is done by the baseclass")]
[assembly: SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0", Scope = "member", Target = "OscarBrouwer.Framework.Entities.XmlFileRepository`1.#WriteAllRecordsToFile(System.IO.FileInfo,OscarBrouwer.Framework.Entities.DataSourceInfo,System.Collections.Generic.IEnumerable`1<!0>)", Justification = "Validation is done by the baseclass")]
[assembly: SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0", Scope = "member", Target = "OscarBrouwer.Framework.Entities.ServiceSourceInfo.#SelectEndpointConfigurationName(OscarBrouwer.Framework.Entities.DataSourceInfo)", Justification = "The parameter is checked through the Is*Specified method")]
[assembly: SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0", Scope = "member", Target = "OscarBrouwer.Framework.Entities.ServiceSourceInfo.#SelectBinding(OscarBrouwer.Framework.Entities.DataSourceInfo)", Justification = "The parameter is checked through the Is*Specified method")]
[assembly: SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0", Scope = "member", Target = "OscarBrouwer.Framework.Entities.ServiceSourceInfo.#SelectRemoteAddress(OscarBrouwer.Framework.Entities.DataSourceInfo)", Justification = "The parameter is checked through the Is*Specified method")]
[assembly: SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0", Scope = "member", Target = "OscarBrouwer.Framework.Entities.ServiceSourceInfo.#.ctor(System.Collections.Generic.Dictionary`2<System.String,System.Object>)", Justification = "Validation is done by the base constructor.")]
[assembly: SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0", Scope = "member", Target = "OscarBrouwer.Framework.Entities.MemorySourceInfo`1.#.ctor(System.Collections.Generic.Dictionary`2<System.String,System.Object>)", Justification = "Validation is done by the base constructor.")]
[assembly: SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0", Scope = "member", Target = "OscarBrouwer.Framework.Entities.MemorySourceInfo.#SelectMemoryStore`1(OscarBrouwer.Framework.Entities.DataSourceInfo)", Justification = "The parameter is checked through the Is*Specified method")]
[assembly: SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "1", Scope = "member", Target = "OscarBrouwer.Framework.Entities.DatabaseRepository`1.#CreateLikeExpressionCore(System.Func`2<!0,System.String>,System.String)", Justification = "The parameter is checked in the public method")]
[assembly: SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0", Scope = "member", Target = "OscarBrouwer.Framework.Entities.Repository`1.#CreateCustomExpressionCore(OscarBrouwer.Framework.ISpecification`1<!0>)", Justification = "The parameter is checked in the public method")]
[assembly: SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "1", Scope = "member", Target = "OscarBrouwer.Framework.Entities.Repository`1.#CreateLikeExpressionCore(System.Func`2<!0,System.String>,System.String)", Justification = "The parameter is checked in the public method")]

[assembly: SuppressMessage("Microsoft.Design", "CA1063:ImplementIDisposableCorrectly", Scope = "member", Target = "OscarBrouwer.Framework.Entities.Repository`1.#Dispose()", Justification = "The Microsoft reference implementation is wrong.")]

[assembly: SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity", Scope = "member", Target = "OscarBrouwer.Framework.Entities.MemoryRepository`1.#SaveChangesCore(OscarBrouwer.Framework.Entities.DataSourceInfo)", Justification = "The code is well documented and therefore fine.")]

[assembly: SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "Db", Scope = "member", Target = "OscarBrouwer.Framework.Entities.DatabaseRepository`1.#DbContext", Justification = "This naming follows the naming convention of the EntityFramework CF CTP-library")]

[assembly: SuppressMessage("Microsoft.Usage", "CA1816:CallGCSuppressFinalizeCorrectly", Scope = "member", Target = "OscarBrouwer.Framework.Entities.Repository`1.#Dispose()", Justification = "The Microsoft reference implementation is wrong.")]

[assembly: SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "FileRepository", Scope = "member", Target = "OscarBrouwer.Framework.Entities.FileRepository`1.#.ctor(OscarBrouwer.Framework.Entities.DataSourceInfo)", Justification = "The spelling here is fine")]
