using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace absinterface.FiigureArea
{
    internal class Rectangular : Figure
    {
        private int _width;
        public int Width
        {
            get
            {
                return _width;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("width menfi ola bilmez");
                    return;
                }
                _width = value;
            }
        }
        private int _length;
        public int Length
        {
            get
            {
                return _length;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("length menfi ola bilmez");
                    return;
                }
                _length = value;
            }
        }
        public Rectangular(int width, int length)
        {
            Width = width;
            Length = length;
        }

        public override void CalcArea()
        {
            Console.WriteLine(Width * Length);
        }
    }
}
