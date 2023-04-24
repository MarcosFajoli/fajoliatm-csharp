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
            ComboBoxContas = new ComboBox();
            ButtonCadastro = new Button();
            ButtonDepositar = new Button();
            ButtonTransferir = new Button();
            ButtonSacar = new Button();
            panel1 = new Panel();
            TipoConta = new Label();
            NomeConta = new Label();
            SaldoValor = new Label();
            LabelSaldo = new Label();
            LabelTipoConta = new Label();
            LabelNome = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // ComboBoxContas
            // 
            ComboBoxContas.FormattingEnabled = true;
            ComboBoxContas.Location = new Point(100, 26);
            ComboBoxContas.Name = "ComboBoxContas";
            ComboBoxContas.Size = new Size(447, 23);
            ComboBoxContas.TabIndex = 0;
            ComboBoxContas.SelectedIndexChanged += ComboBoxContas_SelectedIndexChanged;
            // 
            // ButtonCadastro
            // 
            ButtonCadastro.BackColor = Color.FromArgb(151, 71, 255);
            ButtonCadastro.FlatAppearance.BorderSize = 0;
            ButtonCadastro.FlatAppearance.MouseDownBackColor = Color.FromArgb(140, 50, 255);
            ButtonCadastro.FlatAppearance.MouseOverBackColor = Color.FromArgb(140, 50, 255);
            ButtonCadastro.FlatStyle = FlatStyle.Flat;
            ButtonCadastro.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonCadastro.ForeColor = SystemColors.ControlLightLight;
            ButtonCadastro.Location = new Point(588, 10);
            ButtonCadastro.Name = "ButtonCadastro";
            ButtonCadastro.Size = new Size(181, 54);
            ButtonCadastro.TabIndex = 1;
            ButtonCadastro.Text = "Cadastrar";
            ButtonCadastro.UseMnemonic = false;
            ButtonCadastro.UseVisualStyleBackColor = false;
            ButtonCadastro.Click += ButtonCadastro_Click;
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
            ButtonDepositar.Location = new Point(144, 357);
            ButtonDepositar.Name = "ButtonDepositar";
            ButtonDepositar.Size = new Size(173, 79);
            ButtonDepositar.TabIndex = 2;
            ButtonDepositar.Text = "Depositar";
            ButtonDepositar.UseMnemonic = false;
            ButtonDepositar.UseVisualStyleBackColor = false;
            ButtonDepositar.Click += ButtonDepositar_Click;
            // 
            // ButtonTransferir
            // 
            ButtonTransferir.BackColor = Color.FromArgb(151, 71, 255);
            ButtonTransferir.FlatAppearance.BorderSize = 0;
            ButtonTransferir.FlatAppearance.MouseDownBackColor = Color.FromArgb(140, 50, 255);
            ButtonTransferir.FlatAppearance.MouseOverBackColor = Color.FromArgb(140, 50, 255);
            ButtonTransferir.FlatStyle = FlatStyle.Flat;
            ButtonTransferir.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonTransferir.ForeColor = SystemColors.ControlLightLight;
            ButtonTransferir.Location = new Point(510, 357);
            ButtonTransferir.Name = "ButtonTransferir";
            ButtonTransferir.Size = new Size(173, 79);
            ButtonTransferir.TabIndex = 3;
            ButtonTransferir.Text = "Transferir";
            ButtonTransferir.UseMnemonic = false;
            ButtonTransferir.UseVisualStyleBackColor = false;
            ButtonTransferir.Click += ButtonTransferir_Click;
            // 
            // ButtonSacar
            // 
            ButtonSacar.BackColor = Color.FromArgb(151, 71, 255);
            ButtonSacar.FlatAppearance.BorderSize = 0;
            ButtonSacar.FlatAppearance.MouseDownBackColor = Color.FromArgb(140, 50, 255);
            ButtonSacar.FlatAppearance.MouseOverBackColor = Color.FromArgb(140, 50, 255);
            ButtonSacar.FlatStyle = FlatStyle.Flat;
            ButtonSacar.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonSacar.ForeColor = SystemColors.ControlLightLight;
            ButtonSacar.Location = new Point(327, 357);
            ButtonSacar.Name = "ButtonSacar";
            ButtonSacar.Size = new Size(173, 79);
            ButtonSacar.TabIndex = 4;
            ButtonSacar.Text = "Sacar";
            ButtonSacar.UseMnemonic = false;
            ButtonSacar.UseVisualStyleBackColor = false;
            ButtonSacar.Click += ButtonSacar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(238, 224, 255);
            panel1.Controls.Add(TipoConta);
            panel1.Controls.Add(NomeConta);
            panel1.Controls.Add(SaldoValor);
            panel1.Controls.Add(LabelSaldo);
            panel1.Controls.Add(LabelTipoConta);
            panel1.Controls.Add(LabelNome);
            panel1.Location = new Point(44, 86);
            panel1.Name = "panel1";
            panel1.Size = new Size(395, 236);
            panel1.TabIndex = 5;
            // 
            // TipoConta
            // 
            TipoConta.AutoSize = true;
            TipoConta.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            TipoConta.Location = new Point(92, 53);
            TipoConta.Name = "TipoConta";
            TipoConta.Size = new Size(99, 30);
            TipoConta.TabIndex = 5;
            TipoConta.Text = "Corrente";
            // 
            // NomeConta
            // 
            NomeConta.AutoSize = true;
            NomeConta.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            NomeConta.Location = new Point(92, 6);
            NomeConta.Name = "NomeConta";
            NomeConta.Size = new Size(140, 30);
            NomeConta.TabIndex = 4;
            NomeConta.Text = "Fulano de Tal";
            // 
            // SaldoValor
            // 
            SaldoValor.AutoSize = true;
            SaldoValor.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            SaldoValor.Location = new Point(177, 137);
            SaldoValor.Name = "SaldoValor";
            SaldoValor.Size = new Size(199, 54);
            SaldoValor.TabIndex = 3;
            SaldoValor.Text = "R$ 000,00";
            // 
            // LabelSaldo
            // 
            LabelSaldo.AutoSize = true;
            LabelSaldo.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            LabelSaldo.Location = new Point(8, 146);
            LabelSaldo.Name = "LabelSaldo";
            LabelSaldo.Size = new Size(156, 37);
            LabelSaldo.TabIndex = 2;
            LabelSaldo.Text = "Saldo atual:";
            // 
            // LabelTipoConta
            // 
            LabelTipoConta.AutoSize = true;
            LabelTipoConta.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            LabelTipoConta.Location = new Point(8, 53);
            LabelTipoConta.Name = "LabelTipoConta";
            LabelTipoConta.Size = new Size(75, 30);
            LabelTipoConta.TabIndex = 1;
            LabelTipoConta.Text = "Conta:";
            // 
            // LabelNome
            // 
            LabelNome.AutoSize = true;
            LabelNome.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            LabelNome.Location = new Point(8, 6);
            LabelNome.Name = "LabelNome";
            LabelNome.Size = new Size(78, 30);
            LabelNome.TabIndex = 0;
            LabelNome.Text = "Nome:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(214, 180, 255);
            panel2.Location = new Point(36, 94);
            panel2.Name = "panel2";
            panel2.Size = new Size(395, 236);
            panel2.TabIndex = 6;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(805, 456);
            Controls.Add(panel1);
            Controls.Add(ButtonSacar);
            Controls.Add(ButtonTransferir);
            Controls.Add(ButtonDepositar);
            Controls.Add(panel2);
            Controls.Add(ButtonCadastro);
            Controls.Add(ComboBoxContas);
            Name = "FormMain";
            Text = "Fajoli's Bank";
            Activated += FormMain_Activated;
            Load += FormMain_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox ComboBoxContas;
        private Button ButtonCadastro;
        private Button ButtonDepositar;
        private Button ButtonTransferir;
        private Button ButtonSacar;
        private Panel panel1;
        private Label LabelNome;
        private Label SaldoValor;
        private Label LabelSaldo;
        private Label LabelTipoConta;
        private Panel panel2;
        private Label NomeConta;
        private Label TipoConta;
    }
}