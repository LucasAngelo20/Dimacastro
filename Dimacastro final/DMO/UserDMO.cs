using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dimacastro_final
{
    public class UserDMO
    {
        public int UserID { get; set; }
        public string UserAdmin { get; set; }
        public string username { get; set; }
        public string id { get; set; }
        public string idLoja { get; set; }
        public string UserName { get; set; }
        public string email { get; set; }
        public string senha { get; set; }
        public string telefone { get; set; }
        public string CNPJ { get; set; }
        public string fkLoja { get; set; }
        public string emailRecovery { get; set; }
        public string ErrorMsg { get; set; }
        public string userTokenR { get; set; }
        public string userToken{ get; set; }
        public string senhaReset { get; set; }

    }
}