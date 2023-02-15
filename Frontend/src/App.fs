module App

#if !DEBUG
open Elmish
open Elmish.React

Program.mkProgram Home.init Home.update Home.render
|> Program.withReactSynchronous "elmish-app"
|> Program.run

#else
open Elmish
open Elmish.React
open Elmish.HMR

Program.mkProgram Home.init Home.update Home.render
|> Program.withReactSynchronous "elmish-app"
|> Program.run
#endif
