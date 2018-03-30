using System;
using System.Linq;

namespace starterproject
{
    public class WeWorker
    {
        public WeWorker()
        {
        }

        public String Name { get; set; }
        public int Age { get; set; }
        public int HeightFeet { get; set; }
        public int HeightInches { get; set; }
        public string HeightFormatted()
        {
            if (HeightFeet > 0 && HeightInches > 0)
            {
                return $"{HeightFeet}\'-{HeightInches}\"";
            }
            else
            {
                return "Incomplete Height Information";
            }
        }

        public static WeWorker ReadWorker()
        {
            var worker = new WeWorker();
            Console.WriteLine("Input a new WeWorker");
            Console.Write("Name: ");
            var name = Console.ReadLine();
            worker.Name = name;

            Console.Write("Age: ");
            var ageTxt = Console.ReadLine();
            if (int.TryParse(ageTxt, out int age))
            {
                worker.Age = age;
            }
            else
            {
                Console.WriteLine("that doesn't seem like a valid age bro");
            }

            Console.Write("Height (e.g. 6\'1\"): ");
            var heightTxt = Console.ReadLine();

            var splitResults = heightTxt.Split(new char[] {'\"',' ','\''})
                                        .Where(s => !string.IsNullOrEmpty(s));
           

            if(int.TryParse(splitResults.First(),out int feet) 
               && 
               int.TryParse(splitResults.Last(), out int inches)) {
                worker.HeightFeet = feet;
                worker.HeightInches = inches;
            } else {
                Console.WriteLine("are you f**king with me?");
            }


            return worker;

        }


    }
}
