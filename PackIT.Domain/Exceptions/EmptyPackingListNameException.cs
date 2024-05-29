using PackIT.Shared.Abstractions.Exceptions;

namespace PackIT.Domain.Exceptions
{
    public class EmptyPackingListNameException : PackITException
    {
        public EmptyPackingListNameException() : base("Packing list name cannot be empty!")
        {
        }
    }
}
