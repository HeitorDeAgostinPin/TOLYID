using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOLYID.BANCO
{
    public class Equipe
    {
        public int Id { get; set; }
        public int IDEquipeResponsavel { get; set; }
        public string Instituicao { get; set; }
        public Usuario UsuarioResponsavel { get; set; } 
    }
}
