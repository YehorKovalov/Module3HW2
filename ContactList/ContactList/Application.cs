using System.Linq;
using ContactList.Models;
using ContactList.Services.Abstractions;
using ContactList.UI;

namespace ContactList
{
    public class Application
    {
        private readonly IUI _uI;
        private readonly IContactListManager _contactListManager;

        public Application(
            IUI uI,
            IContactListManager contactListManager)
        {
            _uI = uI;
            _contactListManager = contactListManager;
        }

        public void Run()
        {
            _contactListManager.Add(new Contact() { Surname = "Kovalov", Name = "Yehor" });
            _contactListManager.Add(new Contact() { Surname = "Ковалёв", Name = "Егор" });
            _contactListManager.Add(new Contact() { Surname = "Zubenko", Name = "Mikhail" });
            _contactListManager.Add(new Contact() { Surname = "Zarchenko", Name = "Victor" });
            _contactListManager.Add(new Contact() { Surname = "Shultc", Name = "Andrey" });
            _contactListManager.Add(new Contact() { Surname = "Moscvina", Name = "Valeriya" });
            _contactListManager.Add(new Contact() { Surname = "~", Name = "/31123" });
            _contactListManager.Add(new Contact() { Surname = "33333", Name = "3333333" });
            _contactListManager.Add(new Contact() { Surname = "11111", Name = "11111" });
            _contactListManager.Add(new Contact() { Surname = "Kovalov", Name = "22222" });
            foreach (var section in _contactListManager.GroupedContactList)
            {
                if (section.Value.Any())
                {
                    _uI.DisplayMessage($"{section.Key}");
                    _uI.DisplayContacts(section.Value);
                }
            }
        }
    }
}
