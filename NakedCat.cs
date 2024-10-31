namespace Labb2._1
{
    internal class NakedCat : Cat
    {
        // Sub sub class - Property
        public string EyeColor { get; set; } = "Not set";
        public bool HasFur { get; set; } = false;

        // Sub sub class - Constructors
        public NakedCat() { }
        public NakedCat(bool hasEyes, bool hasTail, bool isDomesticated,
            int numOfLegs, bool canFly, bool hasFur, string eyeColor) : base(hasEyes, hasTail, isDomesticated,
            numOfLegs, canFly, hasFur)
        {
            EyeColor = eyeColor;
        }

        // Sub sub class - Methods
        public void WearClothes()
        {
            Console.WriteLine("The Naked cat is in need of some clothes.");
        }
    }
}
