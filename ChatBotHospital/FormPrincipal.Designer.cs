namespace ChatBotHospital
{
    partial class FormPrincipal
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
            rchtxb_mensagem = new RichTextBox();
            txb_escrever = new TextBox();
            btn_enviar = new Button();
            SuspendLayout();
            // 
            // rchtxb_mensagem
            // 
            rchtxb_mensagem.BackColor = SystemColors.Window;
            rchtxb_mensagem.BorderStyle = BorderStyle.None;
            rchtxb_mensagem.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rchtxb_mensagem.Location = new Point(0, 2);
            rchtxb_mensagem.Name = "rchtxb_mensagem";
            rchtxb_mensagem.ReadOnly = true;
            rchtxb_mensagem.Size = new Size(788, 357);
            rchtxb_mensagem.TabIndex = 0;
            rchtxb_mensagem.Text = "";
            // 
            // txb_escrever
            // 
            txb_escrever.BorderStyle = BorderStyle.FixedSingle;
            txb_escrever.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txb_escrever.Location = new Point(12, 365);
            txb_escrever.Multiline = true;
            txb_escrever.Name = "txb_escrever";
            txb_escrever.PlaceholderText = "Digite sua mensagem...";
            txb_escrever.Size = new Size(605, 73);
            txb_escrever.TabIndex = 1;
            // 
            // btn_enviar
            // 
            btn_enviar.BackColor = SystemColors.Highlight;
            btn_enviar.FlatStyle = FlatStyle.Flat;
            btn_enviar.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_enviar.ForeColor = SystemColors.Window;
            btn_enviar.Location = new Point(648, 376);
            btn_enviar.Name = "btn_enviar";
            btn_enviar.Size = new Size(81, 58);
            btn_enviar.TabIndex = 2;
            btn_enviar.Text = "Enviar";
            btn_enviar.UseVisualStyleBackColor = false;
            btn_enviar.Click += btn_enviar_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_enviar);
            Controls.Add(txb_escrever);
            Controls.Add(rchtxb_mensagem);
            ForeColor = SystemColors.Desktop;
            Name = "FormPrincipal";
            Text = "ChatBot Hospital";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox rchtxb_mensagem;
        private TextBox txb_escrever;
        private Button btn_enviar;
    }
}
