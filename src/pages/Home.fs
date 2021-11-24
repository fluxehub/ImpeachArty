module App.Pages.Home

open App

open Feliz
open Extensions
open Components.CallToAction

[<ReactComponent>]
let HomePage () =
    Html.div [
        prop.classes [ tw.``flex``]

        prop.children [
            Html.div [
                prop.classes [ tw.``w-2/3``; tw.``h-screen``; tw.``flex``; tw.``flex-col``; tw.``items-center``; tw.``px-24`` ]
                prop.style [ style.backgroundColor "#222" ]

                prop.children [
                    CallToAction { Author = "Paul Clavier"; Quote = "Test quote to fill out space lorem ipsum dolor sit amet, consectetur adipiscing elit. \
                                                            Praesent id vulputate lorem. Nunc ut nisi at neque elementum finibus. \
                                                            Class aptent taciti sociosqu ad litora." }
                ]
            ]
        ]
    ]