using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FS19_UC12_Sistema.Classes
{
    public class PessoaJuridica : Pessoa
    {
        public string? cnpj { get; set; }
        public string? razaoSocial { get; set; }

        public override void PagarImposto(float rendimento)
        {
            
        }

        // somente permitir o cadastro com 14 números
        // sendo os 4 antepenúltimos 0001. 
        // configurar uma mensagem de erro.

        public bool ValidarCNPJ(string cnpj){
            if((cnpj.Length >= 14) && (cnpj.Substring(cnpj.Length - 4)) == "0001"){
                return true;
            }
            return false;
        }


    }
}