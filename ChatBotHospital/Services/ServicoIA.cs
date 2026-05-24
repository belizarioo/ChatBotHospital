using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBotHospital.Services
{
    public class ServicoIA
    {
        public string ChaveAPI {  get; set; }

        public ServicoIA(string chaveapi)
        {
            ChaveAPI = chaveapi;
        }

        public async Task<string> ObterResposta(string mensagem) 
        { 
            HttpClient cliente = new HttpClient();
            
            string corpo = $"{{\"contents\": [{{\"parts\": [{{\"text\": \"{mensagem}\"}}]}}]}}";

            string url = $"https://generativelanguage.googleapis.com/v1beta/models/gemini-2.5-flash:generateContent?key={ChaveAPI}";

            HttpResponseMessage resposta = await cliente.PostAsync(url, new StringContent(corpo, Encoding.UTF8, "application/json"));

            string conteudo = await resposta.Content.ReadAsStringAsync();

            var json = JObject.Parse(conteudo);

            
            string textoResposta = json["candidates"][0]["content"]["parts"][0]["text"].ToString();
            return textoResposta;
        }

    }
}
