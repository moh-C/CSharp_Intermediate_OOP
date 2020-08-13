namespace Abstract
{
    abstract class Shape
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Heigh { get; set; }

        public abstract void Draw();
    }
}