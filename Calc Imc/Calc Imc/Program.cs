using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc_Imc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem Vindo a calculadora de Imc, informe seu peso em KG:");
            double peso = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Agora sua altura em M");
            double altura = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Seu imc é igual a:");
            double imc = peso / (altura * altura);
            string casasDecimais = string.Format("{0:0.0}", imc);
            Console.WriteLine(casasDecimais + " kg/m2\r\n");

            if (imc <= 18.5)
            {
                Console.WriteLine("magrin.");
            }
            else if (imc > 18.5 && imc <= 24.9)
            {
                Console.WriteLine("Você está normalzin dimais.");
            }
            else if (imc > 24.9 && imc <= 30)
            {
                Console.WriteLine("Você está com Sobrepeso.");
            }
            else
            {
                Console.WriteLine("Você está com obesidade.");
            }
            Console.ReadLine();
        }
    }
}
