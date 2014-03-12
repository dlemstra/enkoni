﻿using System;
using System.Linq;
using System.Data.Entity;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Enkoni.Framework.Entities.Tests {
  /// <summary>Contains test cases that replay discovered bug scenarios to ensure a bug doesn't re-appear in a future release.</summary>
  [TestClass]
  public class BugScenarios {
    /// <summary>Replays the bug described in bug 12. Querying entities by RecordID causes an entity framework exception.</summary>
    /// <seealso href="https://humanprinter.visualstudio.com/DefaultCollection/Enkoni.Framework/_workitems/edit/12"/>
    [TestMethod, TestCategory("Bugs")]
    [DeploymentItem(@"TestData\TestData.mdf", @"BugScenarios\Bug01")]
    public void Bug01_QueryById() {
      DbContext context = new DatabaseRepositoryTestContext("BugScenarios");
      DataSourceInfo sourceInfo = new DatabaseSourceInfo(context);

      TestDomainModel domainModel = new TestDomainModel(sourceInfo);
      SubDomainModel<TestDummy> subDomain = domainModel.GetSubDomain<TestDummy>();

      TestDummy result = subDomain.FindEntityById(2);
      if(result == null) {
        Console.WriteLine(context.Set<TestDummy>().Count());
      }
      Assert.IsNotNull(result);
      Assert.AreEqual(2, result.RecordId);
      Assert.AreEqual("TestDummy 2", result.TextValue);
    }
  }
}
