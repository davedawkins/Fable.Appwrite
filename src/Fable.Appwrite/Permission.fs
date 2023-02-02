// ts2fable 0.8.0
module rec AppwriteSdk.Permission

open System
open Fable.Core
open Fable.Core.JS


type [<AllowNullLiteral>] IExports =
    abstract Permission: PermissionStatic

type [<AllowNullLiteral>] Permission =
    interface end

type [<AllowNullLiteral>] PermissionStatic =
    [<EmitConstructor>] abstract Create: unit -> Permission
    abstract read: string -> string
    abstract write:  string -> string
    abstract create: string -> string
    abstract update: string -> string
    abstract delete: string -> string