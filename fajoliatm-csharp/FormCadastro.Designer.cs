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
            labelConta = new Label();
            label1 = new Label();
            label2 = new Label();
            InputNomeCompleto = new TextBox();
            InputUserLogin = new TextBox();
            label3 = new Label();
            InputDataNasc = new DateTimePicker();
            label4 = new Label();
            InputPassword = new TextBox();
            label5 = new Label();
            ButtonCriarConta = new Button();
            ButtonVoltarMain = new Button();
            SuspendLayout();
            // 
            // labelConta
            // 
            labelConta.AutoSize = true;
            labelConta.BackColor = Color.Gainsboro;
            labelConta.BorderStyle = BorderStyle.Fixed3D;
            labelConta.Font = new Font("Palatino Linotype", 24F, FontStyle.Bold, GraphicsUnit.Point);
            labelConta.Location = new Point(12, 9);
            labelConta.Name = "labelConta";
            labelConta.Size = new Size(357, 46);
            labelConta.TabIndex = 7;
            labelConta.Text = "BANCO LEMARCIAO";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(88, 113);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.WhiteSmoke;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(7, 92);
            label2.Name = "label2";
            label2.Size = new Size(192, 21);
            label2.TabIndex = 12;
            label2.Text = "Insira seu nome completo:";
            // 
            // InputNomeCompleto
            // 
            InputNomeCompleto.Location = new Point(12, 116);
            InputNomeCompleto.Name = "InputNomeCompleto";
            InputNomeCompleto.Size = new Size(357, 23);
            InputNomeCompleto.TabIndex = 13;
            // 
            // InputUserLogin
            // 
            InputUserLogin.Location = new Point(12, 180);
            InputUserLogin.Name = "InputUserLogin";
            InputUserLogin.Size = new Size(357, 23);
            InputUserLogin.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.WhiteSmoke;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(7, 156);
            label3.Name = "label3";
            label3.Size = new Size(200, 21);
            label3.TabIndex = 14;
            label3.Text = "Insira seu nome de usuário:";
            // 
            // InputDataNasc
            // 
            InputDataNasc.Location = new Point(12, 247);
            InputDataNasc.MaxDate = new DateTime(2023, 1, 1, 0, 0, 0, 0);
            InputDataNasc.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            InputDataNasc.Name = "InputDataNasc";
            InputDataNasc.Size = new Size(242, 23);
            InputDataNasc.TabIndex = 16;
            InputDataNasc.Value = new DateTime(2023, 1, 1, 0, 0, 0, 0);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.WhiteSmoke;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(8, 223);
            label4.Name = "label4";
            label4.Size = new Size(246, 21);
            label4.TabIndex = 17;
            label4.Text = "Selecione sua data de nascimento:";
            // 
            // InputPassword
            // 
            InputPassword.Location = new Point(12, 312);
            InputPassword.Name = "InputPassword";
            InputPassword.PasswordChar = '*';
            InputPassword.Size = new Size(357, 23);
            InputPassword.TabIndex = 19;
            InputPassword.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.WhiteSmoke;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(7, 288);
            label5.Name = "label5";
            label5.Size = new Size(213, 21);
            label5.TabIndex = 18;
            label5.Text = "Insira sua senha para acesso: ";
            // 
            // ButtonCriarConta
            // 
            ButtonCriarConta.BackColor = Color.FromArgb(192, 255, 192);
            ButtonCriarConta.FlatAppearance.BorderColor = Color.Black;
            ButtonCriarConta.FlatAppearance.MouseDownBackColor = Color.Transparent;
            ButtonCriarConta.FlatAppearance.MouseOverBackColor = Color.Transparent;
            ButtonCriarConta.FlatStyle = FlatStyle.Flat;
            ButtonCriarConta.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonCriarConta.Location = new Point(206, 358);
            ButtonCriarConta.Name = "ButtonCriarConta";
            ButtonCriarConta.Size = new Size(163, 61);
            ButtonCriarConta.TabIndex = 20;
            ButtonCriarConta.Text = "Criar Conta";
            ButtonCriarConta.UseVisualStyleBackColor = false;
            ButtonCriarConta.Click += ButtonCriarConta_Click;
            // 
            // ButtonVoltarMain
            // 
            ButtonVoltarMain.BackColor = Color.Gainsboro;
            ButtonVoltarMain.FlatAppearance.BorderColor = Color.Black;
            ButtonVoltarMain.FlatAppearance.MouseDownBackColor = Color.Silver;
            ButtonVoltarMain.FlatAppearance.MouseOverBackColor = Color.Silver;
            ButtonVoltarMain.FlatStyle = FlatStyle.Flat;
            ButtonVoltarMain.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonVoltarMain.Location = new Point(12, 358);
            ButtonVoltarMain.Name = "ButtonVoltarMain";
            ButtonVoltarMain.Size = new Size(163, 61);
            ButtonVoltarMain.TabIndex = 21;
            ButtonVoltarMain.Text = "Voltar";
            ButtonVoltarMain.UseVisualStyleBackColor = false;
            ButtonVoltarMain.Click += ButtonVoltarMain_Click;
            // 
            // FormCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(385, 440);
            Controls.Add(ButtonVoltarMain);
            Controls.Add(ButtonCriarConta);
            Controls.Add(InputPassword);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(InputDataNasc);
            Controls.Add(InputUserLogin);
            Controls.Add(label3);
            Controls.Add(InputNomeCompleto);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(labelConta);
            Name = "FormCadastro";
            Text = "FormCadastro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelConta;
        private Label label1;
        private Label label2;
        private TextBox InputNomeCompleto;
        private TextBox InputUserLogin;
        private Label label3;
        private DateTimePicker InputDataNasc;
        private Label label4;
        private TextBox InputPassword;
        private Label label5;
        private Button ButtonCriarConta;
        private Button ButtonVoltarMain;
    }
}