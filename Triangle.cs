using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleHomework
{
    public class Triangle
    {
        public string triangleType(int a, int b, int c)
        {
            //check if any of the sides is smaller or equal to 0
            if (a <= 0 || b <= 0 || c <= 0)
            {
                return "Wrong length of sides";
            }

            return "";
        }
    }
}
