using ContactList.Configs;
using ContactList.Services.Abstractions;
using Newtonsoft.Json;

namespace ContactList.Services
{
    public class ConfigServices : IConfigServices
    {
        private const string ConfigPath = "../../../appsettings.json";
        private readonly IFileServices _fileServices;
        private Config _config;
        public ConfigServices(IFileServices fileServices)
        {
            _fileServices = fileServices;
            Init();
        }

        public Config Config => _config;
        public string EnglisAlphabet => _config.AlphabetConfig.English;
        public string RussianAlphabet => _config.AlphabetConfig.Russian;

        private void Init()
        {
            var configFile = _fileServices.ReadTextOrNull(ConfigPath);
            _config = JsonConvert.DeserializeObject<Config>(configFile);
        }
    }
}
