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
    public partial class Polyalphabetic1 : Form
    {
        public Polyalphabetic1()
        {
            InitializeComponent();
        }

        private void Polyalphabetic1_Load(object sender, EventArgs e)
        {

        }

        private void Ebtn_Click(object sender, EventArgs e)
        {
            string plainText = Inputtxt.Text;
            string key = Keytxt.Text;

            // Mã hóa
            string cipherText = Encrypt(plainText, key);
            Outputtxt.Text = cipherText;

        }

        private void Dbtn_Click(object sender, EventArgs e)
        {
            string plainText = Inputtxt.Text;
            string key = Keytxt.Text;

            // Mã hóa
            string cipherText = Decrypt(plainText, key);
            Outputtxt.Text = cipherText;
        }


        public static string Encrypt(string plainText, string key)
        {
            string encryptedText = "";
            key = key.ToUpper();
            int keyLength = key.Length;

            for (int i = 0, j = 0; i < plainText.Length; i++)
            {
                char c = plainText[i];
                if (char.IsLetter(c))
                {
                    char offset = char.IsUpper(c) ? 'A' : 'a';
                    encryptedText += (char)(((c + key[j % keyLength] - 2 * offset) % 26) + offset);
                    j++;
                }
            }
            return encryptedText;
        }


        public static string Decrypt(string cipherText, string key)
        {
            string decryptedText = "";
            key = key.ToUpper();
            int keyLength = key.Length;

            for (int i = 0, j = 0; i < cipherText.Length; i++)
            {
                char c = cipherText[i];
                if (char.IsLetter(c))
                {
                    char offset = char.IsUpper(c) ? 'A' : 'a';
                    decryptedText += (char)(((c - key[j % keyLength] + 26) % 26) + offset);
                    j++;
                }
            }
            return decryptedText;
        }

        private void Keytxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            int code = Convert.ToInt32(e.KeyChar);

            if ((code >64 && code < 91) || code==8 )
            {
                e.Handled = false;
            }
            else e.Handled = true;
        }

        private void Inputtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            int code = Convert.ToInt32(e.KeyChar);

            if ((code > 64 && code < 91) || code == 8)
            {
                e.Handled = false;
            }
            else e.Handled = true;
        }
    }
}
