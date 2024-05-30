﻿namespace StarBook.Models
{
    public class Star
    {
        public string? Name { get; set; }
        public string? Constellation { get; set; }
        public float StellarMagnitude { get; set; }
        public double Distance { get; set; }
        public int CoordinateX { get; set; }
        public int CoordinateY { get; set; }
        public int StartMinute { get; set; }
        public int StartHour { get; set; }
        public int EndMinute { get; set; }
        public int EndHour { get; set; }
    }
}
