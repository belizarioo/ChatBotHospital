using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBotHospital.Models
{
    public class CategoriaResposta
    {
        public string Nome { get; set; }
        public List<string> PalavrasChave { get; set; }
        public string Resposta { get; set; }

    public CategoriaResposta()
        {
                PalavrasChave = new List<string>();
        }

    }
}
