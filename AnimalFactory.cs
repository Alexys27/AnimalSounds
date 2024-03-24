using System;

namespace AnimalSounds
{
    public class AnimalFactory
    {
        public IAnimal CreateAnimal(string animalType)
        {
            switch (animalType)
            {
                case "Cat":
                    return new Cat();
                case "Dog":
                    return new Dog();
                case "Cow":
                    return new Cow();
                default:
                    throw new ArgumentException($"Invalid animal type: {animalType}");
            }
        }
    }
}
