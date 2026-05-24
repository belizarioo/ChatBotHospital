namespace ChatBotHospital
{
    partial class FormInicial
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
            btn_entrar = new Button();
            txb_nome = new TextBox();
            label1 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // btn_entrar
            // 
            btn_entrar.BackColor = SystemColors.Highlight;
            btn_entrar.FlatStyle = FlatStyle.Flat;
            btn_entrar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_entrar.ForeColor = SystemColors.Window;
            btn_entrar.Location = new Point(328, 263);
            btn_entrar.Name = "btn_entrar";
            btn_entrar.Size = new Size(89, 57);
            btn_entrar.TabIndex = 0;
            btn_entrar.Text = "ENTRAR";
            btn_entrar.UseVisualStyleBackColor = false;
            btn_entrar.Click += btn_entrar_Click;
            // 
            // txb_nome
            // 
            txb_nome.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txb_nome.Location = new Point(212, 187);
            txb_nome.Name = "txb_nome";
            txb_nome.PlaceholderText = "Digite seu nome...";
            txb_nome.Size = new Size(323, 30);
            txb_nome.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(212, 164);
            label1.Name = "label1";
            label1.Size = new Size(60, 23);
            label1.TabIndex = 2;
            label1.Text = "NOME";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(148, 97);
            label3.Name = "label3";
            label3.Size = new Size(474, 38);
            label3.TabIndex = 4;
            label3.Text = "Bem-vindo ao ChatBot do Hospital";
            // 
            // FormInicial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(txb_nome);
            Controls.Add(btn_entrar);
            Name = "FormInicial";
            Text = "ChatBot Hospital";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_entrar;
        private TextBox txb_nome;
        private Label label1;
        private Label label3;
    }
}