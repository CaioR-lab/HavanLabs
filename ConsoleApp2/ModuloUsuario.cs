using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace ConsoleApp2
{
    class ModuloUsuario
    {
        UsuarioRepository repository = new UsuarioRepository();
        public void Create()
        {
            string resposta = "";

            do
            {
                Console.Write("Digite o nome:");
                string nome = Validacao.ValidarStringEmBranco();
                Console.Write("Digite o sobrenome:");
                string sobrenome = Validacao.ValidarStringEmBranco();
                Console.Write("Digite o idade:");
                int idade = Validacao.ValidarInteiro();
                Console.Write("Digite o email:");
                string email = Validacao.ValidarStringEmBranco();
                Console.Write("Digite o endereco:");
                string endereco = Validacao.ValidarStringEmBranco();

                Usuario model = new Usuario(nome, sobrenome, idade, email, endereco);
                repository.Create(model);
                Console.WriteLine("Deseja cadastrar mais 1?(y/n)");
                resposta = Console.ReadLine();

            } while (resposta == "y");
        }
    }
}
