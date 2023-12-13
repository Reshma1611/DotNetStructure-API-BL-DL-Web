using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DAL.Models
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<TblState> tblState { get; set; }
        public DbSet<TblCity> tblCity { get; set; }
        public DbSet<TblUserRegistration> tblUserRegistration { get; set; }

    }
}
