using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TesteResort
{
    public partial class CadQuarto : Form
    {
        public CadQuarto()
        {
            InitializeComponent();
        }

        public static class QuartoInfo
        {
            public static string quartoInfo = "";
        }

            private void button2_Click(object sender, EventArgs e)
        {
            CadQuarto.QuartoInfo.quartoInfo = textBox1.Text + '\t' + textBox2.Text + '\t' + textBox3.Text + '\t' + textBox4.Text + '\t' + textBox5.Text + '\t' + textBox6.Text + '\t' + comboBox1.SelectedItem;
            if (richTextBox1.Lines.Length != 0)
                richTextBox1.AppendText("\n" + CadQuarto.QuartoInfo.quartoInfo);

            else
            {
                richTextBox1.AppendText(QuartoInfo.quartoInfo);
            }

            richTextBox1.SaveFile("quartos.txt");

            this.Close();
        }

            
        
        private void CadQuarto_Load(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.LoadFile("quartos.txt");

            }
            catch (Exception erro)
            {

            }
        }
    }
}
