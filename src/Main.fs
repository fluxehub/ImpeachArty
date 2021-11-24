module Main

open Feliz
open Feliz.Router
open Browser.Dom
open Fable.Core.JsInterop

open App
open Pages.Home

importSideEffects "./styles/global.css"

[<ReactComponent>]
let Router () =
    let (currentUrl, updateUrl) = React.useState (Router.currentPath ())

    React.router [ router.pathMode
                   router.onUrlChanged updateUrl
                   router.children [ match currentUrl with
                                     | [] -> HomePage ()
                                     | [ "hello" ] -> Html.h1 "Hi!"
                                     | _ -> Html.h1 "Not found" ] ]

ReactDOM.render (Router(), document.getElementById "feliz-app")
