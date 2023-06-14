using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ap2_crud_medicos.Domain.Entities;


namespace ap2_crud_medicos.Data
{
  public class DataContext : DbContext
  {
    public string DbPath { get; }
    public DbSet<Medico> Medicos { get; set; }
    public DbSet<Consulta> Consultas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite("Data Source=meuBancoDeDados.db");
  }
}