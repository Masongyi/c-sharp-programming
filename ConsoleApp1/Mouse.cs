using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Mouse
    {
        private double price;
        private string brand;
        private string model;

        private void ReadBrand()
        {
            Console.WriteLine("What is the brand of your mouse?");
            brand = Console.ReadLine();
        }
        private void ReadModel()
        {
            Console.WriteLine("What is the model of your mouse?");
            model = Console.ReadLine();
        }
        private void ReadPrice()
        {
            Console.WriteLine("What is the price of " + brand +" "+ model + " mouse?");
            price = double.Parse(Console.ReadLine());
        }

        private void ReadSaveMouse()
        {
            ReadBrand();
            Console.WriteLine();
            ReadModel();
            Console.WriteLine();
            ReadPrice();

        }

        private void DisplayMouseInfo()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            string MouseInfo = "Mouse's brand: " + brand + " Model: " + model + " Price: " + price;
            Console.WriteLine(MouseInfo);
        }
        public void Start()
        {
            DateTime time = DateTime.Now;
            Console.WriteLine(time.ToString("yyyy-MM-dd h:mm:ss tt"));
            Console.WriteLine("Welcome to mouse information registration");
            ReadSaveMouse();
            Console.WriteLine();
            DisplayMouseInfo();
        }
    }
}
