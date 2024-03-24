using System;

namespace AnimalSounds
{
    public class Cat : IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine("Cat makes sound: Meow");
        }
    }
}
