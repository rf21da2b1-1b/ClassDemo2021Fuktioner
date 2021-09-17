using System;

namespace ClassDemo2021Fuktioner
{
    public class InsertCodeHere
    {
        public InsertCodeHere()
        {
        }

        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            double b = 34;
            double l = 12;

            double areal = ArealAfRektangel(b, l);
            Console.WriteLine($"bredde {b} længde {l} giver arealet {areal}");



            // The LAST line of code should be ABOVE this line
        }

        // en metode eller funktion

        public double ArealAfRektangel(double bredde, double længde)
        {
            // lave koden

            double areal = bredde * længde;
            return areal;
            // return bredde * længde;

        }
    }
}