using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOLYID.BANCO
{
    public class FichaAnestesica
    {
        public int Id { get; set; }
        public int FichaDeCampoId { get; set; }
        public decimal Dose { get; set; }
        public TimeSpan TempoDeAnestesia { get; set; }
        public string TipoAnestesia { get; set; }
        public string ViaDeAdministracao { get; set; }
        public TimeSpan Aplicacao { get; set; }
        public TimeSpan Inducao { get; set; }
        public TimeSpan Retorno { get; set; }
        public string Observacoes { get; set; }
        public decimal Temperatura { get; set; }
        public string ParametrosFisiologicos { get; set; }

        public FichaDeCampo FichaDeCampo { get; set; } // Navigation Property
    }
}
