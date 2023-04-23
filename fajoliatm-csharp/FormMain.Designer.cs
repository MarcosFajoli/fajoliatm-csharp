namespace fajoliatm_csharp
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ComboBoxContas = new System.Windows.Forms.ComboBox();
            this.ButtonCadastro = new System.Windows.Forms.Button();
            this.ButtonDepositar = new System.Windows.Forms.Button();
            this.ButtonTransferir = new System.Windows.Forms.Button();
            this.ButtonSacar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelSaldoValor = new System.Windows.Forms.Label();
            this.LabelSaldo = new System.Windows.Forms.Label();
            this.LabelTipoConta = new System.Windows.Forms.Label();
            this.LabelNome = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ComboBoxContas
            // 
            this.ComboBoxContas.FormattingEnabled = true;
            this.ComboBoxContas.Location = new System.Drawing.Point(100, 26);
            this.ComboBoxContas.Name = "ComboBoxContas";
            this.ComboBoxContas.Size = new System.Drawing.Size(447, 23);
            this.ComboBoxContas.TabIndex = 0;
            // 
            // ButtonCadastro
            // 
            this.ButtonCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(71)))), ((int)(((byte)(255)))));
            this.ButtonCadastro.FlatAppearance.BorderSize = 0;
            this.ButtonCadastro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(50)))), ((int)(((byte)(255)))));
            this.ButtonCadastro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(50)))), ((int)(((byte)(255)))));
            this.ButtonCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCadastro.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonCadastro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ButtonCadastro.Location = new System.Drawing.Point(588, 10);
            this.ButtonCadastro.Name = "ButtonCadastro";
            this.ButtonCadastro.Size = new System.Drawing.Size(181, 54);
            this.ButtonCadastro.TabIndex = 1;
            this.ButtonCadastro.Text = "Cadastrar";
            this.ButtonCadastro.UseMnemonic = false;
            this.ButtonCadastro.UseVisualStyleBackColor = false;
            this.ButtonCadastro.Click += new System.EventHandler(this.ButtonCadastro_Click_1);
            // 
            // ButtonDepositar
            // 
            this.ButtonDepositar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(71)))), ((int)(((byte)(255)))));
            this.ButtonDepositar.FlatAppearance.BorderSize = 0;
            this.ButtonDepositar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(50)))), ((int)(((byte)(255)))));
            this.ButtonDepositar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(50)))), ((int)(((byte)(255)))));
            this.ButtonDepositar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDepositar.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonDepositar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ButtonDepositar.Location = new System.Drawing.Point(144, 357);
            this.ButtonDepositar.Name = "ButtonDepositar";
            this.ButtonDepositar.Size = new System.Drawing.Size(173, 79);
            this.ButtonDepositar.TabIndex = 2;
            this.ButtonDepositar.Text = "Depositar";
            this.ButtonDepositar.UseMnemonic = false;
            this.ButtonDepositar.UseVisualStyleBackColor = false;
            // 
            // ButtonTransferir
            // 
            this.ButtonTransferir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(71)))), ((int)(((byte)(255)))));
            this.ButtonTransferir.FlatAppearance.BorderSize = 0;
            this.ButtonTransferir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(50)))), ((int)(((byte)(255)))));
            this.ButtonTransferir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(50)))), ((int)(((byte)(255)))));
            this.ButtonTransferir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonTransferir.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonTransferir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ButtonTransferir.Location = new System.Drawing.Point(510, 357);
            this.ButtonTransferir.Name = "ButtonTransferir";
            this.ButtonTransferir.Size = new System.Drawing.Size(173, 79);
            this.ButtonTransferir.TabIndex = 3;
            this.ButtonTransferir.Text = "Transferir";
            this.ButtonTransferir.UseMnemonic = false;
            this.ButtonTransferir.UseVisualStyleBackColor = false;
            this.ButtonTransferir.Click += new System.EventHandler(this.ButtonTransferir_Click);
            // 
            // ButtonSacar
            // 
            this.ButtonSacar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(71)))), ((int)(((byte)(255)))));
            this.ButtonSacar.FlatAppearance.BorderSize = 0;
            this.ButtonSacar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(50)))), ((int)(((byte)(255)))));
            this.ButtonSacar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(50)))), ((int)(((byte)(255)))));
            this.ButtonSacar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSacar.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonSacar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ButtonSacar.Location = new System.Drawing.Point(327, 357);
            this.ButtonSacar.Name = "ButtonSacar";
            this.ButtonSacar.Size = new System.Drawing.Size(173, 79);
            this.ButtonSacar.TabIndex = 4;
            this.ButtonSacar.Text = "Sacar";
            this.ButtonSacar.UseMnemonic = false;
            this.ButtonSacar.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.LabelSaldoValor);
            this.panel1.Controls.Add(this.LabelSaldo);
            this.panel1.Controls.Add(this.LabelTipoConta);
            this.panel1.Controls.Add(this.LabelNome);
            this.panel1.Location = new System.Drawing.Point(44, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(395, 236);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // LabelSaldoValor
            // 
            this.LabelSaldoValor.AutoSize = true;
            this.LabelSaldoValor.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelSaldoValor.Location = new System.Drawing.Point(140, 157);
            this.LabelSaldoValor.Name = "LabelSaldoValor";
            this.LabelSaldoValor.Size = new System.Drawing.Size(199, 54);
            this.LabelSaldoValor.TabIndex = 3;
            this.LabelSaldoValor.Text = "R$ 000,00";
            // 
            // LabelSaldo
            // 
            this.LabelSaldo.AutoSize = true;
            this.LabelSaldo.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelSaldo.Location = new System.Drawing.Point(8, 146);
            this.LabelSaldo.Name = "LabelSaldo";
            this.LabelSaldo.Size = new System.Drawing.Size(90, 37);
            this.LabelSaldo.TabIndex = 2;
            this.LabelSaldo.Text = "Saldo:";
            // 
            // LabelTipoConta
            // 
            this.LabelTipoConta.AutoSize = true;
            this.LabelTipoConta.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelTipoConta.Location = new System.Drawing.Point(8, 53);
            this.LabelTipoConta.Name = "LabelTipoConta";
            this.LabelTipoConta.Size = new System.Drawing.Size(75, 30);
            this.LabelTipoConta.TabIndex = 1;
            this.LabelTipoConta.Text = "Conta:";
            // 
            // LabelNome
            // 
            this.LabelNome.AutoSize = true;
            this.LabelNome.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelNome.Location = new System.Drawing.Point(8, 6);
            this.LabelNome.Name = "LabelNome";
            this.LabelNome.Size = new System.Drawing.Size(78, 30);
            this.LabelNome.TabIndex = 0;
            this.LabelNome.Text = "Nome:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.panel2.Location = new System.Drawing.Point(36, 94);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(395, 236);
            this.panel2.TabIndex = 6;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(805, 456);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ButtonSacar);
            this.Controls.Add(this.ButtonTransferir);
            this.Controls.Add(this.ButtonDepositar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ButtonCadastro);
            this.Controls.Add(this.ComboBoxContas);
            this.Name = "FormMain";
            this.Text = "Fajoli\'s Bank";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBox ComboBoxContas;
        private Button ButtonCadastro;
        private Button ButtonDepositar;
        private Button ButtonTransferir;
        private Button ButtonSacar;
        private Panel panel1;
        private Label LabelNome;
        private Label LabelSaldoValor;
        private Label LabelSaldo;
        private Label LabelTipoConta;
        private Panel panel2;
        private Label label1;
    }
}