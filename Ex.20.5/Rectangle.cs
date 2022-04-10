using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._20._5
{
    class Rectangle : Shapes
    {
        public Rectangle()
        {

        }

        public override double CalculateSurface()
        {
            return this.Height * this.Width ;
        }

    }
}
