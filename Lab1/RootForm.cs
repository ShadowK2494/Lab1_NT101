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

        private void Mono1_Click(object sender, EventArgs e)
        {
            Mono1 mono1 = new Mono1();
            mono1.ShowDialog();
        }

        private void Mono2_Click(object sender, EventArgs e)
        {
            Mono2 mono2 = new Mono2();
            mono2.ShowDialog();
        }

        private void Playfair1_Click(object sender, EventArgs e)
        {
            Playfair1 playfair1 = new Playfair1();
            playfair1.ShowDialog();
        }

        private void Playfair2_Click(object sender, EventArgs e)
        {
            Playfair2 playfair2 = new Playfair2();
            playfair2.ShowDialog();
        }

        private void Caesier_Click(object sender, EventArgs e)
        {
            Caesier caesier = new Caesier();
            caesier.ShowDialog();
        }

        private void Hill_Click(object sender, EventArgs e)
        {
            Hill hill = new Hill();
            hill.ShowDialog();
        }

        private void Polyalphabetic1_Click(object sender, EventArgs e)
        {
            Polyalphabetic1 polyalphabetic1 = new Polyalphabetic1();
            polyalphabetic1.ShowDialog();
        }

        private void Polyalphabetic2_Click(object sender, EventArgs e)
        {
            Polyalphabetic2 polyalphabetic2 = new Polyalphabetic2();
            polyalphabetic2.ShowDialog();
        }
    }
}
