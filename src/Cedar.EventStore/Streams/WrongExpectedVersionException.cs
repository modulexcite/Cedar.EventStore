﻿namespace Cedar.EventStore.Streams
{
    using System;

    public class WrongExpectedVersionException : Exception
    {
        public WrongExpectedVersionException(string message, Exception inner = null)
            : base(message, inner)
        {}
    }
}