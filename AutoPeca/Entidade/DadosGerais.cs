using System;
using System.Collections.Generic;
using System.Text;

namespace AutoPeca.Entidade
{
    public abstract class DadosGerais : Base
    {
        public string Nome { get; set; }        
        public string Documento { get; set; }

        public abstract void Cadastrado();
        
    }
}
