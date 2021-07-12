using System;

namespace User
{
    class Usuario
    {
        //encapulamento - propriedades
        private string Nome { get; set; }
        private string Sobrenome { get; set; }
        private string Email { get; set; }
        private int Idade { get; set; }

        public string Endereco { get; set; }

        //Construtor
        public Usuario(string nome, string sobrenome, int idade, string email, string endereco)
        {
            this.Nome = nome;
            this.Sobrenome = sobrenome;
            this.Email = email;
            this.Endereco = endereco;
            this.Idade = idade;
        }
    }
}