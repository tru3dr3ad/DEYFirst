using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaClases;
namespace BibliotecaControlador
{
    public class EventoCollection
    {
        List<TipoEvento> TipoEventos;
        public EventoCollection()
        {
            if (TipoEventos == null)
            {
                new List<TipoEvento>();
            }

        }
        public bool ExisteTipoEvento(int Id_eve)
        {
            try
            {
                foreach (TipoEvento item in TipoEventos)
                {
                    if (item.idEvento.Equals(Id_eve))
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
        public bool AgregarTipoEvento(TipoEvento eve)
        {
            try
            {
                if (ExisteTipoEvento(eve.idEvento) == false)
                {
                    TipoEventos.Add(eve);
                    return true;

                }
                return false;
            }
            catch (Exception ex)
            {

                return false;
            }

        }
        public TipoEvento buscarTipoEvento(int Id_eve)
        {
            try
            {
                foreach (TipoEvento item in TipoEventos)
                {
                    if (item.idEvento.Equals(Id_eve))
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

        public List<TipoEvento> Listar()
        {
            try
            {
                return TipoEventos;
            }
            catch (Exception ex)
            {

                return null;
            }

        }

        public bool eliminarTipoEvento(int Id_eve)
        {
            try
            {
                foreach (TipoEvento item in TipoEventos)
                {

                    if (item.idEvento.Equals(Id_eve))
                    {
                        TipoEventos.Remove(item);
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
