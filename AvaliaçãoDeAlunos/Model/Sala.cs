using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaliaçãoDeAlunos.Model
{
	public class Sala
	{
		public string Nome;
		public string Ano;
		public List<Aluno> alunos = new List<Aluno>();

		public Sala(string nome, string ano)
		{
			Nome = nome;
			Ano = ano;
		}
	}
}
