using PackIT.Shared.Abstractions.Exceptions;
using System.Runtime.Serialization;

namespace PackIT.Domain.Exceptions
{
    [Serializable]
    internal class EmptyPackingListItemNameException : PackITException
    {
        public EmptyPackingListItemNameException() : base("Packing item cannot be empty!") 
        {
        }

    }
}