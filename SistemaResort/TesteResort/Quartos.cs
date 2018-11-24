using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TesteResort
{
    public partial class Quartos : UserControl
    {
        public Quartos()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CadQuarto cadQuarto = new CadQuarto();
            cadQuarto.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VerQuarto verQuarto = new VerQuarto();
            verQuarto.ShowDialog();
        }
    }
}
