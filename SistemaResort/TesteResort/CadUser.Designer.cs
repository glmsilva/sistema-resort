/*
 * Created by SharpDevelop.
 * User: dell i5
 * Date: 23/11/2018
 * Time: 01:04
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace TesteResort
{
	partial class CadUser
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Label label7;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(23, 60);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(133, 28);
			this.label1.TabIndex = 0;
			this.label1.Text = "Novo Login:";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(23, 87);
			this.textBox1.Margin = new System.Windows.Forms.Padding(4);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(132, 23);
			this.textBox1.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(25, 122);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Nova Senha:";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(24, 150);
			this.textBox2.Margin = new System.Windows.Forms.Padding(4);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(132, 23);
			this.textBox2.TabIndex = 3;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(134)))), ((int)(((byte)(179)))));
			this.panel1.Controls.Add(this.label7);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(345, 40);
			this.panel1.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(191, 59);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(131, 23);
			this.label3.TabIndex = 5;
			this.label3.Text = "Função Usuário:";
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
			"Colaborador",
			"Gerente"});
			this.comboBox1.Location = new System.Drawing.Point(191, 88);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(131, 24);
			this.comboBox1.TabIndex = 6;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(190, 150);
			this.textBox3.Margin = new System.Windows.Forms.Padding(4);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(132, 23);
			this.textBox3.TabIndex = 8;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(191, 122);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(121, 23);
			this.label4.TabIndex = 7;
			this.label4.Text = "E-mail Usuário:";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(134)))), ((int)(((byte)(179)))));
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.Location = new System.Drawing.Point(75, 212);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(174, 45);
			this.button1.TabIndex = 10;
			this.button1.Text = "Cadastrar";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(152, 186);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(28, 21);
			this.label5.TabIndex = 11;
			this.label5.Text = "0";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(25, 186);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(130, 23);
			this.label6.TabIndex = 12;
			this.label6.Text = "Usuários Cadastrados:";
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(256, 182);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(77, 77);
			this.richTextBox1.TabIndex = 13;
			this.richTextBox1.Text = "";
			this.richTextBox1.Visible = false;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.White;
			this.label7.Location = new System.Drawing.Point(112, 9);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 31);
			this.label7.TabIndex = 1;
			this.label7.Text = "Registrar";
			// 
			// CadUser
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(345, 269);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "CadUser";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "CadUser";
			this.Load += new System.EventHandler(this.CadUserLoad);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
