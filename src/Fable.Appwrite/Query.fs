// ts2fable 0.8.0
module rec AppwriteSdk.Query
open System
open Fable.Core
open Fable.Core.JS


type [<AllowNullLiteral>] IExports =
    abstract Query: QueryStatic

type QueryTypesSingle =
    U3<string, float, bool>

type QueryTypesList =
    U3<string[], float[], bool[]>

type QueryTypes =
    U2<QueryTypesSingle, QueryTypesList>

type [<AllowNullLiteral>] Query =
    interface end

type [<AllowNullLiteral>] QueryStatic =
    [<EmitConstructor>] abstract Create: unit -> Query
    abstract equal: attribute:string * value : QueryTypes -> string
    abstract lessThan: attribute:string * value : QueryTypes -> string
    abstract lessThanEqual: attribute:string * value : QueryTypes -> string
    abstract greaterThan: attribute:string * value : QueryTypes -> string
    abstract greaterThanEqual: attribute:string * value : QueryTypes -> string
    abstract search: attribute:string * value : QueryTypes -> string
    abstract orderDesc: attribute:string -> string
    abstract orderAsc: attribute:string -> string
    abstract cursorAfter: docId:string -> string
    abstract cursorBefore: docId:string -> string
    abstract limit: limit:int -> string
    abstract offset: offset:int -> string