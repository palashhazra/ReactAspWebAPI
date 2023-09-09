using Microsoft.EntityFrameworkCore;

namespace ReactASPCRUD.Models
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options):base(options)
        {
            
        }

        public DbSet<Student> Students { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Data Source=INFOSYS-1313507\\SQL2019; Initial Catalog=Student; TrustServerCertificate=True");

        //}
    }
}
