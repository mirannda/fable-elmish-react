module Todo.Types

open Fable.Import.TheMedico


type Model = {
    Entries : ToDo list
    Entry : ToDo
}

let newEntry: ToDo = {
    Id = 0
    Order = 0
    Content = ""
    Status = "NotCompleted"
}
let newModel = {
    Entries = []
    Entry = newEntry
}


type Msg =
    | Change of ToDo
    | Add of AddToDo
    | Update of UpdateToDo
    | Delete of DeleteToDo
    | ListFetched of ToDoList
    | InsertOrUpdated of ToDo
    | Deleted of DeleteToDo
    | FetchError of exn