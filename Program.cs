using Examen_azb_R.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_azb_R
{
    class Program
    {
        static void Main()
        {
            ListaEnlazada flotaCarros = new ListaEnlazada();
            // Ingresa los datos del usuario -------------------------------------------------------------------------------------//
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Ingrese los datos del carro {i + 1}:");

                Console.Write("Marca: ");
                string marca = Console.ReadLine();

                Console.Write("Modelo: ");
                string modelo = Console.ReadLine();

                Console.Write("Año de fabricación: ");
                string anioFabricacion = Console.ReadLine();

                flotaCarros.AgregarCarros(new Carros { Marca = marca, Modelo = modelo, AñioDeFabricacion = anioFabricacion });
            }
            //--------------------------------------------------------------------------------------------------------------------//



            // Imprime la flota ------------------------------------//
            flotaCarros.ImprimirFlota();
            //-----------------------------------------------------//



            //-Busca la marca que pide el usuario------------------//
            Console.Write("\nIngrese la marca para buscar carros: ");
            string BuscarMarca = Console.ReadLine();
            flotaCarros.BuscarPorMarca(BuscarMarca);
            //---------------------------------------------------//
        }
    }
}
