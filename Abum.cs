using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Album
    {
        private string albumName;
        private string artistName;
        private int numberOfTracks;
      

        private void ReadAlbum()
        {   
            Console.WriteLine("What is the name of your favorit music album?");
            albumName = Console.ReadLine();
        }

        private void ReadArtist()
        {
            Console.WriteLine();
            Console.WriteLine("What is the name of Artist or Brand for " + albumName + "?");
            artistName = Console.ReadLine();
        }

        private void ReadTrackNumber()
        {
            Console.WriteLine();
            Console.WriteLine("How many tracks dose " + albumName + " have?");
            numberOfTracks = int.Parse(Console.ReadLine());
        }
        private void ReadSaveAlbum()
        {
            ReadAlbum();
            ReadArtist();
            ReadTrackNumber();
            
        }
        private void DisplayAlbumInfo()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Album Name: " + albumName);
            Console.WriteLine("Artist/Brand: " + artistName);
            Console.WriteLine("Number of Tracks: " + numberOfTracks);
            Console.WriteLine();
            Console.WriteLine("Enjoy listening!");
        }
        public void Start()
        {
            DateTime time = DateTime.Now;
            Console.WriteLine(time.ToString("yyyy-MM-dd h:mm:ss tt"));

            Console.WriteLine("Starting Album Program!");
            ReadSaveAlbum();
            Console.WriteLine();
            DisplayAlbumInfo();
        }

    }
}
