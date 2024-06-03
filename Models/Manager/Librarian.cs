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
            if (!File.Exists(path))
            {
                File.Create(path);
                var library = new Library();
                library.Stars.AddRange(FillWithTestData(20));

                return library;
            }

            var jsonString = File.ReadAllText(path);
            return JsonSerializer.Deserialize<Library>(jsonString);
        }


        private List<Star> FillWithTestData(int n)
        {
            var stars = new List<Star>();

            for (int i = 0; i < n; i++)
            {
                stars.Add(new Star
                {
                    Name = $"Star{i}",
                    Constellation = $"Constellation{i / 3}",
                    StellarMagnitude = i,
                    Distance = i,
                    CoordinateX = i / 3,
                    CoordinateY = i % 5,
                    StartHour = 20 + i % 4,
                    StartMinute = i % 60,
                    EndHour = i % 5,
                    EndMinute = i % 60
                });
            }

            return stars;
        }
    }
}
