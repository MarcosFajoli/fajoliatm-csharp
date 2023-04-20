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
            this.labelConta = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.InputNomeCompleto = new System.Windows.Forms.TextBox();
            this.InputUserLogin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.InputDataNasc = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.InputPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ButtonCriarConta = new System.Windows.Forms.Button();
            this.ButtonVoltarMain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelConta
            // 
            this.labelConta.AutoSize = true;
            this.labelConta.BackColor = System.Drawing.Color.Gainsboro;
            this.labelConta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelConta.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelConta.Location = new System.Drawing.Point(12, 9);
            this.labelConta.Name = "labelConta";
            this.labelConta.Size = new System.Drawing.Size(357, 46);
            this.labelConta.TabIndex = 7;
            this.labelConta.Text = "BANCO LEMARCIAO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(7, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "Insira seu nome completo:";
            // 
            // InputNomeCompleto
            // 
            this.InputNomeCompleto.Location = new System.Drawing.Point(12, 116);
            this.InputNomeCompleto.Name = "InputNomeCompleto";
            this.InputNomeCompleto.Size = new System.Drawing.Size(357, 23);
            this.InputNomeCompleto.TabIndex = 13;
            // 
            // InputUserLogin
            // 
            this.InputUserLogin.Location = new System.Drawing.Point(12, 180);
            this.InputUserLogin.Name = "InputUserLogin";
            this.InputUserLogin.Size = new System.Drawing.Size(357, 23);
            this.InputUserLogin.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(7, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 21);
            this.label3.TabIndex = 14;
            this.label3.Text = "Insira seu nome de usuário:";
            // 
            // InputDataNasc
            // 
            this.InputDataNasc.Location = new System.Drawing.Point(12, 247);
            this.InputDataNasc.MaxDate = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
            this.InputDataNasc.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.InputDataNasc.Name = "InputDataNasc";
            this.InputDataNasc.Size = new System.Drawing.Size(242, 23);
            this.InputDataNasc.TabIndex = 16;
            this.InputDataNasc.Value = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(8, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(246, 21);
            this.label4.TabIndex = 17;
            this.label4.Text = "Selecione sua data de nascimento:";
            // 
            // InputPassword
            // 
            this.InputPassword.Location = new System.Drawing.Point(12, 312);
            this.InputPassword.Name = "InputPassword";
            this.InputPassword.PasswordChar = '*';
            this.InputPassword.Size = new System.Drawing.Size(357, 23);
            this.InputPassword.TabIndex = 19;
            this.InputPassword.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(7, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(213, 21);
            this.label5.TabIndex = 18;
            this.label5.Text = "Insira sua senha para acesso: ";
            // 
            // ButtonCriarConta
            // 
            this.ButtonCriarConta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ButtonCriarConta.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ButtonCriarConta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ButtonCriarConta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ButtonCriarConta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCriarConta.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonCriarConta.Location = new System.Drawing.Point(206, 358);
            this.ButtonCriarConta.Name = "ButtonCriarConta";
            this.ButtonCriarConta.Size = new System.Drawing.Size(163, 61);
            this.ButtonCriarConta.TabIndex = 20;
            this.ButtonCriarConta.Text = "Criar Conta";
            this.ButtonCriarConta.UseVisualStyleBackColor = false;
            // 
            // ButtonVoltarMain
            // 
            this.ButtonVoltarMain.BackColor = System.Drawing.Color.Gainsboro;
            this.ButtonVoltarMain.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ButtonVoltarMain.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.ButtonVoltarMain.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.ButtonVoltarMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonVoltarMain.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonVoltarMain.Location = new System.Drawing.Point(12, 358);
            this.ButtonVoltarMain.Name = "ButtonVoltarMain";
            this.ButtonVoltarMain.Size = new System.Drawing.Size(163, 61);
            this.ButtonVoltarMain.TabIndex = 21;
            this.ButtonVoltarMain.Text = "Voltar";
            this.ButtonVoltarMain.UseVisualStyleBackColor = false;
            // 
            // FormCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 440);
            this.Controls.Add(this.ButtonVoltarMain);
            this.Controls.Add(this.ButtonCriarConta);
            this.Controls.Add(this.InputPassword);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.InputDataNasc);
            this.Controls.Add(this.InputUserLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.InputNomeCompleto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelConta);
            this.Name = "FormCadastro";
            this.Text = "FormCadastro";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCadastro_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

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