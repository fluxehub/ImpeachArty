module App.Components.Footer

open Feliz

let githubLogo = StaticFile.import "../assets/github.png"

[<ReactComponent>]
let Footer () =
    Html.div [
        prop.classes [ tw.``w-screen``; tw.``fixed``; tw.``bottom-0``; tw.``left-0``; tw.``z-10``; tw.``p-4``; tw.``flex``; tw.``justify-between`` ]

        prop.children [
            Html.div [
                prop.classes [ tw.``flex``; tw.``opacity-50``; tw.``items-center`` ]

                prop.children [
                    Html.a [
                        prop.href "https://github.com/clavierpaul/ImpeachArty"

                        prop.children [
                            Html.img [
                                prop.classes [ tw.``h-6``]
                                prop.src githubLogo
                            ]
                        ]
                    ]
                    
                    Html.h1 [
                        prop.classes [ tw.``text-white``; tw.``font-semibold``; tw.``ml-2`` ]
                        
                        prop.text "Paid for by the Problematic Happenings In Leadership Committee"
                    ]
                ]
            ]

            Html.h1 [
                prop.classes [ tw.``font-semibold``; tw.``opacity-50``; ]

                prop.text "CompSoc <3 You, not Arty"
            ]
        ]
    ]