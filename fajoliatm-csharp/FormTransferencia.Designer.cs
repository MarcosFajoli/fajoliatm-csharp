namespace fajoliatm_csharp
{
    partial class FormTransferencia
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
            ButtonTransferir = new Button();
            ValorTransferencia = new TextBox();
            label1 = new Label();
            ContaDestino = new ComboBox();
            LabelTipoConta = new Label();
            SuspendLayout();
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
            ButtonTransferir.Location = new Point(78, 290);
            ButtonTransferir.Name = "ButtonTransferir";
            ButtonTransferir.Size = new Size(173, 79);
            ButtonTransferir.TabIndex = 16;
            ButtonTransferir.Text = "Transferir";
            ButtonTransferir.UseMnemonic = false;
            ButtonTransferir.UseVisualStyleBackColor = false;
            ButtonTransferir.Click += ButtonTransferir_Click;
            // 
            // ValorTransferencia
            // 
            ValorTransferencia.Location = new Point(35, 221);
            ValorTransferencia.Name = "ValorTransferencia";
            ValorTransferencia.Size = new Size(256, 23);
            ValorTransferencia.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(124, 181);
            label1.Name = "label1";
            label1.Size = new Size(78, 37);
            label1.TabIndex = 12;
            label1.Text = "Valor";
            // 
            // ContaDestino
            // 
            ContaDestino.FormattingEnabled = true;
            ContaDestino.Location = new Point(35, 121);
            ContaDestino.Name = "ContaDestino";
            ContaDestino.Size = new Size(256, 23);
            ContaDestino.TabIndex = 15;
            // 
            // LabelTipoConta
            // 
            LabelTipoConta.AutoSize = true;
            LabelTipoConta.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            LabelTipoConta.Location = new Point(30, 88);
            LabelTipoConta.Name = "LabelTipoConta";
            LabelTipoConta.Size = new Size(178, 30);
            LabelTipoConta.TabIndex = 11;
            LabelTipoConta.Text = "Conta de destino";
            // 
            // FormTransferencia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(321, 450);
            Controls.Add(ButtonTransferir);
            Controls.Add(ValorTransferencia);
            Controls.Add(label1);
            Controls.Add(ContaDestino);
            Controls.Add(LabelTipoConta);
            Name = "FormTransferencia";
            Text = "FormTransferencia";
            Activated += FormTransferencia_Activated;
            Load += FormTransferencia_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ButtonTransferir;
        private TextBox ValorTransferencia;
        private Label label1;
        private ComboBox ContaDestino;
        private Label LabelTipoConta;
    }
}