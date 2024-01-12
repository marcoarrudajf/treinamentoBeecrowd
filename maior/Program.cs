using maior;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Formats.Asn1;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Schema;

namespace Principal
{
    /* Treino de soluções de problema com c# no beecrowd.
     * Treinamento simples de criações de funções para gerar resultados esperado. */
    class Program
    {
        static void Main(string[] args)
        {

            //CrescimentoCidade cc = new CrescimentoCidade();
            NumerosPerfeitos numerosPerfeitos = new NumerosPerfeitos();
            numerosPerfeitos.numeroPerfeito(int.Parse(Console.ReadLine()));

            //Chamada das funções estaticas

            //somaImparseq();
            //numImparesSeq();
            //numImpares();
            //posNegParesImpares();
            //positivoMediaPar();
            //positivoMedia();
            //medirAreas();
            //medirArea();
            //diferencaSoma();
            //comissaoSalario();
            //valorAPagar();
            //volume();
            //qualMaior();
            //gastoGasolina();
            //tempoEmMinutos();
            //anosEmDias();
            //contarDinheiro();
            //valoresAceitos();
            //calcularRaiz();
            //intervaloValor();
            //valorPagar();
            //mediaNota();
            //numMenor();
            //compararNum();
            //triangulo();
            //multiplos();
            //tiposTriang();
            //tempoJogo();
            //tempoJogoMin();                 //terminar e testar
            //aumentarSalario();
            //tipoSer();
            //ddd();
            //imposto();
            //mes();
            //pares();
            //numPositivo();
            //intervaloValorDois();
            //quadradPares();
            //parImpar();
            //restoDois();
            //tabuada();
            //mediasPonderadas();
            //maiorNum();
            //experiencias();
            //gangorra();
            //dez();
            //tipoDeCha();
            //buscaInternet();
            //calibrarPneu();
            //sequenciaSecreta();
            //tacografo();
            //notaDaProva();
            //contarMandioca();
            //corrida();
            //abasDePerices();
            //domino();
            //aviaoDePapel();
            //bobConduite();
            //feijao();
            //top();
            //truco();
            //qualANota();
            //saidaSeis();
            //McDonalds();
            //eventoXp();

            //Teste ex = new Teste();
            //ex.extrato();

            //Nova nova = new Nova();
            //nova.novaFun();
        }

        public void triangulo()
        {
            string[] linha = Console.ReadLine().Split(' ');
            double A = double.Parse(linha[0]);
            double B = double.Parse(linha[1]);
            double C = double.Parse(linha[2]);
            if (A < B + C && B < A + C && C < A + B)
            {
                double perimetro = A + B + C;
                Console.WriteLine("Perimetro = " + perimetro.ToString("F1"));
            }
            else
            {
                double areaTrapezio = ((A + B) * C) / 2;
                Console.WriteLine("Area = " + areaTrapezio.ToString("F1"));
            }
        }

        public static void multiplos()
        {
            string[] linha = Console.ReadLine().Split(' ');
            double a = double.Parse(linha[0]);
            double b = double.Parse(linha[1]);
            if (a % b == 0 || b % a == 0)
            {
                Console.WriteLine($"Sao Multiplos");
            }
            else
            {
                Console.WriteLine($"Nao sao Multiplos");
            }
        }

        public static void tiposTriang()
        {
            string[] linha = Console.ReadLine().Split(' ');
            double a = double.Parse(linha[0]);
            double b = double.Parse(linha[1]);
            double c = double.Parse(linha[2]);

            if (a < b)
            {
                double temp = a;
                a = b;
                b = temp;
            }
            if (a < c)
            {
                double temp = a;
                a = c;
                c = b;
                b = temp;
            }

            if (a >= b + c)
            {
                Console.WriteLine("NAO FORMA TRIANGULO");
                return;
            }
            if (Math.Pow(a, 2) == Math.Pow(b, 2) + Math.Pow(c, 2))
            {
                Console.WriteLine("TRIANGULO RETANGULO");
            }
            if (Math.Pow(a, 2) > (Math.Pow(b, 2) + Math.Pow(c, 2)))
            {
                Console.WriteLine("TRIANGULO OBTUSANGULO");
            }
            if (Math.Pow(a, 2) < Math.Pow(b, 2) + Math.Pow(c, 2))
            {
                Console.WriteLine("TRIANGULO ACUTANGULO");
            }
            if (a == b && b == c && c == a)
            {
                Console.WriteLine("TRIANGULO EQUILATERO");
            }
            if (b == c && c != a || a == b && c != b || c == a && b != a)
            {
                Console.WriteLine("TRIANGULO ISOSCELES");

            }
        }

        public static void tempoJogo()
        {
            string[] num = Console.ReadLine().Split(' ');
            int ini = int.Parse(num[0]);
            int fim = int.Parse(num[1]);

            if (ini < fim)
            {
                int hora = fim - ini;
                Console.WriteLine($"O JOGO DUROU {hora} HORA(S)");
            }
            else if (ini >= fim)
            {
                int hora = 24 - ini + fim;
                Console.WriteLine($"O JOGO DUROU {hora} HORA(S)");

            }

        }
        public static void tempoJogoMin()
        {
            string[] num = Console.ReadLine().Split(' ');
            int hI = int.Parse(num[0]);
            int mI = int.Parse(num[1]);
            int hF = int.Parse(num[2]);
            int mF = int.Parse(num[3]);
            int hora = 0;
            int min = 0;

            if (hI == hF && mI > mF)
            {
                hora = 0;
                min = 60 - mI + mF;

            }
            if (hI == hF && mI < mF)
            {
                hora = 0;
                min = mF - mI;
            }
            if (hI == hF && mI == mF)
            {
                hora = 24;
                min = mF - mI;
            }
            if (hI > hF && mI > mF)
            {
                hora = 24 - hI + hF;
                min = 60 - mI + mF;
            }
            if (hI < hF && mI < mF)
            {
                hora = hF - hI;
                min = mF - mI;
            }


            Console.WriteLine($"O JOGO DUROU {hora} HORA(S) E {min} MINUTO(S)");


            //string[] num = Console.ReadLine().Split(' ');
            //int hI = int.Parse(num[0]);
            //int mI = int.Parse(num[1]);
            //int hF = int.Parse(num[2]);
            //int mF = int.Parse(num[3]);

            //int hora, min, dia;


            //min = mF - mI;
            //hora = hF - hI;
            //if (hI == hF)
            //{
            //    hora = 24;
            //}


            //if (hora < 0)
            //{
            //    hora += 24;
            //}


            //if (min < 0)
            //{
            //    hora -= 1; // Remove 1 hora, já que houve uma "compensação" dos minutos
            //    min += 60; // Acrescenta 60 minutos para o minuto final
            //}

            //Console.WriteLine($"O JOGO DUROU {hora} HORA(S) E {min} MINUTO(S)");





        }

        public static void aumentarSalario()
        {
            double salario = double.Parse(Console.ReadLine());
            double novoSal, reajuste;

            if (salario <= 400)
            {
                reajuste = (salario * 15) / 100;
                novoSal = salario + reajuste;
                Console.WriteLine($"Novo salario: {novoSal:F2}");
                Console.WriteLine($"Reajuste ganho: {reajuste:F2}");
                Console.WriteLine($"Percentual: 15 %");
            }
            else if (salario <= 800)
            {
                reajuste = (salario * 12) / 100;
                novoSal = salario + reajuste;
                Console.WriteLine($"Novo salario: {novoSal:F2}");
                Console.WriteLine($"Reajuste ganho: {reajuste:F2}");
                Console.WriteLine($"Percentual: 12 %");
            }
            else if (salario <= 1200)
            {
                reajuste = (salario * 10) / 100;
                novoSal = salario + reajuste;
                Console.WriteLine($"Novo salario: {novoSal:F2}");
                Console.WriteLine($"Reajuste ganho: {reajuste:F2}");
                Console.WriteLine($"Percentual: 10 %");
            }
            else if (salario <= 2000)
            {
                reajuste = (salario * 7) / 100;
                novoSal = salario + reajuste;
                Console.WriteLine($"Novo salario: {novoSal:F2}");
                Console.WriteLine($"Reajuste ganho: {reajuste:F2}");
                Console.WriteLine($"Percentual: 7 %");
            }
            else
            {
                reajuste = (salario * 4) / 100;
                novoSal = salario + reajuste;
                Console.WriteLine($"Novo salario: {novoSal:F2}");
                Console.WriteLine($"Reajuste ganho: {reajuste:F2}");
                Console.WriteLine($"Percentual: 4 %");
            }

        }

        public static void tipoSer()
        {
            string caract1 = Console.ReadLine();
            string caract2 = Console.ReadLine();
            string caract3 = Console.ReadLine();

            if (caract1 == "vertebrado" && caract2 == "ave" && caract3 == "carnivoro")
            {
                Console.WriteLine("aguia");
            }
            else if (caract1 == "vertebrado" && caract2 == "ave" && caract3 == "onivoro")
            {
                Console.WriteLine("pomba");
            }

            else if (caract1 == "vertebrado" && caract2 == "mamifero" && caract3 == "onivoro")
            {
                Console.WriteLine("homem");
            }
            else if (caract1 == "vertebrado" && caract2 == "mamifero" && caract3 == "herbivoro")
            {
                Console.WriteLine("vaca");
            }

            if (caract1 == "invertebrado" && caract2 == "inseto" && caract3 == "hematofago")
            {
                Console.WriteLine("pulga");
            }
            else if (caract1 == "invertebrado" && caract2 == "inseto" && caract3 == "herbivoro")
            {
                Console.WriteLine("lagarta");
            }
            else if (caract1 == "invertebrado" && caract2 == "anelideo" && caract3 == "hematofago")
            {
                Console.WriteLine("sanguessuga");
            }
            else if (caract1 == "invertebrado" && caract2 == "anelideo" && caract3 == "onivero")
            {
                Console.WriteLine("minhoca");
            }



        }

        public static void ddd()
        {
            int num = int.Parse(Console.ReadLine());

            switch (num)
            {
                case 61:
                    Console.WriteLine("Brasilia");
                    break;
                case 71:
                    Console.WriteLine("Salvador");
                    break;
                case 11:
                    Console.WriteLine("Sao Paulo");
                    break;
                case 21:
                    Console.WriteLine("Rio de Janeiro");
                    break;
                case 32:
                    Console.WriteLine("Juiz de Fora");
                    break;
                case 19:
                    Console.WriteLine("Campinas");
                    break;
                case 27:
                    Console.WriteLine("Vitoria");
                    break;
                case 31:
                    Console.WriteLine("Belo Horizonte");
                    break;
                default:
                    Console.WriteLine("DDD nao cadastrado");
                    break;

            }
        }

        public static void imposto()
        {
            double salario = double.Parse(Console.ReadLine());

            double a = 2000;
            double b = 3000;
            double c = 4500;
            double imposto, faixa1, faixa2, faixa3, soma1, soma2, soma3;


            if (salario <= a)
            {
                Console.WriteLine("Isento");
            }
            else if (salario <= b)
            {
                imposto = (salario - a) * 8 / 100;
                Console.WriteLine($"R$ {imposto:F2}");
            }
            else if (salario <= c)
            {
                faixa1 = salario - b;
                faixa2 = salario - a - faixa1;
                soma1 = (faixa2 * 8) / 100;
                soma2 = (faixa1 * 18) / 100;
                imposto = soma1 + soma2;
                Console.WriteLine($"R$ {imposto:F2}");
            }
            else
            {
                faixa3 = (salario - c);
                faixa1 = (salario - b - faixa3);
                faixa2 = (salario - a - faixa1 - faixa3);
                soma1 = (faixa2 * 8) / 100;
                soma2 = (faixa1 * 18) / 100;
                soma3 = (faixa3 * 28) / 100;
                imposto = soma1 + soma2 + soma3;
                Console.WriteLine($"R$ {imposto:F2}");
            }

        }

        public static void mes()
        {
            int num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 1:
                    Console.WriteLine("January");
                    break;
                case 2:
                    Console.WriteLine("February");
                    break;
                case 3:
                    Console.WriteLine("March");
                    break;
                case 4:
                    Console.WriteLine("April");
                    break;
                case 5:
                    Console.WriteLine("May");
                    break;
                case 6:
                    Console.WriteLine("June");
                    break;
                case 7:
                    Console.WriteLine("July");
                    break;
                case 8:
                    Console.WriteLine("August");
                    break;
                case 9:
                    Console.WriteLine("September");
                    break;
                case 10:
                    Console.WriteLine("October");
                    break;
                case 11:
                    Console.WriteLine("November");
                    break;
                case 12:
                    Console.WriteLine("December");
                    break;
                default:
                    Console.WriteLine("valor invalido");
                    break;
            }
        }

        public static void pares()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0) Console.WriteLine(i++);
            }
        }

        public static void numPositivo()
        {
            //int tamArr = 6;
            double[] arr = new double[6];
            int cont = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = double.Parse(Console.ReadLine());
                if (arr[i] > 0)
                {
                    cont++;
                }
            }
            Console.WriteLine($"{cont} valores positivos");
        }

        public static void numMenor()
        {


            string[] linha = Console.ReadLine().Split(' ');
            int a = int.Parse(linha[0]);
            int b = int.Parse(linha[1]);
            int c = int.Parse(linha[2]);

            int[] valores = new int[3];
            valores[0] = a;
            valores[1] = b;
            valores[2] = c;
            int[] valores2 = new int[3];


            for (int i = 0; i < 3; i++)
            {
                valores2[i] = valores[i];
            }

            Array.Sort(valores);

            foreach (int valor in valores)
            {
                Console.WriteLine(valor);
            }

            Console.WriteLine();

            foreach (int valor in valores2)
            {
                Console.WriteLine(valor);
            }
        }

        public static void compararNum()
        {
            string[] input = Console.ReadLine().Split(' ');

            double x = double.Parse(input[0]);
            double y = double.Parse(input[1]);

            if (x == 0 && y == 0)
            {
                Console.WriteLine("Origem");
            }
            else if (x == 0)
            {
                Console.WriteLine("Eixo Y");
            }
            else if (y == 0)
            {
                Console.WriteLine("Eixo X");
            }
            else if (x > 0 && y > 0)
            {
                Console.WriteLine("Q1");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Q2");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Q3");
            }
            else // (x > 0 && y < 0)
            {
                Console.WriteLine("Q4");
            }
        }

        public static void mediaNota()
        {
            string[] linha = Console.ReadLine().Split(' ');
            double a = double.Parse(linha[0]) * 2;
            double b = double.Parse(linha[1]) * 3;
            double c = double.Parse(linha[2]) * 4;
            double d = double.Parse(linha[3]);
            double media = (a + b + c + d) / 10;
            if (Math.Floor(media * 10) / 10 >= 7d)
            {
                Console.WriteLine($"Media: {media:F1}");
                Console.WriteLine($"Aluno aprovado.");
            }
            else if (Math.Floor(media * 10) / 10 >= 5.0d && Math.Floor(media * 10) / 10 < 7d)
            {
                Console.WriteLine($"Media: {media:F1}");
                Console.WriteLine($"Aluno em exame.");
                double notaExame = double.Parse(Console.ReadLine());
                double mediaFinal = (media + notaExame) / 2;
                if (Math.Floor(mediaFinal * 10) / 10 >= 5d)
                {
                    Console.WriteLine($"Nota do exame: {notaExame:F1}");
                    Console.WriteLine($"Aluno aprovado.");
                    Console.WriteLine($"Media final: {mediaFinal:F1}");
                }
                else
                {
                    Console.WriteLine($"Nota do exame: {notaExame:F1}");
                    Console.WriteLine($"Aluno reprovado.");
                    Console.WriteLine($"Media final: {mediaFinal:F1}");
                }
            }
            else
            {
                // Para tratar o arredondamento das casas decimais para baixo realizei a multiplicação do valor por 10 e dividi por 10 passando Math.Floor()
                Console.WriteLine($"Media: {Math.Floor(media * 10) / 10:F1}");
                Console.WriteLine("Aluno reprovado.");
            }
        }
        public static void valorPagar()
        {
            string[] linha = Console.ReadLine().Split(' ');
            double id = double.Parse(linha[0]);
            double qtde = double.Parse(linha[1]);

            double pagar = 0;
            double valor = 0;

            if (id == 1)
            {
                valor = 4.00;
            }
            else if (id == 2)
            {
                valor = 4.50;
            }
            else if (id == 3)
            {
                valor = 5.00;
            }
            else if (id == 4)
            {
                valor = 2.00;
            }
            else if (id == 5)
            {
                valor = 1.50;
            }

            pagar = qtde * valor;
            Console.WriteLine($"Total: R$ {pagar:F2}");
        }

        public static void intervaloValor()
        {
            double valor = double.Parse(Console.ReadLine());

            if (valor >= 0 && valor <= 25)
            {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if (valor > 25 && valor <= 50)
            {
                Console.WriteLine("Intervalo (25,50]");
            }
            else if (valor > 50 && valor <= 75)
            {
                Console.WriteLine("Intervalo (50,75]");
            }
            else if (valor > 75 && valor <= 100)
            {
                Console.WriteLine("Intervalo (75,100]");
            }
            else
            {
                Console.WriteLine("Fora de intervalo");
            }
        }
        public static void calcularRaiz()
        {
            string[] linha = Console.ReadLine().Split(' ');
            double a = double.Parse(linha[0]);
            double b = double.Parse(linha[1]);
            double c = double.Parse(linha[2]);

            // Calcula o delta da equação de Bhaskara
            double delta = Math.Pow(b, 2) - 4 * a * c;

            // Verifica se é possível calcular as raízes
            if (a == 0 || delta < 0)
            {
                Console.WriteLine("Impossivel calcular");
            }
            else
            {
                // Calcula as raízes
                double raiz1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double raiz2 = (-b - Math.Sqrt(delta)) / (2 * a);

                // Imprime as raízes com 5 dígitos após o ponto
                Console.WriteLine($"R1 = {raiz1:F5}");
                Console.WriteLine($"R2 = {raiz2:F5}");
            }
        }

        public static void valoresAceitos()
        {
            string[] linha1 = Console.ReadLine().Split(' ');
            int a = int.Parse(linha1[0]);
            int b = int.Parse(linha1[1]);
            int c = int.Parse(linha1[2]);
            int d = int.Parse(linha1[3]);

            if ((b > c && d > a) && ((c + d) > (a + b)) && (c > 0 && d > 0 && (a % 2 == 0)))
            {
                Console.WriteLine("Valores aceitos");
            }
            else
            {
                Console.WriteLine("Valores nao aceitos");
            }
        }

        public static void contarDinheiro()
        {
            double[] notas = { 100, 50, 20, 10, 5, 2 };
            double[] moedas = { 1, 0.50, 0.25, 0.10, 0.05, 0.01 };
            int[] quantidadeNotas = new int[notas.Length];
            int[] quantidadeMoedas = new int[moedas.Length];

            double valorTotal = double.Parse(Console.ReadLine()) + 0.000000005; //CAMBIARRA

            for (int i = 0; i < notas.Length; i++)
            {
                quantidadeNotas[i] = (int)valorTotal / (int)notas[i];
                valorTotal %= notas[i];
            }

            for (int i = 0; i < moedas.Length; i++)
            {
                quantidadeMoedas[i] = (int)(valorTotal / moedas[i]);
                valorTotal %= moedas[i];
            }

            Console.WriteLine($"NOTAS:");
            for (int i = 0; i < notas.Length; i++)
            {
                Console.WriteLine($"{quantidadeNotas[i]} nota(s) de R$ {notas[i]:F2}");
            }

            Console.WriteLine($"MOEDAS:");
            for (int i = 0; i < moedas.Length; i++)
            {
                Console.WriteLine($"{quantidadeMoedas[i]} moeda(s) de R$ {moedas[i]:F2}");
            }
        }

        public static void anosEmDias()
        {
            int dias = int.Parse(Console.ReadLine());
            int ano = dias / 365;
            int restAno = dias % 365;
            int mes = restAno / 30;
            int dia = restAno % 30;

            Console.WriteLine($"{ano} ano(s)");
            Console.WriteLine($"{mes} mes(es)");
            Console.WriteLine($"{dia} dia(s)");
        }

        public static void tempoEmMinutos()
        {
            int tempo = int.Parse(Console.ReadLine());

            int hora = tempo / 3600;
            int resTemp = tempo % 3600;
            int minuto = resTemp / 60;
            int segundo = tempo % 60;

            Console.WriteLine($"{hora}:{minuto}:{segundo}");
        }

        public static void gastoGasolina()
        {
            int dist = int.Parse(Console.ReadLine());
            double consumo = double.Parse(Console.ReadLine());
            double precoGas = double.Parse(Console.ReadLine());

            double autonomia = dist / consumo;
            double despesa = precoGas * autonomia;
            Console.WriteLine($"Combustivel consumido: {autonomia:F3} km/l");
            Console.WriteLine($"Valor gasto com a viagem: R$ {despesa:F2}");
        }

        public static void qualMaior()
        {
            string[] linha1 = Console.ReadLine().Split(' ');
            int a = int.Parse(linha1[0]);
            int b = int.Parse(linha1[1]);
            int c = int.Parse(linha1[2]);

            int maiorAB = (a + b + Math.Abs(a - b)) / 2;
            int maiorBC = (b + c + Math.Abs(b - c)) / 2;
            int maiorABC = (maiorAB + maiorBC + Math.Abs(maiorAB - maiorBC)) / 2;

            Console.WriteLine($"{maiorABC} eh o maior");
        }
        public static void volume()
        {
            int r = int.Parse(Console.ReadLine());
            const double pi = 3.14159;
            double circ = (4.0 / 3.0) * pi * Math.Pow(r, 3);
            Console.WriteLine($"VOLUME = {circ:F3}");
        }

        public static void valorAPagar()
        {
            string[] linha1 = Console.ReadLine().Split(' ');
            int codigoPeca1 = int.Parse(linha1[0]);
            int numeroPecas1 = int.Parse(linha1[1]);
            double valorUnitarioPeca1 = double.Parse(linha1[2]);


            string[] linha2 = Console.ReadLine().Split(' ');
            int codigoPeca2 = int.Parse(linha2[0]);
            int numeroPecas2 = int.Parse(linha2[1]);
            double valorUnitarioPeca2 = double.Parse(linha2[2]);


            double valorTotal = (numeroPecas1 * valorUnitarioPeca1) + (numeroPecas2 * valorUnitarioPeca2);

            //// Impressão do resultado formatado
            Console.WriteLine("VALOR A PAGAR: R$ " + valorTotal.ToString("F2"));
        }

        public static void comissaoSalario()
        {
            string nome = Console.ReadLine();
            double valorSal = double.Parse(Console.ReadLine());
            double totalVendas = double.Parse(Console.ReadLine());
            double comissao = (totalVendas * 15) / 100;
            double salFinal = valorSal + comissao;

            Console.WriteLine($"TOTAL = R$ {salFinal:F2}");
        }

        public static void diferencaSoma()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            int diferenca = (a * b - c * d);

            Console.WriteLine($"DIFERENCA = {diferenca}");
        }

        public static void medirArea()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            double x = a + b;

            Console.WriteLine($"X = {x}");

            const double pi = 3.14159;
            x = double.Parse(Console.ReadLine());
            double areaCirculo = pi * Math.Pow(x, 2);
            Console.WriteLine($"A={areaCirculo:F4}");
        }

        public static void medirAreas()
        {
            const double pi = 3.14159;
            string[] linha1 = Console.ReadLine().Split(' ');
            double a = double.Parse(linha1[0]);
            double b = double.Parse(linha1[1]);
            double c = double.Parse(linha1[2]);

            double areaTriangulo = (a * c) / 2;
            double areaCirculo = pi * Math.Pow(c, 2);
            double areaTrapezio = ((a + b) * c) / 2;
            double areaQuadrado = Math.Pow(b, 2);
            double areaRetangulo = a * b;

            Console.WriteLine($"TRIANGULO: {areaTriangulo.ToString("F3")}");
            Console.WriteLine($"CIRCULO: {areaCirculo.ToString("F3")}");
            Console.WriteLine($"TRAPEZIO: {areaTrapezio.ToString("F3")}");
            Console.WriteLine($"QUADRADO: {areaQuadrado.ToString("F3")}");
            Console.WriteLine($"RETANGULO: {areaRetangulo.ToString("F3")}");
        }

        public static void positivoMedia()
        {
            double[] num = new double[6];
            int cont = 0;
            double valor = 0;
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = double.Parse(Console.ReadLine());
                if (num[i] > 0)
                {
                    valor += num[i];
                    cont++;

                }
            }
            double media = valor / cont;
            Console.WriteLine($"{cont} valores positivos");
            Console.WriteLine($"{media:F1}");

        }
        public static void positivoMediaPar()
        {
            double[] num = new double[5];
            int cont = 0;
            double valor = 0;
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = double.Parse(Console.ReadLine());
                if (num[i] % 2 == 0)
                {
                    valor += num[i];
                    cont++;

                }
            }
            double media = valor / cont;
            Console.WriteLine($"{cont} valores pares");

        }
        public static void posNegParesImpares()
        {
            int[] num = new int[5];
            int contPar = 0;
            int contImpar = 0;
            int positivo = 0;
            int negativo = 0;
            int valor = 0;

            for (int i = 0; i < num.Length; i++)
            {
                num[i] = int.Parse(Console.ReadLine());
                if (num[i] % 2 == 0)
                {
                    valor += num[i];
                    contPar++;
                }
                else
                {
                    valor += num[i];
                    contImpar++;
                }
                if (num[i] > 0)
                {
                    valor += num[i];
                    positivo++;
                }
                else if (num[i] < 0)
                {
                    valor += num[i];
                    negativo++;
                }
            }
            Console.WriteLine($"{contPar} valor(es) par(es)");
            Console.WriteLine($"{contImpar} valor(es) impar(es)");
            Console.WriteLine($"{positivo} valor(es) positivo(s)");
            Console.WriteLine($"{negativo} valor(es) negativo(s)");
        }
        public static void numImpares()
        {

            int valor = int.Parse(Console.ReadLine());
            for (int i = 0; i <= valor; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine($"{i}");
                }

            }
        }
        public static void numImparesSeq()
        {
            int num = int.Parse(Console.ReadLine());
            int valor = num + 12;
            for (int i = num; i < valor; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine($"{i}");
                }

            }
        }

        public static void somaImparseq()
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int ret = 0;

            if (num1 > num2)
            {
                int temp = num1;
                num1 = num2;
                num2 = temp;
            }
            for (int i = num1 + 1; i < num2; i++)
            {
                if (i % 2 != 0)
                {
                    ret += i;
                }
            }
            Console.WriteLine(ret);
        }

        public static void intervaloValorDois()
        {
            int n = int.Parse(Console.ReadLine()); // Lê o número de casos de teste

            int dentroIntervalo = 0;
            int foraIntervalo = 0;

            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine()); // Lê o valor X

                if (x >= 10 && x <= 20) // Verifica se x está dentro do intervalo [10, 20]
                {
                    dentroIntervalo++;
                }
                else
                {
                    foraIntervalo++;
                }
            }

            // Imprime os resultados
            Console.WriteLine($"{dentroIntervalo} in");
            Console.WriteLine($"{foraIntervalo} out");




        }

        public static void quadradPares()
        {
            int n = int.Parse(Console.ReadLine());

            //beecrowd deu certo mas é cambiarra deles
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    double res = i * i;
                    Console.WriteLine($"{i}^2 = {res}");
                }
            }
        }

        public static void parImpar()
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            //int[] x;


            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            foreach (int i in arr)
            {
                if (i % 2 != 0 && i < 0)

                {
                    Console.WriteLine("ODD NEGATIVE");
                }
                if (i % 2 == 0 && i < 0)
                {
                    Console.WriteLine("EVEN NEGATIVE");
                }
                if (i % 2 != 0 && i > 0)
                {
                    Console.WriteLine("ODD POSITIVE");
                }
                if (i % 2 == 0 && i > 0)
                {
                    Console.WriteLine("EVEN POSITIVE");
                }
                if (i == 0)
                {
                    Console.WriteLine("NULL");
                }
            }

        }

        public static void restoDois()
        {
            int n = int.Parse(Console.ReadLine());
            int x = 10000;

            for (int i = 0; i <= x; i++)
            {
                if (i % n == 2)
                {
                    Console.WriteLine($"{i}");
                }
            }
        }

        public static void tabuada()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                int res = i * n;
                Console.WriteLine($"{i} x {n} = {res}");
            }
        }

        public static void mediasPonderadas()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] linha = Console.ReadLine().Split();
                double a = double.Parse(linha[0]) * 2;
                double b = double.Parse(linha[1]) * 3;
                double c = double.Parse(linha[2]) * 5;
                double media = (a + b + c) / 10;
                Console.WriteLine($"{media:F1}");
            }
        }

        public static void maiorNum()
        {
            const int tamanhoArray = 100;
            int[] valores = new int[tamanhoArray];
            int maiorValor = int.MinValue;
            int posicaoMaiorValor = -1;

            Random ran = new Random();

            for (int i = 0; i < tamanhoArray; i++)
            {
                valores[i] = ran.Next();
                if (valores[i] > maiorValor)
                {
                    maiorValor = valores[i];
                    posicaoMaiorValor = i;
                }
            }
            Console.WriteLine(maiorValor);
            Console.WriteLine(posicaoMaiorValor);
        }

        public static void experiencias()
        {
            int n = int.Parse(Console.ReadLine());
            int total = 0, coelho = 0, rato = 0, sapo = 0;
            double pCoelho = 0.0;
            double pRato = 0.0;
            double pSapo = 0.0;

            for (int i = 0; i < n; i++)
            {
                string[] arr = Console.ReadLine().Split();
                int valor = int.Parse(arr[0]);
                string sigla = arr[1].ToUpper();
                total += valor;

                if (sigla == "C")
                {
                    coelho += valor;
                }
                else if (sigla == "S")
                {
                    sapo += valor;
                }
                else if (sigla == "R")
                {
                    rato += valor;
                }
            }
            pCoelho = ((double)coelho / total) * 100;
            pSapo = ((double)sapo / total) * 100;
            pRato = ((double)rato / total) * 100;
            Console.WriteLine($"Total: {total} cobaias");
            Console.WriteLine($"Total de coelhos: {coelho}");
            Console.WriteLine($"Total de ratos: {rato}");
            Console.WriteLine($"Total de sapos: {sapo}");
            Console.WriteLine($"Percentual de coelhos: {pCoelho:F2} %");
            Console.WriteLine($"Percentual de ratos: {pRato:F2} %");
            Console.WriteLine($"Percentual de sapos: {pSapo:F2} %");
        }

        public static void gangorra()
        {
            string[] lista = Console.ReadLine().Split(' ');
            int p1 = int.Parse(lista[0]);
            int c1 = int.Parse(lista[1]);
            int p2 = int.Parse(lista[2]);
            int c2 = int.Parse(lista[3]);
            int soma1 = p1 * c1;
            int soma2 = p2 * c2;

            if (soma1 == soma2)
            {
                Console.WriteLine("0");
            }
            else if (soma1 < soma2)
            {
                Console.WriteLine("1");
            }
            else
            {
                Console.WriteLine("-1");
            }
        }

        public static void dez()
        {
            Console.WriteLine("       A");
            Console.WriteLine("      B B");
            Console.WriteLine("     C   C");
            Console.WriteLine("    D     D");
            Console.WriteLine("   E       E");
            Console.WriteLine("    D     D");
            Console.WriteLine("     C   C");
            Console.WriteLine("      B B");
            Console.WriteLine("       A");
        }

        public static void tipoDeCha()
        {
            int t = int.Parse(Console.ReadLine());
            string[] lista = Console.ReadLine().Split();
            int.Parse(lista[0]);
            int.Parse(lista[1]);
            int.Parse(lista[2]);
            int.Parse(lista[3]);
            int.Parse(lista[4]);
            int res = 0;

            foreach (string s in lista)
            {
                Console.WriteLine(s);
                if (t == int.Parse(s))
                {
                    res++;
                }
            }
            if (res != 0)
            {
                Console.WriteLine(res);
            }
            else
            {
                Console.WriteLine("0");
            }
        }

        public static void buscaInternet()
        {
            int t = int.Parse(Console.ReadLine());
            int res = (t + t) * 2;
            Console.WriteLine(res);
        }

        public static void calibrarPneu()
        {
            int bomba = int.Parse(Console.ReadLine());
            int pneu = int.Parse(Console.ReadLine());
            int res = bomba - pneu;
            Console.WriteLine(res);
        }

        public static void sequenciaSecreta()
        {
            int n = int.Parse(Console.ReadLine());
            int v1 = 0, v2 = 0;
            int res = 0;
            for (int i = 1; i <= n; i++)
            {
                v2 = int.Parse(Console.ReadLine());
                if (v1 != v2)
                {
                    res++;
                }
                v1 = v2;
            }

            Console.WriteLine(res);
        }

        public static void tacografo()
        {
            int n = int.Parse(Console.ReadLine());
            int res = 0;
            int resV = 0;

            for (int i = 0; i < n; i++)
            {
                string[] list = Console.ReadLine().Split();
                int t = int.Parse(list[0]);
                int v = int.Parse(list[1]);
                res = t * v;
                resV += res;
            }

            Console.WriteLine(resV);

        }

        public static void notaDaProva()
        {
            int n = int.Parse(Console.ReadLine());
            if (n == 0)
            {
                Console.WriteLine("E");
            }
            else if (n <= 35)
            {
                Console.WriteLine("D");
            }
            else if (n <= 60)
            {
                Console.WriteLine("C");
            }
            else if (n <= 85)
            {
                Console.WriteLine("B");
            }
            else if (n <= 100)
            {
                Console.WriteLine("A");
            }
        }

        public static void contarMandioca()
        {
            int n = 5;
            int curup = 300;
            int boit = 1500;
            int boto = 600;
            int mapi = 1000;
            int iara = 150;
            int chica = 225;
            int soma = 0;

            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (i == 1)
                {
                    soma += num * curup;
                }
                else if (i == 2)
                {
                    soma += num * boit;
                }
                else if (i == 3)
                {
                    soma += num * boto;
                }
                else if (i == 4)
                {
                    soma += num * mapi;
                }
                else if (i == 5)
                {
                    soma += num * iara;
                }
            }
            Console.WriteLine(soma + chica);
        }

        public static void corrida()
        {
            string[] list = Console.ReadLine().Split();
            int c = int.Parse(list[0]);
            int n = int.Parse(list[1]);
            int res = 0;

            if (c < n)
            {
                int temp = c;
                c = n;
                n = temp;
            }

            while (c >= n)
            {
                res = c - n;
                c = res;
            }
            Console.WriteLine(res);
        }

        public static void domino()
        {
            int n = int.Parse(Console.ReadLine());
            int res = ((n + 1) * (n + 2)) / 2;

            Console.WriteLine(res);
        }

        public static void aviaoDePapel()
        {
            string[] list = Console.ReadLine().Split();
            int c = int.Parse(list[0]);
            int p = int.Parse(list[1]);
            int f = int.Parse(list[2]);
            if (c * f <= p)
            {
                Console.WriteLine("S");
            }
            else
            {
                Console.WriteLine("N");
            }
        }

        public static void bobConduite()
        {
            int teste = int.Parse(Console.ReadLine());

            for (int i = 0; i < teste; i++)
            {
                string[] list = Console.ReadLine().Split();
                int r1 = int.Parse(list[0]);
                int r2 = int.Parse(list[1]);
                int res = r1 + r2;
                Console.WriteLine(res);
            }
        }

        public static void feijao()
        {
            string[] list = Console.ReadLine().Split();
            int c1 = int.Parse(list[0]);
            int c2 = int.Parse(list[1]);
            int c3 = int.Parse(list[2]);
            int c4 = int.Parse(list[3]);
            int res = 0;

            for (int i = 1; i <= list.Length; i++)
            {
                if (c1 == 1)
                {
                    res = 1;
                }
                else if (c2 == 1)
                {
                    res = 2;
                }
                else if (c3 == 1)
                {
                    res = 3;
                }
                else if (c4 == 1)
                {
                    res = 4;
                }
            }
            Console.WriteLine(res);
        }

        public static void top()
        {
            int k = int.Parse(Console.ReadLine());
            int saida = 0;
            if (k <= 1)
            {
                saida = 1;
            }
            else if (k <= 3)
            {
                saida = 3;
            }
            else if (k <= 5)
            {
                saida = 5;
            }
            else if (k <= 10)
            {
                saida = 10;
            }
            else if (k <= 25)
            {
                saida = 25;
            }
            else if (k <= 50)
            {
                saida = 50;
            }
            else if (k <= 100)
            {
                saida = 100;
            }
            Console.WriteLine($"Top {saida}");
        }

        public static void truco()
        {
            string[] list = Console.ReadLine().Split();
            int a = int.Parse(list[0]);
            int b = int.Parse(list[1]);
            int res = 0;

            for (int i = 0; i < list.Length; i++)
            {
                if (a >= b)
                {
                    res = a;
                }
                else
                {
                    res = b;
                }
            }
            Console.WriteLine(res);
        }

        public static void qualANota()
        {
            int nota1 = int.Parse(Console.ReadLine());
            int media = int.Parse(Console.ReadLine());
            int nota2 = (media + media) - nota1;

            Console.WriteLine(nota2);
        }

        //sem pedir ajuda primeira vez
        public static void saidaSeis()
        {
            string minhaVar = "AMO FAZER EXERCICIO NO URI";
            Console.WriteLine($"<{minhaVar}>");
            Console.WriteLine($"<{minhaVar,30}>");
            Console.WriteLine($"<{minhaVar.Substring(0, Math.Min(minhaVar.Length, 20)),-20}>");
            Console.WriteLine($"<{minhaVar}>");
            Console.WriteLine($"<{minhaVar,-30}>");
            Console.WriteLine($"<{minhaVar}>");
            Console.WriteLine($"<{minhaVar.Substring(0, Math.Min(minhaVar.Length, 20)),30}>");
            Console.WriteLine($"<{minhaVar.Substring(0, Math.Min(minhaVar.Length, 20)),-30}>");

        }

        public static void eventoXp()
        {
            int x = 0;
            int m = 0;
            int res = 0;

            do
            {
                string[] ent = Console.ReadLine().Split(' ');
                x = int.Parse(ent[0]);
                m = int.Parse(ent[1]);
                res = x * m;
                if (x != 0 && m != 0)
                {
                    Console.WriteLine(res);
                }
            }
            while (x != 0 && m != 0);
        }


    }

    class Teste
    {
        public void extrato()
        {

            string[] valor = Console.ReadLine().Split(' ');
            int n = int.Parse(valor[0]);
            int s = int.Parse(valor[1]);
            int saldo = s;
            int menorValor = saldo;

            for (int i = 0; i < n; i++)
            {
                int entr = int.Parse(Console.ReadLine());

                saldo += entr;

                if (menorValor > saldo)
                {
                    menorValor = saldo;
                }
            }

            Console.WriteLine($"{menorValor}");
        }
    }

    class Nova
    {
        public void novaFun()
        {
            Console.WriteLine("Entramos na função nova.");

            int contIn = 0;
            int contOut = 0;
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if (x >= 10 && x < 20)
                {
                    contIn++;
                }
                else
                {
                    contOut++;
                }
            }

            Console.WriteLine($"{contIn} in");
            Console.WriteLine($"{contOut} out");

            for (int i = 2; i <= 2; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i++);
                }
            }

            string[] p1 = Console.ReadLine().Split(' ');
            string[] p2 = Console.ReadLine().Split(' ');
            double x1 = double.Parse(p1[0]);
            double y1 = double.Parse(p1[1]);
            double x2 = double.Parse(p2[0]);
            double y2 = double.Parse(p2[1]);
            double res = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.WriteLine($"{res:F4}");

        }
    }

}


