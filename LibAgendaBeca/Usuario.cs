using System;
using System.Globalization;

namespace LibAgendaBeca
{
    public class Usuario
    {
		public string Nome { get; set; }
		public double Altura { get; set; }
		public int Idade { get; set; }

		public Usuario(string nome, double altura, int idade)
        {
			Nome = nome;
			Altura = altura;
			Idade = idade;
        }

		public string DadosUsuario()
		{
			return $"Nome: {Nome}, Idade: {Idade}, Altura: {Altura.ToString("F2", CultureInfo.InvariantCulture)}";
		}
	}
}
