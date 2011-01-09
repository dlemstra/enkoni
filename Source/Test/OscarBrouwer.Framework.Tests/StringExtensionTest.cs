﻿//--------------------------------------------------------------------------------------------------------------------------
// <copyright file="StringExtensionTest.cs" company="Oscar Brouwer">
//     Copyright (c) Oscar Brouwer 2010. All rights reserved.
// </copyright>
// <summary>
//     Contains testcases that test the functionality of the extension methods for the string-class.
// </summary>
//--------------------------------------------------------------------------------------------------------------------------

using System.Globalization;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OscarBrouwer.Framework.Tests {
  /// <summary>This class defines the testcases that test the functionality of the extension methods for the string-class.
  /// </summary>
  [TestClass]
  public class StringExtensionTest {
    /// <summary>Tests the functionality of the <see cref="Extensions.Capitalize(string, bool)"/> extension method.
    /// </summary>
    [TestMethod]
    public void TestCase1_CapitalizeNoCultureKeepCapitals() {
      string startValue = "hello world and goodmorning";
      string result = startValue.Capitalize(true);
      Assert.AreEqual("Hello World And Goodmorning", result, false);

      startValue = "hello World And goodmorning";
      result = startValue.Capitalize(true);
      Assert.AreEqual("Hello World And Goodmorning", result, false);

      startValue = "hello woRld aNd goodmorning";
      result = startValue.Capitalize(true);
      Assert.AreEqual("Hello WoRld ANd Goodmorning", result, false);
    }

    /// <summary>Tests the functionality of the <see cref="Extensions.Capitalize(string)"/> extension method.
    /// </summary>
    [TestMethod]
    public void TestCase2_CapitalizeNoCultureResetCapitals() {
      string startValue = "hello world and goodmorning";
      string result = startValue.Capitalize();
      Assert.AreEqual("Hello World And Goodmorning", result, false);

      startValue = "hello World And goodmorning";
      result = startValue.Capitalize();
      Assert.AreEqual("Hello World And Goodmorning", result, false);

      startValue = "hello woRld aNd goodmorning";
      result = startValue.Capitalize();
      Assert.AreEqual("Hello World And Goodmorning", result, false);
    }

    /// <summary>Tests the functionality of the <see cref="Extensions.Capitalize(string, bool, CultureInfo)"/> extension 
    /// method.</summary>
    [TestMethod]
    public void TestCase3_CapitalizeWithCultureKeepCapitals() {
      CultureInfo culture = new CultureInfo("nl-NL");

      string startValue = "hello world and goodmorning";
      string result = startValue.Capitalize(true, culture);
      Assert.AreEqual("Hello World And Goodmorning", result, false);

      startValue = "hello World And goodmorning";
      result = startValue.Capitalize(true, culture);
      Assert.AreEqual("Hello World And Goodmorning", result, false);

      startValue = "hello woRld aNd goodmorning";
      result = startValue.Capitalize(true, culture);
      Assert.AreEqual("Hello WoRld ANd Goodmorning", result, false);
    }

    /// <summary>Tests the functionality of the <see cref="Extensions.Capitalize(string, CultureInfo)"/> extension method.
    /// </summary>
    [TestMethod]
    public void TestCase4_CapitalizeWithCultureResetCapitals() {
      CultureInfo culture = new CultureInfo("nl-NL");

      string startValue = "hello world and goodmorning";
      string result = startValue.Capitalize(culture);
      Assert.AreEqual("Hello World And Goodmorning", result, false);

      startValue = "hello World And goodmorning";
      result = startValue.Capitalize(culture);
      Assert.AreEqual("Hello World And Goodmorning", result, false);

      startValue = "hello woRld aNd goodmorning";
      result = startValue.Capitalize(culture);
      Assert.AreEqual("Hello World And Goodmorning", result, false);
    }
  }
}
