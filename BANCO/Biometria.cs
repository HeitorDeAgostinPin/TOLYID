using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOLYID.BANCO
{
    public class Biometria
    {
        public byte[] foto;
        public int Id { get; set; }
        public int FichaDeCampoId { get; set; }
        public decimal ComprimentoTotal { get; set; }
        public decimal ComprimentoDaCabeça { get; set; }
        public decimal LarguraDaCabeça { get; set; }
        public decimal ComprimentoDoEscudoEncefalico { get; set; }
        public string PadraoDoEscudoEncefalico { get; set; }
        public decimal ComprimentoDaCauda { get; set; }
        public decimal LarguraCaudal { get; set; }
        public decimal ComprimentoDoPelo { get; set; }
        public decimal ComprimentoDaUnha { get; set; }
        public decimal ComprimentoDaOrelha { get; set; }
        public decimal ComprimentoDoEscudoPelvico { get; set; }
        public decimal SemicircunferenciaEscudoEscapular { get; set; }
        public decimal SemicircunferenciaEscudoPelvico { get; set; }
        public decimal LarguraSegundaCinta { get; set; }
        public decimal ComprimentoDoClitoris { get; set; }
        public decimal ComprimentoDoPenis { get; set; }
        public decimal LarguraInterOrbital { get; set; }
        public decimal LarguraInterLacrimal { get; set; }
        public decimal LarguraBaseDoPenis { get; set; }
        public int NumeroDeCintas { get; set; }
        public string Observacoes { get; set; }

        public FichaDeCampo FichaDeCampo { get; set; } // Navigation Property
    }

}
