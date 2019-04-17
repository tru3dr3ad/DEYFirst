using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaClases;
namespace BibliotecaControlador
{
    public class ContratoCollection
    {
        List<Contrato> contratos;
        public ContratoCollection()
        {
            if (contratos == null)
            {
                new List<Contrato>();
            }

        }
        public bool ExisteContrato(int numeroContrato)
        {
            try
            {
                foreach (Contrato item in contratos)
                {
                    if (item.nroContrato.Equals(numeroContrato))
                    {
                        return true;
                    }
                }
                return false;
            }
            catch (Exception ex)
            {

                return false;
            }

        }
        public bool AgregarContrato(Contrato con)
        {
            try
            {
                if (ExisteContrato(con.nroContrato) == false)
                {
                    contratos.Add(con);
                    return true;

                }
                return false;
            }
            catch (Exception ex)
            {

                return false;
            }

        }
        public Contrato buscarContrato(int numeroContrato)
        {
            try
            {
                foreach (Contrato item in contratos)
                {
                    if (item.nroContrato.Equals(numeroContrato))
                    {
                        return item;
                    }
                }
                return null;
            }
            catch (Exception ex)
            {

                return null;
            }

        }

        public List<Contrato> Listar()
        {
            try
            {
                return contratos;
            }
            catch (Exception ex)
            {

                return null;
            }

        }

        public bool eliminarContrato(int numeroContrato)
        {
            try
            {
                foreach (Contrato item in contratos)
                {

                    if (item.nroContrato.Equals(numeroContrato))
                    {
                        contratos.Remove(item);
                        return true;
                    }
                }
                return false;
            }
            catch (Exception ex)
            {

                return false;
            }

        }
    }
}
