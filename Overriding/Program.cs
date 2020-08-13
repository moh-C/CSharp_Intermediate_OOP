using System.Collections.Generic;

namespace Overriding
{
    class Program
    {
        static void Main(string[] args)
        {
            var circle = new Circle();
            var rectangle = new Rectangle();
            var canvas = new Canvas();
            var shape = new Shape();
            var shapes = new List<Shape>();
            shapes.Add(circle);
            shapes.Add(rectangle);
            shapes.Add(shape);
            canvas.CanvasDraw(shapes);
        }
    }
}
