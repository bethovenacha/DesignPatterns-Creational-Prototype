using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    public class Color : ColorPrototype
    {
        private int _yellow;
        private int _orange;
        private int _purple;

        public Color(int yellow, int orange, int purple)
        {
            _yellow = yellow;
            _orange = orange;
            _purple = purple;
        }
        public override ColorPrototype Clone()
        {
            Console.WriteLine("RGB color is cloned to {0,3},{1,3},{2,3}", _yellow,_orange,_purple);
            return this.MemberwiseClone() as ColorPrototype; //
        }
    }
}
