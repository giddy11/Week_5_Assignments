using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._20._5
{
    public abstract class Shapes
    {
        public float Width { get; set; }
        public float Height { get; set; }

        public abstract double CalculateSurface();
    }
}
