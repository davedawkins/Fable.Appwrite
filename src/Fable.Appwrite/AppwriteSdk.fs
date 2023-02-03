// ts2fable 0.8.0
namespace AppwriteSdk

#nowarn "3390" // disable warnings for invalid XML comments

open Fable.Core

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
    let Appwrite : IExports = JsInterop.importAll("appwrite")


module JsHelpers =

    [<Emit("(() => { var x = {...$0}; $1.forEach( k => delete x[k] ); return x; })()")>]
    let omit(data : 'T, keys : string array ) : 'T = jsNative

    [<Emit("Object.keys($0)")>]
    let jsKeys( data : 'T ) : string array = jsNative

    let omitInternals( data : 'T ) :'T =
        let keys = jsKeys(data) |> Array.filter( fun k -> k.[0] = '$' )
        omit( data, keys )

[<AutoOpen>]
module Ext =
    type AppwriteSdk.Models.Document with
        [<Emit("$0['$id']")>]
        member this._id : string = jsNative

        static member Omit<'D when 'D :> Models.Document>( data : 'D ) = JsHelpers.omitInternals( data )

    type Models.Account<'P when 'P :> Models.Preferences> with
        [<Emit("$0['$id']")>]
        member this._id : string = jsNative

