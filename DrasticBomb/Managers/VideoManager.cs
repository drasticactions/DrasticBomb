// <copyright file="VideoManager.cs" company="Drastic Actions">
// Copyright (c) Drastic Actions. All rights reserved.
// </copyright>

using DrasticBomb.Models;

namespace DrasticBomb.Managers
{
    public class VideoManager
    {
        private GiantBombClient client;

        private string videosEndpoint = "api/videos/";
        private string videoEndpoint = "api/video/";
        private string videoShowEndpoint = "api/video_shows";

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

        public async Task<VideoShowsResponse> GetVideoShowsAsync(VideosFilters? filters = default, CancellationToken cancellationToken = default)
        {
            if (filters == null)
            {
                filters = new VideosFilters();
            }

            return await this.client.GetAsync<VideoShowsResponse>(videoShowEndpoint, filters.ToNameValueCollection(), cancellationToken);
        }
    }
}
