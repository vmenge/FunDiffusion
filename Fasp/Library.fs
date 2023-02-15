module Fasp

open Microsoft.AspNetCore.Builder
open Microsoft.Extensions.Hosting

type WebApplication with

    member this.Map(path: string) : unit = ()
