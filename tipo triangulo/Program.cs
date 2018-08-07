using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tipo_triangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Nombre del Autor: Mauricio Mejia Estevez
            //Fecha: 13 Noviembre 2016
            //Doy fe que este ejercicio es de mi autoría, en caso de encontrar plagio la nota de todo mi
            //trabajo debe ser de CERO además de las respectivas sanciones a que haya lugar
            // 7. Lea los valores de los lados de un triángulo. Detecte y muestre un mensaje 
            //correspondiente a su tipo (EQUILÁTERO, ISÓSCELES, O ESCALENO)

            double a = 0, b = 0, c = 0;
            Console.WriteLine(" Ingrese el lado a Del Triangulo ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");
            Console.WriteLine(" Ingrese el lado b Del Triangulo ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");
            Console.WriteLine(" Ingrese el lado c Del Triangulo ");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");
            if (a == b && b == c)
                Console.WriteLine(" Los Datos ingresados pertenecen a un triangulo EQUILATERO ");
            else
            {
                if (a == b || a == c || b == c)
                    Console.WriteLine(" Los Datos ingresados pertenecen a un triangulo ISOCELES ");
                else
                {
                    Console.WriteLine(" Los Datos ingresados pertenecen a un triangulo ESCALENO ");
                }
            }
            Console.ReadKey();
        }
    }
}