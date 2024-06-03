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
        }
        public List<Star> Stars { get; set; }

        public List <Star> Search(string name, string constallation, string stellarMagnitude,
            string distance, string coordinateX, string coordinateY, string coordinateH, 
            string coordinateM, string coordinateS, int hour, int minute)
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
                    && s.CoordinateH.ToString().Contains(coordinateH)
                    && s.CoordinateM.ToString().Contains(coordinateM)
                    && s.CoordinateS.ToString().Contains(coordinateS)
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
