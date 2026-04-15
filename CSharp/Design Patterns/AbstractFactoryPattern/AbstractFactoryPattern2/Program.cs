using AbstractFactoryPattern2.AbstractFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IAnimal animal = null;
            AnimalFactory animalFactory = null;
            string sound = null;


            //create respective factory objects
            animalFactory = AnimalFactory.GetAnimalFactory("Sea");
            Console.WriteLine("You have reached : " + animalFactory.GetType().Name);
            Console.WriteLine();

            //animal object
            animal = animalFactory.GetAnimal("Shark");
            Console.WriteLine("Animal Chosen : "+ animal.GetType().Name);

            sound = animal.Speak();
            Console.WriteLine($" You have reached {animalFactory} and you chose to play with {animal} " +
                $"and the sound of the animal is {sound} ");
            Console.Read();
        }
    }
}
