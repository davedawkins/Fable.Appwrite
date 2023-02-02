// ts2fable 0.8.0
module rec AppwriteSdk.Locale

#nowarn "3390" // disable warnings for invalid XML comments

open System
open Fable.Core
open Fable.Core.JS

type Service = AppwriteSdk.Service.Service
type AppwriteException = AppwriteSdk.Client.AppwriteException
type Client = AppwriteSdk.Client.Client
type URL = interface end

type [<AllowNullLiteral>] IExports =
    abstract Locale: LocaleStatic

type [<AllowNullLiteral>] Locale =
    inherit Service
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
    abstract listContinents: unit -> Promise<Models.ContinentList>
    /// <summary>
    /// List Countries
    ///
    /// List of all countries. You can use the locale header to get the data in a
    /// supported language.
    /// </summary>
    /// <exception cref="AppwriteException" />
    /// <returns />
    abstract listCountries: unit -> Promise<Models.CountryList>
    /// <summary>
    /// List EU Countries
    ///
    /// List of all countries that are currently members of the EU. You can use the
    /// locale header to get the data in a supported language.
    /// </summary>
    /// <exception cref="AppwriteException" />
    /// <returns />
    abstract listCountriesEU: unit -> Promise<Models.CountryList>
    /// <summary>
    /// List Countries Phone Codes
    ///
    /// List of all countries phone codes. You can use the locale header to get the
    /// data in a supported language.
    /// </summary>
    /// <exception cref="AppwriteException" />
    /// <returns />
    abstract listCountriesPhones: unit -> Promise<Models.PhoneList>
    /// <summary>
    /// List Currencies
    ///
    /// List of all currencies, including currency symbol, name, plural, and
    /// decimal digits for all major and minor currencies. You can use the locale
    /// header to get the data in a supported language.
    /// </summary>
    /// <exception cref="AppwriteException" />
    /// <returns />
    abstract listCurrencies: unit -> Promise<Models.CurrencyList>
    /// <summary>
    /// List Languages
    ///
    /// List of all languages classified by ISO 639-1 including 2-letter code, name
    /// in English, and name in the respective language.
    /// </summary>
    /// <exception cref="AppwriteException" />
    /// <returns />
    abstract listLanguages: unit -> Promise<Models.LanguageList>

type [<AllowNullLiteral>] LocaleStatic =
    [<EmitConstructor>] abstract Create: client: Client -> Locale