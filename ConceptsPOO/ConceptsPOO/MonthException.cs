using System.Runtime.Serialization;

namespace ConceptsPOO
{
    [Serializable]
    internal class MonthException : Exception
    {
        public MonthException()
        {
        }

        public MonthException(string? message) : base(message)
        {
        }

        public MonthException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected MonthException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}