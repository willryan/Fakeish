module Fakeish

open Fake
open GetLine

let FakeishTarget (name:string) =
  let prompt (le : LineEditor) =
    le.Edit("fake> ", "")


  Target name (fun _ ->
    let targets =
      seq {
        yield "list"
        yield "quit"
        yield "exit"
        yield! Seq.filter (fun t -> t <> name) TargetDict.Keys
      }
    let matchFun (text:string) (_:int) =
      let matchTargets =
        targets
        |> Seq.filter (fun targ -> targ.StartsWith(text))
        |> Seq.map (fun targ -> targ.Substring(text.Length))
      LineEditor.Completion(text, (Seq.toArray matchTargets))
    let handler = LineEditor.AutoCompleteHandler matchFun
    let le = LineEditor("fakeish")
    le.AutoCompleteEvent <- handler

    let mutable line = prompt(le)
    while (line <> "quit" && line <> "exit") do
      try
        if (line = "list") then
          printf "targets: "
          Seq.iter (fun t -> printf "%A " t) targets
          printfn ""
        else
          runSingleTarget <| getTarget line
      with
        | ex -> printfn "%A" ex
      line <- prompt(le)
    exit 0
  )

