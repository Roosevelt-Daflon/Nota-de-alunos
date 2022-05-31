using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AvaliaçãoDeAlunos
{
	public partial class Main : Form
	{
		public Main()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{

		}

		private void Add_Click(object sender, EventArgs e)
		{
			AdicionarEscola addEscola = new AdicionarEscola();
			addEscola.ShowDialog();
		}
	}
}
