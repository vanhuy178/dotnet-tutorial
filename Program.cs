// See https://aka.ms/new-console-template for more information
using System;

namespace MyApplication
{
    interface Phone
    {
        void run(); // method abstract
    }

    class iphone : Phone // Implement 
    {
        public void run()
        {
            Console.WriteLine("I run by iOs");
        }
    }

    // POLYPHISUM
    class Animal
    {
        public virtual void animaSound()
        {
            Console.WriteLine("The animal makes a sound");
        }
    }

    class Pig : Animal
    {
        public override void animaSound()
        {
            Console.WriteLine("The pig make wee wee");
        }
    }
    class Xiaomi : Phone
    {
        public void run()
        {
            Console.WriteLine("I run by Android");
        }
    }

    class Nokia : Phone
    {
        public void run()
        {
            Console.WriteLine("I run by Android");
        }
    }

    abstract class Headphone // abstract class cant't create an object 
    {
        public abstract void type();
    }

    class BluetoothHeaphone : Headphone
    {
        public override void type()
        {
            Console.WriteLine("Tai nghe không dây");
        }
    }



    // ANOTHER WAY TO ACHIVE ABSTRACTION IN C#, IS WITH INTERFACES.
    interface IVehicle
    {
        void start();
        void vehicleSound();
    }

    class Plane : IVehicle
    {
        // On implementation of an interface, you must override all of its methods
        public void start()
        {
            Console.WriteLine("Multile swith to start me");
        }
        public void vehicleSound()
        {// 
            Console.WriteLine("í í í í í");
        }
    }

    // CLASS WE CANNOT INHERITENCE FROM MANI CLASS, BUT WITH INTERFACE WE CAN IMPLEMENT MULTILE INTERFACE

    interface Ione
    {
        void methodOne();
    }

    interface Itwo
    {
        void methodTwo();
    }

    class DemoClass : Ione, Itwo
    {
        public void methodOne()
        {
            Console.WriteLine("This is One's method");
        }

        public void methodTwo()
        {
            Console.WriteLine("This is Two's method");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Xiaomi note7 = new Xiaomi();
            note7.run();

            Animal myAnimal = new Animal();
            Animal myPig = new Pig();

            myAnimal.animaSound();
            myPig.animaSound();

            BluetoothHeaphone airport = new BluetoothHeaphone();
            airport.type();

            Plane booing = new Plane();
            booing.vehicleSound();

            // INPLEMENT MULTIPLE INTERFACE
            DemoClass oneDemo = new DemoClass();
            oneDemo.methodOne();
            DemoClass twoDemo = new DemoClass();
            twoDemo.methodTwo();
        }
    }
}