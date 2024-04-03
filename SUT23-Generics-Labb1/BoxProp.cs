using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUT23_Generics_Labb1
{
    internal class BoxProp : EqualityComparer<Box>
    {
        public override bool Equals(Box b1, Box b2)
        {
            
            if (b1.Height == b2.Width && b1.Width==b2.Width && b1.Length==b2.Length &&
                b1.Volume == b2.Volume)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode(Box obj)
        {
            return obj.GetHashCode();
        }
    }
}
