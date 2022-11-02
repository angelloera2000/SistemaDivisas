﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaDivisas1._0._0.Areas.Identity.Data;

namespace SistemaDivisas1._0._0.Areas.Identity.Data;

public class SistemasDivisasDbContext : IdentityDbContext<SistemaDivisasUser>
{
    public SistemasDivisasDbContext(DbContextOptions<SistemasDivisasDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);

        builder.ApplyConfiguration(new ApplicationUserEntityConfiguration());
    }
}

internal class ApplicationUserEntityConfiguration : IEntityTypeConfiguration<SistemaDivisasUser>
{
    public void Configure(EntityTypeBuilder<SistemaDivisasUser> builder)
    {
        builder.Property(u => u.FirstName).HasMaxLength(50);
        builder.Property(u => u.LastName).HasMaxLength(50);
    }
}