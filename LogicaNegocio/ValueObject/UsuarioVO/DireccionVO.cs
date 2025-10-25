using LogicaNegocio.Excepciones.Usuario;
using LogicaNegocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.ValueObject.UsuarioVO
{
    public class DireccionVO: IValidable
    {
        public string Direccion { get; }

        public DireccionVO(string direccion)
        {
            Direccion = direccion;
            Validar();
        }
        public DireccionVO() { }
        public void Validar()
        {
            // Por ahora permite cualquier valor
        }
    }
}
