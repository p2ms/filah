using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class paciente : Sintoma
    {

       public string nome;
       public  string endereco;
       int [] sintomas = new int[10]; //escolhas entre opções
        /*
         criar vetores, assim como a ultima atv
         cada letra deve representar um numero no vetor 
         g - 3
         m - 2
         f - 1
             */


        public void cadastro(){

            Console.WriteLine("Escreva seu nome:");
            nome = Console.ReadLine();
            Console.WriteLine("Escreva seu endereço:");
            endereco = Console.ReadLine();
        }


        public void mostrar()
        {
            Console.WriteLine("paciente: " + nome);
            Console.WriteLine("endereço: " + endereco);
            Console.WriteLine("situação: " + sintomas);
        }
    }
}
