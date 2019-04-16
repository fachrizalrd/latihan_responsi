using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanClass
{
    public class Time
    {
        //field

        private int year;
        private int month;
        private int date;
        private int second;
        private int hour;
        private int minute;

        //constructor
        public Time()
        {
            year = 2025;
            date = 23;
            month = 11;
            hour = 2;
            minute = 25;
            second = 33;
        }

        //methods
        public void DisplayTime()
        {
            Console.WriteLine("Year : {0}", year);
            Console.WriteLine("Date : {0}", date);
            Console.WriteLine("Month : {0}", month);
            Console.WriteLine("Hour : {0}", hour);
            Console.WriteLine("Minute : {0}", minute);
            Console.WriteLine("Second : {0}", second);
        }

        //property
        public int Year { get; set; }
        public int Month { get; set; }
        public int Date { get; set; }
        public int Hour { get; set; }
        public int Minute { get; set; }
        public int Second { get; set; } 
        public string Hello { get; set; }
       
    }
}
    
