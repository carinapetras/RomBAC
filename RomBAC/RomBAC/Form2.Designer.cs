namespace RomBAC
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.subiect1 = new System.Windows.Forms.Button();
            this.subiect3 = new System.Windows.Forms.Button();
            this.subiect2 = new System.Windows.Forms.Button();
            this.sageata = new System.Windows.Forms.PictureBox();
            this.siglaa = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.sageata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siglaa)).BeginInit();
            this.SuspendLayout();
            // 
            // subiect1
            // 
            this.subiect1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.subiect1.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subiect1.Location = new System.Drawing.Point(93, 234);
            this.subiect1.Name = "subiect1";
            this.subiect1.Size = new System.Drawing.Size(175, 42);
            this.subiect1.TabIndex = 6;
            this.subiect1.Text = "Subiectul I";
            this.subiect1.UseVisualStyleBackColor = false;
            this.subiect1.Click += new System.EventHandler(this.subiect1_Click);
            // 
            // subiect3
            // 
            this.subiect3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.subiect3.Font = new System.Drawing.Font("Segoe Print", 18F);
            this.subiect3.Location = new System.Drawing.Point(93, 356);
            this.subiect3.Name = "subiect3";
            this.subiect3.Size = new System.Drawing.Size(175, 42);
            this.subiect3.TabIndex = 7;
            this.subiect3.Text = "Subiectul III";
            this.subiect3.UseVisualStyleBackColor = false;
            this.subiect3.Click += new System.EventHandler(this.subiect3_Click);
            // 
            // subiect2
            // 
            this.subiect2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.subiect2.Font = new System.Drawing.Font("Segoe Print", 18F);
            this.subiect2.Location = new System.Drawing.Point(93, 294);
            this.subiect2.Name = "subiect2";
            this.subiect2.Size = new System.Drawing.Size(175, 42);
            this.subiect2.TabIndex = 8;
            this.subiect2.Text = "Subiectul II";
            this.subiect2.UseVisualStyleBackColor = false;
            this.subiect2.Click += new System.EventHandler(this.subiect2_Click);
            // 
            // sageata
            // 
            this.sageata.Image = global::RomBAC.Properties.Resources.sagetuta;
            this.sageata.Location = new System.Drawing.Point(2, 1);
            this.sageata.Name = "sageata";
            this.sageata.Size = new System.Drawing.Size(35, 33);
            this.sageata.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sageata.TabIndex = 16;
            this.sageata.TabStop = false;
            this.sageata.Click += new System.EventHandler(this.sageata_Click);
            // 
            // siglaa
            // 
            this.siglaa.Image = global::RomBAC.Properties.Resources.sigla1;
            this.siglaa.Location = new System.Drawing.Point(24, 12);
            this.siglaa.Name = "siglaa";
            this.siglaa.Size = new System.Drawing.Size(304, 204);
            this.siglaa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.siglaa.TabIndex = 5;
            this.siglaa.TabStop = false;
            this.siglaa.Click += new System.EventHandler(this.siglaa_Click);
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
            this.richTextBox1.TabIndex = 17;
            this.richTextBox1.Text = "\n";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(364, 438);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.sageata);
            this.Controls.Add(this.subiect2);
            this.Controls.Add(this.subiect3);
            this.Controls.Add(this.subiect1);
            this.Controls.Add(this.siglaa);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "RomBAC//REAL";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sageata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siglaa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button subiect1;
        private System.Windows.Forms.Button subiect3;
        private System.Windows.Forms.Button subiect2;
        private System.Windows.Forms.PictureBox sageata;
        private System.Windows.Forms.PictureBox siglaa;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}