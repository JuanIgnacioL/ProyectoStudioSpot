using LogicaNegocio.ValueObject.UsuarioVO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.EntidadesNegocio
{
    public class Cliente: Usuario
    {
        public Cliente() : base() { }

        public Cliente(NombreVO nombre, ApellidoVO apellido, CedulaVO cedula, EmailVO email, ContrasenaVO contrasena, WhatsAppVO whatsapp = null)
            : base(nombre, apellido, cedula, email, contrasena, whatsapp)
        { }
    }
}
