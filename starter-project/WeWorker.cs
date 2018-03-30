using System;
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



    }
}
