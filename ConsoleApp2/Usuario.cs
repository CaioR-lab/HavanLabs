using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace Programa
{
    class Usuario
    {
        public string nome = String.Empty;
        public string sobrenome = String.Empty;
        public string email = String.Empty;
        public string endereco = String.Empty;
        public int idade = 0;

        public void Cadastro()
        {

            Console.WriteLine("Insira seu nome");
            this.nome = Validacao.ValidarStringEmBranco();
            Console.WriteLine("Insira seu sobrenome");
            this.sobrenome = Validacao.ValidarStringEmBranco();
            Console.WriteLine("Insira seu email");
            this.email = Validacao.ValidarStringEmBranco();
            Console.WriteLine("Insira seu endereço");
            this.endereco = Validacao.ValidarStringEmBranco();
            Console.WriteLine("Insira sua idade");
            this.idade = Validacao.ValidarInteiro();
        }
    }
}