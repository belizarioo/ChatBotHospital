using ChatBotHospital.Models;
using ChatBotHospital.Services;
using System.Reflection.Metadata.Ecma335;

namespace ChatBotHospital
{
    public partial class FormPrincipal : Form
    {
        public string NomePaciente {  get; set; }

        public FormPrincipal(string nomepaciente) 
        {
            InitializeComponent();
            NomePaciente = nomepaciente;
        }
        public FormPrincipal()
        {
            InitializeComponent();
            NomePaciente = "Paciente";
        }


        ChatBot bot1 = new ChatBot(Path.Combine(Application.StartupPath, "respostas.json"));
        ServicoIA servicoIA = new ServicoIA("AIzaSyDm_YJPb8OtwMBfBLaOu66bSL5vk7qdV_s");
        ServicoHistorico historico = new ServicoHistorico(Path.Combine(Application.StartupPath, "historico.txt"));

        private async void btn_enviar_Click(object sender, EventArgs e)
        {
            Mensagem mensagem = new Mensagem(NomePaciente, txb_escrever.Text);
            
            if (string.IsNullOrEmpty(txb_escrever.Text))
            {
                MessageBox.Show("Digite pelo menos um carácter!");
            }
            else
            {
                rchtxb_mensagem.AppendText($"{mensagem.Remetente} - {mensagem.HoraEnvio:HH:mm}: {mensagem.Texto}\n");

                string respostaBot = bot1.BuscarResposta(txb_escrever.Text);
                if (respostaBot != null)
                {
                    rchtxb_mensagem.AppendText($"Hospital - {mensagem.HoraEnvio:HH:mm}: {respostaBot}\n");
                }
                else
                {
                    string resultado = await servicoIA.ObterResposta(mensagem.Texto);
                    rchtxb_mensagem.AppendText($"Hospital - {mensagem.HoraEnvio:HH:mm}: {resultado}\n");


                }
            }
            historico.Salvar(rchtxb_mensagem.Text);

            txb_escrever.Clear();
            txb_escrever.Focus();
        }
    }
}
