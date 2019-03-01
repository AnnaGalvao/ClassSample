using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSample //unidade organizacional de classes
{
    class Program //classe basica. a classe representa diferentes estruturas - composta de metoros atributos e propriedades
    {
        static void Main(string[] args)
        {
            Aluno a1 = new Aluno(); // instanciando o objeto na memória
           
            a1.Nome = "Pedro";
            a1.Idade = 30;

            Aluno a2 = new Aluno();
            a2.Nome = "Lauro";
            a2.Idade = 18;

            Console.ReadKey();


        }
    }
}
