using Day1.Lab2;
using System;

namespace Day1.Lab1
{
    class Program
    {
        static void Main()
        {
            #region Point
            //point p1 = new point() { x = 50, y = 75, z = 90 };
            //point p2 = new point() { x = 70, y = 65, z = 80 };

            //p1.displayAll();

            //p2.displayAll();

            //Console.WriteLine($"the result of calculation distance = {p2.CalcDistance(p1)} "); 
            #endregion

            #region Fraction
            //Fraction f1 = new Fraction() { nom = 5, Den = 6 };
            //Fraction f2 = new Fraction() { nom = 2, Den = 5 };

            //f1.display();
            //f2.display();

            //Fraction res = f1.add(f1, f2);
            //Console.WriteLine($"The Sum = {res.nom} / {res.Den} ");

            Fraction f1 = new Fraction(5,0);
            Fraction f2 = new Fraction(2, 5);

            f1.display();
            f2.display();
            //Fraction res = f1.add(f1, f2);
            Fraction res = new Fraction(f1, f2);
            //Console.WriteLine($"The Sum = {res.nom} / {res.den} ");
            #endregion



        }
    }
}
