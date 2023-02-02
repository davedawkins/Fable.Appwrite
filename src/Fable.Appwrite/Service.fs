module rec AppwriteSdk.Service
// ts2fable 0.8.0

open Fable.Core

type Client = AppwriteSdk.Client.Client
type Payload = AppwriteSdk.Client.Payload

type [<AllowNullLiteral>] IExports =
    abstract Service: ServiceStatic

type [<AllowNullLiteral>] Service =
    abstract client: Client with get, set

type [<AllowNullLiteral>] ServiceStatic =
    abstract CHUNK_SIZE: obj with get, set
    [<EmitConstructor>] abstract Create: client: Client -> Service
    abstract flatten: data: Payload * prefix: obj -> Payload