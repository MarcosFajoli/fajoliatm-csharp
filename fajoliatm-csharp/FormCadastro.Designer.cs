namespace fajoliatm_csharp
{
    partial class FormCadastro
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
            this.LabelTipoConta = new System.Windows.Forms.Label();
            this.TextBoxNome = new System.Windows.Forms.TextBox();
            this.LabelNome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TipoConta = new System.Windows.Forms.ComboBox();
            this.ButtonCadastrar = new System.Windows.Forms.Button();
            this.ValorDeposito = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // LabelTipoConta
            // 
            this.LabelTipoConta.AutoSize = true;
            this.LabelTipoConta.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelTipoConta.Location = new System.Drawing.Point(25, 137);
            this.LabelTipoConta.Name = "LabelTipoConta";
            this.LabelTipoConta.Size = new System.Drawing.Size(145, 30);
            this.LabelTipoConta.TabIndex = 3;
            this.LabelTipoConta.Text = "Tipo da conta";
            // 
            // TextBoxNome
            // 
            this.TextBoxNome.Location = new System.Drawing.Point(30, 86);
            this.TextBoxNome.Name = "TextBoxNome";
            this.TextBoxNome.Size = new System.Drawing.Size(256, 23);
            this.TextBoxNome.TabIndex = 5;
            // 
            // LabelNome
            // 
            this.LabelNome.AutoSize = true;
            this.LabelNome.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelNome.Location = new System.Drawing.Point(25, 53);
            this.LabelNome.Name = "LabelNome";
            this.LabelNome.Size = new System.Drawing.Size(73, 30);
            this.LabelNome.TabIndex = 2;
            this.LabelNome.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(25, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "Valor de depósito inicial";
            // 
            // TipoConta
            // 
            this.TipoConta.FormattingEnabled = true;
            this.TipoConta.Items.AddRange(new object[] {
            "Conta Corrente",
            "Conta Poupança"});
            this.TipoConta.Location = new System.Drawing.Point(30, 170);
            this.TipoConta.Name = "TipoConta";
            this.TipoConta.Size = new System.Drawing.Size(256, 23);
            this.TipoConta.TabIndex = 8;
            // 
            // ButtonCadastrar
            // 
            this.ButtonCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(71)))), ((int)(((byte)(255)))));
            this.ButtonCadastrar.FlatAppearance.BorderSize = 0;
            this.ButtonCadastrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(50)))), ((int)(((byte)(255)))));
            this.ButtonCadastrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(50)))), ((int)(((byte)(255)))));
            this.ButtonCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCadastrar.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonCadastrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ButtonCadastrar.Location = new System.Drawing.Point(73, 339);
            this.ButtonCadastrar.Name = "ButtonCadastrar";
            this.ButtonCadastrar.Size = new System.Drawing.Size(173, 79);
            this.ButtonCadastrar.TabIndex = 9;
            this.ButtonCadastrar.Text = "Cadastrar";
            this.ButtonCadastrar.UseMnemonic = false;
            this.ButtonCadastrar.UseVisualStyleBackColor = false;
            this.ButtonCadastrar.Click += new System.EventHandler(this.ButtonCadastrar_Click);
            // 
            // ValorDeposito
            // 
            this.ValorDeposito.Location = new System.Drawing.Point(30, 263);
            this.ValorDeposito.Name = "ValorDeposito";
            this.ValorDeposito.Size = new System.Drawing.Size(256, 23);
            this.ValorDeposito.TabIndex = 10;
            // 
            // FormCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(321, 450);
            this.Controls.Add(this.ValorDeposito);
            this.Controls.Add(this.ButtonCadastrar);
            this.Controls.Add(this.LabelNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TipoConta);
            this.Controls.Add(this.TextBoxNome);
            this.Controls.Add(this.LabelTipoConta);
            this.Name = "FormCadastro";
            this.Text = "Cadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LabelTipoConta;
        private TextBox TextBoxNome;
        private Label LabelNome;
        private Label label1;
        private ComboBox TipoConta;
        private Button ButtonCadastrar;
        private MaskedTextBox ValorDeposito;
    }
}