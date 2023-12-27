using My_Unsplash.Data;
using My_Unsplash.Models;
using System;

namespace My_Unsplash
{
    public class Seed
    {
        private readonly DataContext _context;

        public Seed(DataContext context)
        {
            _context = context;
        }

        public void SeedDataContext()
        {
            if (!_context.Fotos.Any())
            {
                var fotos = new List<Fotos>()
                {
                    new Fotos()
                    {
                        Id = Guid.NewGuid(),
                        Url = "https://i.pinimg.com/550x/99/f8/c2/99f8c26d1e544d63fc5fe14201d42c0b.jpg", 
                        Etiqueta = "Etiqueta1",
                        Fecha = DateTime.Now
                    },
                    new Fotos()
                    {
                        Id = Guid.NewGuid(),
                        Url = "https://arsmagazine.com/wp-content/uploads/2022/01/a7s6750-e1642159974133.jpg", // Reemplaza esto con una URL de imagen real
                        Etiqueta = "Etiqueta2",
                        Fecha = DateTime.Now
                    },
                    // Agrega más fotos aquí si lo deseas
                };

                _context.Fotos.AddRange(fotos);
                _context.SaveChanges();
            }
        }
    }
}
