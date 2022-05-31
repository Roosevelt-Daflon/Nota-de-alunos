using System.Collections.Generic;

namespace AvaliaçãoDeAlunos.Model
{
	public class Aluno
	{
		public string Nome;
		public List<Competencia> Competencias = new List<Competencia>();

		public Aluno(string nome) 
		{
			Nome = nome;
			Competencias.Add(new Competencia("INTERESSE"));
			Competencias.Add(new Competencia("CONCENTRAÇÃO"));
			Competencias.Add(new Competencia("PROFICIENCIA NA LEITURA PARA EXECUÇÃO DAS ATIVIDADES"));
			Competencias.Add(new Competencia("EXECUÇÃO DAS ATIVIDADES"));
			Competencias.Add(new Competencia("TRABALHA COLABORATIVAMENTE"));
			Competencias.Add(new Competencia("COMPREENDE OS COMANDOS"));


		}
	}
}