using LogicaNegocio.Excepciones.Usuario;
using LogicaNegocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.ValueObject.UsuarioVO
{
    public class CedulaVO : IValidable
    {
        

        public string Cedula { get; }
        public CedulaVO(string cedula)
        {
            Cedula = cedula;
            Validar();
        }

        public void Validar()
        {
            // Por ahora permite cualquier valor        }
        }
    }
}
