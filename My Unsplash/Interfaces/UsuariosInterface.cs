using My_Unsplash.Models;

namespace My_Unsplash.Interfaces
{
    public interface UsuariosInterface
    {

        bool UpdateUsuarios(Usuarios user);
        bool CreateUsuario(Usuarios user);
        bool DeleteUsuario(Usuarios user);
        ICollection<Usuarios> GetUsuarios();

        Usuarios GetUsuario(Guid Id);


    }
}
