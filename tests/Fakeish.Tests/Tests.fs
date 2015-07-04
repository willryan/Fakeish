module Fakeish.Tests

open NUnit.Framework
open FsUnit

[<TestFixture>]
type ``placeholder`` ()=
  
  [<Test>]
  member x.``1 + 1 = 2`` ()=
    1 + 1 |> should equal 2


