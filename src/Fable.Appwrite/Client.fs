// ts2fable 0.8.0
module rec AppwriteSdk.Client

#nowarn "3390" // disable warnings for invalid XML comments

open System
open Fable.Core
open Fable.Core.JS
open Browser.Types

type [<AllowNullLiteral>] Error = interface end
type URL = interface end
type File = interface end

//type fetch = Cross_fetch.fetch
//type Models = AppwriteSdk.Mo
//type Service = __service.Service

type [<AllowNullLiteral>] IExports =
    abstract AppwriteException: AppwriteExceptionStatic
    abstract Client: ClientStatic

type [<AllowNullLiteral>] Payload =
    [<EmitIndexer>] abstract Item: key: string -> obj option with get, set

type [<AllowNullLiteral>] Headers =
    [<EmitIndexer>] abstract Item: key: string -> string with get, set

type [<AllowNullLiteral>] RealtimeResponse =
    abstract ``type``: RealtimeResponseType with get, set
    abstract data: U4<RealtimeResponseAuthenticated, RealtimeResponseConnected, RealtimeResponseError, RealtimeResponseEvent<obj>> with get, set

type [<AllowNullLiteral>] RealtimeRequest =
    abstract ``type``: string with get, set
    abstract data: RealtimeRequestAuthenticate with get, set

type [<AllowNullLiteral>] RealtimeResponseEvent<'T> =
    abstract events: string[] with get, set
    abstract channels: string[] with get, set
    abstract timestamp: float with get, set
    abstract payload: 'T with get, set

type [<AllowNullLiteral>] RealtimeResponseError =
    abstract code: float with get, set
    abstract message: string with get, set

type [<AllowNullLiteral>] RealtimeResponseConnected =
    abstract channels: string[] with get, set
    abstract user: obj option with get, set

type [<AllowNullLiteral>] RealtimeResponseAuthenticated =
    abstract ``to``: string with get, set
    abstract success: bool with get, set
    abstract user: obj with get, set

type [<AllowNullLiteral>] RealtimeRequestAuthenticate =
    abstract session: string with get, set

type [<AllowNullLiteral>] Realtime =
    abstract socket: WebSocket option with get, set
    abstract timeout: float option with get, set
    abstract url: string option with get, set
    abstract lastMessage: RealtimeResponse option with get, set
    abstract channels: Set<string> with get, set
    abstract subscriptions: Map<float, RealtimeSubscriptionsMap> with get, set
    abstract subscriptionsCounter: float with get, set
    abstract reconnect: bool with get, set
    abstract reconnectAttempts: float with get, set
    abstract getTimeout: unit -> float
    abstract connect: unit -> unit
    abstract createSocket: unit -> unit
    abstract cleanUp: channels: string[] -> unit
    abstract onMessage: ``event``: MessageEvent -> unit

type [<AllowNullLiteral>] UploadProgress =
    abstract ``$id``: string with get, set
    abstract progress: float with get, set
    abstract sizeUploaded: float with get, set
    abstract chunksTotal: float with get, set
    abstract chunksUploaded: float with get, set

type [<AllowNullLiteral>] AppwriteException =
    inherit Error
    abstract code: float with get, set
    abstract response: string with get, set
    abstract ``type``: string with get, set

type [<AllowNullLiteral>] AppwriteExceptionStatic =
    [<EmitConstructor>] abstract Create: message: string * code: float * ``type``: string * response: string -> AppwriteException

type [<AllowNullLiteral>] Client =
    abstract config: obj with get, set
    abstract headers: Headers with get, set
    /// <summary>
    /// Set Endpoint
    ///
    /// Your project endpoint
    /// </summary>
    /// <param name="endpoint" />
    /// <returns />
    abstract setEndpoint: endpoint: string -> Client
    /// <summary>Set Realtime Endpoint</summary>
    /// <param name="endpointRealtime" />
    /// <returns />
    abstract setEndpointRealtime: endpointRealtime: string -> Client
    /// <summary>
    /// Set Project
    ///
    /// Your project ID
    /// </summary>
    /// <param name="value">string</param>
    /// <returns />
    abstract setProject: value: string -> Client
    /// <summary>
    /// Set JWT
    ///
    /// Your secret JSON Web Token
    /// </summary>
    /// <param name="value">string</param>
    /// <returns />
    abstract setJWT: value: string -> Client
    /// <summary>Set Locale</summary>
    /// <param name="value">string</param>
    /// <returns />
    abstract setLocale: value: string -> Client
    /// <summary>Subscribes to Appwrite events and passes you the payload in realtime.</summary>
    /// <param name="channels">
    /// Channel to subscribe - pass a single channel as a string or multiple with an array of strings.
    ///
    /// Possible channels are:
    /// - account
    /// - collections
    /// - collections.[ID]
    /// - collections.[ID].documents
    /// - documents
    /// - documents.[ID]
    /// - files
    /// - files.[ID]
    /// - executions
    /// - executions.[ID]
    /// - functions.[ID]
    /// - teams
    /// - teams.[ID]
    /// - memberships
    /// - memberships.[ID]
    /// </param>
    /// <param name="callback">Is called on every realtime update.</param>
    /// <returns>Unsubscribes from events.</returns>
    abstract subscribe: channels: U2<string, string[]> * callback: (RealtimeResponseEvent<'T> -> unit) -> (unit -> unit)
    abstract call: method: string * url: URL * headers: Headers * ``params``: Payload -> Promise<obj option>

type [<AllowNullLiteral>] ClientStatic =
    [<EmitConstructor>] abstract Create: unit -> Client

type [<StringEnum>] [<RequireQualifiedAccess>] RealtimeResponseType =
    | Error
    | Event
    | Connected
    | Response

type [<AllowNullLiteral>] RealtimeSubscriptionsMap =
    abstract channels: string[] with get, set
    abstract callback: payload: RealtimeResponseEvent<obj option> -> unit