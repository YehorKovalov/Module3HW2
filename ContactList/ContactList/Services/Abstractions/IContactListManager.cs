using System.Collections.Generic;
using ContactList.Models;

namespace ContactList.Services.Abstractions
{
    public interface IContactListManager
    {
        Dictionary<char, List<Contact>> GroupedContactList { get; }

        bool Add(Contact contact);
    }
}