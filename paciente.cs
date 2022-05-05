using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Paciente
    {
        int i;
        int e;
        int aux;
        string f; // f de fila
        string p; //p de  pergunta
        public string nome;
        public string endereco;
        public int[] Sintomas = new int[10]; //escolhas entre opções
                                      /*
                                       criar vetores, assim como a ultima atv
                                       cada letra deve representar um numero no vetor 
                                       g - 3
                                       m - 2
                                       f - 1
                                           */
       

        public void cadastro()
        {

            for (i= 0;i<=9; i++)
            {
            Console.WriteLine("Escreva seu nome:");
            nome = Console.ReadLine();
            Console.WriteLine("Escreva seu endereço:");
            endereco = Console.ReadLine();
            Console.WriteLine("De 1 a 5, quanto a situação é grave?");
            Sintomas[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("Deseja fazer outro cadastro? [s/n]");
                p = Console.ReadLine();
                if (p == "s")
                {

                }else if(p == "n")
                {
                    i = 10;
                    Console.WriteLine("Deseja ver a fila? [s/n]");
                    f = Console.ReadLine();
                    if(f == "s")
                    {
                        Console.WriteLine("Lista atual:");
                        priori();
                    }else if (f == "n")
                    {

                    }
                }
            }
        }



        public void priori()
        {
            for (e = 0; e < 10; e++)
            {
                for (i = 0; i < 10; i++)
                {
                    if (Sintomas[i] < Sintomas[e])
                    {
                        aux = Sintomas[i];
                        Sintomas[i] = Sintomas[e];
                        Sintomas[e] = aux;
                    }
                }
            }

            for (i=0;i<=9;i++)
            {
                Console.WriteLine("Paciente: " + nome + Sintomas[i]);
            }
        }


        public void mostrar()
        {
            Console.WriteLine("paciente: " + nome);
            Console.WriteLine("endereço: " + endereco);
            Console.WriteLine("situação: " + Sintomas);
        }
    }
}
