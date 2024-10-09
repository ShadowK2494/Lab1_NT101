namespace Lab1
{
    partial class Polyalphabetic1
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
            this.Outputtxt = new System.Windows.Forms.TextBox();
            this.Inputtxt = new System.Windows.Forms.TextBox();
            this.Keytxt = new System.Windows.Forms.TextBox();
            this.Key = new System.Windows.Forms.Label();
            this.Ebtn = new System.Windows.Forms.Button();
            this.Dbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Outputtxt
            // 
            this.Outputtxt.Location = new System.Drawing.Point(616, 61);
            this.Outputtxt.Multiline = true;
            this.Outputtxt.Name = "Outputtxt";
            this.Outputtxt.ReadOnly = true;
            this.Outputtxt.Size = new System.Drawing.Size(439, 481);
            this.Outputtxt.TabIndex = 0;
            // 
            // Inputtxt
            // 
            this.Inputtxt.Location = new System.Drawing.Point(90, 61);
            this.Inputtxt.Multiline = true;
            this.Inputtxt.Name = "Inputtxt";
            this.Inputtxt.Size = new System.Drawing.Size(439, 481);
            this.Inputtxt.TabIndex = 1;
            this.Inputtxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Inputtxt_KeyPress);
            // 
            // Keytxt
            // 
            this.Keytxt.Location = new System.Drawing.Point(90, 33);
            this.Keytxt.Name = "Keytxt";
            this.Keytxt.Size = new System.Drawing.Size(965, 22);
            this.Keytxt.TabIndex = 2;
            this.Keytxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Keytxt_KeyPress);
            // 
            // Key
            // 
            this.Key.AutoSize = true;
            this.Key.Location = new System.Drawing.Point(41, 33);
            this.Key.Name = "Key";
            this.Key.Size = new System.Drawing.Size(30, 16);
            this.Key.TabIndex = 3;
            this.Key.Text = "Key";
            // 
            // Ebtn
            // 
            this.Ebtn.Location = new System.Drawing.Point(535, 61);
            this.Ebtn.Name = "Ebtn";
            this.Ebtn.Size = new System.Drawing.Size(75, 23);
            this.Ebtn.TabIndex = 4;
            this.Ebtn.Text = "Encrypt";
            this.Ebtn.UseVisualStyleBackColor = true;
            this.Ebtn.Click += new System.EventHandler(this.Ebtn_Click);
            // 
            // Dbtn
            // 
            this.Dbtn.Location = new System.Drawing.Point(535, 90);
            this.Dbtn.Name = "Dbtn";
            this.Dbtn.Size = new System.Drawing.Size(75, 23);
            this.Dbtn.TabIndex = 5;
            this.Dbtn.Text = "Decrypt";
            this.Dbtn.UseVisualStyleBackColor = true;
            this.Dbtn.Click += new System.EventHandler(this.Dbtn_Click);
            // 
            // Polyalphabetic1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.Dbtn);
            this.Controls.Add(this.Ebtn);
            this.Controls.Add(this.Key);
            this.Controls.Add(this.Keytxt);
            this.Controls.Add(this.Inputtxt);
            this.Controls.Add(this.Outputtxt);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Polyalphabetic1";
            this.Text = "Polyalphabetic1";
            this.Load += new System.EventHandler(this.Polyalphabetic1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Outputtxt;
        private System.Windows.Forms.TextBox Inputtxt;
        private System.Windows.Forms.TextBox Keytxt;
        private System.Windows.Forms.Label Key;
        private System.Windows.Forms.Button Ebtn;
        private System.Windows.Forms.Button Dbtn;
    }
}