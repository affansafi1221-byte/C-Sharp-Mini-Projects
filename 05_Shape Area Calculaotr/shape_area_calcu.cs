using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace C_Sharp_Mini_Projects._05_Shape_Area_Calculaotr
{
    internal class shape_area_calcu
    {
        public static void Run()
        {
            string answer;
            float result = 0f;
    
            Console.WriteLine("What shape would you like to find the area of ? please enter 'r' for rectangle or any other key for circle");

            answer = Console.ReadLine();

            if (string.Equals(answer, "r", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Please Enter height of rectangle");
                float height = float.Parse(Console.ReadLine());

                Console.WriteLine("Please Enter the width of rectangle");
                float width = float.Parse(Console.ReadLine());

                result = height * width;
            }
            else
            {
                Console.WriteLine(" Please Enter the radius of the circle");
                float radius = float.Parse(Console.ReadLine());

                result = ((float)Math.PI * (radius * radius));
            }

            Console.WriteLine("The Result is " + result );
        }
    }
}
