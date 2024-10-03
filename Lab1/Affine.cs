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
    public partial class Affine : Form
    {
        public Affine()
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


        private void btnClear_Click(object sender, EventArgs e)
        {
            tbCiphertext.Text = null;
            tbPlaintext.Text = null;
            tbA.Text = null;
            tbB.Text = null;
        }

        // Hàm tính nghịch đảo của a mod 26
        private static int ModInverse(int a)
        {
            a = a % 26;
            for (int x = 1; x < 26; x++)
                if ((a * x) % 26 == 1)
                    return x;
            return -1; // Không tìm thấy nghịch đảo
        }

        // Hàm mã hóa Affine
        public static string Encrypt(string plaintext, int a, int b)
        {
            b = (b % 26 + 26) % 26; // Điều chỉnh b để nó nằm trong khoảng [0, 25]

            char[] buffer = new char[plaintext.Length];
            for (int i = 0; i < plaintext.Length; i++)
            {
                char letter = plaintext[i];
                if (char.IsLetter(letter))
                {
                    letter = char.ToUpper(letter);
                    int x = letter - 'A'; 
                    int y = (a * x + b) % 26; // Mã hóa (a*x + b) mod 26
                    buffer[i] = (char)(y + 'A'); 
                }
                else
                {
                    buffer[i] = letter;
                }
            }
            return new string(buffer);
        }

        //Xử lý sự kiện nhấn nút Mã hóa
        private void btnMahoa_Click(object sender, EventArgs e)
        {
            pbCode.Visible = true;
            pbDecode.Visible = false;

            int a,b;

            if (int.TryParse(tbA.Text, out a) &&  int.TryParse(tbB.Text, out b))
            {
                if (!tbPlaintext.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
                {
                    tbPlaintext.Text = null;
                    tbCiphertext.Text = null;
                    MessageBox.Show("Vui lòng chỉ nhập ký tự chữ cái cần mã hóa!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    tbCiphertext.Text = Encrypt(RemoveDiacritics(tbPlaintext.Text), a, b);
                }
            }
            else
            {
                if (int.TryParse(tbB.Text, out b))
                {
                    tbA.Text = null;
                    MessageBox.Show("Vui lòng nhập a là số nguyên (coprime với 26 để có thể giải mã chính xác văn bản)!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    tbB.Text = null;
                    MessageBox.Show("Vui lòng nhập b là số nguyên!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Hàm giải mã Affine
        public static string Decrypt(string ciphertext, int a, int b)
        {
            b = (b % 26 + 26) % 26; // Điều chỉnh b để nó nằm trong khoảng [0, 25]
            char[] buffer = new char[ciphertext.Length];
            int aInverse = ModInverse(a);

            for (int i = 0; i < ciphertext.Length; i++)
            {
                char letter = ciphertext[i];
                if (char.IsLetter(letter))
                {
                    letter = char.ToUpper(letter);
                    int y = letter - 'A';
                    int x = (aInverse * ((y - b + 26) % 26)) % 26; // Giải mã (y - b + 26) * a^-1 mod 26

                    // Điều chỉnh để kết quả nằm trong khoảng từ 0 đến 25
                    if (x < 0)
                    {
                        x += 26;
                    }

                    buffer[i] = (char)(x + 'A'); 
                }
                else
                {
                    buffer[i] = letter;
                }
            }
            return new string(buffer);
        }

        //Xử lý sự kiện nhấn nút Giải mã
        private void btnGiaima_Click(object sender, EventArgs e)
        {
            pbDecode.Visible = true;
            pbCode.Visible = false;
            int a, b;

            if (int.TryParse(tbA.Text, out a) &&  int.TryParse(tbB.Text, out b) && (ModInverse(a) != -1))
            {
                if (!tbCiphertext.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
                {
                    tbPlaintext.Text = null;
                    tbCiphertext.Text = null;
                    MessageBox.Show("Vui lòng chỉ nhập ký tự chữ cái cần giải mã!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    tbPlaintext.Text = Decrypt(tbCiphertext.Text, a, b);
                }
            }
            else
            {
                if (int.TryParse(tbB.Text, out b))
                {
                    tbA.Text = null;
                    MessageBox.Show("Vui lòng nhập a là số nguyên lẻ và có ước chung với 26!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    tbB.Text = null;
                    MessageBox.Show("Vui lòng nhập b là số nguyên!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Affine_Load(object sender, EventArgs e)
        {
            pbDecode.Visible = false;
            pbCode.Visible = false;
        }
    }
}
