// <copyright file="ExtensionHelpers.cs" company="Drastic Actions">
// Copyright (c) Drastic Actions. All rights reserved.
// </copyright>

using System.Collections.Specialized;
using System.Web;

namespace DrasticBomb.Tools
{
    public static class ExtensionHelpers
    {
        internal static string ToQueryString(this NameValueCollection nvc)
        {
#pragma warning disable CS8603
            var array = (
                from key in nvc.AllKeys
                from value in nvc.GetValues(key)
                select string.Format(
            "{0}={1}",
            HttpUtility.UrlEncode(key),
            HttpUtility.UrlEncode(value))
                ).ToArray();
#pragma warning restore CS8603
            return "?" + string.Join("&", array);
        }
    }
}
