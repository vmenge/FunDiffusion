module Home

open Feliz
open Elmish
open Fss


let myComponent =
    let style = [ BackgroundColor.black; BorderRadius.value (px 5) ]

    Html.div [ prop.fss style; prop.children [ Html.p "test" ] ]

type State = { Counter: int32 }

type Msg =
    | Inc
    | Dec

let init () = { Counter = 0 }, Cmd.none

let update (msg: Msg) (state: State) =
    match msg with
    | Inc ->
        { state with
            Counter = state.Counter + 1 },
        Cmd.none

    | Dec ->
        { state with
            Counter = state.Counter - 1 },
        Cmd.none

let render (state: State) (dispatch: Msg -> unit) =
    Html.div
        [ Html.img
              [ prop.fss [ BorderRadius.value (px 10); MaxWidth.value (pc 50) ]
                prop.src "/images/maxresdefault.jpg" ]

          Html.p $"Counter is {state.Counter}!"

          myComponent

          Html.button [ prop.text "inc"; prop.onClick (fun _ -> dispatch Inc) ]

          Html.button [ prop.text "dec"; prop.onClick (fun _ -> dispatch Dec) ] ]
