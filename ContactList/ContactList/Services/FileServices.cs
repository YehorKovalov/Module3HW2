using System.IO;
using ContactList.Services.Abstractions;

namespace ContactList.Services
{
    public class FileServices : IFileServices
    {
        public string ReadTextOrNull(string path)
        {
            if (string.IsNullOrWhiteSpace(path))
            {
                return null;
            }

            return File.ReadAllText(path);
        }
    }
}
