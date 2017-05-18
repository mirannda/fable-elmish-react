module Todo.State

open Elmish
open Types
open Fable.Core
open Fable.Import
open Fable.Import.Browser
open Fable.Import.Servicestack
open Fable.Import.TheMedico
open Fable.PowerPack
open Fable.PowerPack.Fetch.Fetch_types
let initPull (data: ToDoByUser)=
        // let client = JsonServiceClient("http://themedico.foo/")
        promise {
            let url = "http://sometodourl/todo"
            let todobyuser = data :> IReturn<ToDoList>
            // Below commented part work with Fable powerpack fetch works
            // let props = [Fetch.requestHeaders [ HttpRequestHeaders.ContentType "application/json" ]]
            // let! result = Fetch.fetchAs<ToDoList> (url + "/?Id=" + todobyuser.Id.ToString()) props
            // printfn "%A" result.ToDos.Length
            let client = JsonServiceClient("http://sometodourl/todo")
            let! result = client.get(U2.Case1 todobyuser)
            return result
        }
let initCmd data=
    Cmd.ofPromise initPull data (unbox FetchTodo) FetchError


let init () : Model * Cmd<Msg> =
    console.log "Todo Init"
    newModel, initCmd {Id = 1}


let update msg model : Model * Cmd<Msg> =
    match msg with
    | Add t ->
        console.log "Add is happending"
        newModel, []
    | Update t ->

        newModel, []
    | Delete id ->
        newModel, []
    | FetchTodo data ->
        printfn "%A" "fetchtodo data"
        printfn "%A" data
        newModel, Cmd.none
    | FetchError exn ->
        printfn "%A" exn
        model, Cmd.none