namespace fajoliatm_csharp
{
    partial class FormPaginaInicial
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
            ButtonEmprestimos = new Button();
            ButtonConsultarExtrato = new Button();
            ButtonTransferir = new Button();
            ButtonDepositar = new Button();
            ButtonSacar = new Button();
            labelNome = new Label();
            SuspendLayout();
            // 
            // ButtonEmprestimos
            // 
            ButtonEmprestimos.BackColor = Color.Gainsboro;
            ButtonEmprestimos.Enabled = true;
            ButtonEmprestimos.FlatAppearance.BorderColor = Color.Black;
            ButtonEmprestimos.FlatAppearance.MouseDownBackColor = Color.Silver;
            ButtonEmprestimos.FlatAppearance.MouseOverBackColor = Color.Silver;
            ButtonEmprestimos.FlatStyle = FlatStyle.Flat;
            ButtonEmprestimos.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonEmprestimos.Location = new Point(625, 352);
            ButtonEmprestimos.Name = "ButtonEmprestimos";
            ButtonEmprestimos.Size = new Size(163, 79);
            ButtonEmprestimos.TabIndex = 15;
            ButtonEmprestimos.Text = "Empréstimos";
            ButtonEmprestimos.UseVisualStyleBackColor = false;
            // 
            // ButtonConsultarExtrato
            // 
            ButtonConsultarExtrato.BackColor = Color.Gainsboro;
            ButtonConsultarExtrato.Enabled = true;
            ButtonConsultarExtrato.FlatAppearance.BorderColor = Color.Black;
            ButtonConsultarExtrato.FlatAppearance.MouseDownBackColor = Color.Silver;
            ButtonConsultarExtrato.FlatAppearance.MouseOverBackColor = Color.Silver;
            ButtonConsultarExtrato.FlatStyle = FlatStyle.Flat;
            ButtonConsultarExtrato.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonConsultarExtrato.Location = new Point(625, 267);
            ButtonConsultarExtrato.Name = "ButtonConsultarExtrato";
            ButtonConsultarExtrato.Size = new Size(163, 79);
            ButtonConsultarExtrato.TabIndex = 14;
            ButtonConsultarExtrato.Text = "Consultar Extrato";
            ButtonConsultarExtrato.UseVisualStyleBackColor = false;
            // 
            // ButtonTransferir
            // 
            ButtonTransferir.BackColor = Color.Gainsboro;
            ButtonTransferir.Enabled = true;
            ButtonTransferir.FlatAppearance.BorderColor = Color.Black;
            ButtonTransferir.FlatAppearance.MouseDownBackColor = Color.Silver;
            ButtonTransferir.FlatAppearance.MouseOverBackColor = Color.Silver;
            ButtonTransferir.FlatStyle = FlatStyle.Flat;
            ButtonTransferir.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonTransferir.Location = new Point(625, 182);
            ButtonTransferir.Name = "ButtonTransferir";
            ButtonTransferir.Size = new Size(163, 79);
            ButtonTransferir.TabIndex = 13;
            ButtonTransferir.Text = "Transferir";
            ButtonTransferir.UseVisualStyleBackColor = false;
            // 
            // ButtonDepositar
            // 
            ButtonDepositar.BackColor = Color.Gainsboro;
            ButtonDepositar.Enabled = true;
            ButtonDepositar.FlatAppearance.BorderColor = Color.Black;
            ButtonDepositar.FlatAppearance.MouseDownBackColor = Color.Silver;
            ButtonDepositar.FlatAppearance.MouseOverBackColor = Color.Silver;
            ButtonDepositar.FlatStyle = FlatStyle.Flat;
            ButtonDepositar.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonDepositar.Location = new Point(625, 97);
            ButtonDepositar.Name = "ButtonDepositar";
            ButtonDepositar.Size = new Size(163, 79);
            ButtonDepositar.TabIndex = 12;
            ButtonDepositar.Text = "Depositar";
            ButtonDepositar.UseVisualStyleBackColor = false;
            // 
            // ButtonSacar
            // 
            ButtonSacar.BackColor = Color.Gainsboro;
            ButtonSacar.Enabled = true;
            ButtonSacar.FlatAppearance.BorderColor = Color.Black;
            ButtonSacar.FlatAppearance.MouseDownBackColor = Color.Silver;
            ButtonSacar.FlatAppearance.MouseOverBackColor = Color.Silver;
            ButtonSacar.FlatStyle = FlatStyle.Flat;
            ButtonSacar.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonSacar.Location = new Point(625, 12);
            ButtonSacar.Name = "ButtonSacar";
            ButtonSacar.Size = new Size(163, 79);
            ButtonSacar.TabIndex = 11;
            ButtonSacar.Text = "Sacar";
            ButtonSacar.UseVisualStyleBackColor = false;
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            labelNome.Location = new Point(12, 9);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(153, 30);
            labelNome.TabIndex = 16;
            labelNome.Text = "Bem vindo(a), ";
            // 
            // FormPaginaInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 442);
            Controls.Add(labelNome);
            Controls.Add(ButtonEmprestimos);
            Controls.Add(ButtonConsultarExtrato);
            Controls.Add(ButtonTransferir);
            Controls.Add(ButtonDepositar);
            Controls.Add(ButtonSacar);
            Name = "FormPaginaInicial";
            Text = "PaginaInicial";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ButtonEmprestimos;
        private Button ButtonConsultarExtrato;
        private Button ButtonTransferir;
        private Button ButtonDepositar;
        private Button ButtonSacar;
        private Label labelNome;
    }
}