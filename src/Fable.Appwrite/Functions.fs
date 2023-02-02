// ts2fable 0.8.0
module rec AppwriteSdk.Functions

#nowarn "3390" // disable warnings for invalid XML comments

open System
open Fable.Core
open Fable.Core.JS

type Service = AppwriteSdk.Service.Service
type AppwriteException = AppwriteSdk.Client.AppwriteException
type Client = AppwriteSdk.Client.Client
type URL = interface end

type [<AllowNullLiteral>] IExports =
    abstract Functions: FunctionsStatic

type [<AllowNullLiteral>] Functions =
    inherit Service
    /// <summary>
    /// List Executions
    ///
    /// Get a list of all the current user function execution logs. You can use the
    /// query params to filter your results.
    /// </summary>
    /// <param name="functionId" />
    /// <param name="queries" />
    /// <param name="search" />
    /// <exception cref="AppwriteException" />
    /// <returns />
    abstract listExecutions: functionId: string * ?queries: string[] * ?search: string -> Promise<Models.ExecutionList>
    /// <summary>
    /// Create Execution
    ///
    /// Trigger a function execution. The returned object will return you the
    /// current execution status. You can ping the <c>Get Execution</c> endpoint to get
    /// updates on the current execution status. Once this endpoint is called, your
    /// function execution process will start asynchronously.
    /// </summary>
    /// <param name="functionId" />
    /// <param name="data" />
    /// <param name="async" />
    /// <exception cref="AppwriteException" />
    /// <returns />
    abstract createExecution: functionId: string * ?data: string * ?async: bool -> Promise<Models.Execution>
    /// <summary>
    /// Get Execution
    ///
    /// Get a function execution log by its unique ID.
    /// </summary>
    /// <param name="functionId" />
    /// <param name="executionId" />
    /// <exception cref="AppwriteException" />
    /// <returns />
    abstract getExecution: functionId: string * executionId: string -> Promise<Models.Execution>

type [<AllowNullLiteral>] FunctionsStatic =
    [<EmitConstructor>] abstract Create: client: Client -> Functions