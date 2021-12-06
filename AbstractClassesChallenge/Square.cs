using System;

namespace AbstractClassesChallenge
{
    public class Square : Rectangle
    {
     

       public  Square(double Side1,string Name, int NumSides) : base(Side1,Side1,Name,  NumSides)
        {
        }
        // Implement your Square Class here.
        protected  override void  SetArea()
        {
            Area=Side1*Side1;
        }

    }
}
