using System;

namespace AbstractClassesChallenge
{
    public class Rectangle : Shape
    {

        protected double Side1;
        protected double Side2;

        public Rectangle(double Side1,double Side2,string Name, int NumSides) : base( Name,  NumSides) 
        {
            this.Side1=Side1;
            this.Side2=Side2;
        }
        
        protected  override void  SetArea()
        {
            Area=Side1*Side2;
        }
        // Implement your Rectangle class here.
    }
}
