using DeltaTask.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DeltaTask.Data.Configuration;

internal class TaskModelConfiguration : IEntityTypeConfiguration<TaskModel>
{
    public void Configure(EntityTypeBuilder<TaskModel> builder)
    {
        builder
            .ToTable("delta_tasks");
        builder
            .HasKey(t => t.Id);
        builder
            .Property(t => t.Name)
            .HasColumnName("name")
            .IsRequired();
        builder
            .Property(t => t.Description)
            .HasColumnName("description")
            .IsRequired(false);
        builder
            .Property(t => t.Status)
            .HasColumnName("status")
            .IsRequired();
        builder
            .Property(t => t.Type)
            .HasColumnName("type")
            .IsRequired();
    }
}
