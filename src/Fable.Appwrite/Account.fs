// ts2fable 0.8.0
module rec AppwriteSdk.Account

#nowarn "3390" // disable warnings for invalid XML comments

open System
open Fable.Core
open Fable.Core.JS

type Service = AppwriteSdk.Service.Service
type AppwriteException = AppwriteSdk.Client.AppwriteException
type Client = AppwriteSdk.Client.Client
type URL = interface end

type [<AllowNullLiteral>] IExports =
    abstract Account: AccountStatic

type [<AllowNullLiteral>] Account =
    inherit Service
    /// <summary>
    /// Get Account
    ///
    /// Get currently logged in user data as JSON object.
    /// </summary>
    /// <exception cref="AppwriteException" />
    /// <returns />
    abstract get: unit -> Promise<Models.Account<'Preferences>> when 'Preferences :> Models.Preferences
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
    abstract create: userId: string * email: string * password: string * ?name: string -> Promise<Models.Account<'Preferences>> when 'Preferences :> Models.Preferences
    /// <summary>
    /// Update Email
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
    abstract updateEmail: email: string * password: string -> Promise<Models.Account<'Preferences>> when 'Preferences :> Models.Preferences
    /// <summary>
    /// Create JWT
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
    /// List Logs
    ///
    /// Get currently logged in user list of latest security activity logs. Each
    /// log returns user IP address, location and date and time of log.
    /// </summary>
    /// <param name="queries" />
    /// <exception cref="AppwriteException" />
    /// <returns />
    abstract listLogs: ?queries: string[] -> Promise<Models.LogList>
    /// <summary>
    /// Update Name
    ///
    /// Update currently logged in user account name.
    /// </summary>
    /// <param name="name" />
    /// <exception cref="AppwriteException" />
    /// <returns />
    abstract updateName: name: string -> Promise<Models.Account<'Preferences>> when 'Preferences :> Models.Preferences
    /// <summary>
    /// Update Password
    ///
    /// Update currently logged in user password. For validation, user is required
    /// to pass in the new password, and the old password. For users created with
    /// OAuth, Team Invites and Magic URL, oldPassword is optional.
    /// </summary>
    /// <param name="password" />
    /// <param name="oldPassword" />
    /// <exception cref="AppwriteException" />
    /// <returns />
    abstract updatePassword: password: string * ?oldPassword: string -> Promise<Models.Account<'Preferences>> when 'Preferences :> Models.Preferences
    /// <summary>
    /// Update Phone
    ///
    /// Update the currently logged in user's phone number. After updating the
    /// phone number, the phone verification status will be reset. A confirmation
    /// SMS is not sent automatically, however you can use the [POST
    /// /account/verification/phone](/docs/client/account#accountCreatePhoneVerification)
    /// endpoint to send a confirmation SMS.
    /// </summary>
    /// <param name="phone" />
    /// <param name="password" />
    /// <exception cref="AppwriteException" />
    /// <returns />
    abstract updatePhone: phone: string * password: string -> Promise<Models.Account<'Preferences>> when 'Preferences :> Models.Preferences
    /// <summary>
    /// Get Account Preferences
    ///
    /// Get currently logged in user preferences as a key-value object.
    /// </summary>
    /// <exception cref="AppwriteException" />
    /// <returns />
    abstract getPrefs: unit -> Promise<'Preferences> when 'Preferences :> Models.Preferences
    /// <summary>
    /// Update Preferences
    ///
    /// Update currently logged in user account preferences. The object you pass is
    /// stored as is, and replaces any previous value. The maximum allowed prefs
    /// size is 64kB and throws error if exceeded.
    /// </summary>
    /// <param name="prefs" />
    /// <exception cref="AppwriteException" />
    /// <returns />
    abstract updatePrefs: prefs: obj -> Promise<Models.Account<'Preferences>> when 'Preferences :> Models.Preferences
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
    /// List Sessions
    ///
    /// Get currently logged in user list of active sessions across different
    /// devices.
    /// </summary>
    /// <exception cref="AppwriteException" />
    /// <returns />
    abstract listSessions: unit -> Promise<Models.SessionList>
    /// <summary>
    /// Delete Sessions
    ///
    /// Delete all sessions from the user account and remove any sessions cookies
    /// from the end client.
    /// </summary>
    /// <exception cref="AppwriteException" />
    /// <returns />
    abstract deleteSessions: unit -> Promise<AccountDeleteSessionsPromise>
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
    /// Create Email Session
    ///
    /// Allow the user to login into their account by providing a valid email and
    /// password combination. This route will create a new session for the user.
    ///
    /// A user is limited to 10 active sessions at a time by default. [Learn more
    /// about session limits](/docs/authentication#limits).
    /// </summary>
    /// <param name="email" />
    /// <param name="password" />
    /// <exception cref="AppwriteException" />
    /// <returns />
    abstract createEmailSession: email: string * password: string -> Promise<Models.Session>
    /// <summary>
    /// Create Magic URL session
    ///
    /// Sends the user an email with a secret key for creating a session. If the
    /// provided user ID has not be registered, a new user will be created. When
    /// the user clicks the link in the email, the user is redirected back to the
    /// URL you provided with the secret key and userId values attached to the URL
    /// query string. Use the query string parameters to submit a request to the
    /// [PUT
    /// /account/sessions/magic-url](/docs/client/account#accountUpdateMagicURLSession)
    /// endpoint to complete the login process. The link sent to the user's email
    /// address is valid for 1 hour. If you are on a mobile device you can leave
    /// the URL parameter empty, so that the login completion will be handled by
    /// your Appwrite instance by default.
    ///
    /// A user is limited to 10 active sessions at a time by default. [Learn more
    /// about session limits](/docs/authentication#limits).
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
    /// Create OAuth2 Session
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
    /// user.
    ///
    /// A user is limited to 10 active sessions at a time by default. [Learn more
    /// about session limits](/docs/authentication#limits).
    /// </summary>
    /// <param name="provider" />
    /// <param name="success" />
    /// <param name="failure" />
    /// <param name="scopes" />
    /// <exception cref="AppwriteException" />
    /// <returns />
    abstract createOAuth2Session: provider: string * ?success: string * ?failure: string * ?scopes: string[] -> U2<unit, URL>
    /// <summary>
    /// Create Phone session
    ///
    /// Sends the user an SMS with a secret key for creating a session. If the
    /// provided user ID has not be registered, a new user will be created. Use the
    /// returned user ID and secret and submit a request to the [PUT
    /// /account/sessions/phone](/docs/client/account#accountUpdatePhoneSession)
    /// endpoint to complete the login process. The secret sent to the user's phone
    /// is valid for 15 minutes.
    ///
    /// A user is limited to 10 active sessions at a time by default. [Learn more
    /// about session limits](/docs/authentication#limits).
    /// </summary>
    /// <param name="userId" />
    /// <param name="phone" />
    /// <exception cref="AppwriteException" />
    /// <returns />
    abstract createPhoneSession: userId: string * phone: string -> Promise<Models.Token>
    /// <summary>
    /// Create Phone Session (confirmation)
    ///
    /// Use this endpoint to complete creating a session with SMS. Use the
    /// **userId** from the
    /// <see cref="/docs/client/account.accountCreatePhoneSession">createPhoneSession</see>
    /// endpoint and the **secret** received via SMS to successfully update and
    /// confirm the phone session.
    /// </summary>
    /// <param name="userId" />
    /// <param name="secret" />
    /// <exception cref="AppwriteException" />
    /// <returns />
    abstract updatePhoneSession: userId: string * secret: string -> Promise<Models.Session>
    /// <summary>
    /// Get Session
    ///
    /// Use this endpoint to get a logged in user's session using a Session ID.
    /// Inputting 'current' will return the current session being used.
    /// </summary>
    /// <param name="sessionId" />
    /// <exception cref="AppwriteException" />
    /// <returns />
    abstract getSession: sessionId: string -> Promise<Models.Session>
    /// <summary>
    /// Update OAuth Session (Refresh Tokens)
    ///
    /// Access tokens have limited lifespan and expire to mitigate security risks.
    /// If session was created using an OAuth provider, this route can be used to
    /// "refresh" the access token.
    /// </summary>
    /// <param name="sessionId" />
    /// <exception cref="AppwriteException" />
    /// <returns />
    abstract updateSession: sessionId: string -> Promise<Models.Session>
    /// <summary>
    /// Delete Session
    ///
    /// Use this endpoint to log out the currently logged in user from all their
    /// account sessions across all of their different devices. When using the
    /// Session ID argument, only the unique session ID provided is deleted.
    /// </summary>
    /// <param name="sessionId" />
    /// <exception cref="AppwriteException" />
    /// <returns />
    abstract deleteSession: sessionId: string -> Promise<AccountDeleteSessionsPromise>
    /// <summary>
    /// Update Status
    ///
    /// Block the currently logged in user account. Behind the scene, the user
    /// record is not deleted but permanently blocked from any access. To
    /// completely delete a user, use the Users API instead.
    /// </summary>
    /// <exception cref="AppwriteException" />
    /// <returns />
    abstract updateStatus: unit -> Promise<Models.Account<'Preferences>> when 'Preferences :> Models.Preferences
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
    /// process](/docs/client/account#accountUpdateEmailVerification). The
    /// verification link sent to the user's email address is valid for 7 days.
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
    /// <summary>
    /// Create Phone Verification
    ///
    /// Use this endpoint to send a verification SMS to the currently logged in
    /// user. This endpoint is meant for use after updating a user's phone number
    /// using the <see cref="/docs/client/account.accountUpdatePhone">accountUpdatePhone</see>
    /// endpoint. Learn more about how to [complete the verification
    /// process](/docs/client/account#accountUpdatePhoneVerification). The
    /// verification code sent to the user's phone number is valid for 15 minutes.
    /// </summary>
    /// <exception cref="AppwriteException" />
    /// <returns />
    abstract createPhoneVerification: unit -> Promise<Models.Token>
    /// <summary>
    /// Create Phone Verification (confirmation)
    ///
    /// Use this endpoint to complete the user phone verification process. Use the
    /// **userId** and **secret** that were sent to your user's phone number to
    /// verify the user email ownership. If confirmed this route will return a 200
    /// status code.
    /// </summary>
    /// <param name="userId" />
    /// <param name="secret" />
    /// <exception cref="AppwriteException" />
    /// <returns />
    abstract updatePhoneVerification: userId: string * secret: string -> Promise<Models.Token>

type [<AllowNullLiteral>] AccountStatic =
    [<EmitConstructor>] abstract Create: client: Client -> Account

type [<AllowNullLiteral>] AccountDeleteSessionsPromise =
    interface end