using LogicaNegocio.Excepciones.Usuario;
using LogicaNegocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.ValueObject.UsuarioVO
{
    public class WhatsAppVO : IValidable
    {
        public string Numero { get; set; }

        public WhatsAppVO(string numero)
        {
            Numero = numero;
            Validar();
        }
        public WhatsAppVO() { }

        public void Validar()
        {
            //if (string.IsNullOrWhiteSpace(Numero))
            //    throw new UsuarioException("El número de WhatsApp no puede estar vacío.");

            // Permite cualquier número de 1 o más dígitos
            // if (!Regex.IsMatch(Numero, @"^\d+$"))
            //  throw new UsuarioException("Número de WhatsApp inválido.");

        }
    }
}
