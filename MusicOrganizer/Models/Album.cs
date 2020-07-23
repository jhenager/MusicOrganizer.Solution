using System.Collections.Generic;

namespace MusicOrganizer.Models
{
    public class Album
    {
        public string Artist { get; set; }
        public string Year { get; set; }
        public int Id { get; }
        private static List<Album> _instances = new List<Album> { };

        public Album(string artist, string year)
        {
            Artist = artist;
            Year = year;
            _instances.Add(this);
            Id = _instances.Count;
        }

        public static List<Album> GetAll()
        {
            return _instances;
        }

        public static void ClearAll()
        {
            _instances.Clear();
        }

        public static Album Find(int searchId)
        {
            return _instances[searchId - 1];
        }
    }
}