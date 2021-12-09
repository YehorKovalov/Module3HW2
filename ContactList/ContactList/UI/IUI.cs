using System.Collections.Generic;
using ContactList.Models;

namespace ContactList.UI
{
    public interface IUI
    {
        void DisplayContacts(List<Contact> contacts);
        void DisplayMessage(string message);
    }
}
