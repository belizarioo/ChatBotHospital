using ChatBotHospital.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace ChatBotHospital.Services
{
    public class ChatBot
    {
        public List<CategoriaResposta> Categorias { get; set; }

        public ChatBot(string caminhoArquivo)
        {
            string categoriaJson = File.ReadAllText(caminhoArquivo);

            RespostaJson resultado = JsonSerializer.Deserialize<RespostaJson>(categoriaJson, new JsonSerializerOptions 
            {
                PropertyNameCaseInsensitive = true
            });
            this.Categorias = resultado.Categorias;
        }

        public string BuscarResposta(string mensagemUsuario)
        {
            foreach(CategoriaResposta categoria in Categorias)
            {
                foreach(string tipo in categoria.PalavrasChave)
                {
                    if (mensagemUsuario.ToLower().Contains(tipo))
                    {
                        return categoria.Resposta;
                    }
                }
            }
            return null;
        }
    }
}
