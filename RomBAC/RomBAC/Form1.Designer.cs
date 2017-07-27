namespace RomBAC
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.real = new System.Windows.Forms.Button();
            this.uman = new System.Windows.Forms.Button();
            this.despre = new System.Windows.Forms.Button();
            this.sfaturi = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.test = new System.Windows.Forms.Button();
            this.siglaa = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.siglaa)).BeginInit();
            this.SuspendLayout();
            // 
            // real
            // 
            this.real.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.real.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.real.Location = new System.Drawing.Point(24, 265);
            this.real.Name = "real";
            this.real.Size = new System.Drawing.Size(111, 57);
            this.real.TabIndex = 0;
            this.real.Text = "REAL";
            this.real.UseVisualStyleBackColor = false;
            this.real.Click += new System.EventHandler(this.real_Click);
            // 
            // uman
            // 
            this.uman.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.uman.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.uman.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uman.Location = new System.Drawing.Point(217, 265);
            this.uman.Name = "uman";
            this.uman.Size = new System.Drawing.Size(111, 57);
            this.uman.TabIndex = 1;
            this.uman.Text = "UMAN";
            this.uman.UseVisualStyleBackColor = false;
            this.uman.Click += new System.EventHandler(this.uman_Click);
            // 
            // despre
            // 
            this.despre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.despre.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.despre.Location = new System.Drawing.Point(123, 340);
            this.despre.Name = "despre";
            this.despre.Size = new System.Drawing.Size(105, 29);
            this.despre.TabIndex = 2;
            this.despre.Text = "Despre";
            this.despre.UseVisualStyleBackColor = false;
            this.despre.Click += new System.EventHandler(this.despre_Click);
            // 
            // sfaturi
            // 
            this.sfaturi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.sfaturi.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfaturi.Location = new System.Drawing.Point(123, 375);
            this.sfaturi.Name = "sfaturi";
            this.sfaturi.Size = new System.Drawing.Size(105, 27);
            this.sfaturi.TabIndex = 3;
            this.sfaturi.Text = "Sfaturi";
            this.sfaturi.UseVisualStyleBackColor = false;
            this.sfaturi.Click += new System.EventHandler(this.sfaturi_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.Cornsilk;
            this.richTextBox1.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.Black;
            this.richTextBox1.Location = new System.Drawing.Point(367, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(861, 414);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "\n";
            // 
            // test
            // 
            this.test.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.test.ForeColor = System.Drawing.SystemColors.ControlText;
            this.test.Location = new System.Drawing.Point(123, 408);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(105, 27);
            this.test.TabIndex = 8;
            this.test.Text = "Test";
            this.test.UseVisualStyleBackColor = false;
            this.test.Click += new System.EventHandler(this.test_Click);
            // 
            // siglaa
            // 
            this.siglaa.Image = global::RomBAC.Properties.Resources.sigla1;
            this.siglaa.Location = new System.Drawing.Point(24, 12);
            this.siglaa.Name = "siglaa";
            this.siglaa.Size = new System.Drawing.Size(304, 204);
            this.siglaa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.siglaa.TabIndex = 6;
            this.siglaa.TabStop = false;
            this.siglaa.Click += new System.EventHandler(this.siglaa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(352, 438);
            this.Controls.Add(this.test);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.siglaa);
            this.Controls.Add(this.sfaturi);
            this.Controls.Add(this.despre);
            this.Controls.Add(this.uman);
            this.Controls.Add(this.real);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "RomBAC";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.siglaa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button real;
        private System.Windows.Forms.Button uman;
        private System.Windows.Forms.Button despre;
        private System.Windows.Forms.Button sfaturi;
        private System.Windows.Forms.PictureBox siglaa;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button test;
    }
}

