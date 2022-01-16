// <copyright file="ErrorClientTests.cs" company="Drastic Actions">
// Copyright (c) Drastic Actions. All rights reserved.
// </copyright>

using DrasticBomb.Managers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace DrasticBomb.Tests
{
    [TestClass]
    public class ErrorClientTests
    {
        private GiantBombClient client;
        private VideoManager manager;

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorClientTests"/> class.
        /// </summary>
        public ErrorClientTests()
        {
            // Enter an invalid token.
            this.client = new GiantBombClient("test");
            this.manager = new VideoManager(this.client);
        }

        [TestMethod]
        public async Task CanHandleBadAuthToken()
        {
            var response = await this.manager.GetVideosAsync();
            Assert.IsNotNull(response);
            Assert.IsTrue(response.StatusCode == Models.StatusCode.InvalidApiKey);
        }
    }
}
