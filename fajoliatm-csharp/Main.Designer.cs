namespace fajoliatm_csharp
{
    partial class Main
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
            ButtonSacar = new Button();
            splitter1 = new Splitter();
            labelConta = new Label();
            ButtonDepositar = new Button();
            ButtonTransferir = new Button();
            ButtonConsultarExtrato = new Button();
            ButtonEmprestimos = new Button();
            label1 = new Label();
            ButtonCadastrar = new Button();
            label2 = new Label();
            ButtonEntrar = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // ButtonSacar
            // 
            ButtonSacar.BackColor = Color.Gainsboro;
            ButtonSacar.Enabled = false;
            ButtonSacar.FlatAppearance.BorderColor = Color.Black;
            ButtonSacar.FlatAppearance.MouseDownBackColor = Color.Silver;
            ButtonSacar.FlatAppearance.MouseOverBackColor = Color.Silver;
            ButtonSacar.FlatStyle = FlatStyle.Flat;
            ButtonSacar.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonSacar.Location = new Point(724, 12);
            ButtonSacar.Name = "ButtonSacar";
            ButtonSacar.Size = new Size(163, 79);
            ButtonSacar.TabIndex = 0;
            ButtonSacar.Text = "Sacar";
            ButtonSacar.UseVisualStyleBackColor = false;
            // 
            // splitter1
            // 
            splitter1.BackColor = Color.WhiteSmoke;
            splitter1.Location = new Point(0, 0);
            splitter1.Margin = new Padding(0, 0, 2, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(379, 440);
            splitter1.TabIndex = 5;
            splitter1.TabStop = false;
            // 
            // labelConta
            // 
            labelConta.AutoSize = true;
            labelConta.BackColor = Color.Gainsboro;
            labelConta.BorderStyle = BorderStyle.Fixed3D;
            labelConta.Font = new Font("Palatino Linotype", 24F, FontStyle.Bold, GraphicsUnit.Point);
            labelConta.Location = new Point(12, 26);
            labelConta.Name = "labelConta";
            labelConta.Size = new Size(357, 46);
            labelConta.TabIndex = 6;
            labelConta.Text = "BANCO LEMARCIAO";
            // 
            // ButtonDepositar
            // 
            ButtonDepositar.BackColor = Color.Gainsboro;
            ButtonDepositar.Enabled = false;
            ButtonDepositar.FlatAppearance.BorderColor = Color.Black;
            ButtonDepositar.FlatAppearance.MouseDownBackColor = Color.Silver;
            ButtonDepositar.FlatAppearance.MouseOverBackColor = Color.Silver;
            ButtonDepositar.FlatStyle = FlatStyle.Flat;
            ButtonDepositar.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonDepositar.Location = new Point(724, 97);
            ButtonDepositar.Name = "ButtonDepositar";
            ButtonDepositar.Size = new Size(163, 79);
            ButtonDepositar.TabIndex = 7;
            ButtonDepositar.Text = "Depositar";
            ButtonDepositar.UseVisualStyleBackColor = false;
            // 
            // ButtonTransferir
            // 
            ButtonTransferir.BackColor = Color.Gainsboro;
            ButtonTransferir.Enabled = false;
            ButtonTransferir.FlatAppearance.BorderColor = Color.Black;
            ButtonTransferir.FlatAppearance.MouseDownBackColor = Color.Silver;
            ButtonTransferir.FlatAppearance.MouseOverBackColor = Color.Silver;
            ButtonTransferir.FlatStyle = FlatStyle.Flat;
            ButtonTransferir.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonTransferir.Location = new Point(724, 182);
            ButtonTransferir.Name = "ButtonTransferir";
            ButtonTransferir.Size = new Size(163, 79);
            ButtonTransferir.TabIndex = 8;
            ButtonTransferir.Text = "Transferir";
            ButtonTransferir.UseVisualStyleBackColor = false;
            // 
            // ButtonConsultarExtrato
            // 
            ButtonConsultarExtrato.BackColor = Color.Gainsboro;
            ButtonConsultarExtrato.Enabled = false;
            ButtonConsultarExtrato.FlatAppearance.BorderColor = Color.Black;
            ButtonConsultarExtrato.FlatAppearance.MouseDownBackColor = Color.Silver;
            ButtonConsultarExtrato.FlatAppearance.MouseOverBackColor = Color.Silver;
            ButtonConsultarExtrato.FlatStyle = FlatStyle.Flat;
            ButtonConsultarExtrato.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonConsultarExtrato.Location = new Point(724, 267);
            ButtonConsultarExtrato.Name = "ButtonConsultarExtrato";
            ButtonConsultarExtrato.Size = new Size(163, 79);
            ButtonConsultarExtrato.TabIndex = 9;
            ButtonConsultarExtrato.Text = "Consultar Extrato";
            ButtonConsultarExtrato.UseVisualStyleBackColor = false;
            // 
            // ButtonEmprestimos
            // 
            ButtonEmprestimos.BackColor = Color.Gainsboro;
            ButtonEmprestimos.Enabled = false;
            ButtonEmprestimos.FlatAppearance.BorderColor = Color.Black;
            ButtonEmprestimos.FlatAppearance.MouseDownBackColor = Color.Silver;
            ButtonEmprestimos.FlatAppearance.MouseOverBackColor = Color.Silver;
            ButtonEmprestimos.FlatStyle = FlatStyle.Flat;
            ButtonEmprestimos.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonEmprestimos.Location = new Point(724, 352);
            ButtonEmprestimos.Name = "ButtonEmprestimos";
            ButtonEmprestimos.Size = new Size(163, 79);
            ButtonEmprestimos.TabIndex = 10;
            ButtonEmprestimos.Text = "Empréstimos";
            ButtonEmprestimos.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.WhiteSmoke;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(57, 128);
            label1.Name = "label1";
            label1.Size = new Size(247, 21);
            label1.TabIndex = 11;
            label1.Text = "Não tem uma conta? Cadastre-se: ";
            // 
            // ButtonCadastrar
            // 
            ButtonCadastrar.BackColor = Color.Gainsboro;
            ButtonCadastrar.Enabled = false;
            ButtonCadastrar.FlatAppearance.BorderColor = Color.Black;
            ButtonCadastrar.FlatAppearance.MouseDownBackColor = Color.Silver;
            ButtonCadastrar.FlatAppearance.MouseOverBackColor = Color.Silver;
            ButtonCadastrar.FlatStyle = FlatStyle.Flat;
            ButtonCadastrar.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonCadastrar.Location = new Point(99, 152);
            ButtonCadastrar.Name = "ButtonCadastrar";
            ButtonCadastrar.Size = new Size(163, 61);
            ButtonCadastrar.TabIndex = 12;
            ButtonCadastrar.Text = "Cadastre-se";
            ButtonCadastrar.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.WhiteSmoke;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(108, 281);
            label2.Name = "label2";
            label2.Size = new Size(145, 21);
            label2.TabIndex = 13;
            label2.Text = "Entre em sua conta:";
            // 
            // ButtonEntrar
            // 
            ButtonEntrar.BackColor = Color.Gainsboro;
            ButtonEntrar.Enabled = false;
            ButtonEntrar.FlatAppearance.BorderColor = Color.Black;
            ButtonEntrar.FlatAppearance.MouseDownBackColor = Color.Silver;
            ButtonEntrar.FlatAppearance.MouseOverBackColor = Color.Silver;
            ButtonEntrar.FlatStyle = FlatStyle.Flat;
            ButtonEntrar.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonEntrar.Location = new Point(99, 305);
            ButtonEntrar.Name = "ButtonEntrar";
            ButtonEntrar.Size = new Size(163, 61);
            ButtonEntrar.TabIndex = 14;
            ButtonEntrar.Text = "Entrar";
            ButtonEntrar.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.WhiteSmoke;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(170, 240);
            label3.Name = "label3";
            label3.Size = new Size(28, 21);
            label3.TabIndex = 15;
            label3.Text = "ou";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(899, 440);
            Controls.Add(label3);
            Controls.Add(ButtonEntrar);
            Controls.Add(label2);
            Controls.Add(ButtonCadastrar);
            Controls.Add(label1);
            Controls.Add(ButtonEmprestimos);
            Controls.Add(ButtonConsultarExtrato);
            Controls.Add(ButtonTransferir);
            Controls.Add(ButtonDepositar);
            Controls.Add(labelConta);
            Controls.Add(splitter1);
            Controls.Add(ButtonSacar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ButtonSacar;
        private Splitter splitter1;
        private Label labelConta;
        private Button ButtonDepositar;
        private Button ButtonTransferir;
        private Button ButtonConsultarExtrato;
        private Button ButtonEmprestimos;
        private Label label1;
        private Button ButtonCadastrar;
        private Label label2;
        private Button ButtonEntrar;
        private Label label3;
    }
}