using System;
using System.Collections.Generic;
using System.Text;

namespace Aula03.Models.pj
{
    public class Pessoa
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }

        public override string ToString()
        {
            return $"{Id}-{Nome}";
        }

        public Pessoa(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }
    }
}
