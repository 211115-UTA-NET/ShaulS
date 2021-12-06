using System;

namespace AbstractClassesChallenge
{
    public class Triangle : Shape
    {
        protected double Side1;
        protected double Side2;
        protected double Side3;

        public Triangle(double Side1,double Side2,double Side3,string Name, int NumSides) :base( Name,  NumSides)
        {
            this.Side1=Side1;
            this.Side2=Side2;
            this.Side3=Side3;
        }


           protected  override void  SetArea()
        {
            double s = (Side1 + Side1 + Side1)/2;
            s=(s*(s-Side1)*(s-Side2)*(s-Side3));
            Area=Math.Sqrt(s);
        }


            // Implement your Triangle class here.
            // HINT: Use Herons Formula to calculate and set the area.
    }
}
