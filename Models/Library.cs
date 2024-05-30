using System.Diagnostics;
using System.Linq;
using System.Text.Json;
using static System.Reflection.Metadata.BlobBuilder;

namespace StarBook.Models
{
    public class Library
    {
        public Library() 
        {
            Stars = new List<Star> ();
            FillWithTestData(1000);
        }
        public List<Star> Stars { get; set; }
        void FillWithTestData(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Stars.Add(new Star
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
        }

        public List <Star> Search(string name, string constallation, string stellarMagnitude,
            string distance, string coordinateX, string coordinateY,
            int hour, int minute)
        {
            var result = new List<Star>();
            foreach (var s in Stars)
            {
                var time = new TimeOnly(hour, minute);
                var startTime = new TimeOnly(s.StartHour, s.StartMinute);
                var endTime = new TimeOnly(s.EndHour, s.EndMinute);

                if ((s.Name == null|| s.Name.Contains(name))
                    && (s.Constellation == null || s.Constellation.Contains(constallation))
                    && s.StellarMagnitude.ToString().Contains(stellarMagnitude)
                    && s.Distance.ToString().Contains(distance)
                    && s.CoordinateX.ToString().Contains(coordinateX)
                    && s.CoordinateY.ToString().Contains(coordinateY)
                    && (startTime < endTime && time >= startTime
                    && time <= endTime || startTime >= endTime
                    && time <= endTime))
                {

                    result.Add(s);

                }

            }
            return result;
        }

        public void AddStar(Star newStar)
        {
            if (newStar != null)
            {
                Stars.Add(newStar);
            }
        }

    }
}
