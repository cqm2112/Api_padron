using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Api_padron.Models
{
    public partial class cedulaContext : DbContext
    {
        public cedulaContext()
        {
        }

        public cedulaContext(DbContextOptions<cedulaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CancelacionTipoCausa> CancelacionTipoCausas { get; set; } = null!;
        public virtual DbSet<Categorium> Categoria { get; set; } = null!;
        public virtual DbSet<CausaCancelacion> CausaCancelacions { get; set; } = null!;
        public virtual DbSet<CedulasPadronFeb2024> CedulasPadronFeb2024s { get; set; } = null!;
        public virtual DbSet<Circunscripcion> Circunscripcions { get; set; } = null!;
        public virtual DbSet<CiudadSeccion> CiudadSeccions { get; set; } = null!;
        public virtual DbSet<Colegio> Colegios { get; set; } = null!;
        public virtual DbSet<Colegio2024> Colegio2024s { get; set; } = null!;
        public virtual DbSet<ElectoresHabilesFebrero> ElectoresHabilesFebreros { get; set; } = null!;
        public virtual DbSet<EstadoCivil> EstadoCivils { get; set; } = null!;
        public virtual DbSet<Fusione> Fusiones { get; set; } = null!;
        public virtual DbSet<Inhabilitado> Inhabilitados { get; set; } = null!;
        public virtual DbSet<MacroRegion> MacroRegions { get; set; } = null!;
        public virtual DbSet<Municipio> Municipios { get; set; } = null!;
        public virtual DbSet<Nacionalidad> Nacionalidads { get; set; } = null!;
        public virtual DbSet<Ocupacion> Ocupacions { get; set; } = null!;
        public virtual DbSet<Padron> Padrons { get; set; } = null!;
        public virtual DbSet<PadronFeb2024Novedade> PadronFeb2024Novedades { get; set; } = null!;
        public virtual DbSet<PadronMayo2020> PadronMayo2020s { get; set; } = null!;
        public virtual DbSet<Provincium> Provincia { get; set; } = null!;
        public virtual DbSet<Recinto> Recintos { get; set; } = null!;
        public virtual DbSet<RecintoResumenSenalGp> RecintoResumenSenalGps { get; set; } = null!;
        public virtual DbSet<RecintosCoordenadasSenal> RecintosCoordenadasSenals { get; set; } = null!;
        public virtual DbSet<Region> Regions { get; set; } = null!;
        public virtual DbSet<SectorParaje> SectorParajes { get; set; } = null!;
        public virtual DbSet<Sexo> Sexos { get; set; } = null!;
        public virtual DbSet<Transhumancia2024AntesAplicar> Transhumancia2024AntesAplicars { get; set; } = null!;
        public virtual DbSet<VwCascadum> VwCascada { get; set; } = null!;
        public virtual DbSet<VwColegioCascadaOrigen> VwColegioCascadaOrigens { get; set; } = null!;
        public virtual DbSet<VwColegioCascadum> VwColegioCascada { get; set; } = null!;
        public virtual DbSet<VwRecintoCascadum> VwRecintoCascada { get; set; } = null!;
        public virtual DbSet<Zona> Zonas { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=cedula.cdkwgeqgw4lt.us-east-2.rds.amazonaws.com,1433;Database=cedula;User Id=admin;Password=Gomez2024;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("SQL_AltDiction_CP850_CI_AI");

            modelBuilder.Entity<CancelacionTipoCausa>(entity =>
            {
                entity.ToTable("CancelacionTipoCausa");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.RegId).HasColumnName("RegID");
            });

            modelBuilder.Entity<Categorium>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LlevaColegio)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LlevaDatosActa)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LlevaDatosPasaporte)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PuedeVotar)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RegId).HasColumnName("RegID");
            });

            modelBuilder.Entity<CausaCancelacion>(entity =>
            {
                entity.ToTable("CausaCancelacion");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.AfectaColegio)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion2016)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DobleEscaneo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IdtipoCausaCancelacion).HasColumnName("IDTipoCausaCancelacion");

                entity.Property(e => e.RegId).HasColumnName("RegID");

                entity.Property(e => e.TipoRegistro)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TituloReporte)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.TituloReporteCancelacion)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.TituloReporteRevalidacion)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CedulasPadronFeb2024>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CedulasPadronFeb2024");

                entity.Property(e => e.Cedula)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("cedula");
            });

            modelBuilder.Entity<Circunscripcion>(entity =>
            {
                entity.ToTable("Circunscripcion");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CodigoCircunscripcion)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Idprovincia).HasColumnName("IDProvincia");

                entity.Property(e => e.RegId).HasColumnName("RegID");
            });

            modelBuilder.Entity<CiudadSeccion>(entity =>
            {
                entity.ToTable("CiudadSeccion");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CodigoCiudad)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Estatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaCreacion).HasColumnType("smalldatetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("smalldatetime");

                entity.Property(e => e.IddistritoMunicipal).HasColumnName("IDDistritoMunicipal");

                entity.Property(e => e.Idmunicipio).HasColumnName("IDMunicipio");

                entity.Property(e => e.RegId).HasColumnName("RegID");
            });

            modelBuilder.Entity<Colegio>(entity =>
            {
                entity.HasKey(e => e.Idcolegio);

                entity.ToTable("Colegio");

                entity.Property(e => e.Idcolegio)
                    .ValueGeneratedNever()
                    .HasColumnName("IDColegio");

                entity.Property(e => e.CodigoColegio)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Idmunicipio).HasColumnName("IDMunicipio");

                entity.Property(e => e.Idrecinto).HasColumnName("IDRecinto");

                entity.Property(e => e.RegId).HasColumnName("RegID");

                entity.Property(e => e.TieneCupo)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Colegio2024>(entity =>
            {
                entity.HasKey(e => e.IdColegio);

                entity.ToTable("Colegio2024");

                entity.Property(e => e.IdColegio).ValueGeneratedNever();

                entity.Property(e => e.CodigoColegio)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoRecinto)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionColegio)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.HashColegio)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ElectoresHabilesFebrero>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ElectoresHabilesFebrero");

                entity.Property(e => e.Apellido1)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("apellido1");

                entity.Property(e => e.Apellido2)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("apellido2");

                entity.Property(e => e.ApellidosPlastico)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Cedula)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoCircunscripcion)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoCiudad)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoColegio)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoRecinto)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoSector)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.ColegioOrigen)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionCiudad)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionColegio)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionDistritoMunicipal)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionMunicipio)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionProvincia)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionRecinto)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionSector)
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.DireccionRecinto)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.EstatusRecinto)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EstatusSector)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaNacimiento).HasColumnType("datetime");

                entity.Property(e => e.IdEstadoCivil)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IdSexo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Nombres)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombres");

                entity.Property(e => e.NombresPlastico)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Zona)
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EstadoCivil>(entity =>
            {
                entity.ToTable("EstadoCivil");

                entity.Property(e => e.Id)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.RegId).HasColumnName("RegID");
            });

            modelBuilder.Entity<Fusione>(entity =>
            {
                entity.HasKey(e => new { e.IdMunicipio, e.CodigoRecinto, e.ColegioOrigen });

                entity.Property(e => e.CodigoRecinto)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ColegioOrigen)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoRecintoDestino)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ColegioDestino)
                    .HasMaxLength(6)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Inhabilitado>(entity =>
            {
                entity.HasKey(e => e.Cedula);

                entity.Property(e => e.Cedula)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Apellido1)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Apellido2)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CedulaAnterior)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EstatusCedulaAzul)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaNacimiento).HasColumnType("datetime");

                entity.Property(e => e.IdEstadoCivil)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.IdSexo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Idcategoria).HasColumnName("IDCategoria");

                entity.Property(e => e.IdcausaCancelacion).HasColumnName("IDCausaCancelacion");

                entity.Property(e => e.Idcolegio).HasColumnName("IDColegio");

                entity.Property(e => e.Idestatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IDEstatus")
                    .IsFixedLength();

                entity.Property(e => e.Idmunicipio).HasColumnName("IDMunicipio");

                entity.Property(e => e.Idnacionalidad).HasColumnName("IDNacionalidad");

                entity.Property(e => e.IdsectorParaje).HasColumnName("IDSectorParaje");

                entity.Property(e => e.LugarNacimiento)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MunCed)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("mun_ced");

                entity.Property(e => e.Nombres)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SeqCed)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("seq_ced");

                entity.Property(e => e.VerCed)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ver_ced");
            });

            modelBuilder.Entity<MacroRegion>(entity =>
            {
                entity.ToTable("MacroRegion");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RegId).HasColumnName("RegID");
            });

            modelBuilder.Entity<Municipio>(entity =>
            {
                entity.ToTable("Municipio");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.Dm)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("DM")
                    .IsFixedLength();

                entity.Property(e => e.Estatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCreacion).HasColumnType("smalldatetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("smalldatetime");

                entity.Property(e => e.IdmunicipioPadre).HasColumnName("IDMunicipioPadre");

                entity.Property(e => e.Idprovincia).HasColumnName("IDProvincia");

                entity.Property(e => e.Oficio).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.RegId).HasColumnName("RegID");
            });

            modelBuilder.Entity<Nacionalidad>(entity =>
            {
                entity.ToTable("Nacionalidad");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Estatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Gentilicio)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RegId).HasColumnName("RegID");

                entity.Property(e => e.Siglas)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Ocupacion>(entity =>
            {
                entity.ToTable("Ocupacion");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Estatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaCreacion).HasColumnType("smalldatetime");

                entity.Property(e => e.Militar)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RegId).HasColumnName("RegID");

                entity.Property(e => e.RequiereTitulo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Padron>(entity =>
            {
                entity.HasKey(e => e.Cedula);

                entity.ToTable("Padron");

                entity.HasIndex(e => new { e.IdMunicipio, e.CodigoColegio }, "IX_Padron");

                entity.HasIndex(e => new { e.IdMunicipio, e.CodigoColegio, e.Apellido1, e.Apellido2, e.Nombres }, "IX_Padron_1");

                entity.Property(e => e.Cedula)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Apellido1)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("apellido1");

                entity.Property(e => e.Apellido2)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("apellido2");

                entity.Property(e => e.ApellidosPlastico)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoCircunscripcion)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoColegio)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoRecinto)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ColegioOrigen)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.FechaNacimiento).HasColumnType("datetime");

                entity.Property(e => e.IdEstadoCivil)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IdSexo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Nombres)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombres");

                entity.Property(e => e.NombresPlastico)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PadronFeb2024Novedade>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Cedula)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Detalle)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<PadronMayo2020>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PadronMayo2020");

                entity.Property(e => e.Apellido1)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("apellido1");

                entity.Property(e => e.Apellido2)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("apellido2");

                entity.Property(e => e.ApellidosPlastico)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Cedula)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoCircunscripcion)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoColegio)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoRecinto)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoRecintoExterior)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ColegioExterior)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.ColegioOrigen)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.FechaNacimiento).HasColumnType("datetime");

                entity.Property(e => e.IdColegioExterior).HasColumnName("idColegioExterior");

                entity.Property(e => e.IdEstadoCivil)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IdSexo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LugarVotacion)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Nombres)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombres");

                entity.Property(e => e.NombresPlastico)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Provincium>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Estatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IdmunicipioCabecera).HasColumnName("IDMunicipioCabecera");

                entity.Property(e => e.Oficio)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RegId).HasColumnName("RegID");

                entity.Property(e => e.Zona)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("ZONA");
            });

            modelBuilder.Entity<Recinto>(entity =>
            {
                entity.ToTable("Recinto");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CodigoRecinto)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionLarga)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.DireccionLarga)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Estatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Idbarrio).HasColumnName("IDBarrio");

                entity.Property(e => e.Idcircunscripcion).HasColumnName("IDCircunscripcion");

                entity.Property(e => e.IdsectorParaje).HasColumnName("IDSectorParaje");

                entity.Property(e => e.RegId).HasColumnName("RegID");

                entity.Property(e => e.Tipo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<RecintoResumenSenalGp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RecintoResumenSenalGPS");

                entity.Property(e => e.CodigoCiudad)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoRecinto)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoSector)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Codigocircunscripcion)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("codigocircunscripcion");

                entity.Property(e => e.Comunicacion2020)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ConectivaCj)
                    .HasMaxLength(255)
                    .HasColumnName("ConectivaCJ");

                entity.Property(e => e.DescripcionCircunscripcion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionCiudad)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionDistritoMunicipal)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionMunicipio)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionProvincia)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionRecinto)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionSector)
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.DireccionRecinto)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Electricidad)
                    .HasMaxLength(255)
                    .HasColumnName("ELECTRICIDAD");

                entity.Property(e => e.EstatusRecinto)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EstatusSector)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Portadoras)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.PosicionamientoGlobal)
                    .HasMaxLength(255)
                    .HasColumnName("POSICIONAMIENTO_GLOBAL");

                entity.Property(e => e.Propiedad).HasMaxLength(255);

                entity.Property(e => e.Ubicación)
                    .HasMaxLength(255)
                    .HasColumnName("UBICACIÓN");

                entity.Property(e => e.Zona)
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RecintosCoordenadasSenal>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RecintosCoordenadasSenal");

                entity.Property(e => e.CodigoRecinto).HasMaxLength(255);

                entity.Property(e => e.Comunicacion2020).HasMaxLength(255);

                entity.Property(e => e.Conectividad)
                    .HasMaxLength(255)
                    .HasColumnName("CONECTIVIDAD");

                entity.Property(e => e.Electricidad)
                    .HasMaxLength(255)
                    .HasColumnName("ELECTRICIDAD");

                entity.Property(e => e.PosicionamientoGlobal)
                    .HasMaxLength(255)
                    .HasColumnName("POSICIONAMIENTO_GLOBAL");

                entity.Property(e => e.Propiedad)
                    .HasMaxLength(255)
                    .HasColumnName("PROPIEDAD");

                entity.Property(e => e.RecintoMunicipio).HasMaxLength(255);

                entity.Property(e => e.Ubicación)
                    .HasMaxLength(255)
                    .HasColumnName("UBICACIÓN");
            });

            modelBuilder.Entity<Region>(entity =>
            {
                entity.ToTable("Region");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdmacroRegion).HasColumnName("IDMacroRegion");
            });

            modelBuilder.Entity<SectorParaje>(entity =>
            {
                entity.ToTable("SectorParaje");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CodigoSector)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.Estatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IdciudadSeccion).HasColumnName("IDCiudadSeccion");

                entity.Property(e => e.Oficio).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.RegId).HasColumnName("RegID");
            });

            modelBuilder.Entity<Sexo>(entity =>
            {
                entity.HasKey(e => e.IdSexo);

                entity.ToTable("Sexo");

                entity.Property(e => e.IdSexo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCreacion).HasColumnType("smalldatetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("smalldatetime");

                entity.Property(e => e.RegId).HasColumnName("RegID");
            });

            modelBuilder.Entity<Transhumancia2024AntesAplicar>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Transhumancia2024AntesAplicar");

                entity.Property(e => e.Cedula)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionCiudad)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionDistritoMunicipal)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionMunicipio)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionProvincia)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionSector)
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.Idcolegio).HasColumnName("IDColegio");

                entity.Property(e => e.IdsectorParaje).HasColumnName("IDSectorParaje");

                entity.Property(e => e.UltimaSolicitud)
                    .HasMaxLength(14)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwCascadum>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwCascada");

                entity.Property(e => e.CodigoCiudad)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoSector)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionCiudad)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionDistritoMunicipal)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionMacroRegion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionMunicipio)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionProvincia)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionRegion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionSector)
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.EstatusSector)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IdmacroRegion).HasColumnName("IDMacroRegion");

                entity.Property(e => e.Idregion).HasColumnName("IDRegion");

                entity.Property(e => e.Zona)
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwColegioCascadaOrigen>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwColegioCascadaOrigen");

                entity.Property(e => e.CodigoCiudad)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoColegio)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoRecinto)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoSector)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Codigocircunscripcion)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("codigocircunscripcion");

                entity.Property(e => e.DescripcionCircunscripcion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionCiudad)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionColegio)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionDistritoMunicipal)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionMunicipio)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionProvincia)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionRecinto)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionSector)
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.DireccionRecinto)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.EstatusRecinto)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EstatusSector)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Idcolegio).HasColumnName("IDColegio");

                entity.Property(e => e.Zona)
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwColegioCascadum>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwColegioCascada");

                entity.Property(e => e.CodigoCiudad)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoColegio)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoRecinto)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoSector)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Codigocircunscripcion)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("codigocircunscripcion");

                entity.Property(e => e.DescripcionCircunscripcion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionCiudad)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionColegio)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionDistritoMunicipal)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionMunicipio)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionProvincia)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionRecinto)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionSector)
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.DireccionRecinto)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.EstatusRecinto)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EstatusSector)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Idcolegio).HasColumnName("IDColegio");

                entity.Property(e => e.Zona)
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwRecintoCascadum>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwRecintoCascada");

                entity.Property(e => e.CodigoCiudad)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoRecinto)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoSector)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Codigocircunscripcion)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("codigocircunscripcion");

                entity.Property(e => e.DescripcionCircunscripcion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionCiudad)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionDistritoMunicipal)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionMunicipio)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionProvincia)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionRecinto)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionSector)
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.DireccionRecinto)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.EstatusRecinto)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EstatusSector)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Zona)
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Zona>(entity =>
            {
                entity.ToTable("Zona");

                entity.Property(e => e.Id)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ID")
                    .IsFixedLength();

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
