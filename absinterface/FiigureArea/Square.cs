using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace absinterface.FiigureArea
{
    internal class Square : Figure
    {
        private int _side;
        public int Side
        {
            get
            {
                return _side;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Side menfi ola bilmez");
                    return;
                }
                _side = value;
            }
        }
        public Square(int side)
        {
            Side = side;
        }
        public override void CalcArea()
        {
            Console.WriteLine(Side * Side);
        }
    }
}
