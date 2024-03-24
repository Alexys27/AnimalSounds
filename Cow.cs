using System;

namespace AnimalSounds
{
    public class Cow : IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine("Cow makes sound: Moo");
        }
    }
}
