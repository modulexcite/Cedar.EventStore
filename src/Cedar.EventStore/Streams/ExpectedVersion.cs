﻿namespace Cedar.EventStore.Streams
{
    /// <summary>
    /// Constants used for expected version control
    /// 
    /// </summary>
    /// 
    /// <remarks>
    /// The use of expected version can be a bit tricky especially when discussing idempotency assurances given by the event store.
    /// 
    ///             There are four possible values that can be used for the passing of an expected version.
    /// 
    ///             ExpectedVersion.Any (-2) says that you should not conflict with anything.
    ///             ExpectedVersion.NoStream (-1) says that the stream should not exist when doing your write.
    ///             ExpectedVersion.EmptyStream (0) says the stream should exist but be empty when doing the write.
    /// 
    ///             Any other value states that the last event written to the stream should have a sequence number matching your
    ///             expected value.
    /// 
    ///             The Event Store will assure idempotency for all operations using any value in ExpectedVersion except for
    ///             ExpectedVersion.Any. When using ExpectedVersion.Any the Event Store will do its best to assure idempotency but
    ///             will not guarantee idempotency.
    /// 
    /// </remarks>
    public static class ExpectedVersion
    {
        /// <summary>
        /// This write should not conflict with anything and should always succeed.
        /// 
        /// </summary>
        public const int Any = -2;

        /// <summary>
        /// The stream being written to should not yet exist. If it does exist treat that as a concurrency problem.
        /// 
        /// </summary>
        public const int NoStream = -1;
    }
}
