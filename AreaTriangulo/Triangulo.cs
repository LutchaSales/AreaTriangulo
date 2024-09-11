using System;


namespace Course
{
    internal class Triangulo
    {
        public double A;
        public double B;
        public double C;


        public double Area()
        {
            double P = (A + B + C) / 2.0;
            return  Math.Sqrt(P * (P - A) * (P - B) * (P - C));
           
        }
    }
}

