module App.Components.SignatureForm

open Feliz
open Fable.Core.JsInterop

let private inputStyle = 
    [ tw.``border-2``
      tw.``border-black``
      tw.``border-opacity-25``
      tw.``w-full``
      tw.``p-4``
      tw.``rounded-lg``
      tw.``font-semibold``
      tw.``mb-4``
      tw.``bg-transparent`` ]

let private buttonStyle =
    [ tw.``text-white``
      tw.``font-bold``
      tw.``p-3``
      tw.``rounded-lg``
      tw.``bg-black-bg`` ]

[<ReactComponent>]
let SignatureForm () =
    Html.form [ 
        prop.classes [ tw.``w-full``;  ] 

        prop.children [
            Html.input [
                prop.classes <| tw.``h-12`` :: inputStyle

                prop.style [ style.color "rgba(0, 0, 0, 0.8)" ]

                prop.placeholder "Name"
            ]

            Html.input [
                prop.classes <|  tw.``h-12`` :: inputStyle

                prop.style [ style.color "rgba(0, 0, 0, 0.8)" ]

                prop.placeholder "Link (optional)"
            ]

            Html.textarea [
                prop.classes <| tw.``h-80`` :: inputStyle

                prop.style [ 
                    style.color "rgba(0, 0, 0, 0.8)" 
                    style.maxHeight 500
                ]

                prop.maxLength 750

                prop.placeholder "Message (optional, max 750 characters)"
            ]

            Html.div [
                prop.classes [ tw.``mb-4`` ]

                prop.children [
                    Feliz.Interop.reactApi.createElement (importDefault "@hcaptcha/react-hcaptcha", createObj [
                        "sitekey" ==> "10000000-ffff-ffff-ffff-000000000001"
                    ])
                ]
            ]
            
            Html.div [
                prop.classes [ tw.``flex``; tw.``justify-end`` ]

                prop.children [
                    Html.button [
                        prop.classes buttonStyle

                        prop.style [ style.backgroundColor "#222" ]

                        prop.text "Submit"
                    ]
                ]
            ]
        ]
    ]