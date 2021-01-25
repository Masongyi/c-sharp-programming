using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            Console.Title = "Pet Owner";
            Console.ForegroundColor = ConsoleColor.Blue;
            Pet petObj = new Pet();
            petObj.Start();
            Console.WriteLine("Press Enter to start a new object!");
            Console.ReadLine();
            
            Console.Title = "Album";
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Clear();
            Album albumObj = new Album();
            albumObj.Start();
            Console.WriteLine("Press Enter to start next object!");
            Console.ReadLine();
            
            Console.Title = "Mouse";
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Mouse mouseObj = new Mouse();
            mouseObj.Start();
            Console.WriteLine("Press Enter to exit!");
            Console.ReadLine();


        }
    }

   

 
}
