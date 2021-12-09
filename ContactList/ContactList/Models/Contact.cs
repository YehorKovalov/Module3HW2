namespace ContactList.Models
{
    public class Contact
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string FullName => $"{Name} {Surname}";
    }
}
