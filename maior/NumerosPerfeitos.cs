using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maior
{
    class NumerosPerfeitos
    {
        public void numeroPerfeito(int contador)
        {
            int soma = 0;
            int valor;

            for (int i = 1; i <= contador; i++)
            {
                valor = int.Parse(Console.ReadLine());
                for (int j = 1; j < valor; j++)
                {
                    if (valor % j == 0)
                    {
                        soma += j;                              
                    }
                }

                if (soma == valor)
                {
                    Console.WriteLine($"{valor} eh perfeito");
                }
                else
                {
                    Console.WriteLine($"{valor} nao eh perfeito");
                }
                soma = 0;
            }

        }
    }
}
