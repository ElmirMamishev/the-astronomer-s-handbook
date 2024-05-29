using System.Text.Json;
using static System.Reflection.Metadata.BlobBuilder;

namespace StarBook.Models
{
    public class Library
    {
        public Library() 
        {
            Stars = new List<Star> ();
            FillWithTestData(10);
        }
        public List<Star> Stars { get; set; }
        void FillWithTestData(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Stars.Add(new Star
                {
                    Name = $"Star{i}",
                    Constellation = $"Constellation{i/3}",
                    StellarMagnitude = i,
                    Distance = i,
                    CoordinateX = i,
                    CoordinateY = i,
                    StartTime = new TimeOnly(20+i%4, i%60),
                    EndTime = new TimeOnly(i%5, i%60)
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
                TimeOnly time = new TimeOnly(hour, minute);

                if (s.Name.Contains(name) && 
                    s.Constellation.Contains(constallation) &&
                    s.StellarMagnitude.ToString().Contains(stellarMagnitude)&&
                    s.Distance.ToString().Contains(distance) &&
                    s.CoordinateX.ToString().Contains(coordinateX) 
                    && s.CoordinateY.ToString().Contains(coordinateY)
                    && (s.StartTime < s.EndTime && time >= s.StartTime 
                    && time <= s.EndTime || s.StartTime>= s.EndTime
                    && time <= s.EndTime))
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
