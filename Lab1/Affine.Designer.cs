namespace Lab1
{
    partial class Affine
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnClear = new System.Windows.Forms.Button();
            this.tbA = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGiaima = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCiphertext = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPlaintext = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMahoa = new System.Windows.Forms.Button();
            this.tbB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pbDecode = new System.Windows.Forms.PictureBox();
            this.pbCode = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbDecode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClear.Location = new System.Drawing.Point(1053, 147);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(117, 49);
            this.btnClear.TabIndex = 21;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // tbA
            // 
            this.tbA.Location = new System.Drawing.Point(744, 155);
            this.tbA.Name = "tbA";
            this.tbA.Size = new System.Drawing.Size(112, 26);
            this.tbA.TabIndex = 20;
            this.tbA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(708, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 29);
            this.label4.TabIndex = 19;
            this.label4.Text = "a:";
            // 
            // btnGiaima
            // 
            this.btnGiaima.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnGiaima.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiaima.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGiaima.Location = new System.Drawing.Point(965, 555);
            this.btnGiaima.Name = "btnGiaima";
            this.btnGiaima.Size = new System.Drawing.Size(173, 49);
            this.btnGiaima.TabIndex = 17;
            this.btnGiaima.Text = "GIẢI MÃ";
            this.btnGiaima.UseVisualStyleBackColor = false;
            this.btnGiaima.Click += new System.EventHandler(this.btnGiaima_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(396, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 29);
            this.label3.TabIndex = 16;
            this.label3.Text = "Ciphertext:";
            // 
            // tbCiphertext
            // 
            this.tbCiphertext.Location = new System.Drawing.Point(401, 185);
            this.tbCiphertext.Multiline = true;
            this.tbCiphertext.Name = "tbCiphertext";
            this.tbCiphertext.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbCiphertext.Size = new System.Drawing.Size(274, 419);
            this.tbCiphertext.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 29);
            this.label2.TabIndex = 14;
            this.label2.Text = "Plaintext :";
            // 
            // tbPlaintext
            // 
            this.tbPlaintext.Location = new System.Drawing.Point(37, 185);
            this.tbPlaintext.Multiline = true;
            this.tbPlaintext.Name = "tbPlaintext";
            this.tbPlaintext.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbPlaintext.Size = new System.Drawing.Size(274, 419);
            this.tbPlaintext.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(498, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 52);
            this.label1.TabIndex = 12;
            this.label1.Text = "Affine Cipher";
            // 
            // btnMahoa
            // 
            this.btnMahoa.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnMahoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMahoa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMahoa.Location = new System.Drawing.Point(744, 555);
            this.btnMahoa.Name = "btnMahoa";
            this.btnMahoa.Size = new System.Drawing.Size(173, 49);
            this.btnMahoa.TabIndex = 11;
            this.btnMahoa.Text = "MÃ HÓA";
            this.btnMahoa.UseVisualStyleBackColor = false;
            this.btnMahoa.Click += new System.EventHandler(this.btnMahoa_Click);
            // 
            // tbB
            // 
            this.tbB.Location = new System.Drawing.Point(916, 154);
            this.tbB.Name = "tbB";
            this.tbB.Size = new System.Drawing.Size(112, 26);
            this.tbB.TabIndex = 20;
            this.tbB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(879, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 29);
            this.label5.TabIndex = 22;
            this.label5.Text = "b:";
            // 
            // pbDecode
            // 
            this.pbDecode.BackgroundImage = global::Lab1.Properties.Resources.muitentrai;
            this.pbDecode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbDecode.Location = new System.Drawing.Point(328, 329);
            this.pbDecode.Name = "pbDecode";
            this.pbDecode.Size = new System.Drawing.Size(60, 89);
            this.pbDecode.TabIndex = 24;
            this.pbDecode.TabStop = false;
            // 
            // pbCode
            // 
            this.pbCode.BackgroundImage = global::Lab1.Properties.Resources.muitenphai;
            this.pbCode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbCode.Location = new System.Drawing.Point(328, 329);
            this.pbCode.Name = "pbCode";
            this.pbCode.Size = new System.Drawing.Size(60, 89);
            this.pbCode.TabIndex = 23;
            this.pbCode.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Lab1.Properties.Resources.Affine;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(705, 220);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(465, 299);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // Affine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.pbDecode);
            this.Controls.Add(this.pbCode);
            this.Controls.Add(this.tbB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.tbA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnGiaima);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbCiphertext);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbPlaintext);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMahoa);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Affine";
            this.Text = "Affine Cipher";
            this.Load += new System.EventHandler(this.Affine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbDecode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox tbA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnGiaima;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCiphertext;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPlaintext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMahoa;
        private System.Windows.Forms.TextBox tbB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pbCode;
        private System.Windows.Forms.PictureBox pbDecode;
    }
}