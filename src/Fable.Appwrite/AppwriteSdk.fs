// ts2fable 0.8.0
module rec AppwriteSdk

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

let exports : IExports = importAll("appwrite")

let Create() = exports.Appwrite.Create()

[<AutoOpen>]
module Ext =
    type Models.Document with
        [<Emit("$0['$id']")>]
        member this._id : string = jsNative

    type Models.User<'P when 'P :> Models.Preferences> with
        [<Emit("$0['$id']")>]
        member this._id : string = jsNative

//--

type [<AllowNullLiteral>] IExports =
    abstract AppwriteException: AppwriteExceptionStatic
    abstract Appwrite: AppwriteStatic
    abstract Query: QueryStatic

module Models =

    /// Documents List
    type [<AllowNullLiteral>] DocumentList<'Document when 'Document :> Models.Document> =
        /// Total number of documents documents that matched your query.
        abstract total: float with get, set
        /// List of documents.
        abstract documents: 'Document[] with get, set

    /// Sessions List
    type [<AllowNullLiteral>] SessionList =
        /// Total number of sessions documents that matched your query.
        abstract total: float with get, set
        /// List of sessions.
        abstract sessions: Session[] with get, set

    /// Logs List
    type [<AllowNullLiteral>] LogList =
        /// Total number of logs documents that matched your query.
        abstract total: float with get, set
        /// List of logs.
        abstract logs: Log[] with get, set

    /// Files List
    type [<AllowNullLiteral>] FileList =
        /// Total number of files documents that matched your query.
        abstract total: float with get, set
        /// List of files.
        abstract files: File[] with get, set

    /// Teams List
    type [<AllowNullLiteral>] TeamList =
        /// Total number of teams documents that matched your query.
        abstract total: float with get, set
        /// List of teams.
        abstract teams: Team[] with get, set

    /// Memberships List
    type [<AllowNullLiteral>] MembershipList =
        /// Total number of memberships documents that matched your query.
        abstract total: float with get, set
        /// List of memberships.
        abstract memberships: Membership[] with get, set

    /// Executions List
    type [<AllowNullLiteral>] ExecutionList =
        /// Total number of executions documents that matched your query.
        abstract total: float with get, set
        /// List of executions.
        abstract executions: Execution[] with get, set

    /// Countries List
    type [<AllowNullLiteral>] CountryList =
        /// Total number of countries documents that matched your query.
        abstract total: float with get, set
        /// List of countries.
        abstract countries: Country[] with get, set

    /// Continents List
    type [<AllowNullLiteral>] ContinentList =
        /// Total number of continents documents that matched your query.
        abstract total: float with get, set
        /// List of continents.
        abstract continents: Continent[] with get, set

    /// Languages List
    type [<AllowNullLiteral>] LanguageList =
        /// Total number of languages documents that matched your query.
        abstract total: float with get, set
        /// List of languages.
        abstract languages: Language[] with get, set

    /// Currencies List
    type [<AllowNullLiteral>] CurrencyList =
        /// Total number of currencies documents that matched your query.
        abstract total: float with get, set
        /// List of currencies.
        abstract currencies: Currency[] with get, set

    /// Phones List
    type [<AllowNullLiteral>] PhoneList =
        /// Total number of phones documents that matched your query.
        abstract total: float with get, set
        /// List of phones.
        abstract phones: Phone[] with get, set

    /// Document
    type [<AllowNullLiteral>] Document =
        /// Document ID.
        abstract ``$id``: string with get, set
        /// Collection ID.
        abstract ``$collection``: string with get, set
        /// Document read permissions.
        abstract ``$read``: string[] with get, set
        /// Document write permissions.
        abstract ``$write``: string[] with get, set

    /// Log
    type [<AllowNullLiteral>] Log =
        /// Event name.
        abstract ``event``: string with get, set
        /// User ID.
        abstract userId: string with get, set
        /// User Email.
        abstract userEmail: string with get, set
        /// User Name.
        abstract userName: string with get, set
        /// API mode when event triggered.
        abstract mode: string with get, set
        /// IP session in use when the session was created.
        abstract ip: string with get, set
        /// Log creation time in Unix timestamp.
        abstract time: float with get, set
        /// <summary>Operating system code name. View list of <see href="https://github.com/appwrite/appwrite/blob/master/docs/lists/os.json">available options</see>.</summary>
        abstract osCode: string with get, set
        /// Operating system name.
        abstract osName: string with get, set
        /// Operating system version.
        abstract osVersion: string with get, set
        /// Client type.
        abstract clientType: string with get, set
        /// <summary>Client code name. View list of <see href="https://github.com/appwrite/appwrite/blob/master/docs/lists/clients.json">available options</see>.</summary>
        abstract clientCode: string with get, set
        /// Client name.
        abstract clientName: string with get, set
        /// Client version.
        abstract clientVersion: string with get, set
        /// Client engine name.
        abstract clientEngine: string with get, set
        /// Client engine name.
        abstract clientEngineVersion: string with get, set
        /// Device name.
        abstract deviceName: string with get, set
        /// Device brand name.
        abstract deviceBrand: string with get, set
        /// Device model name.
        abstract deviceModel: string with get, set
        /// Country two-character ISO 3166-1 alpha code.
        abstract countryCode: string with get, set
        /// Country name.
        abstract countryName: string with get, set

    /// User
    type [<AllowNullLiteral>] User<'Preferences when 'Preferences :> Models.Preferences> =
        /// User ID.
        abstract ``$id``: string with get, set
        /// User name.
        abstract name: string with get, set
        /// User registration date in Unix timestamp.
        abstract registration: float with get, set
        /// <summary>User status. Pass <c>true</c> for enabled and <c>false</c> for disabled.</summary>
        abstract status: bool with get, set
        /// Unix timestamp of the most recent password update
        abstract passwordUpdate: float with get, set
        /// User email address.
        abstract email: string with get, set
        /// Email verification status.
        abstract emailVerification: bool with get, set
        /// User preferences as a key-value object
        abstract prefs: 'Preferences with get, set

    /// Preferences
    type [<AllowNullLiteral>] Preferences =
        interface end

    /// Session
    type [<AllowNullLiteral>] Session =
        /// Session ID.
        abstract ``$id``: string with get, set
        /// User ID.
        abstract userId: string with get, set
        /// Session expiration date in Unix timestamp.
        abstract expire: float with get, set
        /// Session Provider.
        abstract provider: string with get, set
        /// Session Provider User ID.
        abstract providerUid: string with get, set
        /// Session Provider Access Token.
        abstract providerAccessToken: string with get, set
        /// Date, the Unix timestamp of when the access token expires.
        abstract providerAccessTokenExpiry: float with get, set
        /// Session Provider Refresh Token.
        abstract providerRefreshToken: string with get, set
        /// IP in use when the session was created.
        abstract ip: string with get, set
        /// <summary>Operating system code name. View list of <see href="https://github.com/appwrite/appwrite/blob/master/docs/lists/os.json">available options</see>.</summary>
        abstract osCode: string with get, set
        /// Operating system name.
        abstract osName: string with get, set
        /// Operating system version.
        abstract osVersion: string with get, set
        /// Client type.
        abstract clientType: string with get, set
        /// <summary>Client code name. View list of <see href="https://github.com/appwrite/appwrite/blob/master/docs/lists/clients.json">available options</see>.</summary>
        abstract clientCode: string with get, set
        /// Client name.
        abstract clientName: string with get, set
        /// Client version.
        abstract clientVersion: string with get, set
        /// Client engine name.
        abstract clientEngine: string with get, set
        /// Client engine name.
        abstract clientEngineVersion: string with get, set
        /// Device name.
        abstract deviceName: string with get, set
        /// Device brand name.
        abstract deviceBrand: string with get, set
        /// Device model name.
        abstract deviceModel: string with get, set
        /// Country two-character ISO 3166-1 alpha code.
        abstract countryCode: string with get, set
        /// Country name.
        abstract countryName: string with get, set
        /// Returns true if this the current user session.
        abstract current: bool with get, set

    /// Token
    type [<AllowNullLiteral>] Token =
        /// Token ID.
        abstract ``$id``: string with get, set
        /// User ID.
        abstract userId: string with get, set
        /// Token secret key. This will return an empty string unless the response is returned using an API key or as part of a webhook payload.
        abstract secret: string with get, set
        /// Token expiration date in Unix timestamp.
        abstract expire: float with get, set

    /// JWT
    type [<AllowNullLiteral>] Jwt =
        /// JWT encoded string.
        abstract jwt: string with get, set

    /// Locale
    type [<AllowNullLiteral>] Locale =
        /// User IP address.
        abstract ip: string with get, set
        /// <summary>Country code in <see href="http://en.wikipedia.org/wiki/ISO_3166-1">ISO 3166-1</see> two-character format</summary>
        abstract countryCode: string with get, set
        /// Country name. This field support localization.
        abstract country: string with get, set
        /// Continent code. A two character continent code &quot;AF&quot; for Africa, &quot;AN&quot; for Antarctica, &quot;AS&quot; for Asia, &quot;EU&quot; for Europe, &quot;NA&quot; for North America, &quot;OC&quot; for Oceania, and &quot;SA&quot; for South America.
        abstract continentCode: string with get, set
        /// Continent name. This field support localization.
        abstract continent: string with get, set
        /// True if country is part of the Europian Union.
        abstract eu: bool with get, set
        /// <summary>Currency code in <see href="http://en.wikipedia.org/wiki/ISO_4217">ISO 4217-1</see> three-character format</summary>
        abstract currency: string with get, set

    /// File
    type [<AllowNullLiteral>] File =
        /// File ID.
        abstract ``$id``: string with get, set
        /// Bucket ID.
        abstract bucketId: string with get, set
        /// File read permissions.
        abstract ``$read``: string[] with get, set
        /// File write permissions.
        abstract ``$write``: string[] with get, set
        /// File name.
        abstract name: string with get, set
        /// File creation date in Unix timestamp.
        abstract dateCreated: float with get, set
        /// File MD5 signature.
        abstract signature: string with get, set
        /// File mime type.
        abstract mimeType: string with get, set
        /// File original size in bytes.
        abstract sizeOriginal: float with get, set
        /// Total number of chunks available
        abstract chunksTotal: float with get, set
        /// Total number of chunks uploaded
        abstract chunksUploaded: float with get, set

    /// Team
    type [<AllowNullLiteral>] Team =
        /// Team ID.
        abstract ``$id``: string with get, set
        /// Team name.
        abstract name: string with get, set
        /// Team creation date in Unix timestamp.
        abstract dateCreated: float with get, set
        /// Total number of team members.
        abstract total: float with get, set

    /// Membership
    type [<AllowNullLiteral>] Membership =
        /// Membership ID.
        abstract ``$id``: string with get, set
        /// User ID.
        abstract userId: string with get, set
        /// Team ID.
        abstract teamId: string with get, set
        /// User name.
        abstract name: string with get, set
        /// User email address.
        abstract email: string with get, set
        /// Date, the user has been invited to join the team in Unix timestamp.
        abstract invited: float with get, set
        /// Date, the user has accepted the invitation to join the team in Unix timestamp.
        abstract joined: float with get, set
        /// User confirmation status, true if the user has joined the team or false otherwise.
        abstract confirm: bool with get, set
        /// User list of roles
        abstract roles: string[] with get, set

    /// Execution
    type [<AllowNullLiteral>] Execution =
        /// Execution ID.
        abstract ``$id``: string with get, set
        /// Execution read permissions.
        abstract ``$read``: string[] with get, set
        /// Function ID.
        abstract functionId: string with get, set
        /// The execution creation date in Unix timestamp.
        abstract dateCreated: float with get, set
        /// <summary>The trigger that caused the function to execute. Possible values can be: <c>http</c>, <c>schedule</c>, or <c>event</c>.</summary>
        abstract trigger: string with get, set
        /// <summary>The status of the function execution. Possible values can be: <c>waiting</c>, <c>processing</c>, <c>completed</c>, or <c>failed</c>.</summary>
        abstract status: string with get, set
        /// The script status code.
        abstract statusCode: float with get, set
        /// The script stdout output string. Logs the last 4,000 characters of the execution stdout output.
        abstract stdout: string with get, set
        /// The script stderr output string. Logs the last 4,000 characters of the execution stderr output
        abstract stderr: string with get, set
        /// The script execution time in seconds.
        abstract time: float with get, set

    /// Country
    type [<AllowNullLiteral>] Country =
        /// Country name.
        abstract name: string with get, set
        /// Country two-character ISO 3166-1 alpha code.
        abstract code: string with get, set

    /// Continent
    type [<AllowNullLiteral>] Continent =
        /// Continent name.
        abstract name: string with get, set
        /// Continent two letter code.
        abstract code: string with get, set

    /// Language
    type [<AllowNullLiteral>] Language =
        /// Language name.
        abstract name: string with get, set
        /// Language two-character ISO 639-1 codes.
        abstract code: string with get, set
        /// Language native name.
        abstract nativeName: string with get, set

    /// Currency
    type [<AllowNullLiteral>] Currency =
        /// Currency symbol.
        abstract symbol: string with get, set
        /// Currency name.
        abstract name: string with get, set
        /// Currency native symbol.
        abstract symbolNative: string with get, set
        /// Number of decimal digits.
        abstract decimalDigits: float with get, set
        /// Currency digit rounding.
        abstract rounding: float with get, set
        /// <summary>Currency code in <see href="http://en.wikipedia.org/wiki/ISO_4217">ISO 4217-1</see> three-character format.</summary>
        abstract code: string with get, set
        /// Currency plural name
        abstract namePlural: string with get, set

    /// Phone
    type [<AllowNullLiteral>] Phone =
        /// Phone code.
        abstract code: string with get, set
        /// Country two-character ISO 3166-1 alpha code.
        abstract countryCode: string with get, set
        /// Country name.
        abstract countryName: string with get, set

type [<AllowNullLiteral>] Headers =
    [<EmitIndexer>] abstract Item: key: string -> string with get, set

type [<AllowNullLiteral>] RealtimeResponseEvent<'T> =
    abstract ``event``: string with get, set
    abstract channels: string[] with get, set
    abstract timestamp: float with get, set
    abstract payload: 'T with get, set

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
    [<EmitConstructor>] abstract Create: message: string * ?code: float * ?``type``: string * ?response: string -> AppwriteException

type [<AllowNullLiteral>] Appwrite =
    abstract config: AppwriteConfig with get, set
    abstract headers: Headers with get, set
    /// <summary>
    /// Set Endpoint
    ///
    /// Your project endpoint
    /// </summary>
    /// <param name="endpoint" />
    /// <returns />
    abstract setEndpoint: endpoint: string -> Appwrite
    /// <summary>Set Realtime Endpoint</summary>
    /// <param name="endpointRealtime" />
    /// <returns />
    abstract setEndpointRealtime: endpointRealtime: string -> Appwrite
    /// <summary>
    /// Set Project
    ///
    /// Your project ID
    /// </summary>
    /// <param name="value">string</param>
    /// <returns />
    abstract setProject: value: string -> Appwrite
    /// <summary>
    /// Set JWT
    ///
    /// Your secret JSON Web Token
    /// </summary>
    /// <param name="value">string</param>
    /// <returns />
    abstract setJWT: value: string -> Appwrite
    /// <summary>Set Locale</summary>
    /// <param name="value">string</param>
    /// <returns />
    abstract setLocale: value: string -> Appwrite
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
    abstract account: AppwriteAccount<'Preferences> when 'Preferences :> Models.Preferences with get, set
    abstract avatars: AppwriteAvatars with get, set
    abstract database: AppwriteDatabase<'Document> when 'Document :> Models.Document with get, set
    abstract functions: AppwriteFunctions with get, set
    abstract locale: AppwriteLocale with get, set
    abstract storage: AppwriteStorage with get, set
    abstract teams: AppwriteTeams with get, set

type [<AllowNullLiteral>] AppwriteStatic =
    [<EmitConstructor>] abstract Create: unit -> Appwrite
    abstract CHUNK_SIZE: float with get, set

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
    abstract equal: attribute: string * value: QueryTypes -> string
    abstract notEqual: attribute: string * value: QueryTypes -> string
    abstract lesser: attribute: string * value: QueryTypes -> string
    abstract lesserEqual: attribute: string * value: QueryTypes -> string
    abstract greater: attribute: string * value: QueryTypes -> string
    abstract greaterEqual: attribute: string * value: QueryTypes -> string
    abstract search: attribute: string * value: string -> string

type [<AllowNullLiteral>] AppwriteConfig =
    abstract endpoint: string with get, set
    abstract endpointRealtime: string with get, set
    abstract project: string with get, set
    abstract jwt: string with get, set
    abstract locale: string with get, set

type [<AllowNullLiteral>] AppwriteAccountDeletePromise =
    interface end

type [<AllowNullLiteral>] AppwriteAccount<'Preferences> when 'Preferences :> Models.Preferences =
    /// <summary>
    /// Get Account
    ///
    /// Get currently logged in user data as JSON object.
    /// </summary>
    /// <exception cref="AppwriteException" />
    /// <returns />
    abstract get: unit -> Promise<Models.User<'Preferences>>
    /// <summary>
    /// Create Account
    ///
    /// Use this endpoint to allow a new user to register a new account in your
    /// project. After the user registration completes successfully, you can use
    /// the <see cref="/docs/client/account.accountCreateVerification">/account/verfication</see>
    /// route to start verifying the user email address. To allow the new user to
    /// login to their new account, you need to create a new [account
    /// session](/docs/client/account#accountCreateSession).
    /// </summary>
    /// <param name="userId" />
    /// <param name="email" />
    /// <param name="password" />
    /// <param name="name" />
    /// <exception cref="AppwriteException" />
    /// <returns />
    abstract create: userId: string * email: string * password: string * ?name: string -> Promise<Models.User<'Preferences>>
    /// <summary>
    /// Delete Account
    ///
    /// Delete a currently logged in user account. Behind the scene, the user
    /// record is not deleted but permanently blocked from any access. This is done
    /// to avoid deleted accounts being overtaken by new users with the same email
    /// address. Any user-related resources like documents or storage files should
    /// be deleted separately.
    /// </summary>
    /// <exception cref="AppwriteException" />
    /// <returns />
    abstract delete: unit -> Promise<AppwriteAccountDeletePromise>
    /// <summary>
    /// Update Account Email
    ///
    /// Update currently logged in user account email address. After changing user
    /// address, the user confirmation status will get reset. A new confirmation
    /// email is not sent automatically however you can use the send confirmation
    /// email endpoint again to send the confirmation email. For security measures,
    /// user password is required to complete this request.
    /// This endpoint can also be used to convert an anonymous account to a normal
    /// one, by passing an email address and a new password.
    /// </summary>
    /// <param name="email" />
    /// <param name="password" />
    /// <exception cref="AppwriteException" />
    /// <returns />
    abstract updateEmail: email: string * password: string -> Promise<Models.User<'Preferences>>
    /// <summary>
    /// Create Account JWT
    ///
    /// Use this endpoint to create a JSON Web Token. You can use the resulting JWT
    /// to authenticate on behalf of the current user when working with the
    /// Appwrite server-side API and SDKs. The JWT secret is valid for 15 minutes
    /// from its creation and will be invalid if the user will logout in that time
    /// frame.
    /// </summary>
    /// <exception cref="AppwriteException" />
    /// <returns />
    abstract createJWT: unit -> Promise<Models.Jwt>
    /// <summary>
    /// Get Account Logs
    ///
    /// Get currently logged in user list of latest security activity logs. Each
    /// log returns user IP address, location and date and time of log.
    /// </summary>
    /// <param name="limit" />
    /// <param name="offset" />
    /// <exception cref="AppwriteException" />
    /// <returns />
    abstract getLogs: ?limit: float * ?offset: float -> Promise<Models.LogList>
    /// <summary>
    /// Update Account Name
    ///
    /// Update currently logged in user account name.
    /// </summary>
    /// <param name="name" />
    /// <exception cref="AppwriteException" />
    /// <returns />
    abstract updateName: name: string -> Promise<Models.User<'Preferences>>
    /// <summary>
    /// Update Account Password
    ///
    /// Update currently logged in user password. For validation, user is required
    /// to pass in the new password, and the old password. For users created with
    /// OAuth and Team Invites, oldPassword is optional.
    /// </summary>
    /// <param name="password" />
    /// <param name="oldPassword" />
    /// <exception cref="AppwriteException" />
    /// <returns />
    abstract updatePassword: password: string * ?oldPassword: string -> Promise<Models.User<'Preferences>>
    /// <summary>
    /// Get Account Preferences
    ///
    /// Get currently logged in user preferences as a key-value object.
    /// </summary>
    /// <exception cref="AppwriteException" />
    /// <returns />
    abstract getPrefs: unit -> Promise<'Preferences>
    /// <summary>
    /// Update Account Preferences
    ///
    /// Update currently logged in user account preferences. The object you pass is
    /// stored as is, and replaces any previous value. The maximum allowed prefs
    /// size is 64kB and throws error if exceeded.
    /// </summary>
    /// <param name="prefs" />
    /// <exception cref="AppwriteException" />
    /// <returns />
    abstract updatePrefs: prefs: obj -> Promise<Models.User<'Preferences>>
    /// <summary>
    /// Create Password Recovery
    ///
    /// Sends the user an email with a temporary secret key for password reset.
    /// When the user clicks the confirmation link he is redirected back to your
    /// app password reset URL with the secret key and email address values
    /// attached to the URL query string. Use the query string params to submit a
    /// request to the [PUT
    /// /account/recovery](/docs/client/account#accountUpdateRecovery) endpoint to
    /// complete the process. The verification link sent to the user's email
    /// address is valid for 1 hour.
    /// </summary>
    /// <param name="email" />
    /// <param name="url" />
    /// <exception cref="AppwriteException" />
    /// <returns />
    abstract createRecovery: email: string * url: string -> Promise<Models.Token>
    /// <summary>
    /// Create Password Recovery (confirmation)
    ///
    /// Use this endpoint to complete the user account password reset. Both the
    /// **userId** and **secret** arguments will be passed as query parameters to
    /// the redirect URL you have provided when sending your request to the [POST
    /// /account/recovery](/docs/client/account#accountCreateRecovery) endpoint.
    ///
    /// Please note that in order to avoid a [Redirect
    /// Attack](<see href="https://github.com/OWASP/CheatSheetSeries/blob/master/cheatsheets/Unvalidated_Redirects_and_Forwards_Cheat_Sheet.md)" />
    /// the only valid redirect URLs are the ones from domains you have set when
    /// adding your platforms in the console interface.
    /// </summary>
    /// <param name="userId" />
    /// <param name="secret" />
    /// <param name="password" />
    /// <param name="passwordAgain" />
    /// <exception cref="AppwriteException" />
    /// <returns />
    abstract updateRecovery: userId: string * secret: string * password: string * passwordAgain: string -> Promise<Models.Token>
    /// <summary>
    /// Get Account Sessions
    ///
    /// Get currently logged in user list of active sessions across different
    /// devices.
    /// </summary>
    /// <exception cref="AppwriteException" />
    /// <returns />
    abstract getSessions: unit -> Promise<Models.SessionList>
    /// <summary>
    /// Create Account Session
    ///
    /// Allow the user to login into their account by providing a valid email and
    /// password combination. This route will create a new session for the user.
    /// </summary>
    /// <param name="email" />
    /// <param name="password" />
    /// <exception cref="AppwriteException" />
    /// <returns />
    abstract createSession: email: string * password: string -> Promise<Models.Session>
    /// <summary>
    /// Delete All Account Sessions
    ///
    /// Delete all sessions from the user account and remove any sessions cookies
    /// from the end client.
    /// </summary>
    /// <exception cref="AppwriteException" />
    /// <returns />
    abstract deleteSessions: unit -> Promise<AppwriteAccountDeletePromise>
    /// <summary>
    /// Create Anonymous Session
    ///
    /// Use this endpoint to allow a new user to register an anonymous account in
    /// your project. This route will also create a new session for the user. To
    /// allow the new user to convert an anonymous account to a normal account, you
    /// need to update its [email and
    /// password](/docs/client/account#accountUpdateEmail) or create an [OAuth2
    /// session](/docs/client/account#accountCreateOAuth2Session).
    /// </summary>
    /// <exception cref="AppwriteException" />
    /// <returns />
    abstract createAnonymousSession: unit -> Promise<Models.Session>
    /// <summary>
    /// Create Magic URL session
    ///
    /// Sends the user an email with a secret key for creating a session. When the
    /// user clicks the link in the email, the user is redirected back to the URL
    /// you provided with the secret key and userId values attached to the URL
    /// query string. Use the query string parameters to submit a request to the
    /// [PUT
    /// /account/sessions/magic-url](/docs/client/account#accountUpdateMagicURLSession)
    /// endpoint to complete the login process. The link sent to the user's email
    /// address is valid for 1 hour. If you are on a mobile device you can leave
    /// the URL parameter empty, so that the login completion will be handled by
    /// your Appwrite instance by default.
    /// </summary>
    /// <param name="userId" />
    /// <param name="email" />
    /// <param name="url" />
    /// <exception cref="AppwriteException" />
    /// <returns />
    abstract createMagicURLSession: userId: string * email: string * ?url: string -> Promise<Models.Token>
    /// <summary>
    /// Create Magic URL session (confirmation)
    ///
    /// Use this endpoint to complete creating the session with the Magic URL. Both
    /// the **userId** and **secret** arguments will be passed as query parameters
    /// to the redirect URL you have provided when sending your request to the
    /// [POST
    /// /account/sessions/magic-url](/docs/client/account#accountCreateMagicURLSession)
    /// endpoint.
    ///
    /// Please note that in order to avoid a [Redirect
    /// Attack](<see href="https://github.com/OWASP/CheatSheetSeries/blob/master/cheatsheets/Unvalidated_Redirects_and_Forwards_Cheat_Sheet.md)" />
    /// the only valid redirect URLs are the ones from domains you have set when
    /// adding your platforms in the console interface.
    /// </summary>
    /// <param name="userId" />
    /// <param name="secret" />
    /// <exception cref="AppwriteException" />
    /// <returns />
    abstract updateMagicURLSession: userId: string * secret: string -> Promise<Models.Session>
    /// <summary>
    /// Create Account Session with OAuth2
    ///
    /// Allow the user to login to their account using the OAuth2 provider of their
    /// choice. Each OAuth2 provider should be enabled from the Appwrite console
    /// first. Use the success and failure arguments to provide a redirect URL's
    /// back to your app when login is completed.
    ///
    /// If there is already an active session, the new session will be attached to
    /// the logged-in account. If there are no active sessions, the server will
    /// attempt to look for a user with the same email address as the email
    /// received from the OAuth2 provider and attach the new session to the
    /// existing user. If no matching user is found - the server will create a new
    /// user..
    /// </summary>
    /// <param name="provider" />
    /// <param name="success" />
    /// <param name="failure" />
    /// <param name="scopes" />
    /// <exception cref="AppwriteException" />
    /// <returns />
    abstract createOAuth2Session: provider: string * ?success: string * ?failure: string * ?scopes: string[] -> U2<unit, URL>
    /// <summary>
    /// Get Session By ID
    ///
    /// Use this endpoint to get a logged in user's session using a Session ID.
    /// Inputting 'current' will return the current session being used.
    /// </summary>
    /// <param name="sessionId" />
    /// <exception cref="AppwriteException" />
    /// <returns />
    abstract getSession: sessionId: string -> Promise<Models.Session>
    /// <summary>Update Session (Refresh Tokens)</summary>
    /// <param name="sessionId" />
    /// <exception cref="AppwriteException" />
    /// <returns />
    abstract updateSession: sessionId: string -> Promise<Models.Session>
    /// <summary>
    /// Delete Account Session
    ///
    /// Use this endpoint to log out the currently logged in user from all their
    /// account sessions across all of their different devices. When using the
    /// Session ID argument, only the unique session ID provided is deleted.
    /// </summary>
    /// <param name="sessionId" />
    /// <exception cref="AppwriteException" />
    /// <returns />
    abstract deleteSession: sessionId: string -> Promise<AppwriteAccountDeletePromise>
    /// <summary>
    /// Create Email Verification
    ///
    /// Use this endpoint to send a verification message to your user email address
    /// to confirm they are the valid owners of that address. Both the **userId**
    /// and **secret** arguments will be passed as query parameters to the URL you
    /// have provided to be attached to the verification email. The provided URL
    /// should redirect the user back to your app and allow you to complete the
    /// verification process by verifying both the **userId** and **secret**
    /// parameters. Learn more about how to [complete the verification
    /// process](/docs/client/account#accountUpdateVerification). The verification
    /// link sent to the user's email address is valid for 7 days.
    ///
    /// Please note that in order to avoid a [Redirect
    /// Attack](<see href="https://github.com/OWASP/CheatSheetSeries/blob/master/cheatsheets/Unvalidated_Redirects_and_Forwards_Cheat_Sheet.md)," />
    /// the only valid redirect URLs are the ones from domains you have set when
    /// adding your platforms in the console interface.
    /// </summary>
    /// <param name="url" />
    /// <exception cref="AppwriteException" />
    /// <returns />
    abstract createVerification: url: string -> Promise<Models.Token>
    /// <summary>
    /// Create Email Verification (confirmation)
    ///
    /// Use this endpoint to complete the user email verification process. Use both
    /// the **userId** and **secret** parameters that were attached to your app URL
    /// to verify the user email ownership. If confirmed this route will return a
    /// 200 status code.
    /// </summary>
    /// <param name="userId" />
    /// <param name="secret" />
    /// <exception cref="AppwriteException" />
    /// <returns />
    abstract updateVerification: userId: string * secret: string -> Promise<Models.Token>

type [<AllowNullLiteral>] AppwriteAvatars =
    /// <summary>
    /// Get Browser Icon
    ///
    /// You can use this endpoint to show different browser icons to your users.
    /// The code argument receives the browser code as it appears in your user
    /// /account/sessions endpoint. Use width, height and quality arguments to
    /// change the output settings.
    /// </summary>
    /// <param name="code" />
    /// <param name="width" />
    /// <param name="height" />
    /// <param name="quality" />
    /// <exception cref="AppwriteException" />
    /// <returns />
    abstract getBrowser: code: string * ?width: float * ?height: float * ?quality: float -> URL
    /// <summary>
    /// Get Credit Card Icon
    ///
    /// The credit card endpoint will return you the icon of the credit card
    /// provider you need. Use width, height and quality arguments to change the
    /// output settings.
    /// </summary>
    /// <param name="code" />
    /// <param name="width" />
    /// <param name="height" />
    /// <param name="quality" />
    /// <exception cref="AppwriteException" />
    /// <returns />
    abstract getCreditCard: code: string * ?width: float * ?height: float * ?quality: float -> URL
    /// <summary>
    /// Get Favicon
    ///
    /// Use this endpoint to fetch the favorite icon (AKA favicon) of any remote
    /// website URL.
    /// </summary>
    /// <param name="url" />
    /// <exception cref="AppwriteException" />
    /// <returns />
    abstract getFavicon: url: string -> URL
    /// <summary>
    /// Get Country Flag
    ///
    /// You can use this endpoint to show different country flags icons to your
    /// users. The code argument receives the 2 letter country code. Use width,
    /// height and quality arguments to change the output settings.
    /// </summary>
    /// <param name="code" />
    /// <param name="width" />
    /// <param name="height" />
    /// <param name="quality" />
    /// <exception cref="AppwriteException" />
    /// <returns />
    abstract getFlag: code: string * ?width: float * ?height: float * ?quality: float -> URL
    /// <summary>
    /// Get Image from URL
    ///
    /// Use this endpoint to fetch a remote image URL and crop it to any image size
    /// you want. This endpoint is very useful if you need to crop and display
    /// remote images in your app or in case you want to make sure a 3rd party
    /// image is properly served using a TLS protocol.
    /// </summary>
    /// <param name="url" />
    /// <param name="width" />
    /// <param name="height" />
    /// <exception cref="AppwriteException" />
    /// <returns />
    abstract getImage: url: string * ?width: float * ?height: float -> URL
    /// <summary>
    /// Get User Initials
    ///
    /// Use this endpoint to show your user initials avatar icon on your website or
    /// app. By default, this route will try to print your logged-in user name or
    /// email initials. You can also overwrite the user name if you pass the 'name'
    /// parameter. If no name is given and no user is logged, an empty avatar will
    /// be returned.
    ///
    /// You can use the color and background params to change the avatar colors. By
    /// default, a random theme will be selected. The random theme will persist for
    /// the user's initials when reloading the same theme will always return for
    /// the same initials.
    /// </summary>
    /// <param name="name" />
    /// <param name="width" />
    /// <param name="height" />
    /// <param name="color" />
    /// <param name="background" />
    /// <exception cref="AppwriteException" />
    /// <returns />
    abstract getInitials: ?name: string * ?width: float * ?height: float * ?color: string * ?background: string -> URL
    /// <summary>
    /// Get QR Code
    ///
    /// Converts a given plain text to a QR code image. You can use the query
    /// parameters to change the size and style of the resulting image.
    /// </summary>
    /// <param name="text" />
    /// <param name="size" />
    /// <param name="margin" />
    /// <param name="download" />
    /// <exception cref="AppwriteException" />
    /// <returns />
    abstract getQR: text: string * ?size: float * ?margin: float * ?download: bool -> URL

type [<AllowNullLiteral>] AppwriteDatabase<'Document> when 'Document :> Models.Document =
    /// <summary>
    /// List Documents
    ///
    /// Get a list of all the user documents. You can use the query params to
    /// filter your results. On admin mode, this endpoint will return a list of all
    /// of the project's documents. [Learn more about different API
    /// modes](/docs/admin).
    /// </summary>
    /// <param name="collectionId" />
    /// <param name="queries" />
    /// <param name="limit" />
    /// <param name="offset" />
    /// <param name="cursor" />
    /// <param name="cursorDirection" />
    /// <param name="orderAttributes" />
    /// <param name="orderTypes" />
    /// <exception cref="AppwriteException" />
    /// <returns />
    abstract listDocuments: collectionId: string * ?queries: string[] * ?limit: float * ?offset: float * ?cursor: string * ?cursorDirection: string * ?orderAttributes: string[] * ?orderTypes: string[] -> Promise<Models.DocumentList<'Document>>
    /// <summary>
    /// Create Document
    ///
    /// Create a new Document. Before using this route, you should create a new
    /// collection resource using either a [server
    /// integration](/docs/server/database#databaseCreateCollection) API or
    /// directly from your database console.
    /// </summary>
    /// <param name="collectionId" />
    /// <param name="documentId" />
    /// <param name="data" />
    /// <param name="read" />
    /// <param name="write" />
    /// <exception cref="AppwriteException" />
    /// <returns />
    abstract createDocument: collectionId: string * documentId: string * data: obj * ?read: string[] * ?write: string[] -> Promise<'Document>
    /// <summary>
    /// Get Document
    ///
    /// Get a document by its unique ID. This endpoint response returns a JSON
    /// object with the document data.
    /// </summary>
    /// <param name="collectionId" />
    /// <param name="documentId" />
    /// <exception cref="AppwriteException" />
    /// <returns />
    abstract getDocument: collectionId: string * documentId: string -> Promise<'Document>
    /// <summary>
    /// Update Document
    ///
    /// Update a document by its unique ID. Using the patch method you can pass
    /// only specific fields that will get updated.
    /// </summary>
    /// <param name="collectionId" />
    /// <param name="documentId" />
    /// <param name="data" />
    /// <param name="read" />
    /// <param name="write" />
    /// <exception cref="AppwriteException" />
    /// <returns />
    abstract updateDocument: collectionId: string * documentId: string * data: obj * ?read: string[] * ?write: string[] -> Promise<'Document>
    /// <summary>
    /// Delete Document
    ///
    /// Delete a document by its unique ID. This endpoint deletes only the parent
    /// documents, its attributes and relations to other documents. Child documents
    /// **will not** be deleted.
    /// </summary>
    /// <param name="collectionId" />
    /// <param name="documentId" />
    /// <exception cref="AppwriteException" />
    /// <returns />
    abstract deleteDocument: collectionId: string * documentId: string -> Promise<AppwriteAccountDeletePromise>

type [<AllowNullLiteral>] AppwriteFunctions =
    /// <summary>Retry Build</summary>
    /// <param name="functionId" />
    /// <param name="deploymentId" />
    /// <param name="buildId" />
    /// <exception cref="AppwriteException" />
    /// <returns />
    abstract retryBuild: functionId: string * deploymentId: string * buildId: string -> Promise<AppwriteAccountDeletePromise>
    /// <summary>
    /// List Executions
    ///
    /// Get a list of all the current user function execution logs. You can use the
    /// query params to filter your results. On admin mode, this endpoint will
    /// return a list of all of the project's executions. [Learn more about
    /// different API modes](/docs/admin).
    /// </summary>
    /// <param name="functionId" />
    /// <param name="limit" />
    /// <param name="offset" />
    /// <param name="search" />
    /// <param name="cursor" />
    /// <param name="cursorDirection" />
    /// <exception cref="AppwriteException" />
    /// <returns />
    abstract listExecutions: functionId: string * ?limit: float * ?offset: float * ?search: string * ?cursor: string * ?cursorDirection: string -> Promise<Models.ExecutionList>
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

type [<AllowNullLiteral>] AppwriteLocale =
    /// <summary>
    /// Get User Locale
    ///
    /// Get the current user location based on IP. Returns an object with user
    /// country code, country name, continent name, continent code, ip address and
    /// suggested currency. You can use the locale header to get the data in a
    /// supported language.
    ///
    /// (<see href="https://db-ip.com">IP Geolocation by DB-IP</see>)
    /// </summary>
    /// <exception cref="AppwriteException" />
    /// <returns />
    abstract get: unit -> Promise<Models.Locale>
    /// <summary>
    /// List Continents
    ///
    /// List of all continents. You can use the locale header to get the data in a
    /// supported language.
    /// </summary>
    /// <exception cref="AppwriteException" />
    /// <returns />
    abstract getContinents: unit -> Promise<Models.ContinentList>
    /// <summary>
    /// List Countries
    ///
    /// List of all countries. You can use the locale header to get the data in a
    /// supported language.
    /// </summary>
    /// <exception cref="AppwriteException" />
    /// <returns />
    abstract getCountries: unit -> Promise<Models.CountryList>
    /// <summary>
    /// List EU Countries
    ///
    /// List of all countries that are currently members of the EU. You can use the
    /// locale header to get the data in a supported language.
    /// </summary>
    /// <exception cref="AppwriteException" />
    /// <returns />
    abstract getCountriesEU: unit -> Promise<Models.CountryList>
    /// <summary>
    /// List Countries Phone Codes
    ///
    /// List of all countries phone codes. You can use the locale header to get the
    /// data in a supported language.
    /// </summary>
    /// <exception cref="AppwriteException" />
    /// <returns />
    abstract getCountriesPhones: unit -> Promise<Models.PhoneList>
    /// <summary>
    /// List Currencies
    ///
    /// List of all currencies, including currency symbol, name, plural, and
    /// decimal digits for all major and minor currencies. You can use the locale
    /// header to get the data in a supported language.
    /// </summary>
    /// <exception cref="AppwriteException" />
    /// <returns />
    abstract getCurrencies: unit -> Promise<Models.CurrencyList>
    /// <summary>
    /// List Languages
    ///
    /// List of all languages classified by ISO 639-1 including 2-letter code, name
    /// in English, and name in the respective language.
    /// </summary>
    /// <exception cref="AppwriteException" />
    /// <returns />
    abstract getLanguages: unit -> Promise<Models.LanguageList>

type [<AllowNullLiteral>] AppwriteStorage =
    /// <summary>
    /// List Files
    ///
    /// Get a list of all the user files. You can use the query params to filter
    /// your results. On admin mode, this endpoint will return a list of all of the
    /// project's files. <see cref="/docs/admin">Learn more about different API modes</see>.
    /// </summary>
    /// <param name="bucketId" />
    /// <param name="search" />
    /// <param name="limit" />
    /// <param name="offset" />
    /// <param name="cursor" />
    /// <param name="cursorDirection" />
    /// <param name="orderType" />
    /// <exception cref="AppwriteException" />
    /// <returns />
    abstract listFiles: bucketId: string * ?search: string * ?limit: float * ?offset: float * ?cursor: string * ?cursorDirection: string * ?orderType: string -> Promise<Models.FileList>
    /// <summary>
    /// Create File
    ///
    /// Create a new file. Before using this route, you should create a new bucket
    /// resource using either a [server
    /// integration](/docs/server/database#storageCreateBucket) API or directly
    /// from your Appwrite console.
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
    /// <param name="read" />
    /// <param name="write" />
    /// <exception cref="AppwriteException" />
    /// <returns />
    abstract createFile: bucketId: string * fileId: string * file: File * ?read: string[] * ?write: string[] * ?onProgress: (UploadProgress -> unit) -> Promise<Models.File>
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
    /// <param name="read" />
    /// <param name="write" />
    /// <exception cref="AppwriteException" />
    /// <returns />
    abstract updateFile: bucketId: string * fileId: string * ?read: string[] * ?write: string[] -> Promise<Models.File>
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
    abstract deleteFile: bucketId: string * fileId: string -> Promise<AppwriteAccountDeletePromise>
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

type [<AllowNullLiteral>] AppwriteTeams =
    /// <summary>
    /// List Teams
    ///
    /// Get a list of all the teams in which the current user is a member. You can
    /// use the parameters to filter your results.
    ///
    /// In admin mode, this endpoint returns a list of all the teams in the current
    /// project. <see cref="/docs/admin">Learn more about different API modes</see>.
    /// </summary>
    /// <param name="search" />
    /// <param name="limit" />
    /// <param name="offset" />
    /// <param name="cursor" />
    /// <param name="cursorDirection" />
    /// <param name="orderType" />
    /// <exception cref="AppwriteException" />
    /// <returns />
    abstract list: ?search: string * ?limit: float * ?offset: float * ?cursor: string * ?cursorDirection: string * ?orderType: string -> Promise<Models.TeamList>
    /// <summary>
    /// Create Team
    ///
    /// Create a new team. The user who creates the team will automatically be
    /// assigned as the owner of the team. Only the users with the owner role can
    /// invite new members, add new owners and delete or update the team.
    /// </summary>
    /// <param name="teamId" />
    /// <param name="name" />
    /// <param name="roles" />
    /// <exception cref="AppwriteException" />
    /// <returns />
    abstract create: teamId: string * name: string * ?roles: string[] -> Promise<Models.Team>
    /// <summary>
    /// Get Team
    ///
    /// Get a team by its ID. All team members have read access for this resource.
    /// </summary>
    /// <param name="teamId" />
    /// <exception cref="AppwriteException" />
    /// <returns />
    abstract get: teamId: string -> Promise<Models.Team>
    /// <summary>
    /// Update Team
    ///
    /// Update a team using its ID. Only members with the owner role can update the
    /// team.
    /// </summary>
    /// <param name="teamId" />
    /// <param name="name" />
    /// <exception cref="AppwriteException" />
    /// <returns />
    abstract update: teamId: string * name: string -> Promise<Models.Team>
    /// <summary>
    /// Delete Team
    ///
    /// Delete a team using its ID. Only team members with the owner role can
    /// delete the team.
    /// </summary>
    /// <param name="teamId" />
    /// <exception cref="AppwriteException" />
    /// <returns />
    abstract delete: teamId: string -> Promise<AppwriteAccountDeletePromise>
    /// <summary>
    /// Get Team Memberships
    ///
    /// Use this endpoint to list a team's members using the team's ID. All team
    /// members have read access to this endpoint.
    /// </summary>
    /// <param name="teamId" />
    /// <param name="search" />
    /// <param name="limit" />
    /// <param name="offset" />
    /// <param name="cursor" />
    /// <param name="cursorDirection" />
    /// <param name="orderType" />
    /// <exception cref="AppwriteException" />
    /// <returns />
    abstract getMemberships: teamId: string * ?search: string * ?limit: float * ?offset: float * ?cursor: string * ?cursorDirection: string * ?orderType: string -> Promise<Models.MembershipList>
    /// <summary>
    /// Create Team Membership
    ///
    /// Invite a new member to join your team. If initiated from the client SDK, an
    /// email with a link to join the team will be sent to the member's email
    /// address and an account will be created for them should they not be signed
    /// up already. If initiated from server-side SDKs, the new member will
    /// automatically be added to the team.
    ///
    /// Use the 'url' parameter to redirect the user from the invitation email back
    /// to your app. When the user is redirected, use the [Update Team Membership
    /// Status](/docs/client/teams#teamsUpdateMembershipStatus) endpoint to allow
    /// the user to accept the invitation to the team.
    ///
    /// Please note that to avoid a [Redirect
    /// Attack](<see href="https://github.com/OWASP/CheatSheetSeries/blob/master/cheatsheets/Unvalidated_Redirects_and_Forwards_Cheat_Sheet.md)" />
    /// the only valid redirect URL's are the once from domains you have set when
    /// adding your platforms in the console interface.
    /// </summary>
    /// <param name="teamId" />
    /// <param name="email" />
    /// <param name="roles" />
    /// <param name="url" />
    /// <param name="name" />
    /// <exception cref="AppwriteException" />
    /// <returns />
    abstract createMembership: teamId: string * email: string * roles: string[] * url: string * ?name: string -> Promise<Models.Membership>
    /// <summary>
    /// Get Team Membership
    ///
    /// Get a team member by the membership unique id. All team members have read
    /// access for this resource.
    /// </summary>
    /// <param name="teamId" />
    /// <param name="membershipId" />
    /// <exception cref="AppwriteException" />
    /// <returns />
    abstract getMembership: teamId: string * membershipId: string -> Promise<Models.MembershipList>
    /// <summary>
    /// Update Membership Roles
    ///
    /// Modify the roles of a team member. Only team members with the owner role
    /// have access to this endpoint. Learn more about [roles and
    /// permissions](/docs/permissions).
    /// </summary>
    /// <param name="teamId" />
    /// <param name="membershipId" />
    /// <param name="roles" />
    /// <exception cref="AppwriteException" />
    /// <returns />
    abstract updateMembershipRoles: teamId: string * membershipId: string * roles: string[] -> Promise<Models.Membership>
    /// <summary>
    /// Delete Team Membership
    ///
    /// This endpoint allows a user to leave a team or for a team owner to delete
    /// the membership of any other team member. You can also use this endpoint to
    /// delete a user membership even if it is not accepted.
    /// </summary>
    /// <param name="teamId" />
    /// <param name="membershipId" />
    /// <exception cref="AppwriteException" />
    /// <returns />
    abstract deleteMembership: teamId: string * membershipId: string -> Promise<AppwriteAccountDeletePromise>
    /// <summary>
    /// Update Team Membership Status
    ///
    /// Use this endpoint to allow a user to accept an invitation to join a team
    /// after being redirected back to your app from the invitation email received
    /// by the user.
    ///
    /// If the request is successful, a session for the user is automatically
    /// created.
    /// </summary>
    /// <param name="teamId" />
    /// <param name="membershipId" />
    /// <param name="userId" />
    /// <param name="secret" />
    /// <exception cref="AppwriteException" />
    /// <returns />
    abstract updateMembershipStatus: teamId: string * membershipId: string * userId: string * secret: string -> Promise<Models.Membership>