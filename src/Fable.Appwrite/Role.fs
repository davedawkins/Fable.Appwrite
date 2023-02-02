// ts2fable 0.8.0
module rec AppwriteSdk.Role

open System
open Fable.Core
open Fable.Core.JS


type [<AllowNullLiteral>] IExports =
    abstract Role: RoleStatic

type [<AllowNullLiteral>] Role =
    interface end

type [<AllowNullLiteral>] RoleStatic =
    [<EmitConstructor>] abstract Create: unit -> Role
    abstract any: unit -> string
    abstract user: id: string * status: string -> string
    abstract users: status: string -> string
    abstract guests: unit -> string
    abstract team: id: string * role: string -> string
    abstract ``member``: id: string -> string