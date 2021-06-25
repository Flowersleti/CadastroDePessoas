using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroDePessoas.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string CPF { get; set; }
        public DateTime DataNascimento { get; set; }
        public enum Genero { };
        public Endereco Endereco { get; set; }
    }
}
