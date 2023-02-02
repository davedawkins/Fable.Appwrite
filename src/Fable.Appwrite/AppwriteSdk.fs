// ts2fable 0.8.0
namespace AppwriteSdk

#nowarn "3390" // disable warnings for invalid XML comments

open System
open Fable.Core
open Fable.Core.JS
open Fable.Core.JsInterop

//++ Edits
//type Error = System.Exception
type [<AllowNullLiteral>] Error = interface end
type URL = interface end
type File = interface end


type [<AllowNullLiteral>] IExports =
    abstract AppwriteException: AppwriteSdk.Client.AppwriteExceptionStatic
    abstract Query: Query.QueryStatic
    abstract Client: Client.ClientStatic
    abstract Account: Account.AccountStatic
    abstract Teams: Teams.TeamsStatic
    abstract Databases: Databases.DatabasesStatic
    abstract Permission: Permission.PermissionStatic
    abstract Role: Role.RoleStatic


[<AutoOpen>]
module Exports =
    let Appwrite : IExports = importAll("appwrite")

[<AutoOpen>]
module Ext =
    type AppwriteSdk.Models.Document with
        [<Emit("$0['$id']")>]
        member this._id : string = jsNative

    type Models.Account<'P when 'P :> Models.Preferences> with
        [<Emit("$0['$id']")>]
        member this._id : string = jsNative

