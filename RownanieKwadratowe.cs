using System;
using System.IO;

namespace RownanieKwadratowe
{
    class RownanieKwadratowe
    {
        // równanie kwadratowe ma postać ax 2 + bx + c = 0
        // rozwiazanie rownanai kwadratowego podaje wzór kwadratowy 
        // x12 = -b +/- pierwiastek b2 -4ac/2a
        // dyskryminacja rownania kwadratowego Delta = b2 - 4AC
        // wzór kwadratowy z notacją dyskryminacyjną ma postać x12 = -b +/- pierwiastek Delta/2a
        // Gdy Δ/ 0, istnieją 2 pierwiastki rzeczywiste x 1 = (- b + √ Δ ) / (2a) i x 2 = (- b-√ Δ ) / (2a). 
        // Gdy Δ = 0, istnieje jeden pierwiastek x 1 = x 2 = -b BC/ (2a)
        // Gdy Δ <0, nie istnieją żadne realne korzenie, są złożone korzenie: 2 
        // x 1 = (- b + i√ -Δ ) / (2a), a x 2 = (- bi√ -Δ ) / (2a) 

        double a, b, c, x;
        

        double getA()
        {
            return a;
        }
        double getB()
        {
            return b;
        }
        double getC()
        {
            return c;
        }
        double getX()
        {
            return x;
        }


        void setABCX(int wspA, int wspB, int wspC, int wspX)
        {
            a = wspA;
            b = wspB;
            c = wspC;
            x = wspX;
        }

       
        public double RowKwad(double a, double b, double c)
        {
            double delta = ((b * b) - 4*(a *c));

            Console.WriteLine("Delta = " + delta);

            if (delta > 0)
            {
                double x1 = (- b + Math.Sqrt(delta) ) / (2 * a); 
                double x2 = (- b- Math.Sqrt(delta) ) / (2 * a);
                Console.WriteLine("Rozwiąznaie dla równiana kwadrateogo o parametrach: a =" + a + ", b = " + b + " ,c = " + c + ". Jest równie: x1 = " + x1 + " ,x2 = " + x2);
            }
            if (delta < 0 )
            {
                Console.WriteLine("Równanie nie ma rozwiązań");
            }
            if (delta == 0 )
            {
                double x = (-b / (2 * a));
            }

            return delta;



        }

    }
}