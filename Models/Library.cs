using static System.Reflection.Metadata.BlobBuilder;

namespace StarBook.Models
{
    public class Library
    {
        public Library() 
        {

        }
        
        public List<Star> Stars { get; set; }

        void FillWithTestData(int n)
        {
            Stars.Clear();
            for (int i = 0; i < n; i++)
            {
                Stars.Add(new Star
                {
                    Name = $"Name{i}",
                    Constellation = $"Constellation{i}",
                    StellarMagnitude = $"Stellar magnitude{i}",
                    Distance = $"Distance{i}",
                    Coordinate = $"Coordinate{i}"
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
                    s.StellarMagnitude.Contains(stellarMagnitude)&&
                    s.Distance.Contains(distance) &&
                    s.Coordinate.Contains(coordinate))
                {
                    result.Add(s);
                }
            }
            return result;
        }
    }
}
