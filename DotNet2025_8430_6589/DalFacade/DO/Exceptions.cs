

namespace DO;

internal class Exceptions : Exception
{
    [Serializable]
    public class DalIdNotExist : Exception
    {
        public DalIdNotExist(string? message) : base(message) { }

        public DalIdNotExist(string? message, Exception? innerException) : base(message, innerException) { }

    }
    [Serializable]

    public class DalIdAlreadyExist : Exception
    {
        public DalIdAlreadyExist(string? message) : base(message) { }

        public DalIdAlreadyExist(string? message, Exception? innerException) : base(message, innerException) { }

    }


}