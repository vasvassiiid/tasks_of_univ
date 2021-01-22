namespace Task6_15
{
    public class DrawingNotebook : Notebook
    {
        public override string CoverColour { get; set; }
        public override string Type { get; set; }
        public string Orientation { get; set; }
        public bool HasExamples { get; set; }
        
        public override string Draw()
        {
            return "Draw something";
        }

        public string DrawPortrait()
        {
            return "Draw portrait";
        }
        
        public string DrawView()
        {
            return "Draw view";
        }

        public override string Flipping()
        {
            return "Flipping drawing notebook";
        }
    }
}