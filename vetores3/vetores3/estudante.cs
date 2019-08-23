using System;
using System.Collections.Generic;
using System.Text;

namespace vetores3
{
    public class Estudante
    {

        public string Nome;
        public string Email;
        public int Numero;

        public Estudante(string nome, string email, int numero)
        {
            Nome = nome;
            Email = email;
            Numero = numero;
        }

        public Estudante()
        {

        }
    }
}
