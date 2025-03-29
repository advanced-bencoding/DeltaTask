using System.Reflection;
using DeltaTask.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace DeltaTask.Data;

public class DeltaTaskDbContext : DbContext
{
    public DeltaTaskDbContext(DbContextOptions<DeltaTaskDbContext> options) : base(options) { }

    public DbSet<TaskModel> Tasks { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly()); // Auto-load configs
        base.OnModelCreating(modelBuilder);
    }
}
