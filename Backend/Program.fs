module Program

#nowarn "20"

open System
open Microsoft.AspNetCore.Builder
open Microsoft.Extensions.Hosting

let exitCode = 0


[<EntryPoint>]
let main args =
    let x = Bla.f1 10
    let y = Bla.f2 20
    let builder = WebApplication.CreateBuilder(args)
    let app = builder.Build()

    app.MapGet("/", Func<string>(fun _ -> "hello world"))
    app.Run()

    exitCode
