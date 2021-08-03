using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dimacastro_final
{
    public class PedidoDMO
    {
        public string id { get; set; }
        public string fkUser { get; set; }
        public string fkLoja { get; set; }
        public string representacaoId { get; set; }
        public string descricao { get; set; }
        public string dateCreate { get; set; }
        public string dateUpdate { get; set; }
        public string imagem { get; set; }
        public string valor { get; set; }
        public string codigo { get; set; }
        public string contador { get; set; }
        public string ErrorMsg { get; set; }
    }
}