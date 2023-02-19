// See https://aka.ms/new-console-template for more information
using System;

namespace MyApplication
{

    class Program
    {

        static void MyMethod(string firstName, int age) // void means not return value, static means this method is reference to Program, it is not a object
        {
            Console.WriteLine("My name is " + firstName + " age is: " + age);
        }
        static void MyCountry(string myCountry = "Findland") // we can params to here and we can also set defaul value for parameters
        {
            Console.WriteLine("I am from " + myCountry);
        }

        static void NamedArgument(string string1, string string2, string string3)
        {
            Console.WriteLine("This is " + string3);
        }
        // If you want the method returns value using primitive data type instead

        static int Sum(int a, int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            MyMethod("Huy", 21);
            MyCountry("Viet Nam");
            int sumAB = Sum(10, 20);
            Console.WriteLine("The total is: ", sumAB);

            NamedArgument(string3: "String3", string1: "String 1", string2: "String2");
        }
    }
}