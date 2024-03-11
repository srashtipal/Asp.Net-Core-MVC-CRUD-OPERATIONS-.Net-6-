using CRUD_OPERATIONS.Models.Entities;
using Microsoft.EntityFrameworkCore;


namespace CRUD_OPERATIONS.Data
{
    public class NoteDbContext:DbContext
    {

        public NoteDbContext(DbContextOptions options): base(options)
        {

        }

        public DbSet<Note> Notes { get; set; }
    }
}
