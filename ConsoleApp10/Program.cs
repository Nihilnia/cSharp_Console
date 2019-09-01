using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    //Static Classes and Generic List

    public class Song
    {
        public int SongID { get; set; }
        public string SongName { get; set; }
        public string Artist { get; set; }
        public float Duration { get; set; }
    }

    static class SongDatabase
    {
        static List<Song> Songs;
        static SongDatabase()
        {
            Songs = new List<Song>() {

                new Song(){SongID = 1, SongName = "Can't Sleep", Artist = "K.Flay", Duration = 4.11f},
                new Song(){SongID = 2, SongName = "Moskau", Artist = "Ramsstein", Duration = 5.33f},
                new Song(){SongID = 3, SongName = "Gimme tha Power", Artist = "Molotov", Duration = 3.29f},
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
            List<Song> tumSarkilar = SongDatabase.GetSongs();

            foreach (var item in tumSarkilar)
            {
                Console.WriteLine("SongID: {0}, Song Name: {1}, Artist: {2}, Duration: {3}", item.SongID, item.SongName, item.Artist, item.Duration);
            }

            

            Console.ReadLine();
        }
    }
}
