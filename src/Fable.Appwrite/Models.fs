// ts2fable 0.8.0
namespace AppwriteSdk

#nowarn "3390" // disable warnings for invalid XML comments

open Fable.Core

module rec Models =

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
        abstract ``$collectionId``: string with get, set
        /// Database ID.
        abstract ``$databaseId``: string with get, set
        /// Document creation date in ISO 8601 format.
        abstract ``$createdAt``: string with get, set
        /// Document update date in ISO 8601 format.
        abstract ``$updatedAt``: string with get, set
        /// <summary>Document permissions. <see cref="/docs/permissions">Learn more about permissions</see>.</summary>
        abstract ``$permissions``: string[] with get, set
        [<EmitIndexer>] abstract Item: key: string -> obj option with get, set

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
        /// Log creation date in ISO 8601 format.
        abstract time: string with get, set
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

    /// Account
    type [<AllowNullLiteral>] Account<'Preferences when 'Preferences :> Models.Preferences> =
        /// User ID.
        abstract ``$id``: string with get, set
        /// User creation date in ISO 8601 format.
        abstract ``$createdAt``: string with get, set
        /// User update date in ISO 8601 format.
        abstract ``$updatedAt``: string with get, set
        /// User name.
        abstract name: string with get, set
        /// User registration date in ISO 8601 format.
        abstract registration: string with get, set
        /// <summary>User status. Pass <c>true</c> for enabled and <c>false</c> for disabled.</summary>
        abstract status: bool with get, set
        /// Password update time in ISO 8601 format.
        abstract passwordUpdate: string with get, set
        /// User email address.
        abstract email: string with get, set
        /// User phone number in E.164 format.
        abstract phone: string with get, set
        /// Email verification status.
        abstract emailVerification: bool with get, set
        /// Phone verification status.
        abstract phoneVerification: bool with get, set
        /// User preferences as a key-value object
        abstract prefs: 'Preferences with get, set

    /// Preferences
    type [<AllowNullLiteral>] Preferences =
        [<EmitIndexer>] abstract Item: key: string -> obj option with get, set

    /// Session
    type [<AllowNullLiteral>] Session =
        /// Session ID.
        abstract ``$id``: string with get, set
        /// Session creation date in ISO 8601 format.
        abstract ``$createdAt``: string with get, set
        /// User ID.
        abstract userId: string with get, set
        /// Session expiration date in ISO 8601 format.
        abstract expire: string with get, set
        /// Session Provider.
        abstract provider: string with get, set
        /// Session Provider User ID.
        abstract providerUid: string with get, set
        /// Session Provider Access Token.
        abstract providerAccessToken: string with get, set
        /// The date of when the access token expires in ISO 8601 format.
        abstract providerAccessTokenExpiry: string with get, set
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
        /// Token creation date in ISO 8601 format.
        abstract ``$createdAt``: string with get, set
        /// User ID.
        abstract userId: string with get, set
        /// Token secret key. This will return an empty string unless the response is returned using an API key or as part of a webhook payload.
        abstract secret: string with get, set
        /// Token expiration date in ISO 8601 format.
        abstract expire: string with get, set

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
        /// File creation date in ISO 8601 format.
        abstract ``$createdAt``: string with get, set
        /// File update date in ISO 8601 format.
        abstract ``$updatedAt``: string with get, set
        /// <summary>File permissions. <see cref="/docs/permissions">Learn more about permissions</see>.</summary>
        abstract ``$permissions``: string[] with get, set
        /// File name.
        abstract name: string with get, set
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
        /// Team creation date in ISO 8601 format.
        abstract ``$createdAt``: string with get, set
        /// Team update date in ISO 8601 format.
        abstract ``$updatedAt``: string with get, set
        /// Team name.
        abstract name: string with get, set
        /// Total number of team members.
        abstract total: float with get, set

    /// Membership
    type [<AllowNullLiteral>] Membership =
        /// Membership ID.
        abstract ``$id``: string with get, set
        /// Membership creation date in ISO 8601 format.
        abstract ``$createdAt``: string with get, set
        /// Membership update date in ISO 8601 format.
        abstract ``$updatedAt``: string with get, set
        /// User ID.
        abstract userId: string with get, set
        /// User name.
        abstract userName: string with get, set
        /// User email address.
        abstract userEmail: string with get, set
        /// Team ID.
        abstract teamId: string with get, set
        /// Team name.
        abstract teamName: string with get, set
        /// Date, the user has been invited to join the team in ISO 8601 format.
        abstract invited: string with get, set
        /// Date, the user has accepted the invitation to join the team in ISO 8601 format.
        abstract joined: string with get, set
        /// User confirmation status, true if the user has joined the team or false otherwise.
        abstract confirm: bool with get, set
        /// User list of roles
        abstract roles: string[] with get, set

    /// Execution
    type [<AllowNullLiteral>] Execution =
        /// Execution ID.
        abstract ``$id``: string with get, set
        /// Execution creation date in ISO 8601 format.
        abstract ``$createdAt``: string with get, set
        /// Execution upate date in ISO 8601 format.
        abstract ``$updatedAt``: string with get, set
        /// Execution roles.
        abstract ``$permissions``: string[] with get, set
        /// Function ID.
        abstract functionId: string with get, set
        /// <summary>The trigger that caused the function to execute. Possible values can be: <c>http</c>, <c>schedule</c>, or <c>event</c>.</summary>
        abstract trigger: string with get, set
        /// <summary>The status of the function execution. Possible values can be: <c>waiting</c>, <c>processing</c>, <c>completed</c>, or <c>failed</c>.</summary>
        abstract status: string with get, set
        /// The script status code.
        abstract statusCode: float with get, set
        /// The script response output string. Logs the last 4,000 characters of the execution response output.
        abstract response: string with get, set
        /// The script stdout output string. Logs the last 4,000 characters of the execution stdout output. This will return an empty string unless the response is returned using an API key or as part of a webhook payload.
        abstract stdout: string with get, set
        /// The script stderr output string. Logs the last 4,000 characters of the execution stderr output. This will return an empty string unless the response is returned using an API key or as part of a webhook payload.
        abstract stderr: string with get, set
        /// The script execution duration in seconds.
        abstract duration: float with get, set

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