using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    internal class Aluno
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public int RM { get; set; }

        public Aluno(string nome, string email, int rm)
        {
            Nome = nome;
            Email = email;
            RM = rm;
        }
    }
}
