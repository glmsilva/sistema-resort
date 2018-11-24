/*
 * Created by SharpDevelop.
 * User: dell i5
 * Date: 23/11/2018
 * Time: 01:04
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace TesteResort
{
	/// <summary>
	/// Description of CadUser.
	/// </summary>
	public partial class CadUser : Form
	{
		public CadUser()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void CadUserLoad(object sender, EventArgs e)
		{
			try {
				richTextBox1.LoadFile("logins.txt");
			
			} catch (Exception erro){
				
			}
			
			label5.Text = richTextBox1.Lines.Length.ToString();
		}
		
		public static class LoginInfo
		{
			public static string userLogin = "";
    		
		}
		
		void Button1Click(object sender, EventArgs e)
		{
	
			label5.Text = richTextBox1.Lines.Length.ToString();
			CadUser.LoginInfo.userLogin = textBox1.Text + '\t' + textBox2.Text + '\t' + textBox3.Text + '\t' + comboBox1.SelectedItem;
			
				if(richTextBox1.Lines.Length != 0 )
					richTextBox1.AppendText("\n" + CadUser.LoginInfo.userLogin);
				
				else
					richTextBox1.AppendText(LoginInfo.userLogin);
				
				
			
			/*if(nCad == richTextBox1.Lines.Length !=0)
				richTextBox1.AppendText("\n" + login);
			else
				richTextBox1.AppendText(login);*/
			
			richTextBox1.SaveFile("logins.txt");
			MessageBox.Show("Registro Concluído");
			this.Close();
			
			
		}
	}
}
