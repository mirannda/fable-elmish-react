namespace Fable.Import.TheMedico
open System
open System.Text.RegularExpressions
open Fable.Core
// open Fable.Import.JS
open Fable.Import.Servicestack
open FSharp.Core



module CommonHelper =

  let baseUrl = "http://sometodourl"

  let client = JsonServiceClient(baseUrl)
// type [<AllowNullLiteral>] IReturnVoid =
//     interface end

// and [<AllowNullLiteral>] IReturn<'T> =
//     interface end

//TODO
[<CLIMutable>]
type ToDo =
    { Id : int
      Order : int
      Content : string
      Status : string }

[<CLIMutable>]
type ToDoList = ToDo []

type ToDoByUser() =
  member __.getTypeName() = typeof<ToDoByUser>.Name
with interface IReturn<ToDoList>

[<CLIMutable>]
type AddToDo = {
    Order : int
    Content : string
    Status : string
} with interface IReturn<ToDo>

[<CLIMutable>]
type UpdateToDo = {
    Id:int
    Order :int
    Content : string
    Status : string
} with interface IReturn<ToDo>

[<CLIMutable>]
type DeleteToDo = {
    Id:int
} with interface IReturn<DeleteToDo>






