using System;
using System.Collections.Generic;
using System.Linq;


namespace BO
{

    [Serializable]
    public class BLIdNotExist : Exception
    {
        public BLIdNotExist(string? message) : base(message) { }

        public BLIdNotExist(string? message, Exception? innerException) : base(message, innerException) { }

    }
    [Serializable]

    public class BLIdAlreadyExist : Exception
    {
        public BLIdAlreadyExist(string? message) : base(message) { }

        public BLIdAlreadyExist(string? message, Exception? innerException) : base(message, innerException) { }

    }


    //[Serializable]
    //public class BlProductDoesNotExistException : Exception
    //{
    //    public BlProductDoesNotExistException(int id) : base($"Product with ID {id} was not found.") { }
    //    public BlProductDoesNotExistException(string message, Exception inner) : base(message, inner) { }
    //}

    //[Serializable]
    //public class BlProductAlreadyExistsException : Exception
    //{
    //    public BlProductAlreadyExistsException(int id) : base($"Product with ID {id} already exists.") { }
    //    public BlProductAlreadyExistsException(string message, Exception inner) : base(message, inner) { }
    //}
   
    //[Serializable]
    //public class BlSaleDoesNotExistException : Exception
    //{
    //    public BlSaleDoesNotExistException(int id) : base($"Sale with ID {id} was not found.") { }
    //    public BlSaleDoesNotExistException(string message, Exception inner) : base(message, inner) { }
    //}

    //[Serializable]
    //public class BlSaleAlreadyExistsException : Exception
    //{
    //    public BlSaleAlreadyExistsException(int id) : base($"Sale with ID {id} already exists.") { }
    //    public BlSaleAlreadyExistsException(string message, Exception inner) : base(message, inner) { }
    //}

    [Serializable]
    public class BlInvalidInputException : Exception
    {
        public BlInvalidInputException(string message) : base(message) { }
    }

    [Serializable]
    public class BlOutOfStockException : Exception
    {
        public BlOutOfStockException(int id, int requested)
            : base($"Not enough stock for product {id}. Requested: {requested}") { }
    }


}
    
