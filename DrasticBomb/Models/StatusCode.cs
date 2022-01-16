// <copyright file="StatusCode.cs" company="Drastic Actions">
// Copyright (c) Drastic Actions. All rights reserved.
// </copyright>

namespace DrasticBomb.Models
{
    /// <summary>
    /// Response Status Code.
    /// </summary>
    public enum StatusCode
    {
        /// <summary>
        /// OK.
        /// </summary>
        OK = 1,

        /// <summary>
        /// Invalid API Key.
        /// </summary>
        InvalidApiKey = 100,

        /// <summary>
        /// Object Not Found.
        /// </summary>
        ObjectNotFound = 101,

        /// <summary>
        /// Error in URL Format.
        /// </summary>
        ErrorInUrlFormat = 102,

        /// <summary>
        /// 'jsonp' format requires a 'json_callback' argument.
        /// </summary>
        JsonPFormatError = 103,

        /// <summary>
        /// Filter Error.
        /// </summary>
        FilterError = 104,

        /// <summary>
        /// Subscriber only video is for subscribers only..
        /// </summary>
        SubscriberOnly = 105,
    }
}
