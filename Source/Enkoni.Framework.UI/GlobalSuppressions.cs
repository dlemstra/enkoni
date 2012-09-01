﻿//---------------------------------------------------------------------------------------------------------------------------------------------------
// <copyright file="GlobalSuppressions.cs" company="Oscar Brouwer">
//     Copyright (c) Oscar Brouwer 2012. All rights reserved.
// </copyright>
// <summary>
//     Contains the project's suppressions.
// </summary>
//---------------------------------------------------------------------------------------------------------------------------------------------------

using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage("Microsoft.Design", "CA1004:GenericMethodsShouldProvideTypeParameter", Scope = "member", Target = "Enkoni.Framework.UI.Mvvm.IMessenger.#Deregister`1(System.Object)", Justification = "The method does require the type parameter, but there simply is no need for an aditional parameter")]
[assembly: SuppressMessage("Microsoft.Design", "CA1004:GenericMethodsShouldProvideTypeParameter", Scope = "member", Target = "Enkoni.Framework.UI.Mvvm.Messenger.#Deregister`1(System.Object)", Justification = "The method does require the type parameter, but there simply is no need for an aditional parameter")]

[assembly: SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Scope = "member", Target = "Enkoni.Framework.UI.Mvvm.IViewDialogMessage.#Callback", Justification = "This type of nesting is not confusing for the user")]
[assembly: SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Scope = "member", Target = "Enkoni.Framework.UI.Mvvm.ViewModel.#AddValidationRule`1(System.Linq.Expressions.Expression`1<System.Func`1<!!0>>,System.Func`1<System.String>)", Justification = "This type of nesting is not confusing for the user")]
[assembly: SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Scope = "member", Target = "Enkoni.Framework.UI.Mvvm.ViewModel.#IsPropertyValid`1(System.Linq.Expressions.Expression`1<System.Func`1<!!0>>)", Justification = "This type of nesting is not confusing for the user")]
[assembly: SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Scope = "member", Target = "Enkoni.Framework.UI.Mvvm.ViewModel.#IsPropertyValid`2(System.Linq.Expressions.Expression`1<System.Func`2<!!0,!!1>>)", Justification = "This type of nesting is not confusing for the user")]
[assembly: SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Scope = "member", Target = "Enkoni.Framework.UI.Mvvm.ViewModel.#RaisePropertyChanged`1(System.Linq.Expressions.Expression`1<System.Func`1<!!0>>)", Justification = "This type of nesting is not confusing for the user")]
[assembly: SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Scope = "member", Target = "Enkoni.Framework.UI.Mvvm.ViewModel.#RaisePropertyChanged`1(System.Linq.Expressions.Expression`1<System.Func`1<!!0>>,!!0,!!0)", Justification = "This type of nesting is not confusing for the user")]
[assembly: SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Scope = "member", Target = "Enkoni.Framework.UI.Mvvm.ViewModel.#RemoveValidationRule`1(System.Linq.Expressions.Expression`1<System.Func`1<!!0>>,System.Func`1<System.String>)", Justification = "This type of nesting is not confusing for the user")]
[assembly: SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Scope = "member", Target = "Enkoni.Framework.UI.Mvvm.ViewModel.#SendPropertyChangedMessage`1(System.Linq.Expressions.Expression`1<System.Func`1<!!0>>,!!0,!!0)", Justification = "This type of nesting is not confusing for the user")]

[assembly: SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters", Scope = "member", Target = "Enkoni.Framework.UI.Mvvm.ViewModel.#AddValidationRule`1(System.Linq.Expressions.Expression`1<System.Func`1<!!0>>,System.Func`1<System.String>)", Justification = "With this type of parameters, using base types is not an option")]
[assembly: SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters", Scope = "member", Target = "Enkoni.Framework.UI.Mvvm.ViewModel.#IsPropertyValid`1(System.Linq.Expressions.Expression`1<System.Func`1<!!0>>)", Justification = "With this type of parameters, using base types is not an option")]
[assembly: SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters", Scope = "member", Target = "Enkoni.Framework.UI.Mvvm.ViewModel.#IsPropertyValid`2(System.Linq.Expressions.Expression`1<System.Func`2<!!0,!!1>>)", Justification = "With this type of parameters, using base types is not an option")]
[assembly: SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters", Scope = "member", Target = "Enkoni.Framework.UI.Mvvm.ViewModel.#RaisePropertyChanged`1(System.Linq.Expressions.Expression`1<System.Func`1<!!0>>)", Justification = "With this type of parameters, using base types is not an option")]
[assembly: SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters", Scope = "member", Target = "Enkoni.Framework.UI.Mvvm.ViewModel.#RaisePropertyChanged`1(System.Linq.Expressions.Expression`1<System.Func`1<!!0>>,!!0,!!0)", Justification = "With this type of parameters, using base types is not an option")]
[assembly: SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters", Scope = "member", Target = "Enkoni.Framework.UI.Mvvm.ViewModel.#RemoveValidationRule`1(System.Linq.Expressions.Expression`1<System.Func`1<!!0>>,System.Func`1<System.String>)", Justification = "With this type of parameters, using base types is not an option")]
[assembly: SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters", Scope = "member", Target = "Enkoni.Framework.UI.Mvvm.ViewModel.#SendPropertyChangedMessage`1(System.Linq.Expressions.Expression`1<System.Func`1<!!0>>,!!0,!!0)", Justification = "With this type of parameters, using base types is not an option")]

[assembly: SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "Enkoni.Framework.UI", Justification = "This namespace is created intentionally")]

[assembly: SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate", Scope = "member", Target = "Enkoni.Framework.UI.Mvvm.IMessage.#GetWindow()", Justification = "'GetWindow' is more descriptive")]

[assembly: SuppressMessage("Microsoft.Design", "CA1030:UseEventsWhereAppropriate", Scope = "member", Target = "Enkoni.Framework.UI.Mvvm.Extensions.#Fire(System.ComponentModel.PropertyChangedEventHandler,System.Object,System.ComponentModel.PropertyChangedEventArgs)", Justification = "Intentionaly constructed as a extension method")]
[assembly: SuppressMessage("Microsoft.Design", "CA1030:UseEventsWhereAppropriate", Scope = "member", Target = "Enkoni.Framework.UI.Mvvm.Extensions.#FireAsync(System.ComponentModel.PropertyChangedEventHandler,System.Object,System.ComponentModel.PropertyChangedEventArgs)", Justification = "Intentionaly constructed as a extension method")]
[assembly: SuppressMessage("Microsoft.Design", "CA1030:UseEventsWhereAppropriate", Scope = "member", Target = "Enkoni.Framework.UI.Mvvm.Extensions.#FireInParallel(System.ComponentModel.PropertyChangedEventHandler,System.Object,System.ComponentModel.PropertyChangedEventArgs)", Justification = "Intentionaly constructed as a extension method")]
[assembly: SuppressMessage("Microsoft.Design", "CA1030:UseEventsWhereAppropriate", Scope = "member", Target = "Enkoni.Framework.UI.Mvvm.RelayCommand.#RaiseCanExecuteChanged()", Justification = "This method hides some administrative functionality from the subclasses.")]
[assembly: SuppressMessage("Microsoft.Design", "CA1030:UseEventsWhereAppropriate", Scope = "member", Target = "Enkoni.Framework.UI.Mvvm.RelayCommand`1.#RaiseCanExecuteChanged()", Justification = "This method hides some administrative functionality from the subclasses.")]
[assembly: SuppressMessage("Microsoft.Design", "CA1030:UseEventsWhereAppropriate", Scope = "member", Target = "Enkoni.Framework.UI.Mvvm.ViewModel.#RaiseAllPropertiesChanged()", Justification = "This method hides some administrative functionality from the subclasses.")]
[assembly: SuppressMessage("Microsoft.Design", "CA1030:UseEventsWhereAppropriate", Scope = "member", Target = "Enkoni.Framework.UI.Mvvm.ViewModel.#RaisePropertyChanged(System.String)", Justification = "This method hides some administrative functionality from the subclasses.")]
[assembly: SuppressMessage("Microsoft.Design", "CA1030:UseEventsWhereAppropriate", Scope = "member", Target = "Enkoni.Framework.UI.Mvvm.ViewModel.#RaisePropertyChanged`1(System.Linq.Expressions.Expression`1<System.Func`1<!!0>>)", Justification = "This method hides some administrative functionality from the subclasses.")]
[assembly: SuppressMessage("Microsoft.Design", "CA1030:UseEventsWhereAppropriate", Scope = "member", Target = "Enkoni.Framework.UI.Mvvm.ViewModel.#RaisePropertyChanged`1(System.Linq.Expressions.Expression`1<System.Func`1<!!0>>,!!0,!!0)", Justification = "This method hides some administrative functionality from the subclasses.")]

[assembly: SuppressMessage("Microsoft.Design", "CA1063:ImplementIDisposableCorrectly", Scope = "member", Target = "Enkoni.Framework.UI.Mvvm.Messenger.#Dispose()", Justification = "The Microsoft reference implementation is wrong.")]
[assembly: SuppressMessage("Microsoft.Design", "CA1063:ImplementIDisposableCorrectly", Scope = "type", Target = "Enkoni.Framework.UI.Mvvm.Messenger", Justification = "The Microsoft reference implementation is wrong.")]

[assembly: SuppressMessage("Microsoft.Naming", "CA1725:ParameterNamesShouldMatchBaseDeclaration", MessageId = "0#", Scope = "member", Target = "Enkoni.Framework.UI.Mvvm.ViewModel.#Item[System.String]", Justification = "In this case, the new parametername is more describing than the original parameter name.")]

[assembly: SuppressMessage("Microsoft.Usage", "CA1816:CallGCSuppressFinalizeCorrectly", Scope = "member", Target = "Enkoni.Framework.UI.Mvvm.Messenger.#Dispose()", Justification = "The Microsoft reference implementation is wrong.")]

[assembly: SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope", Scope = "member", Target = "Enkoni.Framework.UI.Mvvm.Messenger.#.cctor()", Justification = "This instance is not supposed to be disposed before the application ends.")]

[assembly: SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes", Scope = "member", Target = "Enkoni.Framework.UI.UIDispatcher.#Dispatcher", Justification = "The type Dispatcher is in fact immutable")]
