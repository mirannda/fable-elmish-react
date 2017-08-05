module Todo.View

open Fable.Core
open Fable.Helpers
open Fable.Helpers.React
open Fable.Helpers.React.Props
open Types
open Fable.Core.JsInterop
open Elmish.React
open Fable.Import
open Fable.Import.TheMedico
let [<Literal>] ENTER_KEY = 13.
let internal onEnter msg dispatch =
    function
    | (ev:React.KeyboardEvent) when ev.keyCode = ENTER_KEY ->
        ev.target?value <- ""
        dispatch msg
    | _ -> ()
    |> OnKeyDown

let addOrUpdate (model:ToDo) =
    if model.Id = 0
    then Add {AddToDo.Content = model.Content; Order = model.Order; Status = model.Status}
    else Update {UpdateToDo.Id = model.Id; Content = model.Content; Order = model.Order; Status = model.Status}

let root (model:Model) dispatch =
    div [] [
        div [ClassName "field"] [
            label [ClassName "label"] [ str "Tasks"]
            p [ClassName "control"] [
                input [
                    ClassName "input"
                    Type "text"
                    Placeholder "Add new Task"
                    AutoFocus true
                    DefaultValue !^model.Entry.Content
                    onEnter (addOrUpdate model.Entry) dispatch
                    OnChange (fun ev -> !!ev.target?value |> fun x -> {model.Entry with Content = x} |> Change |> dispatch )
                ]
            ]
        ]
        div [ClassName "field"] [
                for entry in model.Entries do
                    yield p [ClassName "control"] [
                            label [ClassName "checkbox"] [
                                input [
                                    Type "checkbox"
                                    Checked (entry.Status = "Completed")
                                    OnChange (fun _ -> (if entry.Status = "Completed" then {entry with Status = "NotCompleted"} else {entry with Status = "Completed"}) |> addOrUpdate |> dispatch)
                                    ]
                                str (sprintf "Id: %d and Content: %s and staus: %s" entry.Id entry.Content entry.Status)

                            ]
                            span [] [
                                    a [
                                        ClassName "delete is-danger is-medium"
                                        OnClick (fun _ -> {DeleteToDo.Id = entry.Id} |> Delete |> dispatch)
                                        ] []
                                ]
                        ]
        ]

    ]