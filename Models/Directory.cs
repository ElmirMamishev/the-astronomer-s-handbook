namespace StarBook.Models
{
    public class Directory
    {
        public Star[] Stars { get; set; }
        public Directory(int n)
        {
            Stars = new Star[n];
            for (int i = 0; i < 10; i++)
            {
                var S = new Star();
                S.StarName = $"Star{i}";
                S.StarConstellation = $"Constellation{i}";
                S.StarDistance = i;
                Console.WriteLine(S);
            }
        }
    }
}
