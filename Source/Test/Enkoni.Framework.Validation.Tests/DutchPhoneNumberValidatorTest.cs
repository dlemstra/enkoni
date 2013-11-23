﻿//---------------------------------------------------------------------------------------------------------------------------------------------------
// <copyright file="DutchPhoneNumberValidatorTest.cs" company="Oscar Brouwer">
//     Copyright (c) Oscar Brouwer 2013. All rights reserved.
// </copyright>
// <summary>
//     Contains testcases that test the functionality of the DutchPhoneNumberValidator class.
// </summary>
//---------------------------------------------------------------------------------------------------------------------------------------------------

using System;

using Enkoni.Framework.Validation.Validators;

using Microsoft.Practices.EnterpriseLibrary.Validation.Validators;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using EntLib = Microsoft.Practices.EnterpriseLibrary.Validation;

namespace Enkoni.Framework.Validation.Tests {
  /// <summary>Tests the functionality of the <see cref="DutchPhoneNumberValidator"/> and <see cref="DutchPhoneNumberValidator"/> classes.</summary>
  [TestClass]
  public class DutchPhoneNumberValidatorTest {
    #region Properties
    /// <summary>Gets or sets the context that gives access to the input data for the test cases.</summary>
    public TestContext TestContext { get; set; }
    #endregion

    #region TestCases
    /// <summary>Tests the functionality of the <see cref="DutchPhoneNumberValidator"/> class.</summary>
    [TestMethod]
    [DeploymentItem(@"Test\Enkoni.Framework.Validation.Tests\TestData\TestData.mdf", @"DutchPhoneNumberValidatorTest\TestCase01")]
    [DataSource("System.Data.SqlClient", @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|DutchPhoneNumberValidatorTest\TestCase01\TestData.mdf;Integrated Security=True;Connect Timeout=30", "RegularPhoneNumber", DataAccessMethod.Sequential)]
    public void TestCase01_Regular() {
      DutchPhoneNumberValidator testSubject = new DutchPhoneNumberValidator("message {0}", "tag", false) { Categories = PhoneNumberCategories.Regular, AllowCountryCallingCode = true, IncludeAreaCodes = null };
      string input = this.TestContext.DataRow["PhoneNumber"].ToString();
      bool containsCarrierPreselect = Convert.ToBoolean(this.TestContext.DataRow["ContainsCarrierPreselect"]);
      bool expected = !containsCarrierPreselect && Convert.ToBoolean(this.TestContext.DataRow["IsValid"]);
      EntLib.ValidationResults results = testSubject.Validate(input);
      Assert.AreEqual(expected, results.IsValid, input);

      testSubject = new DutchPhoneNumberValidator("message {0}", "tag", true) { Categories = PhoneNumberCategories.Regular, AllowCountryCallingCode = true, IncludeAreaCodes = null };
      results = testSubject.Validate(input);
      Assert.AreEqual(!expected, results.IsValid, input);
    }

    /// <summary>Tests the functionality of the <see cref="DutchPhoneNumberValidator"/> class.</summary>
    [TestMethod]
    public void TestCase02_Regular_IncludeAreaCodes() {
      DutchPhoneNumberValidator testSubject = new DutchPhoneNumberValidator("message {0}", "tag", false) { Categories = PhoneNumberCategories.Regular, AllowCountryCallingCode = true, IncludeAreaCodes = "012;013" };
      string input = "+31122151740";
      EntLib.ValidationResults results = testSubject.Validate(input);
      Assert.IsTrue(results.IsValid);

      input = "16420031122151740";
      results = testSubject.Validate(input);
      Assert.IsFalse(results.IsValid);

      input = "0031582151740";
      results = testSubject.Validate(input);
      Assert.IsFalse(results.IsValid);
    }

    /// <summary>Tests the functionality of the <see cref="DutchPhoneNumberValidator"/> class.</summary>
    [TestMethod]
    public void TestCase03_Regular_ExcludeAreaCodes() {
      DutchPhoneNumberValidator testSubject = new DutchPhoneNumberValidator("message {0}", "tag", false) { Categories = PhoneNumberCategories.Regular, AllowCountryCallingCode = true, ExcludeAreaCodes = "058;020", IncludeAreaCodes = null };
      string input = "+31502151740";
      EntLib.ValidationResults results = testSubject.Validate(input);
      Assert.IsTrue(results.IsValid);

      input = "+31582151740";
      results = testSubject.Validate(input);
      Assert.IsFalse(results.IsValid);

      input = "164231502151740";
      results = testSubject.Validate(input);
      Assert.IsFalse(results.IsValid);

      input = "0031582151740";
      results = testSubject.Validate(input);
      Assert.IsFalse(results.IsValid);
    }

    /// <summary>Tests the functionality of the <see cref="DutchPhoneNumberValidator"/> class.</summary>
    [TestMethod]
    [DeploymentItem(@"Test\Enkoni.Framework.Validation.Tests\TestData\TestData.mdf", @"DutchPhoneNumberValidatorTest\TestCase04")]
    [DataSource("System.Data.SqlClient", @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|DutchPhoneNumberValidatorTest\TestCase04\TestData.mdf;Integrated Security=True;Connect Timeout=30", "RegularPhoneNumber", DataAccessMethod.Sequential)]
    public void TestCase04_Regular_NoCountryCode() {
      DutchPhoneNumberValidator testSubject = new DutchPhoneNumberValidator("message {0}", "tag", false) { Categories = PhoneNumberCategories.Regular, AllowCountryCallingCode = false, IncludeAreaCodes = null };
      string input = this.TestContext.DataRow["PhoneNumber"].ToString();
      bool containsCarrierPreselect = Convert.ToBoolean(this.TestContext.DataRow["ContainsCarrierPreselect"]);
      bool expected = !containsCarrierPreselect && Convert.ToBoolean(this.TestContext.DataRow["IsValid"]) && !Convert.ToBoolean(this.TestContext.DataRow["ContainsCountryAccessCode"]);
      EntLib.ValidationResults results = testSubject.Validate(input);
      Assert.AreEqual(expected, results.IsValid, input);

      testSubject = new DutchPhoneNumberValidator("message {0}", "tag", true) { Categories = PhoneNumberCategories.Regular, AllowCountryCallingCode = false, IncludeAreaCodes = null };
      results = testSubject.Validate(input);
      Assert.AreEqual(!expected, results.IsValid, input);
    }

    /// <summary>Tests the functionality of the <see cref="DutchPhoneNumberValidator"/> class.</summary>
    [TestMethod]
    public void TestCase05_Regular_NoCountryCode_IncludeAreaCodes() {
      DutchPhoneNumberValidator testSubject = new DutchPhoneNumberValidator("message {0}", "tag", false) { Categories = PhoneNumberCategories.Regular, IncludeAreaCodes = "012;013", AllowCountryCallingCode = false };
      string input = "+31122151740";
      EntLib.ValidationResults results = testSubject.Validate(input);
      Assert.IsFalse(results.IsValid);

      input = "0122151740";
      results = testSubject.Validate(input);
      Assert.IsTrue(results.IsValid);

      input = "0031582151740";
      results = testSubject.Validate(input);
      Assert.IsFalse(results.IsValid);

      input = "0582151740";
      results = testSubject.Validate(input);
      Assert.IsFalse(results.IsValid);
    }

    /// <summary>Tests the functionality of the <see cref="DutchPhoneNumberValidator"/> class.</summary>
    [TestMethod]
    public void TestCase06_Regular_NoCountryCode_ExcludeAreaCodes() {
      DutchPhoneNumberValidator testSubject = new DutchPhoneNumberValidator("message {0}", "tag", false) { Categories = PhoneNumberCategories.Regular, ExcludeAreaCodes = "058;020", AllowCountryCallingCode = false, IncludeAreaCodes = null };
      string input = "+31502151740";
      EntLib.ValidationResults results = testSubject.Validate(input);
      Assert.IsFalse(results.IsValid);

      input = "0502151740";
      results = testSubject.Validate(input);
      Assert.IsTrue(results.IsValid);

      input = "0031582151740";
      results = testSubject.Validate(input);
      Assert.IsFalse(results.IsValid);

      input = "0582151740";
      results = testSubject.Validate(input);
      Assert.IsFalse(results.IsValid);
    }

    /// <summary>Tests the functionality of the <see cref="DutchPhoneNumberValidator"/> class.</summary>
    [TestMethod]
    [DeploymentItem(@"Test\Enkoni.Framework.Validation.Tests\TestData\TestData.mdf", @"DutchPhoneNumberValidatorTest\TestCase07")]
    [DataSource("System.Data.SqlClient", @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|DutchPhoneNumberValidatorTest\TestCase07\TestData.mdf;Integrated Security=True;Connect Timeout=30", "RegularPhoneNumber", DataAccessMethod.Sequential)]
    public void TestCase07_Regular_WithCarrierPreselect() {
      DutchPhoneNumberValidator testSubject = new DutchPhoneNumberValidator("message {0}", "tag", false) { Categories = PhoneNumberCategories.Regular, AllowCountryCallingCode = true, AllowCarrierPreselect = true, IncludeAreaCodes = null };
      string input = this.TestContext.DataRow["PhoneNumber"].ToString();
      bool expected = Convert.ToBoolean(this.TestContext.DataRow["IsValid"]);
      EntLib.ValidationResults results = testSubject.Validate(input);
      Assert.AreEqual(expected, results.IsValid, input);

      testSubject = new DutchPhoneNumberValidator("message {0}", "tag", true) { Categories = PhoneNumberCategories.Regular, AllowCountryCallingCode = true, AllowCarrierPreselect = true, IncludeAreaCodes = null };
      results = testSubject.Validate(input);
      Assert.AreEqual(!expected, results.IsValid, input);
    }

    /// <summary>Tests the functionality of the <see cref="DutchPhoneNumberValidator"/> class.</summary>
    [TestMethod]
    public void TestCase08_Regular_IncludeAreaCodes_WithCarrierPreselect() {
      DutchPhoneNumberValidator testSubject = new DutchPhoneNumberValidator("message {0}", "tag", false) { Categories = PhoneNumberCategories.Regular, AllowCountryCallingCode = true, AllowCarrierPreselect = true, IncludeAreaCodes = "012;013" };
      string input = "+31122151740";
      EntLib.ValidationResults results = testSubject.Validate(input);
      Assert.IsTrue(results.IsValid);

      input = "16420031122151740";
      results = testSubject.Validate(input);
      Assert.IsTrue(results.IsValid);

      input = "16420031582151740";
      results = testSubject.Validate(input);
      Assert.IsFalse(results.IsValid);
    }

    /// <summary>Tests the functionality of the <see cref="DutchPhoneNumberValidator"/> class.</summary>
    [TestMethod]
    public void TestCase09_Regular_ExcludeAreaCodes_WithCarrierPreselect() {
      DutchPhoneNumberValidator testSubject = new DutchPhoneNumberValidator("message {0}", "tag", false) { Categories = PhoneNumberCategories.Regular, AllowCountryCallingCode = true, AllowCarrierPreselect = true, ExcludeAreaCodes = "058;020", IncludeAreaCodes = null };
      string input = "+31502151740";
      EntLib.ValidationResults results = testSubject.Validate(input);
      Assert.IsTrue(results.IsValid);

      input = "16420031502151740";
      results = testSubject.Validate(input);
      Assert.IsTrue(results.IsValid);

      input = "16420031582151740";
      results = testSubject.Validate(input);
      Assert.IsFalse(results.IsValid);
    }

    /// <summary>Tests the functionality of the <see cref="DutchPhoneNumberValidator"/> class.</summary>
    [TestMethod]
    [DeploymentItem(@"Test\Enkoni.Framework.Validation.Tests\TestData\TestData.mdf", @"DutchPhoneNumberValidatorTest\TestCase10")]
    [DataSource("System.Data.SqlClient", @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|DutchPhoneNumberValidatorTest\TestCase10\TestData.mdf;Integrated Security=True;Connect Timeout=30", "RegularPhoneNumber", DataAccessMethod.Sequential)]
    public void TestCase10_Regular_NoCountryCode_WithCarrierPreselect() {
      DutchPhoneNumberValidator testSubject = new DutchPhoneNumberValidator("message {0}", "tag", false) { Categories = PhoneNumberCategories.Regular, AllowCountryCallingCode = false, AllowCarrierPreselect = true, IncludeAreaCodes = null };
      string input = this.TestContext.DataRow["PhoneNumber"].ToString();
      bool expected = Convert.ToBoolean(this.TestContext.DataRow["IsValid"]) && !Convert.ToBoolean(this.TestContext.DataRow["ContainsCountryAccessCode"]);
      EntLib.ValidationResults results = testSubject.Validate(input);
      Assert.AreEqual(expected, results.IsValid, input);

      testSubject = new DutchPhoneNumberValidator("message {0}", "tag", true) { Categories = PhoneNumberCategories.Regular, AllowCountryCallingCode = false, AllowCarrierPreselect = true, IncludeAreaCodes = null };
      results = testSubject.Validate(input);
      Assert.AreEqual(!expected, results.IsValid, input);
    }

    /// <summary>Tests the functionality of the <see cref="DutchPhoneNumberValidator"/> class.</summary>
    [TestMethod]
    public void TestCase11_Regular_NoCountryCode_IncludeAreaCodes_WithCarrierPreselect() {
      DutchPhoneNumberValidator testSubject = new DutchPhoneNumberValidator("message {0}", "tag", false) { Categories = PhoneNumberCategories.Regular, IncludeAreaCodes = "012;013", AllowCountryCallingCode = false, AllowCarrierPreselect = true };
      string input = "+31122151740";
      EntLib.ValidationResults results = testSubject.Validate(input);
      Assert.IsFalse(results.IsValid);

      input = "16420122151740";
      results = testSubject.Validate(input);
      Assert.IsTrue(results.IsValid);

      input = "105880031582151740";
      results = testSubject.Validate(input);
      Assert.IsFalse(results.IsValid);

      input = "109420582151740";
      results = testSubject.Validate(input);
      Assert.IsFalse(results.IsValid);
    }

    /// <summary>Tests the functionality of the <see cref="DutchPhoneNumberValidator"/> class.</summary>
    [TestMethod]
    public void TestCase12_Regular_NoCountryCode_ExcludeAreaCodes_WithCarrierPreselect() {
      DutchPhoneNumberValidator testSubject = new DutchPhoneNumberValidator("message {0}", "tag", false) { Categories = PhoneNumberCategories.Regular, ExcludeAreaCodes = "058;020", AllowCountryCallingCode = false, AllowCarrierPreselect = true, IncludeAreaCodes = null };
      string input = "+31502151740";
      EntLib.ValidationResults results = testSubject.Validate(input);
      Assert.IsFalse(results.IsValid);

      input = "16000031582151740";
      results = testSubject.Validate(input);
      Assert.IsFalse(results.IsValid);

      input = "16990582151740";
      results = testSubject.Validate(input);
      Assert.IsFalse(results.IsValid);
    }

    /// <summary>Tests the functionality of the <see cref="DutchPhoneNumberValidator"/> class.</summary>
    [TestMethod]
    [DeploymentItem(@"Test\Enkoni.Framework.Validation.Tests\TestData\TestData.mdf", @"DutchPhoneNumberValidatorTest\TestCase13")]
    [DataSource("System.Data.SqlClient", @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|DutchPhoneNumberValidatorTest\TestCase13\TestData.mdf;Integrated Security=True;Connect Timeout=30", "MobilePhoneNumber", DataAccessMethod.Sequential)]
    public void TestCase13_Mobile() {
      DutchPhoneNumberValidator testSubject = new DutchPhoneNumberValidator("message {0}", "tag", false) { Categories = PhoneNumberCategories.Mobile, AllowCountryCallingCode = true, IncludeAreaCodes = null };
      string input = this.TestContext.DataRow["PhoneNumber"].ToString();
      bool containsCarrierPreselect = Convert.ToBoolean(this.TestContext.DataRow["ContainsCarrierPreselect"]);
      bool expected = !containsCarrierPreselect && Convert.ToBoolean(this.TestContext.DataRow["IsValid"]);
      EntLib.ValidationResults results = testSubject.Validate(input);
      Assert.AreEqual(expected, results.IsValid);

      testSubject = new DutchPhoneNumberValidator("message {0}", "tag", true) { Categories = PhoneNumberCategories.Mobile, AllowCountryCallingCode = true, IncludeAreaCodes = null };
      results = testSubject.Validate(input);
      Assert.AreEqual(!expected, results.IsValid, input);
    }

    /// <summary>Tests the functionality of the <see cref="DutchPhoneNumberValidator"/> class.</summary>
    [TestMethod]
    [DeploymentItem(@"Test\Enkoni.Framework.Validation.Tests\TestData\TestData.mdf", @"DutchPhoneNumberValidatorTest\TestCase14")]
    [DataSource("System.Data.SqlClient", @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|DutchPhoneNumberValidatorTest\TestCase14\TestData.mdf;Integrated Security=True;Connect Timeout=30", "MobilePhoneNumber", DataAccessMethod.Sequential)]
    public void TestCase14_Mobile_NoCountryCode() {
      DutchPhoneNumberValidator testSubject = new DutchPhoneNumberValidator("message {0}", "tag", false) { Categories = PhoneNumberCategories.Mobile, AllowCountryCallingCode = false, IncludeAreaCodes = null };
      string input = this.TestContext.DataRow["PhoneNumber"].ToString();
      bool containsCarrierPreselect = Convert.ToBoolean(this.TestContext.DataRow["ContainsCarrierPreselect"]);
      bool expected = !containsCarrierPreselect && Convert.ToBoolean(this.TestContext.DataRow["IsValid"]) && !Convert.ToBoolean(this.TestContext.DataRow["ContainsCountryAccessCode"]);
      EntLib.ValidationResults results = testSubject.Validate(input);
      Assert.AreEqual(expected, results.IsValid);

      testSubject = new DutchPhoneNumberValidator("message {0}", "tag", true) { Categories = PhoneNumberCategories.Mobile, AllowCountryCallingCode = false, IncludeAreaCodes = null };
      results = testSubject.Validate(input);
      Assert.AreEqual(!expected, results.IsValid, input);
    }

    /// <summary>Tests the functionality of the <see cref="DutchPhoneNumberValidator"/> class.</summary>
    [TestMethod]
    [DeploymentItem(@"Test\Enkoni.Framework.Validation.Tests\TestData\TestData.mdf", @"DutchPhoneNumberValidatorTest\TestCase15")]
    [DataSource("System.Data.SqlClient", @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|DutchPhoneNumberValidatorTest\TestCase15\TestData.mdf;Integrated Security=True;Connect Timeout=30", "MobilePhoneNumber", DataAccessMethod.Sequential)]
    public void TestCase15_Mobile_WithCarrierPreselect() {
      DutchPhoneNumberValidator testSubject = new DutchPhoneNumberValidator("message {0}", "tag", false) { Categories = PhoneNumberCategories.Mobile, AllowCountryCallingCode = true, AllowCarrierPreselect = true, IncludeAreaCodes = null };
      string input = this.TestContext.DataRow["PhoneNumber"].ToString();
      bool expected = Convert.ToBoolean(this.TestContext.DataRow["IsValid"]);
      EntLib.ValidationResults results = testSubject.Validate(input);
      Assert.AreEqual(expected, results.IsValid);

      testSubject = new DutchPhoneNumberValidator("message {0}", "tag", true) { Categories = PhoneNumberCategories.Mobile, AllowCountryCallingCode = true, AllowCarrierPreselect = true, IncludeAreaCodes = null };
      results = testSubject.Validate(input);
      Assert.AreEqual(!expected, results.IsValid, input);
    }

    /// <summary>Tests the functionality of the <see cref="DutchPhoneNumberValidator"/> class.</summary>
    [TestMethod]
    [DeploymentItem(@"Test\Enkoni.Framework.Validation.Tests\TestData\TestData.mdf", @"DutchPhoneNumberValidatorTest\TestCase16")]
    [DataSource("System.Data.SqlClient", @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|DutchPhoneNumberValidatorTest\TestCase16\TestData.mdf;Integrated Security=True;Connect Timeout=30", "MobilePhoneNumber", DataAccessMethod.Sequential)]
    public void TestCase16_Mobile_NoCountryCode_WithCarrierPreselect() {
      DutchPhoneNumberValidator testSubject = new DutchPhoneNumberValidator("message {0}", "tag", false) { Categories = PhoneNumberCategories.Mobile, AllowCountryCallingCode = false, AllowCarrierPreselect = true, IncludeAreaCodes = null };
      string input = this.TestContext.DataRow["PhoneNumber"].ToString();
      bool expected = Convert.ToBoolean(this.TestContext.DataRow["IsValid"]) && !Convert.ToBoolean(this.TestContext.DataRow["ContainsCountryAccessCode"]);
      EntLib.ValidationResults results = testSubject.Validate(input);
      Assert.AreEqual(expected, results.IsValid);

      testSubject = new DutchPhoneNumberValidator("message {0}", "tag", true) { Categories = PhoneNumberCategories.Mobile, AllowCountryCallingCode = false, AllowCarrierPreselect = true, IncludeAreaCodes = null };
      results = testSubject.Validate(input);
      Assert.AreEqual(!expected, results.IsValid, input);
    }

    /// <summary>Tests the functionality of the <see cref="DutchPhoneNumberValidator"/> class.</summary>
    [TestMethod]
    public void TestCase17_Emergency_Valid() {
      DutchPhoneNumberValidator testSubject = new DutchPhoneNumberValidator("message {0}", "tag", false) { Categories = PhoneNumberCategories.Emergency };
      EntLib.ValidationResults results = testSubject.Validate("112");
      Assert.IsTrue(results.IsValid);

      results = testSubject.Validate("144");
      Assert.IsTrue(results.IsValid);

      results = testSubject.Validate("116123");
      Assert.IsTrue(results.IsValid);

      testSubject = new DutchPhoneNumberValidator("message {0}", "tag", true) { Categories = PhoneNumberCategories.Emergency };
      results = testSubject.Validate("112");
      Assert.IsFalse(results.IsValid);

      results = testSubject.Validate("144");
      Assert.IsFalse(results.IsValid);

      results = testSubject.Validate("116123");
      Assert.IsFalse(results.IsValid);
    }

    /// <summary>Tests the functionality of the <see cref="DutchPhoneNumberValidator"/> class.</summary>
    [TestMethod]
    public void TestCase18_Emergency_Invalid() {
      DutchPhoneNumberValidator testSubject = new DutchPhoneNumberValidator("message {0}", "tag", false) { Categories = PhoneNumberCategories.Emergency };
      EntLib.ValidationResults results = testSubject.Validate("113");
      Assert.IsFalse(results.IsValid);

      results = testSubject.Validate("1a4");
      Assert.IsFalse(results.IsValid);

      results = testSubject.Validate("11613");
      Assert.IsFalse(results.IsValid);

      testSubject = new DutchPhoneNumberValidator("message {0}", "tag", true) { Categories = PhoneNumberCategories.Emergency };
      results = testSubject.Validate("113");
      Assert.IsTrue(results.IsValid);

      results = testSubject.Validate("1a4");
      Assert.IsTrue(results.IsValid);

      results = testSubject.Validate("11613");
      Assert.IsTrue(results.IsValid);
    }

    /// <summary>Tests the functionality of the <see cref="DutchPhoneNumberValidator"/> class.</summary>
    [TestMethod]
    [DeploymentItem(@"Test\Enkoni.Framework.Validation.Tests\TestData\TestData.mdf", @"DutchPhoneNumberValidatorTest\TestCase19")]
    [DataSource("System.Data.SqlClient", @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|DutchPhoneNumberValidatorTest\TestCase19\TestData.mdf;Integrated Security=True;Connect Timeout=30", "ServicePhoneNumber", DataAccessMethod.Sequential)]
    public void TestCase19_Service() {
      DutchPhoneNumberValidator testSubject = new DutchPhoneNumberValidator("message {0}", "tag", false) { Categories = PhoneNumberCategories.Service };
      string input = this.TestContext.DataRow["PhoneNumber"].ToString();
      bool expected = Convert.ToBoolean(this.TestContext.DataRow["IsValid"]);
      EntLib.ValidationResults results = testSubject.Validate(input);
      Assert.AreEqual(expected, results.IsValid);

      testSubject = new DutchPhoneNumberValidator("message {0}", "tag", true) { Categories = PhoneNumberCategories.Service };
      results = testSubject.Validate(input);
      Assert.AreEqual(!expected, results.IsValid, input);
    }

    /// <summary>Tests the functionality of the <see cref="DutchPhoneNumberValidator"/> class.</summary>
    [TestMethod]
    [DeploymentItem(@"Test\Enkoni.Framework.Validation.Tests\TestData\TestData.mdf", @"DutchPhoneNumberValidatorTest\TestCase20")]
    [DataSource("System.Data.SqlClient", @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|DutchPhoneNumberValidatorTest\TestCase20\TestData.mdf;Integrated Security=True;Connect Timeout=30", "OtherPhoneNumber", DataAccessMethod.Sequential)]
    public void TestCase20_Other() {
      DutchPhoneNumberValidator testSubject = new DutchPhoneNumberValidator("message {0}", "tag", false) { Categories = PhoneNumberCategories.Other, AllowCountryCallingCode = true };
      string input = this.TestContext.DataRow["PhoneNumber"].ToString();
      bool containsCarrierPreselect = Convert.ToBoolean(this.TestContext.DataRow["ContainsCarrierPreselect"]);
      bool expected = !containsCarrierPreselect && Convert.ToBoolean(this.TestContext.DataRow["IsValid"]);
      EntLib.ValidationResults results = testSubject.Validate(input);
      Assert.AreEqual(expected, results.IsValid);

      testSubject = new DutchPhoneNumberValidator("message {0}", "tag", true) { Categories = PhoneNumberCategories.Other, AllowCountryCallingCode = true };
      results = testSubject.Validate(input);
      Assert.AreEqual(!expected, results.IsValid, input);
    }

    /// <summary>Tests the functionality of the <see cref="DutchPhoneNumberValidator"/> class.</summary>
    [TestMethod]
    [DeploymentItem(@"Test\Enkoni.Framework.Validation.Tests\TestData\TestData.mdf", @"DutchPhoneNumberValidatorTest\TestCase21")]
    [DataSource("System.Data.SqlClient", @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|DutchPhoneNumberValidatorTest\TestCase21\TestData.mdf;Integrated Security=True;Connect Timeout=30", "OtherPhoneNumber", DataAccessMethod.Sequential)]
    public void TestCase21_Other_WithCarrierPreselect() {
      DutchPhoneNumberValidator testSubject = new DutchPhoneNumberValidator("message {0}", "tag", false) { Categories = PhoneNumberCategories.Other, AllowCountryCallingCode = true, AllowCarrierPreselect = true };
      string input = this.TestContext.DataRow["PhoneNumber"].ToString();
      bool expected = Convert.ToBoolean(this.TestContext.DataRow["IsValid"]);
      EntLib.ValidationResults results = testSubject.Validate(input);
      Assert.AreEqual(expected, results.IsValid, input);

      testSubject = new DutchPhoneNumberValidator("message {0}", "tag", true) { Categories = PhoneNumberCategories.Other, AllowCountryCallingCode = true, AllowCarrierPreselect = true };
      results = testSubject.Validate(input);
      Assert.AreEqual(!expected, results.IsValid, input);
    }

    /// <summary>Tests the functionality of the <see cref="DutchPhoneNumberValidator"/> class.</summary>
    [TestMethod]
    [DeploymentItem(@"Test\Enkoni.Framework.Validation.Tests\TestData\TestData.mdf", @"DutchPhoneNumberValidatorTest\TestCase22")]
    [DataSource("System.Data.SqlClient", @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|DutchPhoneNumberValidatorTest\TestCase22\TestData.mdf;Integrated Security=True;Connect Timeout=30", "DefaultPhoneNumber", DataAccessMethod.Sequential)]
    public void TestCase22_Default() {
      DutchPhoneNumberValidator testSubject = new DutchPhoneNumberValidator("message {0}", "tag", false) { Categories = PhoneNumberCategories.Default, AllowCountryCallingCode = true, IncludeAreaCodes = null };
      string input = this.TestContext.DataRow["PhoneNumber"].ToString();
      bool expected = Convert.ToBoolean(this.TestContext.DataRow["IsValid"]);
      EntLib.ValidationResults results = testSubject.Validate(input);
      Assert.AreEqual(expected, results.IsValid, input);

      testSubject = new DutchPhoneNumberValidator("message {0}", "tag", true) { Categories = PhoneNumberCategories.Default, AllowCountryCallingCode = true, IncludeAreaCodes = null };
      results = testSubject.Validate(input);
      Assert.AreEqual(!expected, results.IsValid, input);
    }

    /// <summary>Tests the functionality of the <see cref="DutchPhoneNumberValidator"/> class.</summary>
    [TestMethod]
    public void TestCase23_Configuration() {
      DutchPhoneNumberValidator testSubject = new DutchPhoneNumberValidator("message {0}", "tag", false);
      string input = "+31582141740";
      EntLib.ValidationResults results = testSubject.Validate(input);
      Assert.IsTrue(results.IsValid, input);

      input = "1688582141740";
      results = testSubject.Validate(input);
      Assert.IsFalse(results.IsValid, input);

      input = "+31202141740";
      results = testSubject.Validate(input);
      Assert.IsFalse(results.IsValid, input);

      input = "+31519214174";
      results = testSubject.Validate(input);
      Assert.IsTrue(results.IsValid, input);
    }

    /// <summary>Tests the functionality of the <see cref="DutchPhoneNumberValidator"/> class.</summary>
    [TestMethod]
    public void TestCase24_Configuration_NamedValidator() {
      DutchPhoneNumberValidator testSubject = new DutchPhoneNumberValidator("Custom Validator", "message {0}", "tag", false);
      string input = "+31582141740";
      EntLib.ValidationResults results = testSubject.Validate(input);
      Assert.IsFalse(results.IsValid, input);
    }

    /// <summary>Tests the functionality of the <see cref="DutchPhoneNumberValidatorAttribute"/> class.</summary>
    [TestMethod]
    public void TestCase25_Attribute_AllDefaults() {
      TestDummy_AllDefault dummy = new TestDummy_AllDefault { PhoneNumber = "0582151740" };

      EntLib.ValidationResults results = EntLib.Validation.Validate<TestDummy_AllDefault>(dummy, "ValidationTest");
      Assert.IsTrue(results.IsValid);

      dummy.PhoneNumber = "102360582151740";
      results = EntLib.Validation.Validate<TestDummy_AllDefault>(dummy, "ValidationTest");
      Assert.IsFalse(results.IsValid);

      dummy.PhoneNumber = "08001254";
      results = EntLib.Validation.Validate<TestDummy_AllDefault>(dummy, "ValidationTest");
      Assert.IsFalse(results.IsValid);
    }

    /// <summary>Tests the functionality of the <see cref="DutchPhoneNumberValidatorAttribute"/> class.</summary>
    [TestMethod]
    public void TestCase26_Attribute_CustomCategory() {
      TestDummy_CustomCategory dummy = new TestDummy_CustomCategory { PhoneNumber = "0582151740" };

      EntLib.ValidationResults results = EntLib.Validation.Validate<TestDummy_CustomCategory>(dummy, "ValidationTest");
      Assert.IsTrue(results.IsValid);

      dummy.PhoneNumber = "0616070302";
      results = EntLib.Validation.Validate<TestDummy_CustomCategory>(dummy, "ValidationTest");
      Assert.IsFalse(results.IsValid);
    }

    /// <summary>Tests the functionality of the <see cref="DutchPhoneNumberValidatorAttribute"/> class.</summary>
    [TestMethod]
    public void TestCase27_Attribute_CustomCategory() {
      TestDummy_CustomCategory dummy = new TestDummy_CustomCategory { PhoneNumber = "0582151740" };

      EntLib.ValidationResults results = EntLib.Validation.Validate<TestDummy_CustomCategory>(dummy, "ValidationTest");
      Assert.IsTrue(results.IsValid);

      dummy.PhoneNumber = "0616070302";
      results = EntLib.Validation.Validate<TestDummy_CustomCategory>(dummy, "ValidationTest");
      Assert.IsFalse(results.IsValid);
    }

    /// <summary>Tests the functionality of the <see cref="DutchPhoneNumberValidatorAttribute"/> class.</summary>
    [TestMethod]
    public void TestCase28_Attribute_IncludeAreaCodes() {
      TestDummy_IncludeAreaCodes dummy = new TestDummy_IncludeAreaCodes { PhoneNumber = "0582151740" };

      EntLib.ValidationResults results = EntLib.Validation.Validate<TestDummy_IncludeAreaCodes>(dummy, "ValidationTest");
      Assert.IsTrue(results.IsValid);

      dummy.PhoneNumber = "0502348547";
      results = EntLib.Validation.Validate<TestDummy_IncludeAreaCodes>(dummy, "ValidationTest");
      Assert.IsFalse(results.IsValid);
    }

    /// <summary>Tests the functionality of the <see cref="DutchPhoneNumberValidatorAttribute"/> class.</summary>
    [TestMethod]
    public void TestCase29_Attribute_ExcludeAreaCodes() {
      TestDummy_ExcludeAreaCodes dummy = new TestDummy_ExcludeAreaCodes { PhoneNumber = "0582151740" };

      EntLib.ValidationResults results = EntLib.Validation.Validate<TestDummy_ExcludeAreaCodes>(dummy, "ValidationTest");
      Assert.IsTrue(results.IsValid);

      dummy.PhoneNumber = "0202348547";
      results = EntLib.Validation.Validate<TestDummy_ExcludeAreaCodes>(dummy, "ValidationTest");
      Assert.IsFalse(results.IsValid);
    }

    /// <summary>Tests the functionality of the <see cref="DutchPhoneNumberValidatorAttribute"/> class.</summary>
    [TestMethod]
    public void TestCase30_Attribute_AllowCarrierPreselect() {
      TestDummy_AllowCarrierPreselect dummy = new TestDummy_AllowCarrierPreselect { PhoneNumber = "105630582151740" };

      EntLib.ValidationResults results = EntLib.Validation.Validate<TestDummy_AllowCarrierPreselect>(dummy, "ValidationTest");
      Assert.IsTrue(results.IsValid);
    }

    /// <summary>Tests the functionality of the <see cref="DutchPhoneNumberValidatorAttribute"/> class.</summary>
    [TestMethod]
    public void TestCase31_Attribute_NamedValidator() {
      TestDummy_NamedValidator dummy = new TestDummy_NamedValidator { PhoneNumber = "0582151740" };

      EntLib.ValidationResults results = EntLib.Validation.Validate<TestDummy_NamedValidator>(dummy, "ValidationTest");
      Assert.IsFalse(results.IsValid);
    }
    #endregion
  }

  #region Helper classes
  /// <summary>A helper class to support the testcases.</summary>
  public class TestDummy_AllDefault {
    /// <summary>Gets or sets a phone number.</summary>
    [DutchPhoneNumberValidator(Ruleset = "ValidationTest", MessageTemplate = "The property {1} is not a valid Dutch phone number ('{0}').")]
    public string PhoneNumber { get; set; }
  }

  /// <summary>A helper class to support the testcases.</summary>
  public class TestDummy_CustomCategory {
    /// <summary>Gets or sets a phone number.</summary>
    [DutchPhoneNumberValidator(Categories = PhoneNumberCategories.Regular, Ruleset = "ValidationTest", MessageTemplate = "The property {1} is not a valid Dutch phone number ('{0}').")]
    public string PhoneNumber { get; set; }
  }

  /// <summary>A helper class to support the testcases.</summary>
  public class TestDummy_IncludeAreaCodes {
    /// <summary>Gets or sets a phone number.</summary>
    [DutchPhoneNumberValidator(IncludeAreaCodes = "010;020;058", Ruleset = "ValidationTest", MessageTemplate = "The property {1} is not a valid Dutch phone number ('{0}').")]
    public string PhoneNumber { get; set; }
  }

  /// <summary>A helper class to support the testcases.</summary>
  public class TestDummy_ExcludeAreaCodes {
    /// <summary>Gets or sets a phone number.</summary>
    [DutchPhoneNumberValidator(ExcludeAreaCodes = "020;0519", Ruleset = "ValidationTest", MessageTemplate = "The property {1} is not a valid Dutch phone number ('{0}').")]
    public string PhoneNumber { get; set; }
  }

  /// <summary>A helper class to support the testcases.</summary>
  public class TestDummy_AllowCarrierPreselect {
    /// <summary>Gets or sets a phone number.</summary>
    [DutchPhoneNumberValidator(AllowCarrierPreselect = true, Ruleset = "ValidationTest", MessageTemplate = "The property {1} is not a valid Dutch phone number ('{0}').")]
    public string PhoneNumber { get; set; }
  }

  /// <summary>A helper class to support the testcases.</summary>
  public class TestDummy_NamedValidator {
    /// <summary>Gets or sets a phone number.</summary>
    [DutchPhoneNumberValidator(Name = "Custom Validator", Ruleset = "ValidationTest", MessageTemplate = "The property {1} is not a valid Dutch phone number ('{0}').")]
    public string PhoneNumber { get; set; }
  }
  #endregion
}