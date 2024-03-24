using System;
using System.Collections.Generic;

namespace AnimalSounds
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inițializăm un container de dependențe simplu pentru a gestiona crearea obiectelor animalelor
            AnimalFactory animalFactory = new AnimalFactory();

            // Creăm o listă de nume de animale
            List<string> animalNames = new List<string> { "Cat", "Dog", "Cow" };

            // Iterăm prin lista de nume de animale și afișăm sunetul fiecărui animal
            foreach (string name in animalNames)
            {
                IAnimal animal = animalFactory.CreateAnimal(name);
                animal.MakeSound();
            }
        }
    }
}
