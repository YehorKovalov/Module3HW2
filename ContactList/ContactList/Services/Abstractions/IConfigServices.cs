using ContactList.Configs;

namespace ContactList.Services.Abstractions
{
    public interface IConfigServices
    {
        Config Config { get; }
        string EnglisAlphabet { get; }
        string RussianAlphabet { get; }
    }
}