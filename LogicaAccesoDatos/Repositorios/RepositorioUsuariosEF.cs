using LogicaAccesoDatos.BaseDatos;
using LogicaAccesoDatos.InterfacesRepositorios;
using LogicaNegocio.EntidadesNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAccesoDatos.Repositorios
{
    public class RepositorioUsuariosEF : IRepositorioUsuario
    {
        public StudioSpotContext Contexto { get; set; }
        public RepositorioUsuariosEF(StudioSpotContext contexto)
        {
            Contexto = contexto;
        }

        public void Add(Usuario item)
        {
            item.Validar();
            Contexto.Usuarios.Add(item);
            Contexto.SaveChanges();
        }

        public void Update(Usuario item)
        {
            Usuario usuarioBuscado = FindById(item.Id);
            if (usuarioBuscado != null)
            {
                usuarioBuscado.Nombre = item.Nombre;
                usuarioBuscado.Apellido = item.Apellido;
                usuarioBuscado.Contrasena = item.Contrasena;
                Contexto.Usuarios.Update(usuarioBuscado);
                Contexto.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            Usuario usuarioBuscado = FindById(id);
            if (usuarioBuscado == null)
            {
                throw new Exception("No existe usuario con ese id");
            }
            Contexto.Usuarios.Remove(usuarioBuscado);
            Contexto.SaveChanges();
        }

        public IEnumerable<Usuario> FindAll()
        {
            return Contexto.Usuarios;
        }

        public Usuario FindById(int? id)
        {
            return Contexto.Usuarios.Find(id);
        }

        public Usuario BuscarUsuarioParaLogin(Usuario usuario)
        {
            if (usuario == null || usuario.EmailVO == null || usuario.ContrasenaVO == null)
                return null;

            // Buscar el usuario por email
            Usuario usuarioEncontrado = Contexto.Set<Usuario>()
      .FirstOrDefault(u => u.Email == usuario.EmailVO.Email);

            if (usuarioEncontrado == null)
                return null;

            // Verificar contraseña usando el VO
            if (!usuarioEncontrado.ContrasenaVO.Verificar(usuario.ContrasenaVO.Contrasena))
                return null;

            return usuarioEncontrado;
        }
    }
}
