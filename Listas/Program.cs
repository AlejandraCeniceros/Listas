using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> colores = new List<string>();
            colores.Add("Rojo");
            colores.Add("Verde");
            colores.Add("Naranja");
            colores.Add("Amarillo");
            colores.Add("Azul");

            colores.RemoveAt(1);
            colores.Remove("Amarillo");

            Console.WriteLine("Numero de elementos:" + colores.Count);

            int indiceColor = 1;
            foreach(var color in colores)
            {
                Console.WriteLine("elemento:" + indiceColor.ToString() + ":" + color);
                indiceColor++;
            }

            Console.Read();

        }
    }
}
