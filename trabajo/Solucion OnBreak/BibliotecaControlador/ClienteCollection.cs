using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaClases;

namespace BibliotecaControlador
{
    public class ClienteCollection
    {
        List<Cliente> clientes;
        public ClienteCollection()
        {
            if (clientes == null)
            {
                new List<Cliente>();
            }

        }
        public bool ExisteCliente(string Rut)
        {
            try
            {
                foreach (Cliente item in clientes)
                {
                    if (item.rut.Equals(Rut))
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
        public bool AgregarCliente(Cliente cli)
        {
            try
            {
                if (ExisteCliente(cli.rut) == false)
                {
                    clientes.Add(cli);
                    return true;

                }
                return false;
            }
            catch (Exception ex)
            {

                return false;
            }

        }
        public Cliente buscarCliente(string Rut)
        {
            try
            {
                foreach (Cliente item in clientes)
                {
                    if (item.rut.Equals(Rut))
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

        public List<Cliente> Listar()
        {
            try
            {
                return clientes;
            }
            catch (Exception ex)
            {

                return null;
            }

        }

        public bool eliminarCliente(string Rut)
        {
            try
            {
                foreach (Cliente item in clientes)
                {

                    if (item.rut.Equals(Rut))
                    {
                        clientes.Remove(item);
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
