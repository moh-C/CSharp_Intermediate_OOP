using System.Collections.Generic;

namespace Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            var circle = new Circle();
            var rectangle = new Rectangle();
            var canvas = new Canvas();
            var triangle = new Triangle();
            var shapes = new List<Shape>();
            shapes.Add(circle);
            shapes.Add(rectangle);
            shapes.Add(triangle);
            canvas.CanvasDraw(shapes);
        }
    }
}
