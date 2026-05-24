using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatBotHospital
{
    public partial class FormInicial : Form
    {
        public FormInicial()
        {
            InitializeComponent();
        }
        private void btn_entrar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txb_nome.Text))
            {
                MessageBox.Show("Digite um nome válido");
            }
            else
            {
                FormPrincipal formprincipal = new FormPrincipal(txb_nome.Text);
                formprincipal.Show();
                this.Hide();

            }
        }
    }
}
