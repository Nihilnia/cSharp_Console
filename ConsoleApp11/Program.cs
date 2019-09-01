using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    public class Song
    {
        public int SongID { get; set; }
        public string SongName { get; set; }
        public string Artist { get; set; }
        public float Duration { get; set; }
    }

    static class SongDB
    {
        static List<Song> Songs;
        static SongDB()
        {
            Songs = new List<Song>() {
                new Song(){SongID = 1, SongName = "Fearless OST", Artist = "Jay Chou", Duration = 4.36f},
                new Song(){SongID = 2, SongName = "Garage Palace", Artist = "Gorillaz", Duration = 3.44f}
            };
        }

        public static List<Song> GetSongs()
        {
            return Songs;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Song> AllSongs = SongDB.GetSongs();

            foreach (var item in AllSongs)
            {
                Console.WriteLine("SongID: {0}, Song Name: {1}, Artist: {2}, Duration: {3}", item.SongID, item.SongName, item.Artist, item.Duration);
            }

            Console.ReadLine();
        }
    }
}
