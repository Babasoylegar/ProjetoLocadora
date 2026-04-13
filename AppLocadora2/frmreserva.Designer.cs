namespace AppLocadora2
{
    partial class frmreserva
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblcodigo = new System.Windows.Forms.Label();
            this.lbldata = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.txtdata = new System.Windows.Forms.TextBox();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnnovo = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnvoltar);
            this.panel1.Controls.Add(this.btnlimpar);
            this.panel1.Controls.Add(this.btnnovo);
            this.panel1.Controls.Add(this.txtdata);
            this.panel1.Controls.Add(this.txtcodigo);
            this.panel1.Controls.Add(this.lbldata);
            this.panel1.Controls.Add(this.lblcodigo);
            this.panel1.Location = new System.Drawing.Point(273, 131);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(427, 284);
            this.panel1.TabIndex = 0;
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcodigo.Location = new System.Drawing.Point(25, 94);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(57, 16);
            this.lblcodigo.TabIndex = 0;
            this.lblcodigo.Text = "Código";
            // 
            // lbldata
            // 
            this.lbldata.AutoSize = true;
            this.lbldata.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldata.Location = new System.Drawing.Point(25, 159);
            this.lbldata.Name = "lbldata";
            this.lbldata.Size = new System.Drawing.Size(40, 16);
            this.lbldata.TabIndex = 1;
            this.lbldata.Text = "Data";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Font = new System.Drawing.Font("Corbel", 8.25F);
            this.txtcodigo.Location = new System.Drawing.Point(114, 94);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(100, 21);
            this.txtcodigo.TabIndex = 2;
            // 
            // txtdata
            // 
            this.txtdata.Font = new System.Drawing.Font("Corbel", 8.25F);
            this.txtdata.Location = new System.Drawing.Point(114, 159);
            this.txtdata.Name = "txtdata";
            this.txtdata.Size = new System.Drawing.Size(100, 21);
            this.txtdata.TabIndex = 3;
            // 
            // btnvoltar
            // 
            this.btnvoltar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnvoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnvoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvoltar.Location = new System.Drawing.Point(255, 136);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(158, 44);
            this.btnvoltar.TabIndex = 17;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = false;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.BackColor = System.Drawing.Color.LightCoral;
            this.btnlimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpar.Location = new System.Drawing.Point(296, 203);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(86, 30);
            this.btnlimpar.TabIndex = 16;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = false;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnnovo
            // 
            this.btnnovo.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnnovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnovo.Location = new System.Drawing.Point(255, 66);
            this.btnnovo.Name = "btnnovo";
            this.btnnovo.Size = new System.Drawing.Size(158, 44);
            this.btnnovo.TabIndex = 15;
            this.btnnovo.Text = "Novo";
            this.btnnovo.UseVisualStyleBackColor = false;
            this.btnnovo.Click += new System.EventHandler(this.btnnovo_Click);
            // 
            // frmreserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(963, 607);
            this.Controls.Add(this.panel1);
            this.Name = "frmreserva";
            this.Text = "Reserva";
            this.Load += new System.EventHandler(this.frmreserva_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtdata;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label lbldata;
        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnnovo;
    }
}