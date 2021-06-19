using System;
using DataModel.Modelo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace DataModel.Context
{
    public partial class FisioterapiaContext : DbContext
    {
        public FisioterapiaContext()
        {
        }

        public FisioterapiaContext(DbContextOptions<FisioterapiaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AgenteElectrofisico> AgenteElectrofisicos { get; set; }
        public virtual DbSet<AgenteTermico> AgenteTermicos { get; set; }
        public virtual DbSet<Antecedente> Antecedentes { get; set; }
        public virtual DbSet<Departamento> Departamentos { get; set; }
        public virtual DbSet<Distrito> Distritos { get; set; }
        public virtual DbSet<Estadocivil> Estadocivils { get; set; }
        public virtual DbSet<Frecuencium> Frecuencia { get; set; }
        public virtual DbSet<Historico> Historicos { get; set; }
        public virtual DbSet<ManiobrasTerapeutica> ManiobrasTerapeuticas { get; set; }
        public virtual DbSet<Persona> Personas { get; set; }
        public virtual DbSet<Sexo> Sexos { get; set; }
        public virtual DbSet<SubTramite> SubTramites { get; set; }
        public virtual DbSet<Tipodocumento> Tipodocumentos { get; set; }
        public virtual DbSet<Tramite> Tramites { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<AgenteElectrofisico>(entity =>
            {
                entity.ToTable("AgenteElectrofisico");

                entity.Property(e => e.Descripcion).HasMaxLength(250);

                entity.Property(e => e.Fechacreacion).HasColumnType("datetime");

                entity.Property(e => e.Fechamodificacion).HasColumnType("datetime");

                entity.Property(e => e.Usuariocreacion)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Usuariomodificacion).HasMaxLength(20);

                entity.HasOne(d => d.Historico)
                    .WithMany(p => p.AgenteElectrofisicos)
                    .HasForeignKey(d => d.HistoricoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.AgenteElectrofisico_dbo.Historico_HistoricoId");

                entity.HasOne(d => d.SubTramite)
                    .WithMany(p => p.AgenteElectrofisicos)
                    .HasForeignKey(d => d.SubTramiteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.AgenteElectrofisico_dbo.SubTramite_SubTramiteId");
            });

            modelBuilder.Entity<AgenteTermico>(entity =>
            {
                entity.ToTable("AgenteTermico");

                entity.Property(e => e.Fechacreacion).HasColumnType("datetime");

                entity.Property(e => e.Fechamodificacion).HasColumnType("datetime");

                entity.Property(e => e.Usuariocreacion)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Usuariomodificacion).HasMaxLength(20);

                entity.HasOne(d => d.Historico)
                    .WithMany(p => p.AgenteTermicos)
                    .HasForeignKey(d => d.HistoricoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.AgenteTermico_dbo.Historico_HistoricoId");

                entity.HasOne(d => d.SubTramite)
                    .WithMany(p => p.AgenteTermicos)
                    .HasForeignKey(d => d.SubTramiteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.AgenteTermico_dbo.SubTramite_SubTramiteId");
            });

            modelBuilder.Entity<Antecedente>(entity =>
            {
                entity.HasKey(e => e.AntecedentesId)
                    .HasName("PK_dbo.Antecedentes");

                entity.Property(e => e.Fechacreacion).HasColumnType("datetime");

                entity.Property(e => e.Fechamodificacion).HasColumnType("datetime");

                entity.Property(e => e.Usuariocreacion)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Usuariomodificacion).HasMaxLength(20);

                entity.HasOne(d => d.Historico)
                    .WithMany(p => p.Antecedentes)
                    .HasForeignKey(d => d.HistoricoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Antecedentes_dbo.Historico_HistoricoId");

                entity.HasOne(d => d.SubTramite)
                    .WithMany(p => p.Antecedentes)
                    .HasForeignKey(d => d.SubTramiteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Antecedentes_dbo.SubTramite_SubTramiteId");
            });

            modelBuilder.Entity<Departamento>(entity =>
            {
                entity.ToTable("Departamento");

                entity.HasIndex(e => e.Nombre, "Departamento_Nombre_Index")
                    .IsUnique();

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Distrito>(entity =>
            {
                entity.ToTable("Distrito");

                entity.HasIndex(e => e.Nombre, "Distrito_Nombre_Index")
                    .IsUnique();

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Departamento)
                    .WithMany(p => p.Distritos)
                    .HasForeignKey(d => d.DepartamentoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Distrito_dbo.Departamento_DepartamentoId");
            });

            modelBuilder.Entity<Estadocivil>(entity =>
            {
                entity.ToTable("Estadocivil");

                entity.HasIndex(e => e.Codigo, "Estadocivil_Codigo_Index")
                    .IsUnique();

                entity.HasIndex(e => e.Descripcion, "Estadocivil_Descripcion_Index")
                    .IsUnique();

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Frecuencium>(entity =>
            {
                entity.HasKey(e => e.FrecuenciaId)
                    .HasName("PK_dbo.Frecuencia");

                entity.Property(e => e.Fechacreacion).HasColumnType("datetime");

                entity.Property(e => e.Fechamodificacion).HasColumnType("datetime");

                entity.Property(e => e.Usuariocreacion)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Usuariomodificacion).HasMaxLength(20);

                entity.HasOne(d => d.Historico)
                    .WithMany(p => p.FrecuenciaNavigation)
                    .HasForeignKey(d => d.HistoricoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Frecuencia_dbo.Historico_HistoricoId");

                entity.HasOne(d => d.SubTramite)
                    .WithMany(p => p.Frecuencia)
                    .HasForeignKey(d => d.SubTramiteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Frecuencia_dbo.SubTramite_SubTramiteId");
            });

            modelBuilder.Entity<Historico>(entity =>
            {
                entity.ToTable("Historico");

                entity.Property(e => e.Costo).HasColumnType("decimal(10, 1)");

                entity.Property(e => e.Diagnostico).HasMaxLength(250);

                entity.Property(e => e.Fechacita).HasColumnType("datetime");

                entity.Property(e => e.Fechacreacion).HasColumnType("datetime");

                entity.Property(e => e.Fechamodificacion).HasColumnType("datetime");

                entity.Property(e => e.Frecuencia).HasMaxLength(50);

                entity.Property(e => e.Observaciones).HasMaxLength(250);

                entity.Property(e => e.Otros).HasMaxLength(250);

                entity.Property(e => e.Paquetes).HasMaxLength(50);

                entity.Property(e => e.Usuariocreacion)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Usuariomodificacion).HasMaxLength(20);

                entity.HasOne(d => d.Persona)
                    .WithMany(p => p.Historicos)
                    .HasForeignKey(d => d.PersonaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Historico_dbo.Persona_PersonaId");
            });

            modelBuilder.Entity<ManiobrasTerapeutica>(entity =>
            {
                entity.HasKey(e => e.ManiobrasTerapeuticasId)
                    .HasName("PK_dbo.ManiobrasTerapeuticas");

                entity.Property(e => e.Fechacreacion).HasColumnType("datetime");

                entity.Property(e => e.Fechamodificacion).HasColumnType("datetime");

                entity.Property(e => e.Usuariocreacion)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Usuariomodificacion).HasMaxLength(20);

                entity.HasOne(d => d.Historico)
                    .WithMany(p => p.ManiobrasTerapeuticas)
                    .HasForeignKey(d => d.HistoricoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.ManiobrasTerapeuticas_dbo.Historico_HistoricoId");

                entity.HasOne(d => d.SubTramite)
                    .WithMany(p => p.ManiobrasTerapeuticas)
                    .HasForeignKey(d => d.SubTramiteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.ManiobrasTerapeuticas_dbo.SubTramite_SubTramiteId");
            });

            modelBuilder.Entity<Persona>(entity =>
            {
                entity.ToTable("Persona");

                entity.HasIndex(e => e.Nrodocumento, "Persona_Nrodocumento_Index")
                    .IsUnique();

                entity.Property(e => e.Apellidomaterno)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Apellidopaterno)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Fechacreacion).HasColumnType("datetime");

                entity.Property(e => e.Fechamodificacion).HasColumnType("datetime");

                entity.Property(e => e.Fecnacimiento).HasColumnType("datetime");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Nrodocumento)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Nrotelefono).HasMaxLength(12);

                entity.Property(e => e.Ocupacion).HasMaxLength(250);

                entity.Property(e => e.Usuariocreacion)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Usuariomodificacion).HasMaxLength(20);

                entity.HasOne(d => d.Distrito)
                    .WithMany(p => p.Personas)
                    .HasForeignKey(d => d.DistritoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Persona_dbo.Distrito_DistritoId");

                entity.HasOne(d => d.Sexo)
                    .WithMany(p => p.Personas)
                    .HasForeignKey(d => d.SexoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Persona_dbo.Sexo_SexoId");

                entity.HasOne(d => d.Tipodocumento)
                    .WithMany(p => p.Personas)
                    .HasForeignKey(d => d.TipodocumentoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Persona_dbo.Tipodocumento_TipodocumentoId");
            });

            modelBuilder.Entity<Sexo>(entity =>
            {
                entity.ToTable("Sexo");

                entity.HasIndex(e => e.Codigo, "Sexo_Codigo_Index")
                    .IsUnique();

                entity.HasIndex(e => e.Descripcion, "Sexo_Descripcion_Index")
                    .IsUnique();

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<SubTramite>(entity =>
            {
                entity.ToTable("SubTramite");

                entity.HasIndex(e => e.Descripcion, "SubTramite_Descripcion_Index")
                    .IsUnique();

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Fechacreacion).HasColumnType("datetime");

                entity.Property(e => e.Fechamodificacion).HasColumnType("datetime");

                entity.Property(e => e.Usuariocreacion)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Usuariomodificacion).HasMaxLength(20);

                entity.HasOne(d => d.CodigoNavigation)
                    .WithMany(p => p.SubTramites)
                    .HasForeignKey(d => d.Codigo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.SubTramite_dbo.Tramite_Codigo");
            });

            modelBuilder.Entity<Tipodocumento>(entity =>
            {
                entity.ToTable("Tipodocumento");

                entity.HasIndex(e => e.Codigo, "Tipodocumento_Codigo_Index")
                    .IsUnique();

                entity.HasIndex(e => e.Descripcion, "Tipodocumento_Descripcion_Index")
                    .IsUnique();

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Tramite>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_dbo.Tramite");

                entity.ToTable("Tramite");

                entity.HasIndex(e => e.Descripcion, "Tramite_Descripcion_Index")
                    .IsUnique();

                entity.Property(e => e.Codigo)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Fechacreacion).HasColumnType("datetime");

                entity.Property(e => e.Fechamodificacion).HasColumnType("datetime");

                entity.Property(e => e.Usuariocreacion)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Usuariomodificacion).HasMaxLength(20);
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.ToTable("Usuario");

                entity.HasIndex(e => e.CodUsuario, "Usuario_CodUsuario_Index")
                    .IsUnique();

                entity.HasIndex(e => e.Correo, "Usuario_Correo_Index")
                    .IsUnique();

                entity.Property(e => e.CodUsuario)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Contrasena)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Correo)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Fechacreacion).HasColumnType("datetime");

                entity.Property(e => e.Fechamodificacion).HasColumnType("datetime");

                entity.Property(e => e.Usuariocreacion)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Usuariomodificacion).HasMaxLength(20);

                entity.HasOne(d => d.Persona)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.PersonaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Usuario_dbo.Persona_PersonaId");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
