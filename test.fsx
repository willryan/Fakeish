// --------------------------------------------------------------------------------------
// FAKE build script
// --------------------------------------------------------------------------------------

#r @"packages/FAKE/tools/FakeLib.dll"
#r @"src/Fakeish/bin/Debug/Fakeish.dll"
open Fake
open Fakeish
open Fake.Git
open Fake.AssemblyInfoFile
open Fake.ReleaseNotesHelper
open System
open System.IO

// --------------------------------------------------------------------------------------
// Clean build results

Target "Test1" (fun _ ->
  trace "hello 1"
)

Target "Test2" (fun _ ->
  trace "hello 2"
)

FakeishTarget "shell"

RunTargetOrDefault "shell"
