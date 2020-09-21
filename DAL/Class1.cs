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
    public class ReadWriteDrugs
    {

        public bool InsertDrugs(int id, string commercialName, string genericName, string producer,
                                     string activeIngredients, string doseCharacteristic, string imageUrl)
        {

            bool Result = true;
            using (var ctx = new DrugsContext())
            {
                var drug = new Medicine
                {
                    Id = id,
                    CommercialName = commercialName,
                    GenericName = genericName,
                    Producer = producer,
                    ActiveIngredients = activeIngredients,
                    DoseCharacteristic = doseCharacteristic,
                    ImageUrl = imageUrl
                };
                ctx.Drugs.Add(drug);
                ctx.SaveChanges();
            }

            return Result;
        }
        public void InsertPatient(Patient patient)
        {
            try
            {
                using (var ctx = new PatientsContext())
                {
                    ctx.Patients.Add(patient);
                    ctx.SaveChanges();
                }
            }
            catch (Exception e) { throw new Exception(e.Message); }
        }

        public bool RemoveDrugs(int id, string commercialName, string genericName, string producer,
                                     string activeIngredients, string doseCharacteristic, string imageUrl)
        {
            bool Result = true;
            using (var ctx = new DrugsContext())
            {
                var drug = new Medicine
                {
                    Id = id,
                    CommercialName = commercialName,
                    GenericName = genericName,
                    Producer = producer,
                    ActiveIngredients = activeIngredients,
                    DoseCharacteristic = doseCharacteristic,
                    ImageUrl = imageUrl
                };
                ctx.Drugs.Remove(drug);
                ctx.SaveChanges();
            }

            return Result;
        }


    }
    public class DrugsContext : DbContext
    {
        public DrugsContext() : base("DrugsContext")//Name of the DB
        {
        }
        public DbSet<Medicine> Drugs { set; get; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)//remove the 's' from table name
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
    public class DrugsInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<DrugsContext>
    {
        protected override void Seed(DrugsContext context)
        {
            var Drugs = new List<Medicine>
            {
                new Medicine
                {
                    CommercialName = "Acamol",
                    GenericName = "Acamol",
                    Producer = "Teva",
                    ActiveIngredients = "blabla",
                    DoseCharacteristic = "blabla",
                    ImageUrl = "acamol.jpf"
                },
                new Medicine
                {
                    CommercialName = "Advil",
                    GenericName = "Advil",
                    Producer = "Teva",
                    ActiveIngredients = "blabla",
                    DoseCharacteristic = "blabla",
                    ImageUrl = "advil.jpf"
                }
            };
            Drugs.ForEach(d => context.Drugs.Add(d));
            context.SaveChanges();
        }
    }
    public class PatientsContext : DbContext
    {
        public PatientsContext() : base("PtientsContext")//Name of the DB
        {
        }
        public DbSet<Patient> Patients { set; get; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)//remove the 's' from table name
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
    public class PatientsInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<PatientsContext>
    {
        protected override void Seed(PatientsContext context)
        {
            var Patients = new List<Patient>
            {
                new Patient
                {
                    Name = "shosh",
                    DateOfBirth=DateTime.Now,
                    Phone = "0536897421",
                    Email = "blabla@gmail.com",
                    Drugs=new List<Medicine>()
                }
            };
             Patients.ForEach(d => context.Patients.Add(d));
             context.SaveChanges();
        }
    }
}
