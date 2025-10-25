using LogicaNegocio.ValueObject.UsuarioVO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.EntidadesNegocio
{
    public class Administrador: Usuario
    {
        public string RUT { get; set; }
        public string Direccion { get; set; }

        [NotMapped] public RUTVO RUTVO => RUT != null ? new RUTVO(RUT) : null;
        [NotMapped] public DireccionVO DireccionVO => Direccion != null ? new DireccionVO(Direccion) : null;

        public Administrador() : base() { }

        public Administrador(
            NombreVO nombre,
            ApellidoVO apellido,
            CedulaVO cedula,
            EmailVO email,
            ContrasenaVO contrasena,
            RUTVO rut,
            DireccionVO direccion,
            WhatsAppVO whatsapp = null
        ) : base(nombre, apellido, cedula, email, contrasena, whatsapp)
        {
            RUT = rut?.RUT;
            Direccion = direccion?.Direccion;
            if (whatsapp != null)
                WhatsApp = whatsapp.Numero;
        }
    }
}
