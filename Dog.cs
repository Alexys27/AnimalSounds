using System;

namespace AnimalSounds
{
    public class Dog : IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine("Dog makes sound: Woof");
        }
    }
}
