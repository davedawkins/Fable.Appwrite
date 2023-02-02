// ts2fable 0.8.0
module rec AppwriteSdk.Avatars

#nowarn "3390" // disable warnings for invalid XML comments

open System
open Fable.Core
open Fable.Core.JS

type Service = AppwriteSdk.Service.Service
type AppwriteException = AppwriteSdk.Client.AppwriteException
type Client = AppwriteSdk.Client.Client
type URL = interface end

type [<AllowNullLiteral>] IExports =
    abstract Avatars: AvatarsStatic

type [<AllowNullLiteral>] Avatars =
    inherit Service
    /// <summary>
    /// Get Browser Icon
    ///
    /// You can use this endpoint to show different browser icons to your users.
    /// The code argument receives the browser code as it appears in your user [GET
    /// /account/sessions](/docs/client/account#accountGetSessions) endpoint. Use
    /// width, height and quality arguments to change the output settings.
    ///
    /// When one dimension is specified and the other is 0, the image is scaled
    /// with preserved aspect ratio. If both dimensions are 0, the API provides an
    /// image at source quality. If dimensions are not specified, the default size
    /// of image returned is 100x100px.
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
    ///
    /// When one dimension is specified and the other is 0, the image is scaled
    /// with preserved aspect ratio. If both dimensions are 0, the API provides an
    /// image at source quality. If dimensions are not specified, the default size
    /// of image returned is 100x100px.
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
    /// height and quality arguments to change the output settings. Country codes
    /// follow the <see href="http://en.wikipedia.org/wiki/ISO_3166-1">ISO 3166-1</see> standard.
    ///
    /// When one dimension is specified and the other is 0, the image is scaled
    /// with preserved aspect ratio. If both dimensions are 0, the API provides an
    /// image at source quality. If dimensions are not specified, the default size
    /// of image returned is 100x100px.
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
    ///
    /// When one dimension is specified and the other is 0, the image is scaled
    /// with preserved aspect ratio. If both dimensions are 0, the API provides an
    /// image at source quality. If dimensions are not specified, the default size
    /// of image returned is 400x400px.
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
    ///
    /// When one dimension is specified and the other is 0, the image is scaled
    /// with preserved aspect ratio. If both dimensions are 0, the API provides an
    /// image at source quality. If dimensions are not specified, the default size
    /// of image returned is 100x100px.
    /// </summary>
    /// <param name="name" />
    /// <param name="width" />
    /// <param name="height" />
    /// <param name="background" />
    /// <exception cref="AppwriteException" />
    /// <returns />
    abstract getInitials: ?name: string * ?width: float * ?height: float * ?background: string -> URL
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

type [<AllowNullLiteral>] AvatarsStatic =
    [<EmitConstructor>] abstract Create: client: Client -> Avatars