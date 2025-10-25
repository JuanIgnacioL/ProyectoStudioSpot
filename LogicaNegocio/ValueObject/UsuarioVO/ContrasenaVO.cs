using LogicaNegocio.Excepciones.Usuario;
using LogicaNegocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.ValueObject.UsuarioVO
{
    public class ContrasenaVO : IValidable
    {
        public string Contrasena { get; private set; }

        public ContrasenaVO(string contrasena, bool encriptar = true)
        {
            if (encriptar)
                Contrasena = BCrypt.Net.BCrypt.HashPassword(contrasena);
            else
                Contrasena = contrasena;

            Validar();
        }
        public ContrasenaVO() { }
        public bool Verificar(string contrasena)
        {
            return BCrypt.Net.BCrypt.Verify(contrasena, Contrasena);
        }
        public void Validar()
        {
            //   if (string.IsNullOrWhiteSpace(Contrasena))
            /////        throw new UsuarioException("La contraseña no puede estar vacía");
            //   if (Contrasena.Length < 6)
            //        throw new UsuarioException("La contraseña debe tener al menos 6 caracteres");

        }
    }
}
