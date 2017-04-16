module About.Views

open Fable.Helpers.React
open Fable.Helpers.React.Props




let root =
  div
    [ ClassName "content" ]
    [ h1
        [ ]
        [ str "About page" ]
      p
        [ ]
        [ str "page" ]
    ]
