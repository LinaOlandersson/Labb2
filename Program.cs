namespace Labb2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a1 = new Animal();
            var b1 = new Bird();
            var w1 = new Wolf();
            var c1 = new Cat();
            var n1 = new NorwegianForestCat();
            var n2 = new NakedCat();

            Console.WriteLine("Calling MakeSound() from base class:");
            a1.MakeSound();
            Console.WriteLine("\nCalling MakeSound() from sub classes:");
            b1.MakeSound();
            w1.MakeSound();
            c1.MakeSound();
            Console.WriteLine("\nCalling MakeSound() from sub sub classes:");
            n1.MakeSound();
            n2.MakeSound();
            Console.WriteLine("\nCalling specific methods for sub sub classes:");
            n1.Comb();
            n2.WearClothes();
        }
    }
}
