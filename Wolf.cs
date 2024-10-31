namespace Labb2._1
{
    public class Wolf : Animal
    {
        // Sub class - Property
        public bool HasSharpTeeth { get; set; } = true;

        // Sub class - Constructors
        public Wolf() { }
        public Wolf(bool hasEyes, bool hasTail, bool isDomesticated,
            int numOfLegs, bool canFly, bool hasSharpTeeth) : base(hasEyes, hasTail, isDomesticated,
            numOfLegs, canFly)
        { 
            IsDomesticated = false;
            HasSharpTeeth = hasSharpTeeth;
        }

        // Sub class - Methods
        public override void MakeSound()
        {
            Console.WriteLine("The wolf goes aoooooo!");
        }
        public void Hunt()
        {
            Console.WriteLine("The wolf is always on a hunt.");
        }
    }
        
}

