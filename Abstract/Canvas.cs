using System.Collections.Generic;

namespace Abstract
{
    class Canvas
    {
        public void CanvasDraw(List<Shape> shapes)
        {
            foreach (var shape in shapes)
            {
                shape.Draw();
            }
        }
    }
}