namespace Overriding
{
    class Shape
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Heigh { get; set; }

        public virtual void Draw()
        {
            System.Console.WriteLine("Draw method of Shape");
        }
    }
}