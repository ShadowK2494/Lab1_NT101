using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class RootForm : Form
    {
        public RootForm()
        {
            InitializeComponent();
        }

        private void Playfair1_Click(object sender, EventArgs e)
        {
            Playfair1 playfair1 = new Playfair1();
            playfair1.ShowDialog();
        }

        private void Caesier_Click(object sender, EventArgs e)
        {
            Caesier caesier = new Caesier();
            caesier.ShowDialog();
        }

        private void Affine_Click(object sender, EventArgs e)
        {
            Affine affine = new Affine();
            affine.ShowDialog();
        }

        private void Polyalphabetic1_Click(object sender, EventArgs e)
        {
            Polyalphabetic1 polyalphabetic1 = new Polyalphabetic1();
            polyalphabetic1.ShowDialog();
        }
    }
}
