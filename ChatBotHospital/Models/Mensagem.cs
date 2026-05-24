using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBotHospital.Models
{
    public class Mensagem
    {
        public string Remetente { get; set; }
        public string Texto { get; set; }
        public DateTime HoraEnvio { get; set; }
        public Mensagem(string remetente, string texto)
        {
            Remetente = remetente;
            Texto = texto;

            HoraEnvio = DateTime.Now;
        }

          
        
    }
}
