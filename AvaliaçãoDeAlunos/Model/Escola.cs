using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaliaçãoDeAlunos.Model
{
	public class Escola
	{
		public string Nome;
		public List<Sala> Salas = new List<Sala>();
	}
}
