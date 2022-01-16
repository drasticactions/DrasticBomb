// <copyright file="VideosFilters.cs" company="Drastic Actions">
// Copyright (c) Drastic Actions. All rights reserved.
// </copyright>

using DrasticBomb.Tools;
using System.Collections.Specialized;

namespace DrasticBomb.Models
{
    public class VideosFilters : BaseFilters
    {
        public int Id { get; set; }

        public int VideoShowId { get; set; }

        public override NameValueCollection ToNameValueCollection()
        {
            var nvc = base.ToNameValueCollection();

            var formatNvc = new NameValueCollection();

            if (this.Id > 0)
            {
                formatNvc.Add("id", this.Id.ToString());
            }

            if (this.VideoShowId > 0)
            {
                formatNvc.Add("video_show", this.VideoShowId.ToString());
            }

            if (formatNvc.HasKeys())
            {
                nvc.Add("filter", formatNvc.ToFilterString());
            }

            return nvc;
        }
    }
}
