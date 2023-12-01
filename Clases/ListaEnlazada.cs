using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_azb_R.Clases
{
    public class ListaEnlazada
    {

        private Nodo cabeza;
        //----------------------------------------------------------------------------------------------------------------------------------------------------------
        public void AgregarCarros(Carros carro)
        {
            Nodo nuevoNodo = new Nodo(carro);

            if (cabeza == null)
            {
                cabeza = nuevoNodo;
            }
            else
            {
                Nodo actual = cabeza;
                while (actual.Siguiente != null)
                {
                    actual = actual.Siguiente;
                }

                actual.Siguiente = nuevoNodo;
            }
        }
        //No se pudo hacer
        public void OrdenarPorAño(Carros carros)
        {

        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------------
        public void BuscarPorMarca(string marca)
        {
            Nodo actual = cabeza;
            bool encontrado = false;

            Console.WriteLine($"Carros encontrados con la marca {marca}:");

            while (actual != null)
            {
                if (string.Equals(actual.Datos.Marca, marca, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Marca: {actual.Datos.Marca}, Modelo: {actual.Datos.Modelo}, Año: {actual.Datos.AñioDeFabricacion}");
                    encontrado = true;
                }
                actual = actual.Siguiente;
            }
            if (!encontrado)
            {
                Console.WriteLine($"No se encontraron carros con la marca {marca}.");
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------
        public void ImprimirFlota()
        {
            Nodo actual = cabeza;

            Console.WriteLine("Información de la flota:");

            while (actual != null)
            {

                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine($" Posicion: {i + 1},  Marca: {actual.Datos.Marca}, Modelo: {actual.Datos.Modelo}, Año: {actual.Datos.AñioDeFabricacion}");
                    actual = actual.Siguiente;
                }
            }
        }
    }
}
