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
            labelConta = new Label();
            label1 = new Label();
            ButtonCadastrar = new Button();
            label2 = new Label();
            ButtonEntrar = new Button();
            label3 = new Label();
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
            labelConta.TabIndex = 6;
            labelConta.Text = "BANCO LEMARCIAO";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.WhiteSmoke;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(61, 103);
            label1.Name = "label1";
            label1.Size = new Size(247, 21);
            label1.TabIndex = 11;
            label1.Text = "Não tem uma conta? Cadastre-se: ";
            // 
            // ButtonCadastrar
            // 
            ButtonCadastrar.BackColor = Color.Gainsboro;
            ButtonCadastrar.Enabled = true;
            ButtonCadastrar.FlatAppearance.BorderColor = Color.Black;
            ButtonCadastrar.FlatAppearance.MouseDownBackColor = Color.Silver;
            ButtonCadastrar.FlatAppearance.MouseOverBackColor = Color.Silver;
            ButtonCadastrar.FlatStyle = FlatStyle.Flat;
            ButtonCadastrar.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonCadastrar.Location = new Point(103, 127);
            ButtonCadastrar.Name = "ButtonCadastrar";
            ButtonCadastrar.Size = new Size(163, 61);
            ButtonCadastrar.TabIndex = 12;
            ButtonCadastrar.Text = "Cadastre-se";
            ButtonCadastrar.UseVisualStyleBackColor = false;
            ButtonCadastrar.Click += ButtonCadastrar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.WhiteSmoke;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(112, 266);
            label2.Name = "label2";
            label2.Size = new Size(145, 21);
            label2.TabIndex = 13;
            label2.Text = "Entre em sua conta:";
            // 
            // ButtonEntrar
            // 
            ButtonEntrar.BackColor = Color.Gainsboro;
            ButtonEntrar.Enabled = true;
            ButtonEntrar.FlatAppearance.BorderColor = Color.Black;
            ButtonEntrar.FlatAppearance.MouseDownBackColor = Color.Silver;
            ButtonEntrar.FlatAppearance.MouseOverBackColor = Color.Silver;
            ButtonEntrar.FlatStyle = FlatStyle.Flat;
            ButtonEntrar.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonEntrar.Location = new Point(103, 290);
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
            label3.Location = new Point(174, 215);
            label3.Name = "label3";
            label3.Size = new Size(28, 21);
            label3.TabIndex = 15;
            label3.Text = "ou";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(385, 440);
            Controls.Add(label3);
            Controls.Add(ButtonEntrar);
            Controls.Add(label2);
            Controls.Add(ButtonCadastrar);
            Controls.Add(label1);
            Controls.Add(labelConta);
            Name = "FormMain";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelConta;
        private Label label1;
        private Button ButtonCadastrar;
        private Label label2;
        private Button ButtonEntrar;
        private Label label3;
    }
}