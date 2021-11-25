module App.Pages.Home

open App

open Feliz
open Extensions
open Components.CallToAction
open Components.Quote
open Components.SignatureForm

[<ReactComponent>]
let HomePage () =
    Html.div [
        // Flex is probably unnecessary but oh well
        // TODO: CSS Grid?
        prop.classes [ tw.``flex`` ]

        prop.children [
            Html.div [
                prop.classes [ tw.``w-2/3``; tw.``h-screen``; tw.``flex``; tw.``flex-col``; tw.``items-center``; tw.``px-24``; tw.``bg-black-bg`` ]

                prop.children [
                    CallToAction ()

                    Quote { Author = "Paul Clavier"; Quote = "Test quote to fill out space lorem ipsum dolor sit amet, consectetur adipiscing elit. \
                                                            Praesent id vulputate lorem. Nunc ut nisi at neque elementum finibus. \
                                                            Class aptent taciti sociosqu ad litora." }

                    
                    Html.a [
                        prop.classes [ tw.``bg-white``; tw.``text-xl``; tw.``font-medium``; tw.``my-8``; tw.``p-2``; tw.``rounded-lg``; tw.``text-center``; tw.``opacity-90`` ]
                        prop.text "View Submissions"
                    ]
                ]
            ]

            Html.div [
                prop.classes [ tw.``w-1/3``; tw.``h-screen``; tw.``flex``; tw.``flex-col``; tw.``items-center``; tw.``p-10`` ]

                prop.children [
                    Html.div [
                        prop.classes [ tw.``w-full`` ]
                        
                        prop.children [
                            Html.h6 [
                                prop.classes [ tw.``text-lg``; tw.``font-semibold``; tw.``opacity-50`` ]
                                prop.text "20 signatures"
                            ]

                            Html.h1 [
                                prop.classes [ tw.``text-4xl``; tw.``font-extrabold``; tw.``mb-6``; tw.``opacity-80`` ]
                                prop.text "Sign the petition."
                            ]
                        ]
                    ]

                    SignatureForm ()
                ]
            ]
        ]
    ]