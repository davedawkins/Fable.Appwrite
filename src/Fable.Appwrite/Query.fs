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
    abstract lessThan: obj with get, set
    abstract lessThanEqual: obj with get, set
    abstract greaterThan: obj with get, set
    abstract greaterThanEqual: obj with get, set
    abstract search: obj with get, set
    abstract orderDesc: obj with get, set
    abstract orderAsc: obj with get, set
    abstract cursorAfter: obj with get, set
    abstract cursorBefore: obj with get, set
    abstract limit: obj with get, set
    abstract offset: obj with get, set