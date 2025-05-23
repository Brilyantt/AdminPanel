
using MedicalProject.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace MedicalProject.DAL.Contexts
{
    public class  AppDbContext : DbContext 
    {
        public DbSet<Doctor> Doctors { get; set; }
        public AppDbContext (DbContextOptions options) : base(options)
        {

        }
    }
}
