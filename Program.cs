// See https://aka.ms/new-console-template for more information
using System;

namespace MyApplication
{

    class Animal
    {
        public virtual void animalSound()
        {
            Console.WriteLine("The animal makes a sounds");
        }
    }
    class Pig : Animal  // Derived class (child) 
    {
        public override void animalSound()
        {
            Console.WriteLine("The pig says: wee wee");
        }
    }


    class Dog : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("The pig says: gau gau!!!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Animal myAnimal = new Animal();
            Animal myPig = new Pig();
            Animal myDog = new Dog();

            myAnimal.animalSound();
            myPig.animalSound();
            myDog.animalSound();

            Pig heonai = new Pig();
            Animal heocon = new Pig();

            Console.WriteLine("Heo con kêu");
            heocon.animalSound();
        }
    }
}