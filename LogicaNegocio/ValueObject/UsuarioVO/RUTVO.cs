using LogicaNegocio.Excepciones.Usuario;
using LogicaNegocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.ValueObject.UsuarioVO
{
    public class RUTVO: IValidable
    {
        public string RUT { get; }

        public RUTVO(string rut)
        {
            RUT = rut;
            Validar();
        }
        public RUTVO() { }
        public void Validar()
        {
            // Por ahora permite cualquier valor
        }
    }
}
