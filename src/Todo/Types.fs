module Todo.Types

open Fable.Import.TheMedico


type Model = {
    Entries : ToDo list
    field: string
    uid : int
}

let newEntry: ToDo = {
    Id = 0
    Order = 0
    Content = ""
    Status = ""
}
let newModel = {
    Entries = []
    field = ""
    uid = 0
}


type Msg =
    | Add of AddToDo
    | Update of UpdateToDo
    | Delete of DeleteToDo
    | FetchTodo of obj 
    | FetchError of exn