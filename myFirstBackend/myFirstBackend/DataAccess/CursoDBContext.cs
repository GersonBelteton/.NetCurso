using Microsoft.EntityFrameworkCore;
using myFirstBackend.Models;

namespace myFirstBackend.DataAccess
{
    public class CursoDBContext : DbContext
    {
        public CursoDBContext(DbContextOptions<CursoDBContext> options) : base (options) { }

        public DbSet<Curso> cursos { get; set; }


    }
}
