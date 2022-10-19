using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        //Trial = 111;
        //Pro = 222;
        static void Main(string[] args)
        {
            Console.WriteLine("Введiть ключ: ");
            int license = Convert.ToInt32(Console.ReadLine());

            //create document worker
            var User = new ApplicationLicense();
            if(license == 111)
            {
                User.AllowTrial();
            }
            else if( license == 222)
            {
                User.AllowPro();
            }
            else
            {
                User.AllowCommon();
            }
        }
    }

    public class ApplicationLicense
    {
        public void AllowCommon()
        {
            Console.WriteLine("Безкоштовна версiя");
        }

        public void AllowTrial()
        {
            Console.WriteLine("Триальний режим");
        }

        public void AllowPro()
        {
            Console.WriteLine("Платна версiя");
        }
    }

    
}
