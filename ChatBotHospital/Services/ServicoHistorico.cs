using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBotHospital.Services
{
    public class ServicoHistorico
    {
        public string CaminhoArquivo{  get; set; }

        public ServicoHistorico(string historico) 
        { 
             CaminhoArquivo = historico;
        }

        public void Salvar(string historico)
        {
            
            File.WriteAllText(CaminhoArquivo, historico);
        }
    }


}
