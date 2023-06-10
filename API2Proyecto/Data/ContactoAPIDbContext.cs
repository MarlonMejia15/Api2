using API2Proyecto.Models;
using Microsoft.EntityFrameworkCore;

namespace API2Proyecto.Data
{
    public class ContactoAPIDbContext: DbContext
    {
        public ContactoAPIDbContext(DbContextOptions options): base(options) { 
        
        }


        public DbSet<Contacto> Contactos { get; set; }
        
    }
}
