// ts2fable 0.8.0
module rec AppwriteSdk.Teams

#nowarn "3390" // disable warnings for invalid XML comments

open System
open Fable.Core
open Fable.Core.JS

type Service = AppwriteSdk.Service.Service
type AppwriteException = AppwriteSdk.Client.AppwriteException
type Client = AppwriteSdk.Client.Client
type URL = interface end

type [<AllowNullLiteral>] IExports =
    abstract Teams: TeamsStatic

type [<AllowNullLiteral>] Teams =
    inherit Service
    /// <summary>
    /// List Teams
    ///
    /// Get a list of all the teams in which the current user is a member. You can
    /// use the parameters to filter your results.
    /// </summary>
    /// <param name="queries" />
    /// <param name="search" />
    /// <exception cref="AppwriteException" />
    /// <returns />
    abstract list: ?queries: string[] * ?search: string -> Promise<Models.TeamList>
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
    abstract delete: teamId: string -> Promise<TeamsDeletePromise>
    /// <summary>
    /// List Team Memberships
    ///
    /// Use this endpoint to list a team's members using the team's ID. All team
    /// members have read access to this endpoint.
    /// </summary>
    /// <param name="teamId" />
    /// <param name="queries" />
    /// <param name="search" />
    /// <exception cref="AppwriteException" />
    /// <returns />
    abstract listMemberships: teamId: string * ?queries: string[] * ?search: string -> Promise<Models.MembershipList>
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
    abstract getMembership: teamId: string * membershipId: string -> Promise<Models.Membership>
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
    abstract deleteMembership: teamId: string * membershipId: string -> Promise<TeamsDeletePromise>
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

type [<AllowNullLiteral>] TeamsStatic =
    [<EmitConstructor>] abstract Create: client: Client -> Teams

type [<AllowNullLiteral>] TeamsDeletePromise =
    interface end