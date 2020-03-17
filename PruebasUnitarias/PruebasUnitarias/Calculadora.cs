using System;
namespace PruebasUnitarias
{
    public static class Calculadora
    {
        public static double Sumar(double a, double b)
        {
            return a + b;
        }

        public static double Restar(double a, double b)
        {
            return a - b;
        }

        public static double Multiplicar(double a, double b)
        {
            return a * b;
        }

        public static double Dividir(double a, double b)
        {
            if (b == 0)
                return 0;

            return a / b;
        }
    }
}
