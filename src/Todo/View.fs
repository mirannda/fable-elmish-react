module Todo.View

open Fable.Core
open Fable.Helpers.React
open Fable.Helpers.React.Props
open Types
open Fable.Core.JsInterop
let root model dispatch =
    div [ClassName "field"] [
        label [ClassName "label"] [ str "Todo"]
        p [ClassName "control"] [
            input [
                ClassName "input"
                Type "text"
                Placeholder "Add new Todo"
                AutoFocus true
                DefaultValue !^model.field
                OnChange (fun ev -> !!ev.target?value |> Add |> dispatch )
            ]
        ]
    ]