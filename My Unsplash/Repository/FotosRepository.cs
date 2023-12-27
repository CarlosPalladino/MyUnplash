using My_Unsplash.Data;
using My_Unsplash.Interfaces;
using My_Unsplash.Models;

namespace My_Unsplash.Repository
{
    public class FotosRepository : FotosInterface
    {
        private readonly DataContext _context;

        public FotosRepository(DataContext context)
        {
            _context = context;
        }
        public bool CreateFoto(Fotos fotos)
        {
            throw new NotImplementedException();
        }

        public bool DeleteFoto(Fotos fotos)
        {
            throw new NotImplementedException();
        }

        public bool FotoExist(Guid Id)
        {
            throw new NotImplementedException();
        }

        public ICollection<Fotos> GetAllFotos()
        {
            throw new NotImplementedException();
        }

        public Fotos GetFoto(Guid Id)
        {
            throw new NotImplementedException();
        }

        public bool Save(Fotos fotos)
        {
            throw new NotImplementedException();
        }

        public bool UpdateFoto(Fotos fotos)
        {
            throw new NotImplementedException();
        }
    }
}
