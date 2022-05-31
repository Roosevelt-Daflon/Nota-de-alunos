
namespace AvaliaçãoDeAlunos
{
	partial class Main
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
			this.Add = new System.Windows.Forms.Button();
			this.Load = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// Add
			// 
			this.Add.Location = new System.Drawing.Point(12, 12);
			this.Add.Name = "Add";
			this.Add.Size = new System.Drawing.Size(200, 72);
			this.Add.TabIndex = 0;
			this.Add.Text = "Adicionar";
			this.Add.UseVisualStyleBackColor = true;
			this.Add.Click += new System.EventHandler(this.Add_Click);
			// 
			// Load
			// 
			this.Load.Location = new System.Drawing.Point(224, 12);
			this.Load.Name = "Load";
			this.Load.Size = new System.Drawing.Size(200, 72);
			this.Load.TabIndex = 1;
			this.Load.Text = "Carregar";
			this.Load.UseVisualStyleBackColor = true;
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(436, 96);
			this.Controls.Add(this.Load);
			this.Controls.Add(this.Add);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Name = "Main";
			this.Text = "Main";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button Add;
		private System.Windows.Forms.Button Load;
	}
}