using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Nirmal_Khatri_dotnet_assignment.Models;

namespace Nirmal_Khatri_dotnet_assignment.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Nirmal_Khatri_dotnet_assignment.Models.jobinvestigate> jobinvestigate { get; set; } = default!;
        public DbSet<Nirmal_Khatri_dotnet_assignment.Models.JobSeeker> JobSeeker { get; set; } = default!;
    }
}
