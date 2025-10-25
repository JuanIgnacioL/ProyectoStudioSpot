using LogicaNegocio.ValueObject.UsuarioVO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.EntidadesNegocio
{
    public abstract class Usuario
    {
        [Key]
        public int Id { get; set; }

        // Propiedades persistibles (BD)
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cedula { get; set; }
        public string Email { get; set; }
        public string Contrasena { get; set; }
        public string WhatsApp { get; set; }

        // Propiedades VO para lógica, NO persistibles
        [NotMapped] public NombreVO NombreVO => Nombre != null ? new NombreVO(Nombre) : null;
        [NotMapped] public ApellidoVO ApellidoVO => Apellido != null ? new ApellidoVO(Apellido) : null;
        [NotMapped] public CedulaVO CedulaVO => Cedula != null ? new CedulaVO(Cedula) : null;
        [NotMapped] public EmailVO EmailVO => Email != null ? new EmailVO(Email) : null;
        [NotMapped] public ContrasenaVO ContrasenaVO => Contrasena != null ? new ContrasenaVO(Contrasena, false) : null;
        [NotMapped] public WhatsAppVO WhatsAppVO => WhatsApp != null ? new WhatsAppVO(WhatsApp) : null;

        // Constructor vacío para EF
        public Usuario() { }

        // Constructor desde VO
        public Usuario(NombreVO nombre, ApellidoVO apellido, CedulaVO cedula, EmailVO email, ContrasenaVO contrasena, WhatsAppVO whatsapp)
        {
            Nombre = nombre?.Nombre;
            Apellido = apellido?.Apellido;
            Cedula = cedula?.Cedula;
            Email = email?.Email;
            Contrasena = contrasena?.Contrasena;
            WhatsApp = whatsapp?.Numero;
        }

        // Método para validar la entidad usando los VO
        public virtual void Validar()
        {
            NombreVO?.Validar();
            ApellidoVO?.Validar();
            CedulaVO?.Validar();
            EmailVO?.Validar();
            ContrasenaVO?.Validar();
            WhatsAppVO?.Validar();
        }
    }
}
