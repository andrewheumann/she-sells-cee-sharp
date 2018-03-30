using System;
using Newtonsoft.Json;

namespace starterproject
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var andrew = new WeWorker()
            {
                Name = "Andrew",
                Age = 29,
                HeightFeet = 5,
                HeightInches = 6
            };


            Console.WriteLine($"{andrew.Name} is {andrew.Age} years old");
            Console.WriteLine($"{andrew.Name} is {andrew.HeightFormatted()} tall");
        }
    }
}
