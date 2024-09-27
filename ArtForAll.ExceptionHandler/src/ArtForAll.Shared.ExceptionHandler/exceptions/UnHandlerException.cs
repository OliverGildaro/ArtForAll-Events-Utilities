namespace ArtForAll.Shared.ExceptionHandler.Exceptions
{
    using System;
    public class UnHandlerException : Exception
    {
        public UnHandlerException(string message)
        {
            ExceptionMessage = message;
        }

        public string ExceptionMessage { get; set; }
    }
}
