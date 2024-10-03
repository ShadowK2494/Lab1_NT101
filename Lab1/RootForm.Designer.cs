namespace Lab1
{
    partial class RootForm
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
            this.Mono1 = new System.Windows.Forms.Button();
            this.Mono2 = new System.Windows.Forms.Button();
            this.Playfair1 = new System.Windows.Forms.Button();
            this.Playfair2 = new System.Windows.Forms.Button();
            this.Hill = new System.Windows.Forms.Button();
            this.Caesier = new System.Windows.Forms.Button();
            this.Polyalphabetic2 = new System.Windows.Forms.Button();
            this.Polyalphabetic1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Mono1
            // 
            this.Mono1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Mono1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mono1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Mono1.Location = new System.Drawing.Point(290, 225);
            this.Mono1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Mono1.Name = "Mono1";
            this.Mono1.Size = new System.Drawing.Size(255, 80);
            this.Mono1.TabIndex = 0;
            this.Mono1.Text = "Mono 1";
            this.Mono1.UseVisualStyleBackColor = false;
            this.Mono1.Click += new System.EventHandler(this.Mono1_Click);
            // 
            // Mono2
            // 
            this.Mono2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Mono2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mono2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Mono2.Location = new System.Drawing.Point(290, 314);
            this.Mono2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Mono2.Name = "Mono2";
            this.Mono2.Size = new System.Drawing.Size(255, 80);
            this.Mono2.TabIndex = 1;
            this.Mono2.Text = "Mono 2";
            this.Mono2.UseVisualStyleBackColor = false;
            this.Mono2.Click += new System.EventHandler(this.Mono2_Click);
            // 
            // Playfair1
            // 
            this.Playfair1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Playfair1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Playfair1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Playfair1.Location = new System.Drawing.Point(290, 403);
            this.Playfair1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Playfair1.Name = "Playfair1";
            this.Playfair1.Size = new System.Drawing.Size(255, 80);
            this.Playfair1.TabIndex = 2;
            this.Playfair1.Text = "Playfair 1";
            this.Playfair1.UseVisualStyleBackColor = false;
            this.Playfair1.Click += new System.EventHandler(this.Playfair1_Click);
            // 
            // Playfair2
            // 
            this.Playfair2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Playfair2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Playfair2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Playfair2.Location = new System.Drawing.Point(290, 492);
            this.Playfair2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Playfair2.Name = "Playfair2";
            this.Playfair2.Size = new System.Drawing.Size(255, 80);
            this.Playfair2.TabIndex = 3;
            this.Playfair2.Text = "Playfair 2";
            this.Playfair2.UseVisualStyleBackColor = false;
            this.Playfair2.Click += new System.EventHandler(this.Playfair2_Click);
            // 
            // Hill
            // 
            this.Hill.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Hill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hill.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Hill.Location = new System.Drawing.Point(640, 314);
            this.Hill.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Hill.Name = "Hill";
            this.Hill.Size = new System.Drawing.Size(255, 80);
            this.Hill.TabIndex = 7;
            this.Hill.Text = "Affine cipher";
            this.Hill.UseVisualStyleBackColor = false;
            this.Hill.Click += new System.EventHandler(this.Hill_Click);
            // 
            // Caesier
            // 
            this.Caesier.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Caesier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Caesier.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Caesier.Location = new System.Drawing.Point(640, 225);
            this.Caesier.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Caesier.Name = "Caesier";
            this.Caesier.Size = new System.Drawing.Size(255, 80);
            this.Caesier.TabIndex = 6;
            this.Caesier.Text = "Caesier cipher ";
            this.Caesier.UseVisualStyleBackColor = false;
            this.Caesier.Click += new System.EventHandler(this.Caesier_Click);
            // 
            // Polyalphabetic2
            // 
            this.Polyalphabetic2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Polyalphabetic2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Polyalphabetic2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Polyalphabetic2.Location = new System.Drawing.Point(640, 492);
            this.Polyalphabetic2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Polyalphabetic2.Name = "Polyalphabetic2";
            this.Polyalphabetic2.Size = new System.Drawing.Size(255, 80);
            this.Polyalphabetic2.TabIndex = 5;
            this.Polyalphabetic2.Text = "Polyalphabetic 2";
            this.Polyalphabetic2.UseVisualStyleBackColor = false;
            this.Polyalphabetic2.Click += new System.EventHandler(this.Polyalphabetic2_Click);
            // 
            // Polyalphabetic1
            // 
            this.Polyalphabetic1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Polyalphabetic1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Polyalphabetic1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Polyalphabetic1.Location = new System.Drawing.Point(640, 403);
            this.Polyalphabetic1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Polyalphabetic1.Name = "Polyalphabetic1";
            this.Polyalphabetic1.Size = new System.Drawing.Size(255, 80);
            this.Polyalphabetic1.TabIndex = 4;
            this.Polyalphabetic1.Text = "Polyalphabetic 1";
            this.Polyalphabetic1.UseVisualStyleBackColor = false;
            this.Polyalphabetic1.Click += new System.EventHandler(this.Polyalphabetic1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 111);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(978, 64);
            this.label1.TabIndex = 8;
            this.label1.Text = "LAB 1 - CLASSICAL CRYTOGRAPHY";
            // 
            // RootForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Hill);
            this.Controls.Add(this.Caesier);
            this.Controls.Add(this.Polyalphabetic2);
            this.Controls.Add(this.Polyalphabetic1);
            this.Controls.Add(this.Playfair2);
            this.Controls.Add(this.Playfair1);
            this.Controls.Add(this.Mono2);
            this.Controls.Add(this.Mono1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "RootForm";
            this.Text = "RootForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Mono1;
        private System.Windows.Forms.Button Mono2;
        private System.Windows.Forms.Button Playfair1;
        private System.Windows.Forms.Button Playfair2;
        private System.Windows.Forms.Button Hill;
        private System.Windows.Forms.Button Caesier;
        private System.Windows.Forms.Button Polyalphabetic2;
        private System.Windows.Forms.Button Polyalphabetic1;
        private System.Windows.Forms.Label label1;
    }
}

