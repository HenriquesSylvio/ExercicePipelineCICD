using System;

namespace ExercicePipelineCICD
{
    public class Calcul
    {

        public static double Addition(double a, double b)
        { 
            return a + b;
        }

        public static double Soustraction(double a, double b)
        {    
            return a - b;
        } 
         
        public static double Division(double a, double b)
        {
            if(a == 0 || b == 0)
            {
                throw new DivideByZeroException();
            }
             return a / b;
        }

        public static double Multiplication(double a, double b)
        {
            return a * b;
        }
    }
}
