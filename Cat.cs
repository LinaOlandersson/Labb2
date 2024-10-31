namespace Labb2._1
{
    internal class Cat : Animal
    {
        // Sub class - Property
        public bool HasFur { get; set; } = true;

        // Sub class - Constructors
        public Cat() { }
        public Cat(bool hasEyes, bool hasTail, bool isDomesticated,
            int numOfLegs, bool canFly, bool hasFur) : base(hasEyes, hasTail, isDomesticated,
            numOfLegs, canFly)
        {
            HasFur = hasFur;
        }

        // Sub class - Methods
        public override void MakeSound()
        {
            Console.WriteLine("The cat says mioooow!");
        }
        public void Claw()
        {
            Console.WriteLine("The cat claws on the furiture.");
        }
    }
}
