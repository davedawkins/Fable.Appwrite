// ts2fable 0.8.0
module rec AppwriteSdk.Storage

#nowarn "3390" // disable warnings for invalid XML comments

open System
open Fable.Core
open Fable.Core.JS

type Service = AppwriteSdk.Service.Service
type AppwriteException = AppwriteSdk.Client.AppwriteException
type Client = AppwriteSdk.Client.Client
type URL = interface end
type File = interface end

type [<AllowNullLiteral>] IExports =
    abstract Storage: StorageStatic

type [<AllowNullLiteral>] Storage =
    inherit Service
    /// <summary>
    /// List Files
    ///
    /// Get a list of all the user files. You can use the query params to filter
    /// your results.
    /// </summary>
    /// <param name="bucketId" />
    /// <param name="queries" />
    /// <param name="search" />
    /// <exception cref="AppwriteException" />
    /// <returns />
    abstract listFiles: bucketId: string * ?queries: string[] * ?search: string -> Promise<Models.FileList>
    /// <summary>
    /// Create File
    ///
    /// Create a new file. Before using this route, you should create a new bucket
    /// resource using either a [server
    /// integration](/docs/server/storage#storageCreateBucket) API or directly from
    /// your Appwrite console.
    ///
    /// Larger files should be uploaded using multiple requests with the
    /// <see href="https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Content-Range">content-range</see>
    /// header to send a partial request with a maximum supported chunk of <c>5MB</c>.
    /// The <c>content-range</c> header values should always be in bytes.
    ///
    /// When the first request is sent, the server will return the **File** object,
    /// and the subsequent part request must include the file's **id** in
    /// <c>x-appwrite-id</c> header to allow the server to know that the partial upload
    /// is for the existing file and not for a new one.
    ///
    /// If you're creating a new file using one of the Appwrite SDKs, all the
    /// chunking logic will be managed by the SDK internally.
    /// </summary>
    /// <param name="bucketId" />
    /// <param name="fileId" />
    /// <param name="file" />
    /// <param name="permissions" />
    /// <exception cref="AppwriteException" />
    /// <returns />
    abstract createFile: bucketId: string * fileId: string * file: File * ?permissions: string[] * onProgress: obj -> Promise<Models.File>
    /// <summary>
    /// Get File
    ///
    /// Get a file by its unique ID. This endpoint response returns a JSON object
    /// with the file metadata.
    /// </summary>
    /// <param name="bucketId" />
    /// <param name="fileId" />
    /// <exception cref="AppwriteException" />
    /// <returns />
    abstract getFile: bucketId: string * fileId: string -> Promise<Models.File>
    /// <summary>
    /// Update File
    ///
    /// Update a file by its unique ID. Only users with write permissions have
    /// access to update this resource.
    /// </summary>
    /// <param name="bucketId" />
    /// <param name="fileId" />
    /// <param name="permissions" />
    /// <exception cref="AppwriteException" />
    /// <returns />
    abstract updateFile: bucketId: string * fileId: string * ?permissions: string[] -> Promise<Models.File>
    /// <summary>
    /// Delete File
    ///
    /// Delete a file by its unique ID. Only users with write permissions have
    /// access to delete this resource.
    /// </summary>
    /// <param name="bucketId" />
    /// <param name="fileId" />
    /// <exception cref="AppwriteException" />
    /// <returns />
    abstract deleteFile: bucketId: string * fileId: string -> Promise<StorageDeleteFilePromise>
    /// <summary>
    /// Get File for Download
    ///
    /// Get a file content by its unique ID. The endpoint response return with a
    /// 'Content-Disposition: attachment' header that tells the browser to start
    /// downloading the file to user downloads directory.
    /// </summary>
    /// <param name="bucketId" />
    /// <param name="fileId" />
    /// <exception cref="AppwriteException" />
    /// <returns />
    abstract getFileDownload: bucketId: string * fileId: string -> URL
    /// <summary>
    /// Get File Preview
    ///
    /// Get a file preview image. Currently, this method supports preview for image
    /// files (jpg, png, and gif), other supported formats, like pdf, docs, slides,
    /// and spreadsheets, will return the file icon image. You can also pass query
    /// string arguments for cutting and resizing your preview image. Preview is
    /// supported only for image files smaller than 10MB.
    /// </summary>
    /// <param name="bucketId" />
    /// <param name="fileId" />
    /// <param name="width" />
    /// <param name="height" />
    /// <param name="gravity" />
    /// <param name="quality" />
    /// <param name="borderWidth" />
    /// <param name="borderColor" />
    /// <param name="borderRadius" />
    /// <param name="opacity" />
    /// <param name="rotation" />
    /// <param name="background" />
    /// <param name="output" />
    /// <exception cref="AppwriteException" />
    /// <returns />
    abstract getFilePreview: bucketId: string * fileId: string * ?width: float * ?height: float * ?gravity: string * ?quality: float * ?borderWidth: float * ?borderColor: string * ?borderRadius: float * ?opacity: float * ?rotation: float * ?background: string * ?output: string -> URL
    /// <summary>
    /// Get File for View
    ///
    /// Get a file content by its unique ID. This endpoint is similar to the
    /// download method but returns with no  'Content-Disposition: attachment'
    /// header.
    /// </summary>
    /// <param name="bucketId" />
    /// <param name="fileId" />
    /// <exception cref="AppwriteException" />
    /// <returns />
    abstract getFileView: bucketId: string * fileId: string -> URL

type [<AllowNullLiteral>] StorageStatic =
    [<EmitConstructor>] abstract Create: client: Client -> Storage

type [<AllowNullLiteral>] StorageDeleteFilePromise =
    interface end