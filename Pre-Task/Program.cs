using System;

namespace Pre_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            GCD_Program gcd_program = new GCD_Program();
            
            int x1 = 12;
            int x2 = 30;
            double leadTime;

            gcd_program.Euclid(1, 2,out leadTime);
            gcd_program.Stein(1, 2, out leadTime);
            Console.WriteLine("GCD (Euclid) of {0} and {1}: {2}. Time: {3} mcrsec", x1,x2, gcd_program.Euclid(x1,x2, out leadTime), leadTime);
            Console.WriteLine("GCD (Euclid) of {0} and {1}: {2}. Time: {3} mcrsec", x1, x2, gcd_program.Stein(x1, x2, out leadTime), leadTime);

            gcd_program.Info();
            Console.ReadKey();
        }
    }
}
