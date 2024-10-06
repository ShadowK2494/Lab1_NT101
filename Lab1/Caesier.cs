using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Lab1
{
    public partial class Caesier : Form
    {
        public Caesier()
        {
            InitializeComponent();
        }

        //Hàm xử lý chữ có dấu
        public static string RemoveDiacritics(string text)
        {
            string normalizedText = text.Normalize(NormalizationForm.FormD);
            StringBuilder sb = new StringBuilder();

            foreach (char c in normalizedText)
            {
                UnicodeCategory uc = CharUnicodeInfo.GetUnicodeCategory(c);

                // Loại bỏ các ký tự dấu
                if (uc != UnicodeCategory.NonSpacingMark)
                {
                    // Quy tắc đặc biệt cho ký tự 'đ' và 'Đ'
                    if (c == 'đ' || c == 'Đ')
                    {
                        sb.Append('d');
                    }
                    else
                    {
                        sb.Append(c);
                    }
                }
            }

            return sb.ToString().Normalize(NormalizationForm.FormC);
        }



        // Hàm mã hóa Caesar
        private string CaesarEncrypt(string input, int key)
        {
            // Chuẩn hóa giá trị key trong khoảng [0, 25]
            key = (key % 26 + 26) % 26;

            char[] buffer = new char[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                char letter = input[i];

                if (char.IsLetter(letter))
                {
                    if (char.IsUpper(letter))
                    {
                        // Mã hóa chữ hoa
                        letter = (char)((((letter - 'A') + key) % 26) + 'A');
                    }
                    else if (char.IsLower(letter))
                    {
                        // Mã hóa chữ thường
                        letter = (char)((((letter - 'a') + key) % 26) + 'a');
                    }
                }

                buffer[i] = letter;
            }
            return new string(buffer);
        }


        //Xử lý sự kiện nhấn nút Mã hóa
        private void btnMahoa_Click(object sender, EventArgs e)
        {
            pbCode.Visible = true;
            pbDecode.Visible = false;

            int key;

            if (int.TryParse(tbKey.Text, out key))
            {
                if (!tbPlaintext.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c) || char.IsPunctuation(c)))
                {
                    tbPlaintext.Text = null;
                    tbCiphertext.Text = null;
                    MessageBox.Show("Vui lòng chỉ nhập ký tự chữ cái vào văn bản cần mã hóa!", "ERROR", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return; 
                }
                else
                {
                    tbCiphertext.Text = CaesarEncrypt(RemoveDiacritics(tbPlaintext.Text), key);
                }
            }
            else
            {
                tbKey.Text = null;
                tbCiphertext.Text = null;
                MessageBox.Show("Vui lòng nhập Key là số tự nhiên!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Hàm giải mã Caesar
        private string CaesarDecrypt(string input, int key)
        {
            // Chuẩn hóa giá trị key trong khoảng [0, 25]
            key = (key % 26 + 26) % 26;

            char[] buffer = new char[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                char letter = input[i];

                if (char.IsLetter(letter))
                {
                    if (char.IsUpper(letter))
                    {
                        letter = (char)((((letter - 'A') - key + 26) % 26) + 'A');
                    }
                    else if (char.IsLower(letter))
                    {
                        letter = (char)((((letter - 'a') - key + 26) % 26) + 'a');
                    }
                }
                buffer[i] = letter;
            }
            return new string(buffer);
        }


        //Sự kiện nhấn nút Giải mã
        private void btnGiaima_Click(object sender, EventArgs e)
        {
            pbDecode.Visible = true;
            pbCode.Visible = false;
            int key;

            if (int.TryParse(tbKey.Text, out key))
            {
                if (!tbCiphertext.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c) || char.IsPunctuation(c)))
                {
                    tbPlaintext.Text = null;
                    tbCiphertext.Text = null;
                    MessageBox.Show("Vui lòng chỉ nhập ký tự chữ cái vào văn bản cần giải mã!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    tbPlaintext.Text = CaesarDecrypt(tbCiphertext.Text, key);
                }
            }
            else
            {
                tbKey.Text = null;
                tbPlaintext.Text = null;
                MessageBox.Show("Vui lòng nhập Key là số tự nhiên!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbKey.Text = null;
            tbPlaintext.Text = null;
            tbCiphertext.Text= null;
        }

        private void Caesier_Load(object sender, EventArgs e)
        {
            pbCode.Visible = false;
            pbDecode.Visible = false;
        }
    }
}


    
