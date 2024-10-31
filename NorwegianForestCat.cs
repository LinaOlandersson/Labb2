namespace Labb2._1
{
    internal class NorwegianForestCat : Cat
    {
        // Sub sub class - Property
        public string Color { get; set; } = "Not set";

        // Sub sub class - Constructors
        public NorwegianForestCat() { }
        public NorwegianForestCat(bool hasEyes, bool hasTail, bool isDomesticated,
            int numOfLegs, bool canFly, bool hasFur, string color) : base(hasEyes, hasTail, isDomesticated,
            numOfLegs, canFly, hasFur)
        {
            Color = color;
        }

        // Sub sub class - Methods
        public void Comb()
        {
            Console.WriteLine("The Norwegian Forest cat has a lot of fur to comb.");
        }
    }
}
