using System.Collections.Generic;
using ContactList.Models;

namespace ContactList.Helpers
{
    public class ContactFullNameComparer : IComparer<Contact>
    {
        public int Compare(Contact x, Contact y)
        {
            return string.Compare(x?.FullName, y?.FullName);
        }
    }
}
