using System;

namespace Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            var shape = new Shape();
            var text = new Text();
            text.Height = 500;
            System.Console.WriteLine(shape.Height);
            System.Console.WriteLine(text.Height);
            shape = (Shape)text;
            shape.Height = 200;
            System.Console.WriteLine(shape.Height);
            System.Console.WriteLine(text.Height);
            // Another casting

            // string name_ = "MC";
            // int nameInt = (int)name_; Error

            // Upcasting
            var castedText = (Text)new Shape();

        }
    }
}
