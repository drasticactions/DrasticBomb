// <copyright file="GiantBombClientException.cs" company="Drastic Actions">
// Copyright (c) Drastic Actions. All rights reserved.
// </copyright>

namespace DrasticBomb.Exceptions
{
    public class GiantBombClientException : Exception
    {
        public GiantBombClientException()
        {
        }

        public GiantBombClientException(string? message)
            : base(message)
        {
        }
    }
}
