﻿//--------------------------------------------------------------------------------------------------------------------------
// <copyright file="GlobalSuppressions.cs" company="Oscar Brouwer">
//     Copyright (c) Oscar Brouwer 2010. All rights reserved.
// </copyright>
// <summary>
//     Contains the project's suppressions.
// </summary>
//--------------------------------------------------------------------------------------------------------------------------

// This file is used by Code Analysis to maintain SuppressMessage 
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given 
// a specific target and scoped to a namespace, type, member, etc.
//
// To add a suppression to this file, right-click the message in the 
// Error List, point to "Suppress Message(s)", and click 
// "In Project Suppression File".
// You do not need to add suppressions to this file manually.
using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage("Microsoft.Design", "CA1063:ImplementIDisposableCorrectly", Scope = "member", Target = "OscarBrouwer.Framework.Testing.TestRepository`1.#Dispose()", Justification = "The Microsoft reference implementation is wrong.")]
[assembly: SuppressMessage("Microsoft.Design", "CA1063:ImplementIDisposableCorrectly", Scope = "type", Target = "OscarBrouwer.Framework.Testing.TestRepository`1", Justification = "The Microsoft reference implementation is wrong.")]

[assembly: SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity", Scope = "member", Target = "OscarBrouwer.Framework.Testing.TestRepository`1.#SaveChangesCore()", Justification = "The code is well documented and therefore fine.")]

[assembly: SuppressMessage("Microsoft.Usage", "CA1816:CallGCSuppressFinalizeCorrectly", Scope = "member", Target = "OscarBrouwer.Framework.Testing.TestRepository`1.#Dispose()", Justification = "The Microsoft reference implementation is wrong.")]
