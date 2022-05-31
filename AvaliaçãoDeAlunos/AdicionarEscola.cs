using AvaliaçãoDeAlunos.Model;
using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace AvaliaçãoDeAlunos
{
	public partial class AdicionarEscola : Form
	{
		public static AdicionarEscola Current;
		public Escola Escola = new Escola();

		public AdicionarEscola()
		{
			InitializeComponent();
			Current = this;
			panel1.AutoScroll = true;
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			Escola.Nome = textBox1.Text;
		}

		private void AdicionarEscola_Load(object sender, EventArgs e)
		{

		}

		public void UpdatePainel() 
		{
			groupBox1.Controls.Clear();
			List<Label> labels = new List<Label>();
			foreach(var i in Escola.Salas) 
			{
				Label l = new Label();
				l.Width = 550;
				l.Text = "Turma: " + i.Nome + " Ano: " + i.Ano + " Total Alunos: " + i.alunos.Count;
				l.Location = new Point(20, (labels.Count == 0) ? 20 : labels[labels.Count - 1].Location.Y + 25);
				groupBox1.Controls.Add(l);
				labels.Add(l);
			}
			groupBox1.Show();
		}

		private void Add_Click(object sender, EventArgs e)
		{
			AdicionarTurma addTurma = new AdicionarTurma();
			addTurma.ShowDialog();
		}

		private void Complete_Click(object sender, EventArgs e)
		{
			string filePath = System.IO.Directory.GetCurrentDirectory() + "\\" + Escola.Nome+".xlsx";
			if (File.Exists(filePath)) File.Delete(filePath);

			using (var workBook = new XLWorkbook()) 
			{
				
				foreach (var i in Current.Escola.Salas) 
				{
					var planilha = workBook.Worksheets.Add(i.Nome);
					int line = 2;
					
					GenerateHeader(planilha);
					foreach(var j in i.alunos) 
					{
						planilha.Cell("A" + line).Value = j.Nome;
						line++;
					}
					planilha.Columns().AdjustToContents();
				}
				workBook.SaveAs(filePath);
			}
			this.Close();
		}

		static void GenerateHeader(IXLWorksheet worksheet) 
		{
			worksheet.Cell("A1").Value = "ALUNO";
			worksheet.Cell("C1").Value = "INTERESSE";
			worksheet.Cell("D1").Value = "CONCENTRAÇÃO";
			worksheet.Cell("E1").Value = "PROFICIENCIA NA LEITURA PARA EXECUÇÃO DAS ATIVIDADES";
			worksheet.Cell("F1").Value = "EXECUÇÃO DAS ATIVIDADES";
			worksheet.Cell("G1").Value = "TRABALHA COLABORATIVAMENTE";
			worksheet.Cell("H1").Value = "COMPREENDE OS COMANDOS";

		}
	}
}
