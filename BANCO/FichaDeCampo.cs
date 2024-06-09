using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOLYID.BANCO
{
    
    public class FichaDeCampo
    {
        public int Id { get; set; }
        public string NumeroDoMicrochip { get; set; }
        public DateTime DataDaCaptura { get; set; }
        public TimeSpan HorarioDaCaptura { get; set; }
        public string LocalDeCaptura { get; set; }
        public int IdentificacaoDoAnimal { get; set; }
        public int IDEquipeResponsavel { get; set; }
        public string InstituicaoResponsavel { get; set; }

        public Tatu Tatu { get; set; } // Navigation Property
        public Equipe EquipeResponsavel { get; set; } // Navigation Property
    }
}
