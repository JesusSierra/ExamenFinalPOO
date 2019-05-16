using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamenFinal_PtIII.Classes;

namespace ExamenFinal_PtIII
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            string apellido;
            int numeroLetras = 0;
            int numeroLetras2 = 0;

            Console.WriteLine("Ingrese su nombre");
            nombre = Console.ReadLine();
            numeroLetras = nombre.Length;
            Console.WriteLine("Ingrese su apellido");
            apellido = Console.ReadLine();
            numeroLetras2 = apellido.Length;

            try
            {
                if (numeroLetras <= 2)
                {
                    throw new CMiExcepcion();
                }if (numeroLetras2 <= 2)
                {
                    throw new CMiExcepcion();
                }
            }
            catch (CMiExcepcion)
            {
                Console.WriteLine("Nombre/Apellido no válido");
            }
        }
    }
}
