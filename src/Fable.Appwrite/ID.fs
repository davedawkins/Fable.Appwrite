module rec AppwriteSdk.ID

open System
open Fable.Core
open Fable.Core.JS


type [<AllowNullLiteral>] IExports =
    abstract ID: IDStatic

type [<AllowNullLiteral>] ID =
    interface end

type [<AllowNullLiteral>] IDStatic =
    [<EmitConstructor>] abstract Create: unit -> ID
    abstract custom: id: string -> string
    abstract unique: unit -> string