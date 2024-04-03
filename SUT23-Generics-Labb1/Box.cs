using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUT23_Generics_Labb1
{
    internal class Box : IEquatable<Box>
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public int Length { get; set; }
        public int Volume { get; set; }

        public Box(int height, int width, int length)
        {
            this.Height = height;
            this.Width = width;
            this.Length = length;
            Volume = height * width * length;
        }
        public bool Equals(Box other)
        {
            if (new BoxProp().Equals(this, other))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
