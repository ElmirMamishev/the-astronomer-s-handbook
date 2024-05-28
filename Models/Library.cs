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
            Stars.Clear();
            for (int i = 0; i < n; i++)
            {
                Stars.Add(new Star
                {
                    Name = $"Star{i}",
                    Constellation = $"Constellation{i}",
                    StellarMagnitude = i,
                    Distance = i,
                    Coordinate = $"{i}"
                });
            }
        }

        public List <Star> Search(string name, string constallation, string stellarMagnitude,
            string distance, string coordinate)
        {
            var result = new List<Star>();
            foreach (var s in Stars) 
            {
                if(s.Name.Contains(name) && 
                    s.Constellation.Contains(constallation) &&
                    s.StellarMagnitude.ToString().Contains(stellarMagnitude)&&
                    s.Distance.ToString().Contains(distance) &&
                    s.Coordinate.Contains(coordinate))
                {
                    result.Add(s);
                }
            }
            return result;
        }
    }
}
