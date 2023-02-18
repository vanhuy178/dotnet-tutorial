// See https://aka.ms/new-console-template for more information
using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("I am Learning C#");
            Console.WriteLine("It is awesome!");

            Console.WriteLine("Number type");
            Console.WriteLine(3 + 3);

            // Write method
            Console.WriteLine("I will be the point");

            // COMMENT
            /* 
            The code below will print the words Hello World
            to the screen, and it is amazing
            
            */

            // C# VARIBALE
            /*
                int: interger type
                double: decimal number
                char: a character in single quote 'a', 'b'
                string: a letter such like "hello", "Hi"

            */

            string myName = "Nguyen Van Huy";
            int myAge = 21;
            Console.WriteLine("My name is " + myName + " " + myAge + " years old");

            /*
            int myNum = 5;
            double myDoubleNum = 5.99D;
            char myLetter = 'D';
            bool myBool = true;
            string myText = "Hello";                     
            */

            //C# Constants
            const double Pi = 3.14;

            // DISPLAY VARIABLE

            //  + CAN BE CONCAT TRING OR USING PLUS WITH INTEGER
            string firstName = "Huy";
            string lastName = "Nguyen";
            string fullName = firstName + " " + lastName;
            Console.WriteLine(fullName);

            int x, y, z, total;
            x = 10;
            y = 20;
            z = 30;

            total = x + y + z;
            Console.WriteLine(total);

            // IDENTIFIER


            // DATATYPE

            string address = "Tiền giang";
            int number = 10;
            long longNumber = 10L;
            double floatingNumber = 3.4D;
            float fullPi = 3.14F;

            // C# Type Casting

            // IMPLICIT CASTING
            int aNumberCasting = 1;
            double aDoubleCasting = aNumberCasting;

            // EXPLICIT CASTING
            double myDouble = 9.8;
            int aNumber = (int)myDouble;

            // C# INTPUT


            // Type your username and press enter
            Console.WriteLine("Enter username:");

            // Create a string variable and get user input from the keyboard and store it in the variable
            string userName = Console.ReadLine();

            // Print the value of the variable (userName), which will display the input value
            Console.WriteLine("Username is: " + userName);


            // CONVERT AGE WITH CONVERT.TO
            Console.WriteLine("Enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your birth of day");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your age is: " + age + ' ' + " Your year of birth is: " + year);

        }


    }
}