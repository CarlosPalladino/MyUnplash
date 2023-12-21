using My_Unsplash.Models;

namespace My_Unsplash.Interfaces
{
    public interface FotosInterface
    {

        bool FotoExist(Guid Id);
        bool UpdateFoto(Fotos fotos);
        bool DeleteFoto(Fotos fotos);
        bool Save(Fotos fotos);

        ICollection<Fotos> GetAllFotos();

        Fotos GetFoto(Guid Id);

        bool CreateFoto(Fotos fotos);




    }
}
