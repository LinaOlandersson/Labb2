namespace Labb2._1
{
    public class Animal
    {
        // Base class - Properties
        public bool HasEyes { get; set; } = true;
        public bool HasTail { get; set; } = true;
        public bool IsDomesticated { get; set; } = true;
        public int NumOfLegs { get; set; } = 4;
        public bool CanFly { get; set; } = false;

        // Base class - Constructors
        public Animal() { }
        public Animal(bool hasEyes, bool hasTail, bool isDomesticated,
            int numOfLegs, bool canFly)
        {
            HasEyes = hasEyes;
            HasTail = hasTail;
            IsDomesticated = isDomesticated;
            NumOfLegs = numOfLegs;
            CanFly = canFly;
        }

        // Base class - Methods
        public virtual void MakeSound()
        {
            Console.WriteLine("The animal makes a sound.");
        }
        public void Sleep()
        {
            Console.WriteLine("The animal takes a nap.");
        }
        public void Eat()
        {
            Console.WriteLine("The animal eats.");
        }
    }
}
