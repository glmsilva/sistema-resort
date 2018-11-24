/*
 * Created by SharpDevelop.
 * User: dell i5
 * Date: 16/11/2018
 * Time: 05:15
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace TesteResort
{
	partial class Form1
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button btnCkot;
		private System.Windows.Forms.Button btnRes;
		private System.Windows.Forms.Button btnEx;
		private System.Windows.Forms.Button btnPac;
		private System.Windows.Forms.Button btnQrt;
		private System.Windows.Forms.Button btnHome;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel pnClick;
		private System.Windows.Forms.Button btnSair;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel4;
		private TesteResort.ControleReserva controleReserva1;
		private TesteResort.UserControl2 userControl21;
		
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnClick = new System.Windows.Forms.Panel();
            this.btnCkot = new System.Windows.Forms.Button();
            this.btnEx = new System.Windows.Forms.Button();
            this.btnPac = new System.Windows.Forms.Button();
            this.btnQrt = new System.Windows.Forms.Button();
            this.btnRes = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.userControl21 = new TesteResort.UserControl2();
            this.controleReserva1 = new TesteResort.ControleReserva();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSair);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1000, 53);
            this.panel2.TabIndex = 1;
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSair.BackColor = System.Drawing.Color.White;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(946, 4);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(52, 47);
            this.btnSair.TabIndex = 10;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.BtnSairClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(134)))), ((int)(((byte)(179)))));
            this.panel1.Controls.Add(this.pnClick);
            this.panel1.Controls.Add(this.btnCkot);
            this.panel1.Controls.Add(this.btnEx);
            this.panel1.Controls.Add(this.btnPac);
            this.panel1.Controls.Add(this.btnQrt);
            this.panel1.Controls.Add(this.btnRes);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 749);
            this.panel1.TabIndex = 0;
            // 
            // pnClick
            // 
            this.pnClick.BackColor = System.Drawing.Color.Gold;
            this.pnClick.Location = new System.Drawing.Point(0, 141);
            this.pnClick.Name = "pnClick";
            this.pnClick.Size = new System.Drawing.Size(10, 69);
            this.pnClick.TabIndex = 3;
            // 
            // btnCkot
            // 
            this.btnCkot.FlatAppearance.BorderSize = 0;
            this.btnCkot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCkot.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCkot.ForeColor = System.Drawing.Color.White;
            this.btnCkot.Image = ((System.Drawing.Image)(resources.GetObject("btnCkot.Image")));
            this.btnCkot.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCkot.Location = new System.Drawing.Point(14, 471);
            this.btnCkot.Name = "btnCkot";
            this.btnCkot.Size = new System.Drawing.Size(185, 68);
            this.btnCkot.TabIndex = 8;
            this.btnCkot.Text = "Check-out";
            this.btnCkot.UseVisualStyleBackColor = true;
            this.btnCkot.Click += new System.EventHandler(this.BtnCkotClick);
            // 
            // btnEx
            // 
            this.btnEx.FlatAppearance.BorderSize = 0;
            this.btnEx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEx.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEx.ForeColor = System.Drawing.Color.White;
            this.btnEx.Image = ((System.Drawing.Image)(resources.GetObject("btnEx.Image")));
            this.btnEx.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEx.Location = new System.Drawing.Point(14, 389);
            this.btnEx.Name = "btnEx";
            this.btnEx.Size = new System.Drawing.Size(185, 68);
            this.btnEx.TabIndex = 6;
            this.btnEx.Text = "Extras";
            this.btnEx.UseVisualStyleBackColor = true;
            this.btnEx.Click += new System.EventHandler(this.BtnExClick);
            // 
            // btnPac
            // 
            this.btnPac.FlatAppearance.BorderSize = 0;
            this.btnPac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPac.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPac.ForeColor = System.Drawing.Color.White;
            this.btnPac.Image = ((System.Drawing.Image)(resources.GetObject("btnPac.Image")));
            this.btnPac.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPac.Location = new System.Drawing.Point(14, 553);
            this.btnPac.Name = "btnPac";
            this.btnPac.Size = new System.Drawing.Size(185, 68);
            this.btnPac.TabIndex = 5;
            this.btnPac.Text = "Pacotes";
            this.btnPac.UseVisualStyleBackColor = true;
            this.btnPac.Click += new System.EventHandler(this.BtnPacClick);
            // 
            // btnQrt
            // 
            this.btnQrt.FlatAppearance.BorderSize = 0;
            this.btnQrt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQrt.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQrt.ForeColor = System.Drawing.Color.White;
            this.btnQrt.Image = ((System.Drawing.Image)(resources.GetObject("btnQrt.Image")));
            this.btnQrt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQrt.Location = new System.Drawing.Point(13, 314);
            this.btnQrt.Name = "btnQrt";
            this.btnQrt.Size = new System.Drawing.Size(185, 68);
            this.btnQrt.TabIndex = 4;
            this.btnQrt.Text = "Quartos";
            this.btnQrt.UseVisualStyleBackColor = true;
            this.btnQrt.Click += new System.EventHandler(this.Button2Click);
            // 
            // btnRes
            // 
            this.btnRes.FlatAppearance.BorderSize = 0;
            this.btnRes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRes.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRes.ForeColor = System.Drawing.Color.White;
            this.btnRes.Image = ((System.Drawing.Image)(resources.GetObject("btnRes.Image")));
            this.btnRes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRes.Location = new System.Drawing.Point(14, 225);
            this.btnRes.Name = "btnRes";
            this.btnRes.Size = new System.Drawing.Size(185, 68);
            this.btnRes.TabIndex = 7;
            this.btnRes.Text = "Reserva";
            this.btnRes.UseVisualStyleBackColor = true;
            this.btnRes.Click += new System.EventHandler(this.BtnResClick);
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(14, 143);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(185, 68);
            this.btnHome.TabIndex = 3;
            this.btnHome.Text = "Ínicio";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.Button1Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(134)))), ((int)(((byte)(179)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 140);
            this.panel3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(23, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "LOGO";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(46, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cliente";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(134)))), ((int)(((byte)(179)))));
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(200, 53);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1000, 87);
            this.panel4.TabIndex = 3;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel4Paint);
            // 
            // userControl21
            // 
            this.userControl21.BackColor = System.Drawing.Color.White;
            this.userControl21.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userControl21.Location = new System.Drawing.Point(200, 141);
            this.userControl21.Margin = new System.Windows.Forms.Padding(6);
            this.userControl21.Name = "userControl21";
            this.userControl21.Size = new System.Drawing.Size(1000, 595);
            this.userControl21.TabIndex = 4;
            // 
            // controleReserva1
            // 
            this.controleReserva1.BackColor = System.Drawing.Color.White;
            this.controleReserva1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controleReserva1.Location = new System.Drawing.Point(210, 148);
            this.controleReserva1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.controleReserva1.Name = "controleReserva1";
            this.controleReserva1.Size = new System.Drawing.Size(1000, 588);
            this.controleReserva1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 749);
            this.Controls.Add(this.userControl21);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.controleReserva1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

		}
	}
}
