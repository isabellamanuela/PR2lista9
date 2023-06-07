using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR2lista9
{
    internal class Program
    {
        static void Main(string[] args)
        { 


namespace _24_05_2023
    {
        internal class Program
        {
            public static void Exercicio1()
            {
                float media = 0;
                int[] vetor2;
                Console.WriteLine("Escreva o tamanho");
                int q = int.Parse(Console.ReadLine());

                vetor2 = new int[q];
                Random rand = new Random();
                for (int p = 0; p < q; p++)
                {
                    vetor2[p] = rand.Next(10, 50);
                }
                for (int p = 0; p < q; p++)
                {
                    Console.WriteLine("Posição [{0}] = {1}", p, vetor2[p]);
                    media = vetor2[p] + media;
                }
                media = media / (float)q;

                Console.WriteLine("A média é " + media);

                Console.ReadKey();
            }

            public static void Exercicio2()
            {
                int[] vetor2;
                Console.WriteLine("digite o tamanho");
                int q = int.Parse(Console.ReadLine());

                vetor2 = new int[q];
                Random rand = new Random();

                for (int p = 0; p < q; p++)
                {
                    vetor2[p] = rand.Next(10, 50);
                }
                int somap = 0;
                int somai = 0;
                for (int p = 0; p < q; p++)
                {
                    Console.WriteLine("Posição [{0}] = {1}", p, vetor2[p]);
                    if (vetor2[p] % 2 == 0)
                    {
                        somap += vetor2[p];
                    }
                    else
                    {
                        somai += vetor2[p];
                    }
                }
                Console.WriteLine("A soma dos pares é: " + somap);
                Console.WriteLine("A soma dos impares é: " + somai);
                Console.ReadKey();

            }

            public static void Exercicio3()
            {
                int[] vetor2;
                Console.WriteLine("escreva o tamanho");
                int q = int.Parse(Console.ReadLine());

                vetor2 = new int[q];
                Random aleatorio = new Random();

                for (int p = 0; p < q; p++)
                {
                    vetor2[p] = aleatorio.Next(10, 50);
                }

                for (int p = 0; p < q; p++)
                {
                    Console.WriteLine("Posição [{0}] = {1}", p, vetor2[p]);

                }

                Console.WriteLine();
                for (int p = q - 1; p >= 0; p--)
                {
                    Console.WriteLine("Posição [{0}] = {1}", p, vetor2[p]);
                }

            }

            public static void Exercicio4()
            {
                float media = 0;
                int[] vetor2;
                Console.WriteLine("Digite o tamanho");
                int q = int.Parse(Console.ReadLine());

                vetor2 = new int[q];
                Random rand = new Random();

                for (int p = 0; p < q; p++)
                {
                    vetor2[p] = rand.Next(10, 50);


                }
                for (int p = 0; p < q; p++)
                {
                    Console.WriteLine("posição [{0}] = {1}", p, vetor2[p]);
                    if (vetor2[p] % 3 == 0 && vetor2[p] % 5 == 0)
                    {
                        media = vetor2[p] + media;
                    }


                }

                media = media / (float)q;
                Console.WriteLine(" media aridimentica é" + media);

                Console.ReadKey();
            }

            static void Main(string[] args)
            {
                int opção;

                do
                {
                    Console.WriteLine("----Menu----");
                    Console.WriteLine("escreva o numero do exercíco para ser testado");
                    Console.WriteLine("(Selecione um número de 1 à 4 ou 0 para cancelar)");

                    opção = int.Parse(Console.ReadLine());

                    switch (opção)
                    {
                        case 0:
                            Console.WriteLine("Obrigado por ter usado meu programa!");
                            break;

                        case 1:
                            Exercicio1();
                            break;

                        case 2:
                            Exercicio2();
                            break;

                        case 3:
                            Exercicio3();
                            break;

                        case 4:
                            Exercicio4();
                            break;
                    }
                }
                while (opção != 0);

            }
        }
    }



}
    }
}
