using StarBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace StarBook.Manager
{
    public class Librarian
    {
        public void SaveData(Library library, string path)
        {
            var jsonString = JsonSerializer.Serialize(library);
            File.WriteAllText(path, jsonString);
        }

        public Library LoadData(string path)
        {
            var jsonString = File.ReadAllText(path);
            return JsonSerializer.Deserialize<Library>(jsonString);
        }
    }
}
