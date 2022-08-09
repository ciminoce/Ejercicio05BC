using System;

namespace Ejercicio05BC
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int perimetro, superficie;
                Console.Write("Ingrese el primer lado del cuadrilátero:");
                var lado1 = int.Parse(Console.ReadLine());
                Console.Write("Ingrese el segundo lado del cuadrilátero:");
                var lado2 = int.Parse(Console.ReadLine());
                if (lado1 > 0 && lado2 > 0)
                {
                    //bool esCuadrado = VerSiEsCuadrado(lado1, lado2);
                    if (VerSiEsCuadrado(lado1, lado2))
                    {
                        Console.WriteLine("Es un cuadrado");
                        perimetro = ObtenerPerimetroCuadrado(lado1);
                        superficie = ObtenerSuperficieCuadrado(lado1);
                    }
                    else
                    {
                        Console.WriteLine("Es un rectángulo");
                        perimetro = ObtenerPerimetroRectangulo(lado1, lado2);
                        superficie = ObtenerSuperficieRectangulo(lado1, lado2);

                    }
                    Console.WriteLine($"El perímetro es {perimetro}");
                    Console.WriteLine($"La superficie es {superficie}");
                }
                else
                {
                    Console.WriteLine("Alguno de los datos ingresados no son válidos");
                }

            }
            catch (Exception)
            {

                Console.WriteLine("Los datos ingresados podrían no ser válidos");
            }
            Console.ReadLine();
        }

        private static int ObtenerSuperficieRectangulo(int lado1, int lado2) => lado1 * lado2;

        private static int ObtenerPerimetroRectangulo(int lado1, int lado2) => 2 * lado1 + 2 * lado2;

        private static int ObtenerSuperficieCuadrado(int lado1)
        {
            return (int) Math.Pow(lado1, 2);
        }

        private static int ObtenerPerimetroCuadrado(int lado1)
        {
            return lado1 * 4;
        }

        private static bool VerSiEsCuadrado(int lado1, int lado2)
        {
            return lado1 == lado2;
        }
    }
}
