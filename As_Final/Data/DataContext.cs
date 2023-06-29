using As;
using Microsoft.EntityFrameworkCore;

namespace As
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Book> Livros { get; set; }
        public DbSet<Author> Autores { get; set; }
        public DbSet<User> Usuarios { get; set; }
        public DbSet<Emprestimo> Emprestimos { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookAuthor>()
                .HasKey(la => new { la.LivroId, la.AutorId });

            modelBuilder.Entity<BookAuthor>()
                .HasOne(la => la.Livro)
                .WithMany(l => l.Autores)
                .HasForeignKey(la => la.LivroId);

            modelBuilder.Entity<BookAuthor>()
                .HasOne(la => la.Autor)
                .WithMany(a => a.Livros)
                .HasForeignKey(la => la.AutorId);
        }
    }
}

