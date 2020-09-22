using BE;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class mediDB:DbContext
    {
        public mediDB() : base("mediDB")//Name of the DB
        {
        }
        public DbSet<Medicine> Drugs { set; get; }
        public DbSet<Patient> Patients { set; get; }
        public DbSet<Doctor> Doctors { set; get; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)//remove the 's' from table name
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
