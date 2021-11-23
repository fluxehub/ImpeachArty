module Main

open Feliz
open App
open Browser.Dom
open Fable.Core.JsInterop

importSideEffects "./styles/global.css"

ReactDOM.render (
    Components.Router(),
    document.getElementById "feliz-app"
)