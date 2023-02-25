// See https://aka.ms/new-console-template for more information
using System;

namespace MyApplication
{
    class Program
    {
        static void MyMethod() // static means this is a method of class program
        {
            Console.WriteLine("I just got executed!");
        }

        static int PlusMethod(int x, int y)
        {
            return x + y;
        }

        static double PlusMethod(double x, double y)
        {
            return x + y;
        }

        interface Phone // POLYPHISM;
        {
            void run()
            {
                Console.WriteLine("Phone need a operating system");
            }
        }

        class Samsung : Phone
        {
            public void run()
            {
                Console.WriteLine("Samsung run with Android");

            }
        }

        class iPhone : Phone
        {
            public void run()
            {
                Console.WriteLine("Iphone run with iOs");
            }
        }
        static void Main(string[] args)
        {
            int myNum1 = PlusMethod(8, 5); // overload method
            double myNum2 = PlusMethod(4.3, 6.26);
            MyMethod();

            Phone mySamsung = new Samsung();
            mySamsung.run();
            Phone myIphone = new iPhone();
            myIphone.run();
        }
    }
}