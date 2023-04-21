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
            LabelTipoConta = new Label();
            TextBoxNome = new TextBox();
            LabelNome = new Label();
            label1 = new Label();
            TipoConta = new ComboBox();
            ValorDeposito = new TextBox();
            ButtonDepositar = new Button();
            SuspendLayout();
            // 
            // LabelTipoConta
            // 
            LabelTipoConta.AutoSize = true;
            LabelTipoConta.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            LabelTipoConta.Location = new Point(25, 137);
            LabelTipoConta.Name = "LabelTipoConta";
            LabelTipoConta.Size = new Size(70, 30);
            LabelTipoConta.TabIndex = 3;
            LabelTipoConta.Text = "Conta";
            // 
            // TextBoxNome
            // 
            TextBoxNome.Location = new Point(30, 86);
            TextBoxNome.Name = "TextBoxNome";
            TextBoxNome.Size = new Size(256, 23);
            TextBoxNome.TabIndex = 5;
            // 
            // LabelNome
            // 
            LabelNome.AutoSize = true;
            LabelNome.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            LabelNome.Location = new Point(25, 53);
            LabelNome.Name = "LabelNome";
            LabelNome.Size = new Size(73, 30);
            LabelNome.TabIndex = 2;
            LabelNome.Text = "Nome";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(25, 226);
            label1.Name = "label1";
            label1.Size = new Size(243, 30);
            label1.TabIndex = 4;
            label1.Text = "Valor de depósito inicial";
            // 
            // TipoConta
            // 
            TipoConta.FormattingEnabled = true;
            TipoConta.Location = new Point(30, 170);
            TipoConta.Name = "TipoConta";
            TipoConta.Size = new Size(256, 23);
            TipoConta.TabIndex = 8;
            // 
            // ValorDeposito
            // 
            ValorDeposito.Location = new Point(30, 259);
            ValorDeposito.Name = "ValorDeposito";
            ValorDeposito.Size = new Size(256, 23);
            ValorDeposito.TabIndex = 7;
            // 
            // ButtonDepositar
            // 
            ButtonDepositar.BackColor = Color.FromArgb(151, 71, 255);
            ButtonDepositar.FlatAppearance.BorderSize = 0;
            ButtonDepositar.FlatAppearance.MouseDownBackColor = Color.FromArgb(140, 50, 255);
            ButtonDepositar.FlatAppearance.MouseOverBackColor = Color.FromArgb(140, 50, 255);
            ButtonDepositar.FlatStyle = FlatStyle.Flat;
            ButtonDepositar.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonDepositar.ForeColor = SystemColors.ControlLightLight;
            ButtonDepositar.Location = new Point(73, 339);
            ButtonDepositar.Name = "ButtonDepositar";
            ButtonDepositar.Size = new Size(173, 79);
            ButtonDepositar.TabIndex = 9;
            ButtonDepositar.Text = "Cadastrar";
            ButtonDepositar.UseMnemonic = false;
            ButtonDepositar.UseVisualStyleBackColor = false;
            // 
            // FormCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(321, 450);
            Controls.Add(ButtonDepositar);
            Controls.Add(ValorDeposito);
            Controls.Add(LabelNome);
            Controls.Add(label1);
            Controls.Add(TipoConta);
            Controls.Add(TextBoxNome);
            Controls.Add(LabelTipoConta);
            Name = "FormCadastro";
            Text = "FormCadastro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelTipoConta;
        private TextBox TextBoxNome;
        private Label LabelNome;
        private Label label1;
        private ComboBox TipoConta;
        private TextBox ValorDeposito;
        private Button ButtonDepositar;
    }
}