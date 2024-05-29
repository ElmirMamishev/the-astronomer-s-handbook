namespace StarBook.Models
{
    public class Star
    {
        public string Name { get; set; }
        public string Constellation { get; set; }
        public int StellarMagnitude { get; set; }
        public int Distance { get; set; }
        public int CoordinateX { get; set; }
        public int CoordinateY { get; set; }
        public string ViewCoordinate { get; set; }
        public TimeOnly StartTime { get; set; }
        public TimeOnly EndTime { get; set; }
    }
}
