using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_OOP
{
    internal class Circle : ICircle
    {
        
        public double Radius { get ;private set; }
        public double Area { get { return Radius * Radius * Math.PI; }  }

        public Circle(double radius)
        {
            Radius = radius;
            
        }

        
        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Circle: Radius = {Radius}, Area = {Area}");
        }
    }
}
