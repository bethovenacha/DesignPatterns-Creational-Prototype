using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            ColorController colorController = new ColorController();

            //Initialize with standard colors
            colorController["yellow"] = new Color(255, 255, 0);
            colorController["orange"] = new Color(255, 128, 0);
            colorController["purple"] = new Color(128, 0, 255);

            //User adds customized color
            colorController["sunny"] = new Color(255, 54, 0);
            colorController["twilight"] = new Color(255, 153, 51);
            colorController["rainy"] = new Color(255, 0, 255);

            //User clones selected colors
            Color c1 = colorController["yellow"].Clone() as Color;
            Color c2 = colorController["twilight"].Clone() as Color;
            Color c3 = colorController["rainy"].Clone() as Color;

            Console.ReadKey();
        }
    }
}
