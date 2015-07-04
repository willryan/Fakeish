namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("Fakeish")>]
[<assembly: AssemblyProductAttribute("Fakeish")>]
[<assembly: AssemblyDescriptionAttribute("A shell for running Fake tasks")>]
[<assembly: AssemblyVersionAttribute("1.0")>]
[<assembly: AssemblyFileVersionAttribute("1.0")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "1.0"
