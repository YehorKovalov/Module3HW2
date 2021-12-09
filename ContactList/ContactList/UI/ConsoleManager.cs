using System;
using System.Collections.Generic;
using ContactList.Models;

namespace ContactList.UI
{
    public class ConsoleManager : IUI
    {
        public void DisplayContacts(List<Contact> contacts)
        {
            foreach (var contact in contacts)
            {
                Console.WriteLine($"{contact.FullName}");
            }
        }

        public void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
