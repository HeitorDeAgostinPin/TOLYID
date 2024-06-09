using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOLYID.BANCO
{
    public class ParametrosFisiologicos
    {
        public int Id { get; set; }
        public int FichaAnestesicaId { get; set; }
        public int FC { get; set; }
        public int FR { get; set; }
        public decimal SP02 { get; set; }
        public decimal Temperatura { get; set; }
        public string Biximetria { get; set; }

        public FichaAnestesica FichaAnestesica { get; set; } // Navigation Property
    }
}
