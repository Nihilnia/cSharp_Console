using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        class Song
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public string Artist { get; set; }
            public double Duration { get; set; }
        }

        static void Main(string[] args)
        {
            //Classes

            Song song01 = new Song() {
                ID = 01,
                Name = "Moskau",
                Artist = "Rammstein",
                Duration = 4.16
            };


            Song song02 = new Song();
            song02.ID = 02;
            song02.Name = "Los";
            song02.Artist = "Rammstein";
            song02.Duration = 5.11;

            Song[] AllSongs = new Song[2];
            AllSongs[0] = song01;
            AllSongs[1] = song02;

            foreach (var item in AllSongs)
            {
                Console.WriteLine($"ID: {item.ID}\nName: {item.Name}\nArtist: {item.Artist}\nDuration: {item.Duration}\n\n");
            }

            Console.ReadLine();
        }
    }
}
