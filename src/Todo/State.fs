module Todo.State

open Elmish
open Types
open Fable.Core
open Fable.Import
open Fable.Import.Browser
open Fable.Import.Servicestack
open Fable.Import.TheMedico

open CommonHelper


let init () : Model * Cmd<Msg> =
    console.log "Todo Init"
    let initPull (data: ToDoByUser) =
        client.get (U2.Case1 (data :> IReturn<ToDoList>))
    let initCmd data=
        Cmd.ofPromise initPull data ListFetched FetchError
    in
    newModel, initCmd (ToDoByUser())


let update msg model : Model * Cmd<Msg> =
    match msg with
    | Change t ->
        {model with Entry = t}, Cmd.none
    | Add t ->
        console.log "Add is happenning"
        let add t = client.post (t :> IReturn<ToDo>)
        let addCmd t = Cmd.ofPromise add t InsertOrUpdated FetchError
        in
        model, addCmd t
    | Update t ->
        console.log "Update is happenning"
        let update t = client.put (t :> IReturn<ToDo>)
        let updateCmd t = Cmd.ofPromise update t InsertOrUpdated FetchError
        in
        model, updateCmd t
    | Delete t ->
        printfn "%A" t.Id
        let delete' (t:DeleteToDo) = client.delete (U2.Case1 (t :> IReturn<DeleteToDo>))
        let deleteCmd t = Cmd.ofPromise delete' t Deleted FetchError
        in
        model, deleteCmd t
    | ListFetched data ->
        {model with Entries = data |> Array.toList } , Cmd.none
    | InsertOrUpdated data ->
        let found = model.Entries |> List.tryFind(fun x -> x.Id = data.Id)
        let newlist =
            match found with
            | Some x ->
                model.Entries |> List.map (fun a -> if a.Id = x.Id then data else a)
            | None ->
                data::model.Entries
        in
        {model with Entries = newlist}, Cmd.none
    | Deleted data ->
        let found = model.Entries |> List.tryFind(fun x -> x.Id = data.Id)
        let newlist =
            match found with
            | Some x ->

                model.Entries |> List.filter (fun a -> a.Id <> x.Id )
            | None -> model.Entries
        in
        {model with Entries = newlist}, Cmd.none
    | FetchError exn ->
        printfn "%A" exn
        model, Cmd.none
