// ts2fable 0.8.0
module rec AppwriteSdk.Graphql

#nowarn "3390" // disable warnings for invalid XML comments

open System
open Fable.Core
open Fable.Core.JS

type Service = AppwriteSdk.Service.Service
type AppwriteException = AppwriteSdk.Client.AppwriteException
type Client = AppwriteSdk.Client.Client
type URL = interface end

type [<AllowNullLiteral>] IExports =
    abstract Graphql: GraphqlStatic

type [<AllowNullLiteral>] Graphql =
    inherit Service
    /// <summary>
    /// GraphQL Endpoint
    ///
    /// Execute a GraphQL mutation.
    /// </summary>
    /// <param name="query" />
    /// <exception cref="AppwriteException" />
    /// <returns />
    abstract query: query: obj -> Promise<GraphqlQueryPromise>
    /// <summary>
    /// GraphQL Endpoint
    ///
    /// Execute a GraphQL mutation.
    /// </summary>
    /// <param name="query" />
    /// <exception cref="AppwriteException" />
    /// <returns />
    abstract mutation: query: obj -> Promise<GraphqlQueryPromise>

type [<AllowNullLiteral>] GraphqlStatic =
    [<EmitConstructor>] abstract Create: client: Client -> Graphql

type [<AllowNullLiteral>] GraphqlQueryPromise =
    interface end