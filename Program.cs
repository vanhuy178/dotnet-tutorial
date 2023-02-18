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


            int sum1 = 100 + 50;
            int sum2 = sum1 + 200;
            int sum3 = sum1 + sum2;



            // MATH OPERATOR: Math.min(value, value), Math.max(value, value), Math.sqrt(), Math.Abs(), Math.round(), ...

            // C# STRING
            string simpleText = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Console.WriteLine("The lenght of the text: " + simpleText.Length); // TAKE THE LENGTH OF THE STRING
            Console.WriteLine("To UpperCase: " + simpleText.ToUpper());
            Console.WriteLine("To LowerCase: " + simpleText.ToLower());

            // CONCATSTRING WITH + 
            // C# OPERATOR USING BOTH ADDITION AND CONCATENATION

            // Remember: + with number is number but + with string is string 

            // INTERPOLATION

            // string firstName = "John";
            // string lastName = "Doe";
            // string name = $"My full name is: {firstName} {lastName}";
            // Console.WriteLine(name);

            // C# ACCESSS STRING
            string accessString = "NguyenVanHuy";

            // ACCESS BY []

            string firstCharatertAccessString = Convert.ToString(accessString[0]);


            string myString = "Hello";
            Console.WriteLine(myString[0]);
            Console.WriteLine(firstCharatertAccessString);

            // YOU CAN FIND THE INDEX POSITION OF SPECIFIC CHARACTIER IN A STRING

            string status = "Nguyen Van Huy";

            // This will work if you are sure you have a first name and a last name.
            // string fullName = "Adrian Rules";
            // var names = fullName.Split(' ');
            // string firstName = names[0];
            // string lastName = names[1];

            // Strings - Special Characters


            // BOOLEAN SECTION
            int theAge = 18;
            int votingAge = 18;
            if (theAge >= votingAge)
            {
                Console.WriteLine("Old Enough to vote");
            }
            else
            {

                Console.WriteLine("Not old Enough to vote");
            }

            // SWITCH CASE
            int day = 2;
            switch (day)
            {
                case 2:
                    Console.WriteLine("Monday");
                    break;
                case 3:
                    Console.WriteLine("Tuesday");
                    break;
                default:
                    Console.WriteLine("There are no match");
                    break;
            }

            // WHILE LOOP
            int whileLoopValue = 0;
            int whileLoopRange = 10;
            while (whileLoopValue < whileLoopRange)
            {
                Console.WriteLine($"index at {whileLoopValue}");
                whileLoopValue++;
            }


            // DO WHITE
            do
            {
                Console.WriteLine($"index at {whileLoopValue}");
                whileLoopValue++;

            }
            while (whileLoopValue < whileLoopRange);


            // WHILE WITH STRING

            string nameString = "Nguyen-Van-Huy";
            string newString = "";
            int lengthOfNameString = nameString.Length;

            for (int i = 0; i < lengthOfNameString; i++)
            {
                if (nameString[i] == '-')
                {
                    continue;
                }
                // Console.WriteLine(nameString[i]);
                newString += nameString[i];
            }

            // 2D ARRAY
            int[,] numbers = { { 1, 4, 2 }, { 3, 6, 8 } };

            int[,] array2D = { { }, { } };

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    Console.WriteLine(numbers[i, j]);
                }
            }

        }

    }
}