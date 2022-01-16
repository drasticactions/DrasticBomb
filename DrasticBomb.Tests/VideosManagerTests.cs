// <copyright file="VideosManagerTests.cs" company="Drastic Actions">
// Copyright (c) Drastic Actions. All rights reserved.
// </copyright>

using DrasticBomb.Managers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace DrasticBomb.Tests
{
    [TestClass]
    public class VideosManagerTests
    {
        private GiantBombClient client;
        private VideoManager manager;

        /// <summary>
        /// Initializes a new instance of the <see cref="VideosManagerTests"/> class.
        /// </summary>
        public VideosManagerTests()
        {
            this.client = new GiantBombClient(TestApiTokens.API);
            this.manager = new VideoManager(this.client);
        }

        [TestMethod]
        public async Task CanGetBasicVideoResponse()
        {
            var response = await this.manager.GetVideosAsync();
            Assert.IsNotNull(response);
            Assert.IsTrue(response.StatusCode == Models.StatusCode.OK);
        }

        [TestMethod]
        public async Task CanGetBasicVideoShowsResponse()
        {
            var response = await this.manager.GetVideoShowsAsync();
            Assert.IsNotNull(response);
            Assert.IsTrue(response.StatusCode == Models.StatusCode.OK);
        }
    }
}
