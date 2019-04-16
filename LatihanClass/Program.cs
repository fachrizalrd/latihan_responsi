using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Time objTime = new Time();

            //property value
            objTime.Hello = "Semoga Hari Anda Menyenangkan!";

            Console.WriteLine("{0}", objTime.Hello);
            objTime.DisplayTime();
            Console.ReadKey();
        }  
    }
}
