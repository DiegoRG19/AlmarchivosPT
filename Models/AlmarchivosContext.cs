using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AlmarchivosPT.Models;

public partial class AlmarchivosContext : DbContext
{
    public AlmarchivosContext()
    {
    }

    public AlmarchivosContext(DbContextOptions<AlmarchivosContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Persona> Personas { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

//    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
//        => optionsBuilder.UseSqlServer("server=localhost\\SQLEXPRESS; database=almarchivos; integrated security=true; TrustServerCertificate=true ");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Persona>(entity =>
        {
            entity.HasKey(e => e.IdPersona).HasName("PK__Personas__2EC8D2ACFB0CB47E");

            entity.Property(e => e.Apellidos).HasMaxLength(100);
            entity.Property(e => e.Correo).HasMaxLength(70);
            entity.Property(e => e.FechaCreacionP)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Nombres).HasMaxLength(100);
            entity.Property(e => e.TipoIdPersona).HasMaxLength(5);
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.IdUsuario).HasName("PK__Usuario__5B65BF9723998EC8");

            entity.ToTable("Usuario");

            entity.Property(e => e.Contrasenia).HasMaxLength(50);
            entity.Property(e => e.FechaCreacionU)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Usuario1)
                .HasMaxLength(60)
                .HasColumnName("Usuario");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
