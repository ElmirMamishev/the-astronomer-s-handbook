namespace StarBook.Models
{
    public class Directory
    {
        public Star[] Stars { get; set; }
        public Directory(int n) 
        {
            Stars = new Star[n];
            foreach (var star in Stars) 
            {
                Console.WriteLine(star.StarName);
            }
        }
    }
}
