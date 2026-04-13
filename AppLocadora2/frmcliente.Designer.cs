namespace AppLocadora2
{
    partial class frmcliente
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
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtendereco = new System.Windows.Forms.TextBox();
            this.lblcodigo = new System.Windows.Forms.Label();
            this.lblnome = new System.Windows.Forms.Label();
            this.lblendereco = new System.Windows.Forms.Label();
            this.mskcpf = new System.Windows.Forms.MaskedTextBox();
            this.lblcpf = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnnovo = new System.Windows.Forms.Button();
            this.lblprofissao = new System.Windows.Forms.Label();
            this.cbbprofissao = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(122, 53);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(95, 20);
            this.txtcodigo.TabIndex = 0;
            // 
            // txtnome
            // 
            this.txtnome.AccessibleDescription = "";
            this.txtnome.Location = new System.Drawing.Point(122, 101);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(127, 20);
            this.txtnome.TabIndex = 1;
            // 
            // txtendereco
            // 
            this.txtendereco.Location = new System.Drawing.Point(122, 149);
            this.txtendereco.Name = "txtendereco";
            this.txtendereco.Size = new System.Drawing.Size(127, 20);
            this.txtendereco.TabIndex = 2;
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcodigo.Location = new System.Drawing.Point(35, 61);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(57, 16);
            this.lblcodigo.TabIndex = 3;
            this.lblcodigo.Text = "Código";
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnome.Location = new System.Drawing.Point(35, 101);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(48, 16);
            this.lblnome.TabIndex = 4;
            this.lblnome.Text = "Nome";
            // 
            // lblendereco
            // 
            this.lblendereco.AutoSize = true;
            this.lblendereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblendereco.Location = new System.Drawing.Point(35, 152);
            this.lblendereco.Name = "lblendereco";
            this.lblendereco.Size = new System.Drawing.Size(74, 16);
            this.lblendereco.TabIndex = 5;
            this.lblendereco.Text = "Endereço";
            // 
            // mskcpf
            // 
            this.mskcpf.Location = new System.Drawing.Point(122, 198);
            this.mskcpf.Mask = "000000000-00";
            this.mskcpf.Name = "mskcpf";
            this.mskcpf.Size = new System.Drawing.Size(95, 20);
            this.mskcpf.TabIndex = 6;
            // 
            // lblcpf
            // 
            this.lblcpf.AutoSize = true;
            this.lblcpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcpf.Location = new System.Drawing.Point(35, 199);
            this.lblcpf.Name = "lblcpf";
            this.lblcpf.Size = new System.Drawing.Size(36, 16);
            this.lblcpf.TabIndex = 7;
            this.lblcpf.Text = "CPF";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnvoltar);
            this.panel1.Controls.Add(this.btnlimpar);
            this.panel1.Controls.Add(this.btnnovo);
            this.panel1.Controls.Add(this.lblprofissao);
            this.panel1.Controls.Add(this.cbbprofissao);
            this.panel1.Controls.Add(this.lblcpf);
            this.panel1.Controls.Add(this.mskcpf);
            this.panel1.Controls.Add(this.lblendereco);
            this.panel1.Controls.Add(this.lblnome);
            this.panel1.Controls.Add(this.lblcodigo);
            this.panel1.Controls.Add(this.txtendereco);
            this.panel1.Controls.Add(this.txtnome);
            this.panel1.Controls.Add(this.txtcodigo);
            this.panel1.Location = new System.Drawing.Point(249, 117);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(469, 330);
            this.panel1.TabIndex = 8;
            // 
            // btnvoltar
            // 
            this.btnvoltar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnvoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnvoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvoltar.Location = new System.Drawing.Point(295, 171);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(158, 44);
            this.btnvoltar.TabIndex = 14;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = false;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.BackColor = System.Drawing.Color.LightCoral;
            this.btnlimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpar.Location = new System.Drawing.Point(336, 238);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(86, 30);
            this.btnlimpar.TabIndex = 13;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = false;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnnovo
            // 
            this.btnnovo.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnnovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnovo.Location = new System.Drawing.Point(295, 101);
            this.btnnovo.Name = "btnnovo";
            this.btnnovo.Size = new System.Drawing.Size(158, 44);
            this.btnnovo.TabIndex = 12;
            this.btnnovo.Text = "Novo";
            this.btnnovo.UseVisualStyleBackColor = false;
            this.btnnovo.Click += new System.EventHandler(this.btnnovo_Click);
            // 
            // lblprofissao
            // 
            this.lblprofissao.AutoSize = true;
            this.lblprofissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprofissao.Location = new System.Drawing.Point(35, 252);
            this.lblprofissao.Name = "lblprofissao";
            this.lblprofissao.Size = new System.Drawing.Size(73, 16);
            this.lblprofissao.TabIndex = 11;
            this.lblprofissao.Text = "Profissão";
            // 
            // cbbprofissao
            // 
            this.cbbprofissao.FormattingEnabled = true;
            this.cbbprofissao.Items.AddRange(new object[] {
            "Administrador",
            "Analista",
            "Gerente",
            "Supervisor",
            "Auxiliar",
            "Diretor",
            "Copeiro"});
            this.cbbprofissao.Location = new System.Drawing.Point(122, 247);
            this.cbbprofissao.Name = "cbbprofissao";
            this.cbbprofissao.Size = new System.Drawing.Size(121, 21);
            this.cbbprofissao.TabIndex = 10;
            // 
            // frmcliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(963, 607);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmcliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txtendereco;
        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.Label lblendereco;
        private System.Windows.Forms.MaskedTextBox mskcpf;
        private System.Windows.Forms.Label lblcpf;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblprofissao;
        private System.Windows.Forms.ComboBox cbbprofissao;
        private System.Windows.Forms.Button btnnovo;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btnlimpar;
    }
}