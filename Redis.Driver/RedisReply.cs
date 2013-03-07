﻿using System;
using Sodao.FastSocket.Client.Response;

namespace Redis.Driver
{
    /// <summary>
    /// redis reply interface.
    /// </summary>
    public interface IRedisReply : IResponse
    {
    }

    #region Error reply
    /// <summary>
    /// error reply
    /// </summary>
    public sealed class ErrorReply : IRedisReply
    {
        #region Public Members
        /// <summary>
        /// error message
        /// </summary>
        public readonly string ErrorMessage;
        #endregion

        #region Constructors
        /// <summary>
        /// new
        /// </summary>
        /// <param name="errorMessage"></param>
        /// <exception cref="ArgumentNullException">errorMessage is null or empty.</exception>
        public ErrorReply(string errorMessage)
        {
            if (string.IsNullOrEmpty(errorMessage))
                throw new ArgumentNullException("errorMessage");

            this.ErrorMessage = errorMessage;
        }
        #endregion
    }
    #endregion

    #region Integer reply
    /// <summary>
    /// Iinteger reply
    /// </summary>
    public sealed class IntegerReply : IRedisReply
    {
        #region Public Members
        /// <summary>
        /// value
        /// </summary>
        public readonly int Value;
        #endregion

        #region Constructors
        /// <summary>
        /// new
        /// </summary>
        /// <param name="value"></param>
        public IntegerReply(int value)
        {
            this.Value = value;
        }
        #endregion
    }
    #endregion

    #region Status reply
    /// <summary>
    /// status reply
    /// </summary>
    public sealed class StatusReply : IRedisReply
    {
        #region Public Members
        /// <summary>
        /// status
        /// </summary>
        public readonly string Status;
        #endregion

        #region Constructors
        /// <summary>
        /// new
        /// </summary>
        /// <param name="status"></param>
        /// <exception cref="ArgumentNullException">status is null or empty.</exception>
        public StatusReply(string status)
        {
            if (string.IsNullOrEmpty(status))
                throw new ArgumentNullException("status");

            this.Status = status;
        }
        #endregion
    }
    #endregion

    #region Bulk replies
    /// <summary>
    /// bulk replies
    /// </summary>
    public sealed class BulkReplies : IRedisReply
    {
        #region Public Members
        /// <summary>
        /// payload
        /// </summary>
        public readonly byte[] Payload;
        #endregion

        #region Constructors
        /// <summary>
        /// new
        /// </summary>
        /// <param name="payload"></param>
        public BulkReplies(byte[] payload)
        {
            this.Payload = payload;
        }
        #endregion
    }
    #endregion

    #region Multi-bulk replies
    /// <summary>
    /// Multi-bulk replies
    /// </summary>
    public sealed class MultiBulkReplies : IRedisReply
    {
    }
    #endregion
}