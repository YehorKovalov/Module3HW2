using System.Collections.Generic;
using ContactList.Helpers;
using ContactList.Models;
using ContactList.Services.Abstractions;

namespace ContactList.Services
{
    public class ContactListManager : IContactListManager
    {
        private const string NumbersAsKeySymbols = "0123456789";
        private const char SymbolForOtherContancts = '#';
        private readonly IAlphabetServices _alphabetManager;
        private List<char> _keySymbols;
        private Dictionary<char, List<Contact>> _contactList;

        public ContactListManager(IAlphabetServices alphabetManager)
        {
            _alphabetManager = alphabetManager;
            Init();
        }

        public Dictionary<char, List<Contact>> GroupedContactList => _contactList;

        public bool Add(Contact contact)
        {
            if (contact == null)
            {
                return false;
            }

            var contactFirstLetter = char.ToUpper(contact.FullName[0]);
            if (!_contactList.ContainsKey(contactFirstLetter))
            {
                _contactList[SymbolForOtherContancts].Add(contact);
            }
            else
            {
                _contactList[contactFirstLetter].Add(contact);
                _contactList[contactFirstLetter].Sort(new ContactFullNameComparer());
            }

            return true;
        }

        private void Init()
        {
            FormKeySymbols();
            FormContactList();
        }

        private void FormKeySymbols()
        {
            var alphabet = _alphabetManager.GetCurrentCultureAlphabet();
            _keySymbols = new List<char>();
            foreach (var symbol in alphabet)
            {
                _keySymbols.Add(symbol);
            }

            foreach (var number in NumbersAsKeySymbols)
            {
                _keySymbols.Add(number);
            }

            _keySymbols.Add(SymbolForOtherContancts);
        }

        private void FormContactList()
        {
            _contactList = new Dictionary<char, List<Contact>>();
            foreach (var symbol in _keySymbols)
            {
                _contactList.Add(symbol, new List<Contact>());
            }
        }
    }
}
