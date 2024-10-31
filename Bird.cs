namespace Labb2._1
{
    internal class Bird : Animal
    {
        // Sub class  - Property
        public string Gender { get; set; } = "Not set";

        // Sub class - Constructors
        public Bird() { }
        public Bird(bool hasEyes, bool hasTail, bool isDomesticated,
            int numOfLegs, bool canFly, string gender) : base(hasEyes, hasTail, isDomesticated,
            numOfLegs, canFly)
        {
            HasTail = false;
            IsDomesticated = false;
            NumOfLegs = 2;
            CanFly = true;
            Gender = gender;
        }

        // Sub class - Methods
        public override void MakeSound()
        {
            Console.WriteLine("The bird sounds piip-piip-piip!");
        }
        public void Fly()
        {
            Console.WriteLine("The bird flies away.");
        }
    }
}
