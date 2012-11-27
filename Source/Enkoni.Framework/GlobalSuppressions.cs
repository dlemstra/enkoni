//---------------------------------------------------------------------------------------------------------------------------------------------------
// <copyright file="GlobalSuppressions.cs" company="Oscar Brouwer">
//     Copyright (c) Oscar Brouwer 2012. All rights reserved.
// </copyright>
// <summary>
//     Contains the project's suppressions.
// </summary>
//---------------------------------------------------------------------------------------------------------------------------------------------------

using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage("Microsoft.Design", "CA1002:DoNotExposeGenericLists", Scope = "member", Target = "Enkoni.Framework.Collections.Extensions.#IndexOf`1(System.Collections.Generic.List`1<!!0>,!!0,System.Int32,System.Collections.Generic.IEqualityComparer`1<!!0>)", Justification = "The method provides an 'overload' for a List-method")]
[assembly: SuppressMessage("Microsoft.Design", "CA1002:DoNotExposeGenericLists", Scope = "member", Target = "Enkoni.Framework.Collections.Extensions.#IndexOf`1(System.Collections.Generic.List`1<!!0>,!!0,System.Int32,System.Int32,System.Collections.Generic.IEqualityComparer`1<!!0>)", Justification = "The method provides an 'overload' for a List-method")]

[assembly: SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Scope = "member", Target = "Enkoni.Framework.ISpecification`1.#Visit(Enkoni.Framework.ISpecificationVisitor`1<!0>)", Justification = "This is an accepted type and the user will hardly ever see it")]
[assembly: SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Scope = "member", Target = "Enkoni.Framework.ISpecification`1.#OrderBy`1(System.Linq.Expressions.Expression`1<System.Func`2<!0,!!0>>)", Justification = "This is an accepted type and the user will hardly ever see it")]
[assembly: SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Scope = "member", Target = "Enkoni.Framework.ISpecification`1.#OrderBy`1(System.Linq.Expressions.Expression`1<System.Func`2<!0,!!0>>,Enkoni.Framework.SortOrder)", Justification = "This is an accepted type and the user will hardly ever see it")]
[assembly: SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Scope = "member", Target = "Enkoni.Framework.ISpecification`1.#OrderByDescending`1(System.Linq.Expressions.Expression`1<System.Func`2<!0,!!0>>)", Justification = "This is an accepted type and the user will hardly ever see it")]
[assembly: SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Scope = "member", Target = "Enkoni.Framework.ISpecificationVisitor`1.#CreateAndExpression(Enkoni.Framework.ISpecification`1<!0>,Enkoni.Framework.ISpecification`1<!0>)", Justification = "This is an accepted type and the user will hardly ever see it")]
[assembly: SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Scope = "member", Target = "Enkoni.Framework.ISpecificationVisitor`1.#CreateOrExpression(Enkoni.Framework.ISpecification`1<!0>,Enkoni.Framework.ISpecification`1<!0>)", Justification = "This is an accepted type and the user will hardly ever see it")]
[assembly: SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Scope = "member", Target = "Enkoni.Framework.ISpecificationVisitor`1.#CreateNotExpression(Enkoni.Framework.ISpecification`1<!0>)", Justification = "This is an accepted type and the user will hardly ever see it")]
[assembly: SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Scope = "member", Target = "Enkoni.Framework.ISpecificationVisitor`1.#CreateCustomExpression(Enkoni.Framework.ISpecification`1<!0>)", Justification = "This is an accepted type and the user will hardly ever see it")]
[assembly: SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Scope = "member", Target = "Enkoni.Framework.ISpecificationVisitor`1.#CreateLambdaExpression(System.Linq.Expressions.Expression`1<System.Func`2<!0,System.Boolean>>)", Justification = "This is an accepted type and the user will hardly ever see it")]
[assembly: SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Scope = "member", Target = "Enkoni.Framework.ISpecificationVisitor`1.#CreateLikeExpression(System.Linq.Expressions.Expression`1<System.Func`2<!0,System.Boolean>>)", Justification = "This is an accepted type and the user will hardly ever see it")]
[assembly: SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Scope = "member", Target = "Enkoni.Framework.ISpecificationVisitor`1.#CreateLikeExpression(System.Linq.Expressions.Expression`1<System.Func`2<!0,System.String>>,System.String)", Justification = "This is an accepted type and the user will hardly ever see it")]
[assembly: SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Scope = "member", Target = "Enkoni.Framework.Specification.#Lambda`1(System.Linq.Expressions.Expression`1<System.Func`2<!!0,System.Boolean>>)", Justification = "This is an accepted type and the user will hardly ever see it")]
[assembly: SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Scope = "member", Target = "Enkoni.Framework.Specification.#Not`1(System.Linq.Expressions.Expression`1<System.Func`2<!!0,System.Boolean>>)", Justification = "This is an accepted type and the user will hardly ever see it")]
[assembly: SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Scope = "member", Target = "Enkoni.Framework.Specification.#Like`1(System.Linq.Expressions.Expression`1<System.Func`2<!!0,System.String>>,System.String)", Justification = "This is an accepted type and the user will hardly ever see it")]
[assembly: SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Scope = "member", Target = "Enkoni.Framework.Specification`1.#VisitCore(Enkoni.Framework.ISpecificationVisitor`1<!0>)", Justification = "This is an accepted type and the user will hardly ever see it")]
[assembly: SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Scope = "member", Target = "Enkoni.Framework.Specification`1.#OrderBy`1(System.Linq.Expressions.Expression`1<System.Func`2<!0,!!0>>)", Justification = "This is an accepted type and the user will hardly ever see it")]
[assembly: SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Scope = "member", Target = "Enkoni.Framework.Specification`1.#OrderBy`1(System.Linq.Expressions.Expression`1<System.Func`2<!0,!!0>>,Enkoni.Framework.SortOrder)", Justification = "This is an accepted type and the user will hardly ever see it")]
[assembly: SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Scope = "member", Target = "Enkoni.Framework.Specification`1.#OrderByDescending`1(System.Linq.Expressions.Expression`1<System.Func`2<!0,!!0>>)", Justification = "This is an accepted type and the user will hardly ever see it")]
[assembly: SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Scope = "member", Target = "Enkoni.Framework.Linq.Extensions.#FirstOrDefault`1(System.Linq.IQueryable`1<!!0>,System.Linq.Expressions.Expression`1<System.Func`2<!!0,System.Boolean>>,!!0)", Justification = "This is an accepted type and the user will hardly ever see it")]
[assembly: SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Scope = "member", Target = "Enkoni.Framework.Linq.Extensions.#LastOrDefault`1(System.Linq.IQueryable`1<!!0>,System.Linq.Expressions.Expression`1<System.Func`2<!!0,System.Boolean>>,!!0)", Justification = "This is an accepted type and the user will hardly ever see it")]
[assembly: SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Scope = "member", Target = "Enkoni.Framework.Linq.Extensions.#SingleOrDefault`1(System.Linq.IQueryable`1<!!0>,System.Linq.Expressions.Expression`1<System.Func`2<!!0,System.Boolean>>,!!0)", Justification = "This is an accepted type and the user will hardly ever see it")]
[assembly: SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Scope = "member", Target = "Enkoni.Framework.Linq.Extensions.#Not`1(System.Linq.Expressions.Expression`1<System.Func`2<!!0,System.Boolean>>)", Justification = "This is an accepted type and the user will hardly ever see it")]

[assembly: SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters", Scope = "member", Target = "Enkoni.Framework.Specification`1.#HandleOrderByRulesUpdated(System.Object,Enkoni.Framework.SortSpecificationsEventArgs`1<!0>)", Justification = "This type is more understandable than the basetype.")]

[assembly: SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "Enkoni.Framework.Linq", Justification = "The types in this namespace extend the functionality of the default Linq library")]
[assembly: SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "Enkoni.Framework.Timers", Justification = "The types in this namespace extend the functionality of the default Timers library")]

[assembly: SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate", Scope = "member", Target = "Enkoni.Framework.Collections.CircularStack`1.#GetEnumeratorCore()", Justification = "A method is more appropriate here")]

[assembly: SuppressMessage("Microsoft.Design", "CA1030:UseEventsWhereAppropriate", Scope = "member", Target = "Enkoni.Framework.Extensions.#Fire(System.EventHandler,System.Object,System.EventArgs)", Justification = "Intentionaly constructed as a extension method")]
[assembly: SuppressMessage("Microsoft.Design", "CA1030:UseEventsWhereAppropriate", Scope = "member", Target = "Enkoni.Framework.Extensions.#Fire`1(System.EventHandler`1<!!0>,System.Object,!!0)", Justification = "Intentionaly constructed as a extension method")]
[assembly: SuppressMessage("Microsoft.Design", "CA1030:UseEventsWhereAppropriate", Scope = "member", Target = "Enkoni.Framework.Extensions.#FireAsync(System.EventHandler,System.Object,System.EventArgs)", Justification = "Intentionaly constructed as a extension method")]
[assembly: SuppressMessage("Microsoft.Design", "CA1030:UseEventsWhereAppropriate", Scope = "member", Target = "Enkoni.Framework.Extensions.#FireAsync`1(System.EventHandler`1<!!0>,System.Object,!!0)", Justification = "Intentionaly constructed as a extension method")]
[assembly: SuppressMessage("Microsoft.Design", "CA1030:UseEventsWhereAppropriate", Scope = "member", Target = "Enkoni.Framework.Extensions.#FireInParallel(System.EventHandler,System.Object,System.EventArgs)", Justification = "Intentionaly constructed as a extension method")]
[assembly: SuppressMessage("Microsoft.Design", "CA1030:UseEventsWhereAppropriate", Scope = "member", Target = "Enkoni.Framework.Extensions.#FireInParallel`1(System.EventHandler`1<!!0>,System.Object,!!0)", Justification = "Intentionaly constructed as a extension method")]

[assembly: SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Enkoni.Framework.Workflow.#StopWorkflowHelper(System.Object)", Justification = "The exception is stored and rethrown later on, so no harm's done")]
[assembly: SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Enkoni.Framework.Workflow.#StartWorkflowHelper(System.Object)", Justification = "The exception is stored and rethrown later on, so no harm's done")]
[assembly: SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Enkoni.Framework.Workflow.#PauseWorkflowHelper(System.Object)", Justification = "The exception is stored and rethrown later on, so no harm's done")]
[assembly: SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Enkoni.Framework.Workflow.#ContinueWorkflowHelper(System.Object)", Justification = "The exception is stored and rethrown later on, so no harm's done")]
[assembly: SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Enkoni.Framework.Serialization.Serializer`1.#DeserializeToFileHelper(System.Object)", Justification = "The exception is stored and rethrown later on, so no harm's done")]
[assembly: SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Enkoni.Framework.Serialization.Serializer`1.#DeserializeToStreamHelper(System.Object)", Justification = "The exception is stored and rethrown later on, so no harm's done")]
[assembly: SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Enkoni.Framework.Serialization.Serializer`1.#SerializeToFileHelper(System.Object)", Justification = "The exception is stored and rethrown later on, so no harm's done")]
[assembly: SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Enkoni.Framework.Serialization.Serializer`1.#SerializeToStreamHelper(System.Object)", Justification = "The exception is stored and rethrown later on, so no harm's done")]

[assembly: SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0", Scope = "member", Target = "Enkoni.Framework.AndSpecification`1.#VisitCore(Enkoni.Framework.ISpecificationVisitor`1<!0>)", Justification = "The parameter is already checked in the public method")]
[assembly: SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0", Scope = "member", Target = "Enkoni.Framework.LambdaSpecification`1.#VisitCore(Enkoni.Framework.ISpecificationVisitor`1<!0>)", Justification = "The parameter is already checked in the public method")]
[assembly: SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0", Scope = "member", Target = "Enkoni.Framework.LikeSpecification`1.#VisitCore(Enkoni.Framework.ISpecificationVisitor`1<!0>)", Justification = "The parameter is already checked in the public method")]
[assembly: SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0", Scope = "member", Target = "Enkoni.Framework.NotSpecification`1.#VisitCore(Enkoni.Framework.ISpecificationVisitor`1<!0>)", Justification = "The parameter is already checked in the public method")]
[assembly: SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0", Scope = "member", Target = "Enkoni.Framework.OrSpecification`1.#VisitCore(Enkoni.Framework.ISpecificationVisitor`1<!0>)", Justification = "The parameter is already checked in the public method")]
[assembly: SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0", Scope = "member", Target = "Enkoni.Framework.Collections.CircularStack`1.#CopyTo(System.Array,System.Int32)", Justification = "The parameter is already checked in the public method")]
[assembly: SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0", Scope = "member", Target = "Enkoni.Framework.Collections.CircularStack`1.#CopyToCore(!0[],System.Int32)", Justification = "The parameter is already checked in the public method")]
[assembly: SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0", Scope = "member", Target = "Enkoni.Framework.Serialization.Serializer`1.#Serialize(System.Collections.Generic.IEnumerable`1<!0>,System.Text.Encoding,System.IO.Stream)", Justification = "The parameter is already checked in the public method")]
[assembly: SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "1", Scope = "member", Target = "Enkoni.Framework.Serialization.Serializer`1.#Serialize(System.Collections.Generic.IEnumerable`1<!0>,System.Text.Encoding,System.IO.Stream)", Justification = "The parameter is already checked in the public method")]
[assembly: SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "2", Scope = "member", Target = "Enkoni.Framework.Serialization.Serializer`1.#Serialize(System.Collections.Generic.IEnumerable`1<!0>,System.Text.Encoding,System.IO.Stream)", Justification = "The parameter is already checked in the public method")]
[assembly: SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "3", Scope = "member", Target = "Enkoni.Framework.Serialization.CsvTransformer`1.#FromBytesCore(System.Byte[],System.Int32,System.Int32,System.Text.Encoding)", Justification = "The parameter is already checked in the public method")]
[assembly: SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0", Scope = "member", Target = "Enkoni.Framework.Serialization.CsvTransformer`1.#FromBytesCore(System.Byte[],System.Text.Encoding)", Justification = "The parameter is already checked in the public method")]
[assembly: SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0", Scope = "member", Target = "Enkoni.Framework.Serialization.CsvTransformer`1.#FromStringCore(System.String)", Justification = "The parameter is already checked in the public method")]
[assembly: SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "1", Scope = "member", Target = "Enkoni.Framework.Serialization.CsvTransformer`1.#ToBytesCore(!0,System.Text.Encoding)", Justification = "The parameter is already checked in the public method")]
[assembly: SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "2", Scope = "member", Target = "Enkoni.Framework.Serialization.CsvTransformer`1.#ToBytesCore(!0,System.Text.Encoding,System.Byte[],System.Int32)", Justification = "The parameter is already checked in the public method")]

[assembly: SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters", Scope = "member", Target = "Enkoni.Framework.Linq.Extensions.#Not`1(System.Linq.Expressions.Expression`1<System.Func`2<!!0,System.Boolean>>)", Justification = "This type is more applicable")]

[assembly: SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix", Scope = "type", Target = "Enkoni.Framework.Collections.CircularStack`1", Justification = "The class behaves as a stack even though it doesn't extend it")]

[assembly: SuppressMessage("Microsoft.Naming", "CA1711:IdentifiersShouldNotHaveIncorrectSuffix", Scope = "type", Target = "Enkoni.Framework.Collections.CircularStack`1", Justification = "The class behaves as a stack even though it doesn't extend it")]

[assembly: SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords", MessageId = "And", Scope = "member", Target = "Enkoni.Framework.ISpecification`1.#And(Enkoni.Framework.ISpecification`1<!0>)", Justification = "There simply is no better name for it")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords", MessageId = "Or", Scope = "member", Target = "Enkoni.Framework.ISpecification`1.#Or(Enkoni.Framework.ISpecification`1<!0>)", Justification = "There simply is no better name for it")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords", MessageId = "Continue", Scope = "member", Target = "Enkoni.Framework.IWorkflow.#Continue()", Justification = "There simply is no better name for it")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords", MessageId = "Stop", Scope = "member", Target = "Enkoni.Framework.IWorkflow.#Stop()", Justification = "There simply is no better name for it")]

[assembly: SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", MessageId = "bytes", Scope = "member", Target = "Enkoni.Framework.Serialization.Transformer`1.#FromBytes(System.Byte[],System.Int32,System.Int32,System.Text.Encoding)", Justification = "This name is better self-explanatory than any other name.")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", MessageId = "bytes", Scope = "member", Target = "Enkoni.Framework.Serialization.Transformer`1.#FromBytes(System.Byte[],System.Text.Encoding)", Justification = "This name is better self-explanatory than any other name.")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", MessageId = "bytes", Scope = "member", Target = "Enkoni.Framework.Serialization.Transformer`1.#FromBytesCore(System.Byte[],System.Int32,System.Int32,System.Text.Encoding)", Justification = "This name is better self-explanatory than any other name.")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", MessageId = "bytes", Scope = "member", Target = "Enkoni.Framework.Serialization.Transformer`1.#FromBytesCore(System.Byte[],System.Text.Encoding)", Justification = "This name is better self-explanatory than any other name.")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", MessageId = "bytes", Scope = "member", Target = "Enkoni.Framework.Serialization.Transformer`1.#ToBytes(!0,System.Text.Encoding,System.Byte[],System.Int32)", Justification = "This name is better self-explanatory than any other name.")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", MessageId = "bytes", Scope = "member", Target = "Enkoni.Framework.Serialization.Transformer`1.#ToBytesCore(!0,System.Text.Encoding,System.Byte[],System.Int32)", Justification = "This name is better self-explanatory than any other name.")]

[assembly: SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms", MessageId = "Flag", Scope = "member", Target = "Enkoni.Framework.EnumHelper.#SetFlag`1(!!0,!!0)", Justification = "The term 'flag' is appropriate here")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms", MessageId = "Flag", Scope = "member", Target = "Enkoni.Framework.EnumHelper.#UnsetFlag`1(!!0,!!0)", Justification = "The term 'flag' is appropriate here")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms", MessageId = "Flag", Scope = "member", Target = "Enkoni.Framework.EnumHelper.#ToggleFlag`1(!!0,!!0)", Justification = "The term 'flag' is appropriate here")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms", MessageId = "flag", Scope = "member", Target = "Enkoni.Framework.EnumHelper.#SetFlag`1(!!0,!!0)", Justification = "The term 'flag' is appropriate here")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms", MessageId = "flag", Scope = "member", Target = "Enkoni.Framework.EnumHelper.#UnsetFlag`1(!!0,!!0)", Justification = "The term 'flag' is appropriate here")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms", MessageId = "flag", Scope = "member", Target = "Enkoni.Framework.EnumHelper.#ToggleFlag`1(!!0,!!0)", Justification = "The term 'flag' is appropriate here")]

[assembly: SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "source", Scope = "member", Target = "Enkoni.Framework.Linq.Extensions.#CreateEqualityComparer`2(System.Collections.Generic.IEnumerable`1<!!0>,System.Func`2<!!0,!!1>)", Justification = "The parameter is crucial for the extension mechanism to work")]

[assembly: SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic", Scope = "member", Target = "Enkoni.Framework.Workflow.#EndContinue(System.IAsyncResult)", Justification = "By keeping it an instance-member, its use is more logical for endusers")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic", Scope = "member", Target = "Enkoni.Framework.Workflow.#EndPause(System.IAsyncResult)", Justification = "By keeping it an instance-member, its use is more logical for end users")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic", Scope = "member", Target = "Enkoni.Framework.Workflow.#EndStart(System.IAsyncResult)", Justification = "By keeping it an instance-member, its use is more logical for end users")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic", Scope = "member", Target = "Enkoni.Framework.Workflow.#EndStop(System.IAsyncResult)", Justification = "By keeping it an instance-member, its use is more logical for end users")]

[assembly: SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope", Scope = "member", Target = "Enkoni.Framework.AsyncResultVoid.#AsyncWaitHandle", Justification = "Disposing is handled at a different place")]
[assembly: SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope", Scope = "member", Target = "Enkoni.Framework.AsyncResult`1.#AsyncWaitHandle", Justification = "Disposing is handled at a different place")]

[assembly: SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "CompareTo", Scope = "member", Target = "Enkoni.Framework.Collections.Comparer`1.#Compare(!0,!0)", Justification = "The spelling is correct")]
[assembly: SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "CsvRecord-attribute", Scope = "member", Target = "Enkoni.Framework.Serialization.CsvTransformer`1.#.ctor()", Justification = "The spelling is correct")]
[assembly: SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "BusinessRuleSpecification", Scope = "member", Target = "Enkoni.Framework.Specification`1.#And(Enkoni.Framework.ISpecification`1<!0>)", Justification = "This is the name of the type")]
[assembly: SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "BusinessRuleSpecification", Scope = "member", Target = "Enkoni.Framework.Specification`1.#Or(Enkoni.Framework.ISpecification`1<!0>)", Justification = "This is the name of the type")]
[assembly: SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "GetEnumerator", Scope = "member", Target = "Enkoni.Framework.Collections.CircularStack`1+Enumerator.#Current", Justification = "Literal is the actual name of the method")]
