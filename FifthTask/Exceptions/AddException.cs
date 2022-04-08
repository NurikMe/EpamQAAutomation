using System;

namespace FifthTask.Exceptions
{
    public class AddException : Exception
    {
        public AddException(string message) : base(message) { }
    }
}