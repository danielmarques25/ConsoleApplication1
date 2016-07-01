using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(poten(5, 2));
            Console.WriteLine(radi(25, 2));
            Console.WriteLine(soma(10, 2));
            Console.ReadKey();
        }
        /// <summary>
        /// Função para resolver potencias
        /// </summary>
        /// <param name="n1">Numero a ser elevado</param>
        /// <param name="ne">Expoente da potencia</param>
        static int poten(int n1,int ne)
        {
            int n2 = n1;
            for(int i = 1; i < ne; i++)
            {
                n1 *= n2;
            }
            return n1;
        }
        /// <summary>
        /// Função para radiciação
        /// </summary>
        /// <param name="n1">Radicando</param>
        /// <param name="ne">Indice</param>
        /// <returns></returns>
        static double radi(double n1, double ne)
        {
            double kk = Math.Pow(n1, (1/ne));
            return kk;
        }

      /// <summary>
      /// Soma
      /// </summary>
      /// <param name="n1">Primeiro Termo</param>
      /// <param name="ne">Segundo Termo</param>
      /// <returns></returns>
        static double soma(int n1, int ne) 
        {
            return n1 + ne;
        }
    }
}
