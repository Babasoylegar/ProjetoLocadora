namespace AppLocadora2
{
    partial class frmsplash
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
            this.components = new System.ComponentModel.Container();
            this.tmrsplash = new System.Windows.Forms.Timer(this.components);
            this.pgbsplash = new System.Windows.Forms.ProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblsplash = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrsplash
            // 
            this.tmrsplash.Enabled = true;
            this.tmrsplash.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pgbsplash
            // 
            this.pgbsplash.Location = new System.Drawing.Point(192, 418);
            this.pgbsplash.Name = "pgbsplash";
            this.pgbsplash.Size = new System.Drawing.Size(582, 16);
            this.pgbsplash.TabIndex = 0;
            this.pgbsplash.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AppLocadora2.Properties.Resources.bem_vindo;
            this.pictureBox1.Location = new System.Drawing.Point(277, 123);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(414, 289);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblsplash
            // 
            this.lblsplash.AutoSize = true;
            this.lblsplash.Location = new System.Drawing.Point(464, 437);
            this.lblsplash.Name = "lblsplash";
            this.lblsplash.Size = new System.Drawing.Size(13, 13);
            this.lblsplash.TabIndex = 2;
            this.lblsplash.Text = "0";
            this.lblsplash.Click += new System.EventHandler(this.lblsplash_Click);
            // 
            // frmsplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(963, 607);
            this.Controls.Add(this.lblsplash);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pgbsplash);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "frmsplash";
            this.Text = "frmsplash";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmrsplash;
        private System.Windows.Forms.ProgressBar pgbsplash;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblsplash;
    }
}