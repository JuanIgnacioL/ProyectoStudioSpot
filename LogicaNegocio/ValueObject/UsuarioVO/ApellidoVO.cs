using LogicaNegocio.Excepciones.Usuario;
using LogicaNegocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LogicaNegocio.ValueObject.UsuarioVO
{
    public class ApellidoVO : IValidable
    {

        public string Apellido { get; }
        public ApellidoVO(string apellido)
        {
            Apellido = apellido;
            Validar();
        }


        public void Validar()
        {
            /*    if (string.IsNullOrWhiteSpace(Apellido))
            {
                throw new UsuarioException("Ingrese un apellido válido.");
            }*/
        }
    }
}
