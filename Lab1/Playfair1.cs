using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;
using static System.Net.Mime.MediaTypeNames;

namespace Lab1
{
    public partial class Playfair1 : Form
    {
        public Playfair1()
        {
            InitializeComponent();
        }

        private void Playfair1_Load(object sender, EventArgs e)
        {

        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
            // Lưu vị trí con trỏ để khôi phục sau khi thay đổi
            int cursorPosition = textBox1.SelectionStart;

            // Loại bỏ khoảng trắng
            textBox1.Text = textBox1.Text.Replace(" ", "").Replace("\n", "");

            // Khôi phục vị trí con trỏ sau khi loại bỏ khoảng trắng
            textBox1.SelectionStart = cursorPosition;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Tạm thời vô hiệu hóa sự kiện TextChanged để tránh vòng lặp
            textBox1.TextChanged -= textBox1_TextChanged;

            // Lưu vị trí con trỏ hiện tại
            int cursorPosition = textBox1.SelectionStart;

            // Chuyển đổi tất cả các ký tự thành chữ hoa và loại bỏ khoảng trắng, ký tự xuống dòng
            string newText = textBox1.Text.Replace(" ", "").Replace("\n", "").Replace("\r", "").ToUpper();

            // Gán chuỗi mới đã chỉnh sửa vào TextBox
            textBox1.Text = newText;

            // Khôi phục vị trí con trỏ, nếu con trỏ bị vượt quá độ dài chuỗi thì đặt lại cuối chuỗi
            textBox1.SelectionStart = Math.Min(cursorPosition, newText.Length);

            // Kích hoạt lại sự kiện TextChanged
            textBox1.TextChanged += textBox1_TextChanged;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
            // Lưu vị trí con trỏ để khôi phục sau khi thay đổi
            int cursorPosition = textBox1.SelectionStart;

            // Loại bỏ khoảng trắng
            textBox2.Text = textBox2.Text.Replace(" ", "").Replace("\n", "");

            // Khôi phục vị trí con trỏ sau khi loại bỏ khoảng trắng
            textBox2.SelectionStart = cursorPosition;
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Lưu vị trí con trỏ hiện tại
            int cursorPosition = textBox2.SelectionStart;

            // Chuyển đổi tất cả các ký tự thành chữ hoa và loại bỏ khoảng trắng
            string newText = textBox2.Text.Replace(" ", "").ToUpper().Replace("\n", "");

            // Gán chuỗi mới đã chỉnh sửa vào TextBox
            textBox2.Text = newText;

            // Khôi phục vị trí con trỏ, nếu con trỏ bị vượt quá độ dài chuỗi thì đặt lại cuối chuỗi
            textBox2.SelectionStart = Math.Min(cursorPosition, newText.Length);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string key = textBox2.Text;
            char[,] matrix = new char[5, 5];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matrix[i, j] = '\0'; // Gán ký tự '?' vào từng phần tử
                }
            }
            int dodaikey = key.Length;

            // Duyệt qua từng ký tự trong key
            for (int k = 0; k < dodaikey; k++)
            {
                bool inserted = false; // Biến để theo dõi nếu đã chèn ký tự
                for (int i = 0; i < 5 && !inserted; i++) // Duyệt qua hàng của ma trận
                {
                    for (int j = 0; j < 5 && !inserted; j++) // Duyệt qua cột của ma trận
                    {
                        if (matrix[i, j] == key[k])
                        {
                            // Nếu ký tự đã có trong ma trận, thoát khỏi vòng lặp
                            inserted = true;
                            break;
                        }
                        else if (matrix[i, j] == '\0') // Nếu ô trống
                        {
                            matrix[i, j] = key[k]; // Gán ký tự của key vào vị trí đó
                            inserted = true; // Đánh dấu là đã chèn
                            break; // Thoát vòng lặp khi đã chèn ký tự
                        }
                    }
                }
            }

            // Điền các chữ cái còn lại từ A đến Z, bỏ qua J
            char letter = 'A'; // Bắt đầu từ chữ cái A
            for (int i = 0; i < 5; i++) // Duyệt qua hàng của ma trận
            {
                for (int j = 0; j < 5; j++) // Duyệt qua cột của ma trận
                {
                    if (matrix[i, j] == '\0') // Nếu ô trống
                    {
                        // Tìm chữ cái tiếp theo không có trong ma trận
                        while (letter <= 'Z')
                        {
                            // Bỏ qua chữ J
                            if (letter == 'J')
                            {
                                letter++;
                                continue; // Tiếp tục với chữ cái tiếp theo
                            }

                            // Kiểm tra xem chữ cái đã có trong ma trận chưa
                            bool exists = false;
                            for (int x = 0; x < 5; x++)
                            {
                                for (int y = 0; y < 5; y++)
                                {
                                    if (matrix[x, y] == letter)
                                    {
                                        exists = true;
                                        break;
                                    }
                                }
                                if (exists) break; // Nếu đã tồn tại thì thoát khỏi vòng lặp
                            }
                            if (!exists) // Nếu chưa tồn tại trong ma trận
                            {
                                matrix[i, j] = letter; // Gán chữ cái vào vị trí trống
                                letter++; // Chuyển sang chữ cái tiếp theo
                                break; // Thoát vòng lặp để điền chữ cái mới
                            }
                            letter++; // Chuyển sang chữ cái tiếp theo nếu đã tồn tại
                        }
                    }
                }
            }

            // In ma trận ra TextBox
            PrintMatrixToTextBox(matrix);

            string text = textBox1.Text;
            string result = "";
            int dodaitext = text.Length;
            if (dodaitext % 2 == 1) text = text + "X";
            for (int a =0,b =1; a <= dodaitext && b<= dodaitext; a=a+2, b=b+2)
            {
                int i1 = -1, j1 = -1, i2 = -1, j2 = -1;
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (matrix[i, j] == text[a])
                        {
                            i1=i; j1=j;
                        }
                        if (matrix[i, j] == text[b])
                        {
                            i2 = i; j2 = j;
                        }
                    }
                }

                if (j1 == j2) // cùng cột
                {
                    // Lấy ký tự tiếp theo trong cột, nếu quá cột cuối thì quay lại cột đầu
                    i1 = (i1 + 1) % 5;
                    i2 = (i2 + 1) % 5;

                    // Thêm các ký tự mới vào chuỗi mã hóa
                    result += matrix[i1, j1];
                    result += matrix[i2, j2];
                }
                else if (i1 == i2) // cùng hàng 
                {
                    // Lấy ký tự tiếp theo trong hàng, nếu quá hàng cuối thì quay lại cột hàng
                    j1 = (j1 + 1) % 5;
                    j2 = (j2 + 1) % 5;

                    // Thêm các ký tự mới vào chuỗi mã hóa
                    result += matrix[i1, j1];
                    result += matrix[i2, j2];
                }
                else
                {
                    int temp = j1;
                    j1 = j2;
                    j2 = temp;

                    // Thêm các ký tự mới vào chuỗi mã hóa
                    result += matrix[i1, j1];
                    result += matrix[i2, j2];
                }
            }
            textBox4.Text = result;
        }
        private void PrintMatrixToTextBox(char[,] matrix)
        {
            // Khởi tạo chuỗi để lưu trữ giá trị của ma trận
            string matrixString = "";

            // Duyệt qua ma trận và tạo chuỗi
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matrixString += matrix[i, j] + "\t"; // Thêm giá trị và tab
                }
                matrixString += Environment.NewLine; // Xuống dòng sau mỗi hàng
            }

            // Hiển thị chuỗi trong TextBox
            textBox3.Text = matrixString;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string key = textBox2.Text;
            char[,] matrix = new char[5, 5];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matrix[i, j] = '\0'; // Gán ký tự '?' vào từng phần tử
                }
            }
            int dodaikey = key.Length;

            // Duyệt qua từng ký tự trong key
            for (int k = 0; k < dodaikey; k++)
            {
                bool inserted = false; // Biến để theo dõi nếu đã chèn ký tự
                for (int i = 0; i < 5 && !inserted; i++) // Duyệt qua hàng của ma trận
                {
                    for (int j = 0; j < 5 && !inserted; j++) // Duyệt qua cột của ma trận
                    {
                        if (matrix[i, j] == key[k])
                        {
                            // Nếu ký tự đã có trong ma trận, thoát khỏi vòng lặp
                            inserted = true;
                            break;
                        }
                        else if (matrix[i, j] == '\0') // Nếu ô trống
                        {
                            matrix[i, j] = key[k]; // Gán ký tự của key vào vị trí đó
                            inserted = true; // Đánh dấu là đã chèn
                            break; // Thoát vòng lặp khi đã chèn ký tự
                        }
                    }
                }
            }

            // Điền các chữ cái còn lại từ A đến Z, bỏ qua J
            char letter = 'A'; // Bắt đầu từ chữ cái A
            for (int i = 0; i < 5; i++) // Duyệt qua hàng của ma trận
            {
                for (int j = 0; j < 5; j++) // Duyệt qua cột của ma trận
                {
                    if (matrix[i, j] == '\0') // Nếu ô trống
                    {
                        // Tìm chữ cái tiếp theo không có trong ma trận
                        while (letter <= 'Z')
                        {
                            // Bỏ qua chữ J
                            if (letter == 'J')
                            {
                                letter++;
                                continue; // Tiếp tục với chữ cái tiếp theo
                            }

                            // Kiểm tra xem chữ cái đã có trong ma trận chưa
                            bool exists = false;
                            for (int x = 0; x < 5; x++)
                            {
                                for (int y = 0; y < 5; y++)
                                {
                                    if (matrix[x, y] == letter)
                                    {
                                        exists = true;
                                        break;
                                    }
                                }
                                if (exists) break; // Nếu đã tồn tại thì thoát khỏi vòng lặp
                            }
                            if (!exists) // Nếu chưa tồn tại trong ma trận
                            {
                                matrix[i, j] = letter; // Gán chữ cái vào vị trí trống
                                letter++; // Chuyển sang chữ cái tiếp theo
                                break; // Thoát vòng lặp để điền chữ cái mới
                            }
                            letter++; // Chuyển sang chữ cái tiếp theo nếu đã tồn tại
                        }
                    }
                }
            }

            // In ma trận ra TextBox
            PrintMatrixToTextBox(matrix);

            string text = textBox1.Text;
            string result = "";
            int dodaitext = text.Length;
            if (dodaitext % 2 == 1) text = text + "X";
            for (int a = 0, b = 1; a <= dodaitext && b <= dodaitext; a = a + 2, b = b + 2)
            {
                int i1 = -1, j1 = -1, i2 = -1, j2 = -1;
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (matrix[i, j] == text[a])
                        {
                            i1 = i; j1 = j;
                        }
                        if (matrix[i, j] == text[b])
                        {
                            i2 = i; j2 = j;
                        }
                    }
                }

                if (j1 == j2) // cùng cột
                {
                    // Lấy ký tự tiếp theo trong cột, nếu quá cột cuối thì quay lại cột đầu
                    i1 = (i1 == 0) ? 4 : (i1 - 1); // Nếu i1 bằng 0 thì đặt i1 thành 4, ngược lại trừ 1
                    i2 = (i2 == 0) ? 4 : (i2 - 1); // Nếu i2 bằng 0 thì đặt i2 thành 4, ngược lại trừ 1

                    // Thêm các ký tự mới vào chuỗi mã hóa
                    result += matrix[i1, j1];
                    result += matrix[i2, j2];
                }
                else if (i1 == i2) // cùng hàng 
                {
                    // Lấy ký tự tiếp theo trong hàng, nếu quá hàng cuối thì quay lại cột hàng
                    j1 = (j1 == 0) ? 4 : (j1 - 1); // Nếu i1 bằng 0 thì đặt i1 thành 4, ngược lại trừ 1
                    j2 = (j2 == 0) ? 4 : (j2 - 1); // Nếu i2 bằng 0 thì đặt i2 thành 4, ngược lại trừ 1

                    // Thêm các ký tự mới vào chuỗi mã hóa
                    result += matrix[i1, j1];
                    result += matrix[i2, j2];
                }
                else
                {
                    int temp = j1;
                    j1 = j2;
                    j2 = temp;

                    // Thêm các ký tự mới vào chuỗi mã hóa
                    result += matrix[i1, j1];
                    result += matrix[i2, j2];
                }
            }
            textBox4.Text = result;
        }
    }
    
}
