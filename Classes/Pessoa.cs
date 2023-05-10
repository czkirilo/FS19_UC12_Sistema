using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FS19_UC12_Sistema.Classes
{
    public abstract class Pessoa
    {
        public string? nome { get; set; }
        public Endereco endereco { get; set; }
        public abstract void PagarImposto(float rendimento);
    }
}