module App.Components.CallToAction

open App

open Feliz
open Components.Quote

let logo = StaticFile.import "../assets/compsoc.png"

let bolded (text: string) = Html.span [
    prop.classes [ tw.``font-extrabold``; tw.``opacity-100`` ]
    prop.text text
]

[<ReactComponent>]
let CallToAction () = 
    React.fragment [
        Html.img [
            prop.src logo
            prop.classes [ tw.``h-32``; tw.``w-auto``; tw.``my-24`` ]
        ]

        Html.h1 [
            prop.classes [ tw.``text-white``; tw.``text-8xl``; tw.``font-extrabold`` ]
            prop.text "It's time to take action."
        ]

        Html.p [
            prop.classes [ tw.``text-white``; tw.``text-xl``; tw.``font-medium``; tw.``mt-8``; tw.``mb-16``; tw.``text-center``; tw.``opacity-90`` ]
            
            prop.children [
                Html.text "For too long, CompSoc has been ruled with an iron fist by a series of increasingly evil leaders. \
                           For the sake of the society that we live in, we the people "
                bolded "must"
                Html.text " demand better from those in power. We the people "
                bolded "must"
                Html.text " act. We the people "
                bolded "must IMPEACH ARTY"
                Html.text "."
            ]
        ]
    ]