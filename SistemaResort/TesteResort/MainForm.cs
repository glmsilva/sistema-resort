/*
 * Created by SharpDevelop.
 * User: dell i5
 * Date: 15/11/2018
 * Time: 23:59
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TesteResort
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Button1Click(object sender, EventArgs e)
		{	
			
			
			int nCad = 0;
			bool achou = false;
			if(textBox1.Text == ""){
				MessageBox.Show("Insira um nome de Usuário");
				if(textBox2.Text == ""){
					MessageBox.Show("Insira uma Senha válida");
				}
			}
				
				foreach(string linha in richTextBox1.Lines)
				{
					
					string[] campos = linha.Split('\t');
					if((campos[0] == textBox1.Text) && (campos[1] == textBox2.Text) && (campos[3] == "Gerente")){
					
						
						achou = true;
						break;
					}
					nCad++;
				
				}
				
				
				bool achou2 = false;
				foreach(string linha in richTextBox1.Lines)
				{
					
					string[] campos = linha.Split('\t');
					if((campos[0] == textBox1.Text) && (campos[1] == textBox2.Text) && (campos[3] == "Colaborador")){
					
						
						achou2 = true;
						break;
					}
					nCad++;
				
				}
				if (achou2)
                {
                    Form1 ini = new Form1();
					ini.ShowDialog();
            }
            if (achou)
            {
                Form2 ger = new Form2();
                ger.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuário não cadastrado");
            }


            /*else{
                MessageBox.Show("Usuário não cadastrado");
            }*/




        }
		void BtnSairClick(object sender, EventArgs e)
		{
			this.Dispose();
		}
		void Label7Click(object sender, EventArgs e)
		{
			CadUser cadUser = new CadUser();
			cadUser.ShowDialog();
		}
		void MainFormLoad(object sender, EventArgs e)
		{
			CadUser cadUser = new CadUser();
			try {
				richTextBox1.LoadFile("logins.txt");
			
			} catch (Exception erro){
				
			}
		}
	}
}
