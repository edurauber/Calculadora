using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Funcoes
    {
        public double Somar()
        {
            Console.Write("Digite o primeiro número: ");
            double n1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            double n2 = Convert.ToDouble(Console.ReadLine());

            return Math.Round(n1 + n2, 2);
        }
        public double Subtrair()
        {
            Console.Write("Digite o primeiro número: ");
            double n1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            double n2 = Convert.ToDouble(Console.ReadLine());

            return Math.Round(n1 - n2, 2);
        }
        public double Multiplicar()
        {
            Console.Write("Digite o primeiro número: ");
            double n1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            double n2 = Convert.ToDouble(Console.ReadLine());

            return Math.Round(n1 * n2, 2);
        }
        public double Dividir()
        {
            Console.Write("Digite o primeiro número: ");
            double n1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            double n2 = Convert.ToDouble(Console.ReadLine());

            return Math.Round(n1 / n2, 2);
        }
    }
}
