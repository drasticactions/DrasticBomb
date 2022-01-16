// <copyright file="VideoManager.cs" company="Drastic Actions">
// Copyright (c) Drastic Actions. All rights reserved.
// </copyright>

using DrasticBomb.Models;

namespace DrasticBomb.Managers
{
    public class VideoManager
    {
        private GiantBombClient client;

        private string videosEndpoint = "videos/";
        private string videoEndpoint = "video/";

        public VideoManager(GiantBombClient client)
        {
            this.client = client;
        }

        public async Task<VideosResponse> GetVideosAsync(VideosFilters? filters = default, CancellationToken cancellationToken = default)
        {
            if (filters == null)
            {
                filters = new VideosFilters();
            }

            return await this.client.GetAsync<VideosResponse>(videosEndpoint, filters.ToNameValueCollection(), cancellationToken);
        }
    }
}
