namespace TAR4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void PrintAnimals(Animal[] animals)
            {
                foreach (Animal animal in animals)
                {
                    Console.WriteLine(animal.ToString());

                    if (animal is Dog)
                    {
                        Dog d = (Dog)animal;
                        d.Bark();
                    }

                    if (animal is Cat)
                    {
                        Cat c = (Cat)animal;
                        c.Purr();
                    }
                }
            }
            Animal[] animals =
{
    new Dog { Name = "Rex", Age = 3 },
    new Cat { Name = "Kitty", Age = 2 }
};

            PrintAnimals(animals);
        }
    }
}
