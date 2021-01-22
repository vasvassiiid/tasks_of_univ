namespace Task6_15
{
    public interface IPaper
    {
        string Colour { get; set; }
        string Quality { get; set; }

        string Draw();
        string Shred();
    }
}