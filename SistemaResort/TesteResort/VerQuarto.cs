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
    public partial class VerQuarto : Form
    {
        public VerQuarto()
        {
            InitializeComponent();
        }

        private void VerQuarto_Load(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.LoadFile("quartos.txt");

            }
            catch (Exception erro)
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Visible = true;
        }
    }
}
