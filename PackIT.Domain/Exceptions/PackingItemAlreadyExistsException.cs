using PackIT.Shared.Abstractions.Exceptions;

namespace PackIT.Domain.Exceptions
{
    public class PackingItemAlreadyExistsException : PackITException
    {
        public PackingItemAlreadyExistsException(string listName, string listItem) 
            : base($"Packing list: {listItem} already defined item {listItem}")
        {
            ListName = listName;
            ListItem = listItem;
        }

        public string ListName { get; }
        public string ListItem { get; }
    }
}
