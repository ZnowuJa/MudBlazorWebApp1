namespace MudBlazorWebApp1.Infrastructure.DBContext;

using Microsoft.EntityFrameworkCore;

using MudBlazorWebApp1.Domain.Entities;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
     : base(options)
    {

    }

    public DbSet<BasicFormExample> BasicFormExamples { get; set; }

}
