﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Data
{
    public class Usuario
    {
        //encapulamento - propriedades
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public int Idade { get; set; }

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
        public Usuario()
        {

        }
    }
}