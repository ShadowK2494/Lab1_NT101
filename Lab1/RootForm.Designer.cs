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
            this.Playfair1 = new System.Windows.Forms.Button();
            this.Affine = new System.Windows.Forms.Button();
            this.Caesier = new System.Windows.Forms.Button();
            this.Polyalphabetic2 = new System.Windows.Forms.Button();
            this.Polyalphabetic1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Playfair1
            // 
            this.Playfair1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Playfair1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Playfair1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Playfair1.Location = new System.Drawing.Point(290, 358);
            this.Playfair1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Playfair1.Name = "Playfair1";
            this.Playfair1.Size = new System.Drawing.Size(255, 80);
            this.Playfair1.TabIndex = 2;
            this.Playfair1.Text = "Playfair";
            this.Playfair1.UseVisualStyleBackColor = false;
            this.Playfair1.Click += new System.EventHandler(this.Playfair1_Click);
            // 
            // Affine
            // 
            this.Affine.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Affine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Affine.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Affine.Location = new System.Drawing.Point(640, 269);
            this.Affine.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Affine.Name = "Affine";
            this.Affine.Size = new System.Drawing.Size(255, 80);
            this.Affine.TabIndex = 7;
            this.Affine.Text = "Affine cipher";
            this.Affine.UseVisualStyleBackColor = false;
            this.Affine.Click += new System.EventHandler(this.Affine_Click);
            // 
            // Caesier
            // 
            this.Caesier.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Caesier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Caesier.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Caesier.Location = new System.Drawing.Point(290, 268);
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
            this.Polyalphabetic2.Location = new System.Drawing.Point(640, 447);
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
            this.Polyalphabetic1.Location = new System.Drawing.Point(640, 358);
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
            this.Controls.Add(this.Affine);
            this.Controls.Add(this.Caesier);
            this.Controls.Add(this.Polyalphabetic2);
            this.Controls.Add(this.Polyalphabetic1);
            this.Controls.Add(this.Playfair1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "RootForm";
            this.Text = "RootForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Playfair1;
        private System.Windows.Forms.Button Affine;
        private System.Windows.Forms.Button Caesier;
        private System.Windows.Forms.Button Polyalphabetic2;
        private System.Windows.Forms.Button Polyalphabetic1;
        private System.Windows.Forms.Label label1;
    }
}

