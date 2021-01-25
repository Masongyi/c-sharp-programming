using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Pet
    {
        private string name;
        private int age;
        private bool isFemale;

        private void ReadName()
        {
            // read pet name
            Console.WriteLine("What is the name of your pet?");
            name = Console.ReadLine();
        }

        private void ReadAge ()
        {
            // read pet age 
            Console.WriteLine("What is " + name + "'s age");
            age = int.Parse(Console.ReadLine());
        }

        private void ReadGender()
        {
            // read y/n to gender question 
            Console.WriteLine("Is " + name + "a female ? please enter y / n");
            string respond = Console.ReadLine().Trim();

            if ((respond =="y") || (respond =="Y"))
                isFemale = true;
            else
                isFemale = false;
        }


        private void ReadAndSavePetData()
        {

            ReadName();
            Console.WriteLine();
            ReadAge();
            Console.WriteLine();
            ReadGender();

        }
        private void DisplayPetInfo()

        {
            string Genderinfo = isFemale ? name  + " is a good girl" :name  + "is a good boy";

            string Petinfo = "Pet's name: " + name + ", Age: " + age;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(Petinfo);
            Console.WriteLine(Genderinfo);
        }
        public void Start()
        {
            DateTime time = DateTime.Now;
            Console.WriteLine(time.ToString("yyyy-MM-dd h:mm:ss tt"));
            Console.WriteLine("Welcome to Pet Owner Application");

            ReadAndSavePetData();
            Console.WriteLine();
            DisplayPetInfo();

        }


    }
}
