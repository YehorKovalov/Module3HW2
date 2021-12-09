using System.Globalization;
using ContactList.Services.Abstractions;

namespace ContactList.Services
{
    public class AlphabetServices : IAlphabetServices
    {
        private readonly IConfigServices _config;

        public AlphabetServices(IConfigServices config)
        {
            _config = config;
        }

        public string GetCurrentCultureAlphabet()
        {
            var cultureInfo = CultureInfo.CurrentCulture.Name;
            var alphabet = string.Empty;
            switch (cultureInfo)
            {
                case "ru-RU":
                    alphabet = _config.RussianAlphabet;
                    break;
                default:
                    alphabet = _config.EnglisAlphabet;
                    break;
            }

            return alphabet;
        }
    }
}
