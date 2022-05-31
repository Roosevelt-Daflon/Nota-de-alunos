using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AvaliaçãoDeAlunos.Model;

namespace AvaliaçãoDeAlunos
{
	public partial class AdicionarTurma : Form
	{
		List<TextBox> TextBoxes = new List<TextBox>();
		int Ypos = 20;
		public AdicionarTurma()
		{
			InitializeComponent();
			panel1.AutoScroll = true;
		}

		private void Add_Click(object sender, EventArgs e)
		{
			TextBox t = new TextBox();
			Label l = new Label();
			l.Text = "Aluno: ";
			t.Location = new Point(50, (TextBoxes.Count == 0)? 20: TextBoxes[TextBoxes.Count-1].Location.Y + 25);
			l.Location = new Point(10, t.Location.Y);
			t.Width = 350;
			TextBoxes.Add(t);
			panel1.Controls.Add(t);
			panel1.Controls.Add(l);
			panel1.Show();
		}

		private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
		{

		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void Finalize_Click(object sender, EventArgs e)
		{
			Sala sala = new Sala(textBox1.Text, textBox2.Text);
			foreach(var i in TextBoxes)
			{
				sala.alunos.Add(new Aluno(i.Text));
			}
			AdicionarEscola.Current.Escola.Salas.Add(sala);
			AdicionarEscola.Current.UpdatePainel();
			this.Close();
		}

		private void AdicionarTurma_Load(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}
	}
}
