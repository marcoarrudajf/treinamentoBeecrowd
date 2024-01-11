using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace maior
{
    class CrescimentoCidade
    {
        //treinamento numero    1160
        public CrescimentoCidade()
        {
            int contator = int.Parse(Console.ReadLine());
            int anos = 0;

            for (int i = 0; i < contator; i++)
            {
                string[] val = Console.ReadLine().Split(' ');
                int pop1 = int.Parse(val[0]);
                int pop2 = int.Parse(val[1]);
                float cresc1 = float.Parse(val[2]);
                float cresc2 = float.Parse(val[3]);
                while (pop1 <= pop2)
                {
                    float res1 = pop1 + ((pop1 * cresc1) / 100);
                    if (cresc2 != 0)
                    {
                        float res2 = pop2 + ((pop2 * cresc2) / 100);
                        pop2 = (int)res2;
                    }
                    pop1 = (int)res1;
                    anos++;
                }
                if (anos <= 100)
                {
                    Console.WriteLine($"{anos} anos.");
                }
                else
                {
                    Console.WriteLine("Mais de 1 seculo.");
                    Console.WriteLine($"{anos} anos.");
                }
                anos = 0;
            }
        }

    }
}
