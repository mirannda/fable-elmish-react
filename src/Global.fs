module Global

type Page =
  | Home
  | Counter
  | About
  | Todo

let toHash page =
  match page with
  | About -> "#about"
  | Counter -> "#counter"
  | Home -> "#home"
  | Todo -> "#todo"
