
namespace AvaliaçãoDeAlunos
{
	partial class AdicionarTurma
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.panel1 = new System.Windows.Forms.Panel();
			this.Add = new System.Windows.Forms.Button();
			this.Finalize = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
			this.panel1.Location = new System.Drawing.Point(12, 49);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(476, 516);
			this.panel1.TabIndex = 0;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// Add
			// 
			this.Add.Location = new System.Drawing.Point(413, 571);
			this.Add.Name = "Add";
			this.Add.Size = new System.Drawing.Size(75, 23);
			this.Add.TabIndex = 0;
			this.Add.Text = "Adicionar";
			this.Add.UseVisualStyleBackColor = true;
			this.Add.Click += new System.EventHandler(this.Add_Click);
			// 
			// Finalize
			// 
			this.Finalize.Location = new System.Drawing.Point(12, 571);
			this.Finalize.Name = "Finalize";
			this.Finalize.Size = new System.Drawing.Size(75, 23);
			this.Finalize.TabIndex = 1;
			this.Finalize.Text = "Finalizar";
			this.Finalize.UseVisualStyleBackColor = true;
			this.Finalize.Click += new System.EventHandler(this.Finalize_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(93, 18);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(127, 20);
			this.textBox1.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(75, 24);
			this.label1.TabIndex = 3;
			this.label1.Text = "Turma: ";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(226, 13);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(55, 24);
			this.label2.TabIndex = 4;
			this.label2.Text = "Ano: ";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(287, 17);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(127, 20);
			this.textBox2.TabIndex = 5;
			// 
			// AdicionarTurma
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(503, 606);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.Finalize);
			this.Controls.Add(this.Add);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Name = "AdicionarTurma";
			this.Text = "AdicionarTurma";
			this.Load += new System.EventHandler(this.AdicionarTurma_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button Add;
		private System.Windows.Forms.Button Finalize;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox2;
	}
}