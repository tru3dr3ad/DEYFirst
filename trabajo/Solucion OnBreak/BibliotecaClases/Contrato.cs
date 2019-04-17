using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    public class Contrato
    {
        public int nroContrato { get; set; }
        public DateTime creacion { get; set; }
        public DateTime termino { get; set; }
        public DateTime fechaHoraInicio { get; set; }
        public DateTime fechaHoraTermino { get; set; }
        public string direccion { get; set; }
        public bool vigente { get; set; }
        public string observaciones { get; set; }

        public Contrato()
        {

        }
    }
}
