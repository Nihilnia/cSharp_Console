using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Song
    {
        public string Name { get; set; }
        public string Artist { get; set; }
        public int SpeedLimit { get; set; }


        // I tried to make more functional thing like: playlist, nextSong, previousSong.. But I couldn't.

        //Constructors
        public Song()
        {
            this.SpeedLimit = 5;
            Console.WriteLine($"{this.Name}object is created and default speedLimit {this.SpeedLimit}\n");
        }

        public Song(string Name, string Artist, int SpeedLimit)
        {
            this.Name = Name;
            this.Artist = Artist;
            this.SpeedLimit = SpeedLimit;
            Console.WriteLine($"\"{this.Name}\" object is created and default speedLimit {this.SpeedLimit}\n");
        }

        public Song(int speedLimit)
        {
            this.SpeedLimit = speedLimit;
            Console.WriteLine($"{this.Name}object is created and default speedLimit {this.SpeedLimit}\n");
        }

        public string ShowTheInfos()
        {
            return string.Format($"\nSong Name: {this.Name}\nArtist: {this.Artist}\n");
        }

        public void Play()
        {
            Console.WriteLine($"\"{this.Name}\" playing..\n\n");
        }

        public void Pause()
        {
            Console.WriteLine($"\"{this.Name}\" Paused..\n\n");
        }

        public void Stop()
        {
            Console.WriteLine($"\"{this.Name}\" Stopped..\n\n");
        }

        public void Speed()
        {
            Console.WriteLine($"\"{this.Name}\" speed is: 1x\n\n");
        }
        public void Speed(int value)
        {
            if (value < SpeedLimit)
            {
                Console.WriteLine($"\"{this.Name}\" speed is: {value}x\n\n");
            }
            else
            {
                Console.WriteLine($"You can't.. Max limit of \"{this.Name}\": {this.SpeedLimit}\n");
            }
            
        }

        public void Menu()
        {
            int key = 0;

            do
            {
                Console.WriteLine("What do you want:\n1)Play the song\n2)Pause it\n3)Stop it\n4)Increase Speed\n5)Speed limit\n6)Exit\n");
                int userChoice = int.Parse(Console.ReadLine());
                switch (userChoice)
                {
                    case 1:
                        this.Play();
                        break;

                    case 2:
                        this.Pause();
                        break;

                    case 3:
                        this.Stop();
                        break;

                    case 4:
                        Console.WriteLine("You wanna increase speed?: y/n");
                        string speedChoice = Console.ReadLine();

                        if (speedChoice == "y")
                        {
                            Console.WriteLine("Speed value: ");
                            int speedValue = Convert.ToInt32(Console.ReadLine());
                            this.Speed(speedValue);
                        }
                        else
                        {
                            this.Speed();
                        }

                        break;

                    case 5:
                        Console.WriteLine($"\"{this.Name}\"'s Speed limit is: {this.SpeedLimit}\n");
                        break;

                    default:
                        Console.WriteLine("Exiting..");
                        System.Threading.Thread.Sleep(1000);
                        key++;
                        break;

                }
            } while (key == 0);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Song song01 = new Song(speedLimit: 12)
            {
                Name = "She Wants Me Dead",
                Artist = "CAZZETTE, AaronChupa, The High",
            };

            Song song02 = new Song("Why So Serious", "Overline & Netsy", SpeedLimit: 8);

            song02.Menu();
        }
    }
}
