/*
 * Created by SharpDevelop.
 * User: dell i5
 * Date: 16/11/2018
 * Time: 05:15
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace TesteResort
{
	/// <summary>
	/// Description of Form1.
	/// </summary>
	public partial class Form1 : Form
	{
		public Form1()
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
			btnHome.Height = pnClick.Height;
			pnClick.Top = btnHome.Top;
			userControl21.BringToFront();
		}
		void Button2Click(object sender, EventArgs e)
		{
			btnQrt.Height = pnClick.Height;
			pnClick.Top = btnQrt.Top;
		}
		void BtnSairClick(object sender, EventArgs e)
		{
			this.Dispose();
		}
		void BtnPacClick(object sender, EventArgs e)
		{
			btnPac.Height = pnClick.Height;
			pnClick.Top = btnPac.Top;
		}
		void BtnExClick(object sender, EventArgs e)
		{
			btnEx.Height = pnClick.Height;
			pnClick.Top = btnEx.Top;
		}
		void BtnResClick(object sender, EventArgs e)
		{
			btnRes.Height = pnClick.Height;
			pnClick.Top = btnRes.Top;
			controleReserva1.BringToFront();
			
			
		}
	
		void BtnCkotClick(object sender, EventArgs e)
		{
			btnCkot.Height = pnClick.Height;
			pnClick.Top = btnCkot.Top;
		}
		void Panel4Paint(object sender, PaintEventArgs e)
		{
	
		}
		void Form1Load(object sender, EventArgs e)
		{
	
		}
	}
}
