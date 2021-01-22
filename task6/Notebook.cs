namespace Task6_15
{
    public abstract class Notebook : IPaper
    {
        public string Colour { get; set; }
        public string Quality { get; set; }
        public abstract string CoverColour { get; set; }
        public abstract string Type { get; set; }

        public abstract string Draw();

        public abstract string Flipping();

        public string Shred()
        {
            return "Shred Notebook";
        }
    }
}