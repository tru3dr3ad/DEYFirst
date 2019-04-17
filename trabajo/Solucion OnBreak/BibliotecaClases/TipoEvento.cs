using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    public class TipoEvento
    {
        public int idEvento { get; set; }
        public string nombreEvento { get; set; }
        public int valorBase { get; set; }
        public int personalBase { get; set; }
        public int personalAsistente { get; set; }

        public TipoEvento()
        {

        }
    }
}
