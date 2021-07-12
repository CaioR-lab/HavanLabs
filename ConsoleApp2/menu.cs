using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
namespace Menu
{
    public class menu
    {

        public void cabecalho()
        {
            Console.WriteLine("*************************bem vindo***************************");
        }

        public void rodape ()
        {
            Console.WriteLine("*************************************************************");
        }

        private static void Escolha()
        {
            int opcao = 0;
            do
            {
                opcao = Validacao.ValidarInteiro();
                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("Tchau");
                        break;
                    case 1:
                        string resposta = "";
                        List<Usuario> usuarios = new List<Usuario>();
                        do
                        {
                            Usuario user = new Usuario();
                            user.Cadastro();
                            Console.WriteLine("Deseja cadastrar mais 1?(y/n)");
                            resposta = Console.ReadLine();

                            usuarios.Add(user);
                        } while (resposta == "y");

                        foreach (var item in usuarios)
                        {
                            Console.WriteLine($"Usuario -\n nome:{item.nome.ToLower()}\n sobrenome:{item.sobrenome.ToLower()}\n idade:{item.idade}\n email:{item.email.ToLower()}\n end:{item.endereco}\n");
                        }

                        break;
                    case 2:
                        Console.WriteLine("Em implementacao (falta dev)");
                        break;
                    default:
                        Console.WriteLine("Opcao invalida! Digite 0,1,2");
                        break;
                }

            } while (opcao < 0 || opcao > 2);
        }
    }
}
