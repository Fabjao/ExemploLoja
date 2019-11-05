using System;
using System.Collections.Generic;
using System.Text;

namespace AutoPeca.Entidade
{
   public class VendaItem :Base
    {
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }

    }
}
