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

            //Checking triangle ineqaulity. 
            //can we actually form triangle with the given sides.
            if (a + b <= c || b + c <= a || a + c <= b)
            {
                return "Impossible to form Triangle with given sides";
            }

            //Checking if triangle is equlateral (if all sides are equal)
            if (a == b && b == c)
            {
                return "Triangle is Equilateral";
            }
            
            //Checking if triangle is isosclaes (if two sides are equal)
            if (a == b || b == c || a == c)
            {
                return "Triangle is Isoscales";
            }

            //if triangle sides passed all criterias and 
            //if triangle is neither of the types listed before it is scalene
            return "Triangle is Scalene";
        }

        public string triangleTypeByAngle(int a, int b, int c)
        {
            //check if any of the sides is smaller or equal to 0
            if (a <= 0 || b <= 0 || c <= 0)
            {
                return "Wrong length of sides";
            }

            //Checking triangle ineqaulity. 
            //can we actually form triangle with the given sides.
            if (a + b <= c || b + c <= a || a + c <= b)
            {
                return "Impossible to form Triangle with given sides";
            }

            //checks if a triangle is right
            if (a * a == b * b + c * c || b * b == a * a + c * c || c * c == a * a + b * b)
            {
                return "Triangle is right";
            }
            //checks if triangle is obtuse
            if (a * a > b * b + c * c || b * b > a * a + c * c || c * c > a * a + b * b)
            {
                return "Triangle is obtuse";
            }

            //if triangle sides passed all criterias and 
            //if triangle is neither of the types listed before it is acute
            return "Triangle is acute";
        }
    }
}
