using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOLYID.BANCO
{
    public class Amostras
    {
        public int Id { get; set; }
        public int FichaDeCampoId { get; set; }
        public int TiposDeAmostrasId { get; set; }
        public string NomeAmostras { get; set; }
        public string Local { get; set; }

        public FichaDeCampo FichaDeCampo { get; set; } // Navigation Property
        public TiposDeAmostras TiposDeAmostras { get; set; } // Navigation Property
    }
}
