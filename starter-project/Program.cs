using System;
using System.Collections.Generic;
using System.IO;
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


            var workers = GenerateWeWorkers();

            workers.Add(WeWorker.ReadWorker());
            var json = JsonConvert.SerializeObject(workers);

            File.WriteAllText("workers.json", json);

            Console.WriteLine(json);

            Console.WriteLine($"{andrew.Name} is {andrew.Age} years old");
            Console.WriteLine($"{andrew.Name} is {andrew.HeightFormatted()} tall");
        }

        public static List<WeWorker> GenerateWeWorkers()
        {
            var workers = new List<WeWorker>();
            workers.Add(
                new WeWorker
                {
                    Name = "Andrew",
                    Age = 29,
                    HeightFeet = 5,
                    HeightInches = 6
                });
            workers.Add(
                new WeWorker
                {
                    Name = "Bob",
                    Age = 27,
                    HeightFeet = 5,
                    HeightInches = 10
                });
            return workers;
        }
    }
}
