// This file is used by Code Analysis to maintain SuppressMessage
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given
// a specific target and scoped to a namespace, type, member, etc.
using System.Diagnostics.CodeAnalysis;
[assembly: SuppressMessage("Major Code Smell", "S1172:Unused method parameters should be removed", Justification = "Method is actualy used", Scope = "member", Target = "~M:Abituria.matury.mp21.PageMP21Z1.CheckAnswer(System.Int32)~System.Boolean")]
[assembly: SuppressMessage("Style", "IDE0060:Remove unused parameter", Justification = "Parameter is actualy used", Scope = "member", Target = "~M:Abituria.matury.mp21.PageMP21Z1.CheckAnswer(System.Int32)~System.Boolean")]
[assembly: SuppressMessage("Critical Code Smell", "S3265:Non-flags enums should not be used in bitwise operations", Justification = "Enum marked as flag is located in system files", Scope = "member", Target = "~M:Abituria.viewmodel.WindowViewModel.#ctor(System.Windows.Window)")]
[assembly: SuppressMessage("Critical Code Smell", "S2696:Instance members should not write to \"static\" fields", Justification = "There are no multiple class instances and/or multiple threads", Scope = "member", Target = "~M:Abituria.BaseValueConverter`1.ProvideValue(System.IServiceProvider)~System.Object")]
[assembly: SuppressMessage("Major Code Smell", "S2743:Static fields should not be used in generic types", Justification = "There is no need for shareing among instances of different closed constructed types", Scope = "type", Target = "~T:Abituria.BaseValueConverter`1")]
[assembly: SuppressMessage("Major Code Smell", "S125:Sections of code should not be commented out", Justification = "<Pending>", Scope = "member", Target = "~M:Abituria.viewmodel.GenericDataService`1.Delete(System.Int32)~System.Threading.Tasks.Task{System.Boolean}")]
