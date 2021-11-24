module App.Components.Quote

open Feliz

type QuoteProps = { Author: string; Quote: string; }

let Quote props = Html.div [
    prop.classes [ tw.``w-full``; tw.``border-2``; tw.``p-4``; tw.``rounded-lg``; tw.``border-opacity-90`` ]
    
    prop.children [
        Html.h6 [
            prop.classes [ tw.``text-white``; tw.``text-sm``; tw.``-mt-1``; tw.``font-extrabold``; tw.``opacity-50`` ]
            prop.text $"Signed by {props.Author}"
        ]

        Html.p [
            prop.classes [ tw.``text-white``; tw.``font-medium``; tw.``text-lg``; tw.``opacity-90`` ]
            prop.text $"“{props.Quote}”"
        ]
    ]
]