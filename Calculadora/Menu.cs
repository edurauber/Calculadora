using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Menu
    {
        public string MenuPrincipal()
        {
            Console.WriteLine("---- Menu Principal ----");
            Console.WriteLine();
            Console.WriteLine("1- Somar");
            Console.WriteLine("2- Subtrair");
            Console.WriteLine("3- Multiplicar");
            Console.WriteLine("4- Dividir");
            Console.WriteLine();
            Console.WriteLine("0- Sair");

            return Console.ReadLine();

        }
    }
}
