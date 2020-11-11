using System;
using System.IO;
namespace lab7
{
    public class ExceptionClass : ApplicationException
    {
        public ExceptionClass(string message) : base(message)
        {

        }
    }

    public class InvalidNumberException : ArithmeticException
    {
        public int value {get; }
        public InvalidNumberException(string message, int val) : base(message)
        {
            value = val;
        }
    }

    public class StreamException : System.IO.IOException
    {
        public StreamException(string message) : base(message)
        {

        }
    }

    public class FileCannotBeFoundException : StreamException
    {
        public FileCannotBeFoundException(string message) : base(message)
        {

        }
    }

    public class InvalidSymbolException : ApplicationException
    {
        public InvalidSymbolException(string message) : base(message)
        {

        }
    }
}
