namespace App

open Feliz
open Feliz.Router
open Extensions.Tailwind

//

module Components =
    /// <summary>
    /// The simplest possible React component.
    /// Shows a header with the text Hello World
    /// </summary>
    [<ReactComponent>]
    let HelloWorld () = Html.h1 "Hello World"

    /// <summary>
    /// A stateful React component that maintains a counter
    /// </summary>
    [<ReactComponent>]
    let Counter () =
        let (count, setCount) = React.useState(0)
        Html.div [
            Html.h1 [
                prop.classes [ ]
                prop.text count
            ]
            Html.button [
                prop.onClick (fun _ -> setCount(count + 1))
                prop.text "Increment"
            ]
        ]

    /// <summary>
    /// A React component that uses Feliz.Router
    /// to determine what to show based on the current URL
    /// </summary>
    [<ReactComponent>]
    let Router () =
        let (currentUrl, updateUrl) = React.useState(Router.currentPath())
        React.router [
            router.pathMode
            router.onUrlChanged updateUrl
            router.children [
                match currentUrl with
                | [ ] -> 
                    Html.h1 [
                        prop.classes [ tw.``text-3xl`` ]
                        prop.text "Test"
                    ]
                | [ "hello" ]   -> HelloWorld()
                | [ "counter" ] -> Counter()
                | _ -> Html.h1 "Not found"
            ]
        ]