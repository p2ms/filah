using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Sintoma
    {
        public int[] sintomas = new int[10];

        public void nivel(string[] arg)
        {
            Console.WriteLine("De 1 a 5, quanto a situação é grave?"); //A situação é grave (g), média (m) ou fraca(f)?
            sintomas = int.Parse(Console.ReadLine()); //comando para::
        }

    }
}
