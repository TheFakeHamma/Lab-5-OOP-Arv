namespace Lab_5_OOP_Arv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Luna", 1, 7.5, "House", "French Bulldog");

            Cat cat = new Cat("Mittens", 3, 4.5, "House", true);

            Bird bird = new Bird("Tweety", 1, 0.5, "Forest", true);

            Bulldog bulldog = new Bulldog("Rocky", 4, 25.5, "House", "English Bulldog", true);

            Chihuahua chihuahua = new Chihuahua("Luna", 1, 7.5, "House", "Chihuahua", true);

            dog.Eat();
            dog.Sleep();
            dog.Bark();
            dog.MakeSound();

            cat.Eat();
            cat.Sleep();
            cat.Climb();
            cat.MakeSound();

            bird.Eat();
            bird.Sleep();
            bird.Fly();
            bird.MakeSound();

            bulldog.Snore();
            bulldog.Bark();
            bulldog.MakeSound();

            chihuahua.Shake();
            chihuahua.Bark();
            chihuahua.MakeSound();

            Console.WriteLine("\n--- Polymorphism ---");

            Animal animal1 = new Dog("Buddy", 3, 12.5, "House", "Golden Retriever");
            Animal animal2 = new Cat("Whiskers", 2, 4.0, "House", true);
            Animal animal3 = new Bird("Sky", 1, 0.3, "Forest", true);

            animal1.MakeSound();
            animal2.MakeSound();
            animal3.MakeSound();
        }
    }
}
