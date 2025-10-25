using LogicaNegocio.Excepciones.Usuario;
using LogicaNegocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.ValueObject.UsuarioVO
{
    public class EmailVO: IValidable
    {
        public string Email { get; }

        public EmailVO(string email)
        {
            Email = email;
            Validar();
        }
        public EmailVO() { }
        public void Validar()
        {
            // Por ahora permite cualquier valor
        }
    }
}
