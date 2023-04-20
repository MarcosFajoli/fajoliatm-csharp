namespace fajoliatm_csharp
{
    partial class FormSacarDepositar
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
            ContaOrigem = new ComboBox();
            ButtonSacarDepositar = new Button();
            ValorSaqueDeposito = new TextBox();
            LabelNome = new Label();
            label1 = new Label();
            LabelTipoConta = new Label();
            SaldoAtual = new TextBox();
            SuspendLayout();
            // 
            // ContaOrigem
            // 
            ContaOrigem.Enabled = false;
            ContaOrigem.FormattingEnabled = true;
            ContaOrigem.Location = new Point(35, 76);
            ContaOrigem.Name = "ContaOrigem";
            ContaOrigem.Size = new Size(256, 23);
            ContaOrigem.TabIndex = 24;
            // 
            // ButtonSacarDepositar
            // 
            ButtonSacarDepositar.BackColor = Color.FromArgb(151, 71, 255);
            ButtonSacarDepositar.FlatAppearance.BorderSize = 0;
            ButtonSacarDepositar.FlatAppearance.MouseDownBackColor = Color.FromArgb(140, 50, 255);
            ButtonSacarDepositar.FlatAppearance.MouseOverBackColor = Color.FromArgb(140, 50, 255);
            ButtonSacarDepositar.FlatStyle = FlatStyle.Flat;
            ButtonSacarDepositar.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonSacarDepositar.ForeColor = SystemColors.ControlLightLight;
            ButtonSacarDepositar.Location = new Point(78, 329);
            ButtonSacarDepositar.Name = "ButtonSacarDepositar";
            ButtonSacarDepositar.Size = new Size(173, 79);
            ButtonSacarDepositar.TabIndex = 23;
            ButtonSacarDepositar.Text = "Sacar";
            ButtonSacarDepositar.UseMnemonic = false;
            ButtonSacarDepositar.UseVisualStyleBackColor = false;
            // 
            // ValorSaqueDeposito
            // 
            ValorSaqueDeposito.Location = new Point(35, 260);
            ValorSaqueDeposito.Name = "ValorSaqueDeposito";
            ValorSaqueDeposito.Size = new Size(256, 23);
            ValorSaqueDeposito.TabIndex = 21;
            // 
            // LabelNome
            // 
            LabelNome.AutoSize = true;
            LabelNome.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            LabelNome.Location = new Point(30, 43);
            LabelNome.Name = "LabelNome";
            LabelNome.Size = new Size(177, 30);
            LabelNome.TabIndex = 18;
            LabelNome.Text = "Conta de origem";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(124, 220);
            label1.Name = "label1";
            label1.Size = new Size(78, 37);
            label1.TabIndex = 20;
            label1.Text = "Valor";
            // 
            // LabelTipoConta
            // 
            LabelTipoConta.AutoSize = true;
            LabelTipoConta.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            LabelTipoConta.Location = new Point(30, 127);
            LabelTipoConta.Name = "LabelTipoConta";
            LabelTipoConta.Size = new Size(119, 30);
            LabelTipoConta.TabIndex = 19;
            LabelTipoConta.Text = "Saldo atual";
            // 
            // SaldoAtual
            // 
            SaldoAtual.Enabled = false;
            SaldoAtual.Location = new Point(35, 160);
            SaldoAtual.Name = "SaldoAtual";
            SaldoAtual.Size = new Size(256, 23);
            SaldoAtual.TabIndex = 25;
            // 
            // FormSacarDepositar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(321, 450);
            Controls.Add(SaldoAtual);
            Controls.Add(ContaOrigem);
            Controls.Add(ButtonSacarDepositar);
            Controls.Add(ValorSaqueDeposito);
            Controls.Add(LabelNome);
            Controls.Add(label1);
            Controls.Add(LabelTipoConta);
            Name = "FormSacarDepositar";
            Text = "FormSacarDepositar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox ContaOrigem;
        private Button ButtonSacarDepositar;
        private TextBox ValorSaqueDeposito;
        private Label LabelNome;
        private Label label1;
        private Label LabelTipoConta;
        private TextBox SaldoAtual;
    }
}