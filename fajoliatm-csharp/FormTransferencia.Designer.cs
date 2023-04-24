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
            this.ButtonTransferir = new System.Windows.Forms.Button();
            this.ValorTransferencia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ContaDestino = new System.Windows.Forms.ComboBox();
            this.LabelTipoConta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonTransferir
            // 
            this.ButtonTransferir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(71)))), ((int)(((byte)(255)))));
            this.ButtonTransferir.FlatAppearance.BorderSize = 0;
            this.ButtonTransferir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(50)))), ((int)(((byte)(255)))));
            this.ButtonTransferir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(50)))), ((int)(((byte)(255)))));
            this.ButtonTransferir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonTransferir.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonTransferir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ButtonTransferir.Location = new System.Drawing.Point(78, 290);
            this.ButtonTransferir.Name = "ButtonTransferir";
            this.ButtonTransferir.Size = new System.Drawing.Size(173, 79);
            this.ButtonTransferir.TabIndex = 16;
            this.ButtonTransferir.Text = "Transferir";
            this.ButtonTransferir.UseMnemonic = false;
            this.ButtonTransferir.UseVisualStyleBackColor = false;
            this.ButtonTransferir.Click += new System.EventHandler(this.ButtonTransferir_Click);
            // 
            // ValorTransferencia
            // 
            this.ValorTransferencia.Location = new System.Drawing.Point(35, 221);
            this.ValorTransferencia.Name = "ValorTransferencia";
            this.ValorTransferencia.Size = new System.Drawing.Size(256, 23);
            this.ValorTransferencia.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(124, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 37);
            this.label1.TabIndex = 12;
            this.label1.Text = "Valor";
            // 
            // ContaDestino
            // 
            this.ContaDestino.FormattingEnabled = true;
            this.ContaDestino.Location = new System.Drawing.Point(35, 121);
            this.ContaDestino.Name = "ContaDestino";
            this.ContaDestino.Size = new System.Drawing.Size(256, 23);
            this.ContaDestino.TabIndex = 15;
            // 
            // LabelTipoConta
            // 
            this.LabelTipoConta.AutoSize = true;
            this.LabelTipoConta.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelTipoConta.Location = new System.Drawing.Point(30, 88);
            this.LabelTipoConta.Name = "LabelTipoConta";
            this.LabelTipoConta.Size = new System.Drawing.Size(178, 30);
            this.LabelTipoConta.TabIndex = 11;
            this.LabelTipoConta.Text = "Conta de destino";
            // 
            // FormTransferencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(321, 450);
            this.Controls.Add(this.ButtonTransferir);
            this.Controls.Add(this.ValorTransferencia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ContaDestino);
            this.Controls.Add(this.LabelTipoConta);
            this.Name = "FormTransferencia";
            this.Text = "FormTransferencia";
            this.Load += new System.EventHandler(this.FormTransferencia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button ButtonTransferir;
        private TextBox ValorTransferencia;
        private Label label1;
        private ComboBox ContaDestino;
        private Label LabelTipoConta;
    }
}