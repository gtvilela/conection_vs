using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    class Pessoa
    {
        protected string Nome;
        protected string Email;

        public void SetNome(string Nome)
        {
            this.Nome = Nome;
        }

        public string GetNome()
        {
            return Nome;
        }

        public void SetEmail(string Email)
        {
             if (Email.Contains("@"))
                this.Email = Email;
        }

        public string GetEmail()
        {
            return Email;
        }

        public Pessoa(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }

     
    }

   

    class Aluno : Pessoa
    {
        protected int RA;

        public Aluno(int RA, string Nome, string Email):base(Nome, Email)
        {
            this.RA = RA;
            this.Nome = Nome;
            this.Email = Email;
        }

    }

    class Livro 
    {
        protected string Titulo;
        protected string Genero;
        protected string Autor;

       public Livro(string Titulo, string Genero, string Autor)
        {
            this.Titulo = Titulo;
            this.Genero = Genero;
            this.Autor = Autor;
        }

        public Livro()
        {

        }

        public void SetTitulo(string Titulo)
        {
            this.Titulo = Titulo;
        }

        public string GetTitulo()
        {
            return Titulo;
        }

        public void SetGenero(string Genero)
        {
            this.Genero = Genero;
        }

        public string GetGenero()
        {
            return Genero;
        }

        public void SetAutor(string Autor)
        {
            this.Autor = Autor;
        }

        public string GetAutor()
        {
            return Autor;
        }

    }

    class Emprestimo
    {
        public Aluno Aluno;
        public Livro Livro;

        public string Exibir()
        {
            return Aluno.GetNome() + " " + Livro.GetTitulo();
        }

    }

    class Atraso:Emprestimo
    {
        protected int NumDias;

        public Atraso(Aluno Aluno, Livro Livro, int NumDias):base()
        {
            this.NumDias = NumDias;
        }

        public void SetNumDias(int NumDias)
        {
            this.NumDias = NumDias;
        }

        public int GetNumDias()
        {
            return NumDias;
        }

        public new string Exibir()
        {
            return Aluno.GetNome() + ", " + Livro.GetTitulo() + ", " + GetNumDias();
        }
    }

}