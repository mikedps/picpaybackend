﻿

namespace PicPayBackEnd.Domain.Exceptions
{
    public class TransactionException : Exception
    {
        public TransactionException(string? message) : base(message)
        {
        }
    }
}
