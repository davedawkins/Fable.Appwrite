// ts2fable 0.8.0
module rec AppwriteSdk.Databases

#nowarn "3390" // disable warnings for invalid XML comments

open System
open Fable.Core
open Fable.Core.JS

[<Erase>] type KeyOf<'T> = Key of string

type Service = AppwriteSdk.Service.Service
type AppwriteException = AppwriteSdk.Client.AppwriteException
type Client = AppwriteSdk.Client.Client

type [<AllowNullLiteral>] IExports =
    abstract Databases: DatabasesStatic

[<Erase>]
type Omit<'T,'a> = T of 'T

type [<AllowNullLiteral>] Databases =
    inherit Service
    /// <summary>
    /// List Documents
    ///
    /// Get a list of all the user's documents in a given collection. You can use
    /// the query params to filter your results.
    /// </summary>
    /// <param name="databaseId" />
    /// <param name="collectionId" />
    /// <param name="queries" />
    /// <exception cref="AppwriteException" />
    /// <returns />
    abstract listDocuments: databaseId: string * collectionId: string * ?queries: string[] -> Promise<Models.DocumentList<'Document>> when 'Document :> Models.Document
    /// <summary>
    /// Create Document
    ///
    /// Create a new Document. Before using this route, you should create a new
    /// collection resource using either a [server
    /// integration](/docs/server/databases#databasesCreateCollection) API or
    /// directly from your database console.
    /// </summary>
    /// <param name="databaseId" />
    /// <param name="collectionId" />
    /// <param name="documentId" />
    /// <param name="data" />
    /// <param name="permissions" />
    /// <exception cref="AppwriteException" />
    /// <returns />
    abstract createDocument: databaseId: string * collectionId: string * documentId: string * data: 'Document * ?permissions: string[] -> Promise<'Document> when 'Document :> Models.Document
    /// <summary>
    /// Get Document
    ///
    /// Get a document by its unique ID. This endpoint response returns a JSON
    /// object with the document data.
    /// </summary>
    /// <param name="databaseId" />
    /// <param name="collectionId" />
    /// <param name="documentId" />
    /// <exception cref="AppwriteException" />
    /// <returns />
    abstract getDocument: databaseId: string * collectionId: string * documentId: string -> Promise<'Document> when 'Document :> Models.Document
    /// <summary>
    /// Update Document
    ///
    /// Update a document by its unique ID. Using the patch method you can pass
    /// only specific fields that will get updated.
    /// </summary>
    /// <param name="databaseId" />
    /// <param name="collectionId" />
    /// <param name="documentId" />
    /// <param name="data" />
    /// <param name="permissions" />
    /// <exception cref="AppwriteException" />
    /// <returns />
    abstract updateDocument: databaseId: string * collectionId: string * documentId: string * ?data: obj * ?permissions: string[] -> Promise<'Document> when 'Document :> Models.Document
    /// <summary>
    /// Delete Document
    ///
    /// Delete a document by its unique ID.
    /// </summary>
    /// <param name="databaseId" />
    /// <param name="collectionId" />
    /// <param name="documentId" />
    /// <exception cref="AppwriteException" />
    /// <returns />
    abstract deleteDocument: databaseId: string * collectionId: string * documentId: string -> Promise<DatabasesDeleteDocumentPromise>

type [<AllowNullLiteral>] DatabasesStatic =
    [<EmitConstructor>] abstract Create: client: Client -> Databases

type [<AllowNullLiteral>] DatabasesDeleteDocumentPromise =
    interface end