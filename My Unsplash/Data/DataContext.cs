using Microsoft.EntityFrameworkCore;
using My_Unsplash.Models;

namespace My_Unsplash.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }


        public DbSet<Fotos> Fotos { get; set; }


    }

}

