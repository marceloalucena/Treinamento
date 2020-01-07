using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MAL.Api
{
    public class SettingsJWT
    {
        public string Secret { get; set; } // Segredo
        public int ExpiracaoHoras { get; set; } //Quantas horas leva até expirarção
        public string Emissor { get; set; } //Quem emitiu (API)
        public string ValidoEm { get; set; }  //Em qual URL é valido      
    }
}
