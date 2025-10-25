using LogicaNegocio.Excepciones.Usuario;
using LogicaNegocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.ValueObject.UsuarioVO
{
    public class NombreVO: IValidable
    {
        public string Nombre { get; }

        public NombreVO(string nombre)
        {
            Nombre = nombre;
            Validar();
        }
        public NombreVO() { }
        public void Validar()
        {
            /*   if (string.IsNullOrWhiteSpace(Nombre))
                  {
                      throw new UsuarioException("Ingrese un nombre válido.");
                  }*/
        }
    }
}
