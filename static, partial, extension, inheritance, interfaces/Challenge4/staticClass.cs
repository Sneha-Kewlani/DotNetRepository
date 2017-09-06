using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge4
{
    public static class staticClass
    {
        /*private static float pi = 3.14F;
        private static int r;
        public static void staticMethod()
        {
            Console.WriteLine("Enter the radius: ");
            r = Convert.ToInt16(Console.ReadLine());

            float areaCircle = pi * r * r;

            Console.WriteLine("Area of circle: {0}", areaCircle);


        }
    }*/
        private static int l, b;
        public static void rectangleArea()
        {
            Console.WriteLine("Enter the length: ");
            l = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter the breadth: ");
            b = Convert.ToInt16(Console.ReadLine());


            float areaRectangle = l * b;

            Console.WriteLine("Area of rectangle: {0}", areaRectangle);
        }
    }
}
