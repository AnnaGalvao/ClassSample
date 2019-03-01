using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSample
{
    public class Aluno
    {
        public Aluno()
        {
            Console.WriteLine("Aluno constructor"); // construtor
        }

        public Aluno (string _nome, int _idade)
        {
            this.nome = _nome;
            this.idade = _idade;

        }
        //Fields
        private string nome;
        private int idade;

        //Properties
        public string Nome
        {
            get // busca info de fora
            {
                return nome;
            }
            set // seta a informação
            {
                nome = value;
            }

        }
                
        public int Idade
        {
            get
            {
                return idade;
            }
            set
            {
                idade = value;
            }

        }

        //metodo - tudo aquilo que representa uma ação
       public void Limpar(){
            this.idade = 0;
            this.nome = string.Empty;
        }

        ~Aluno()
        {
            Console.WriteLine("Aluno destructor");
        }

    }
}
