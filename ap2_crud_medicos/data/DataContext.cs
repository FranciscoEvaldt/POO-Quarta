using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ap2_crud_medicos.Data
{
    public class DataContext : DbContext
    {
        public string DbPath { get; }
  }
}