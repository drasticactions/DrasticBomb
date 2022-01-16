// <copyright file="BaseResposne.cs" company="Drastic Actions">
// Copyright (c) Drastic Actions. All rights reserved.
// </copyright>

using System.Text.Json.Serialization;

namespace DrasticBomb.Models
{
    /// <summary>
    /// Base Response.
    /// </summary>
    public class BaseResposne
    {
        /// <summary>
        /// Gets or sets the "error" type. A text string representing the status_code.
        /// If set to "OK," there is no error.
        /// </summary>
        [JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Gets or sets the value of the limit filter specified, or 100 if not specified.
        /// </summary>
        [JsonPropertyName("limit")]
        public long Limit { get; set; }

        /// <summary>
        /// Gets or sets the value of the offset filter specified, or 0 if not specified.
        /// </summary>
        [JsonPropertyName("offset")]
        public long Offset { get; set; }

        /// <summary>
        /// Gets or sets the number of pages in the result.
        /// </summary>
        [JsonPropertyName("number_of_page_results")]
        public long NumberOfPageResults { get; set; }

        /// <summary>
        /// Gets or sets the total number of results.
        /// </summary>
        [JsonPropertyName("number_of_total_results")]
        public long NumberOfTotalResults { get; set; }

        /// <summary>
        /// Gets or sets the status code.
        /// </summary>
        [JsonPropertyName("status_code")]
        public StatusCode StatusCode { get; set; }

        /// <summary>
        /// Gets or sets the API version.
        /// </summary>
        [JsonPropertyName("version")]
        public string? Version { get; set; }
    }
}
