namespace RomBAC
{
    partial class gendramatic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gendramatic));
            this.pCaragiale = new System.Windows.Forms.PictureBox();
            this.sageata = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pCaragiale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sageata)).BeginInit();
            this.SuspendLayout();
            // 
            // pCaragiale
            // 
            this.pCaragiale.Image = global::RomBAC.Properties.Resources._200px_Ion_Luca_Caragiale___Foto03;
            this.pCaragiale.Location = new System.Drawing.Point(45, 57);
            this.pCaragiale.Name = "pCaragiale";
            this.pCaragiale.Size = new System.Drawing.Size(205, 270);
            this.pCaragiale.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pCaragiale.TabIndex = 17;
            this.pCaragiale.TabStop = false;
            this.pCaragiale.Click += new System.EventHandler(this.pCaragiale_Click);
            // 
            // sageata
            // 
            this.sageata.Image = global::RomBAC.Properties.Resources.sagetuta;
            this.sageata.Location = new System.Drawing.Point(12, 12);
            this.sageata.Name = "sageata";
            this.sageata.Size = new System.Drawing.Size(35, 33);
            this.sageata.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sageata.TabIndex = 16;
            this.sageata.TabStop = false;
            this.sageata.Click += new System.EventHandler(this.sageata_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.Cornsilk;
            this.richTextBox1.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.Black;
            this.richTextBox1.Location = new System.Drawing.Point(270, 57);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(696, 578);
            this.richTextBox1.TabIndex = 18;
            this.richTextBox1.Text = "\n";
            this.richTextBox1.Visible = false;
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.Color.Cornsilk;
            this.richTextBox2.Font = new System.Drawing.Font("Segoe Print", 9.75F);
            this.richTextBox2.Location = new System.Drawing.Point(45, 333);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox2.Size = new System.Drawing.Size(205, 302);
            this.richTextBox2.TabIndex = 19;
            this.richTextBox2.Text = "";
            this.richTextBox2.Visible = false;
            // 
            // gendramatic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(297, 414);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.pCaragiale);
            this.Controls.Add(this.sageata);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "gendramatic";
            this.Text = "RomBAC//REAL//Subiectul III//Gen DRAMATIC";
            this.Load += new System.EventHandler(this.gendramatic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pCaragiale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sageata)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox sageata;
        private System.Windows.Forms.PictureBox pCaragiale;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
    }
}