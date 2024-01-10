﻿// <auto-generated />
using System;
using ClinicaAPI.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ClinicaAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240110131342_AlterandoDateOnly")]
    partial class AlterandoDateOnly
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ClinicaAPI.Models.AgendaModel", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("configRept")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateOnly>("diaF")
                        .HasColumnType("date");

                    b.Property<DateOnly>("diaI")
                        .HasColumnType("date");

                    b.Property<DateTime>("dtAlt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("historico")
                        .HasColumnType("text");

                    b.Property<string>("horario")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("idCliente")
                        .HasColumnType("integer");

                    b.Property<int>("idFuncAlt")
                        .HasColumnType("integer");

                    b.Property<string>("multi")
                        .HasColumnType("text");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("obs")
                        .HasColumnType("text");

                    b.Property<string>("profis")
                        .HasColumnType("text");

                    b.Property<int>("repeticao")
                        .HasColumnType("integer");

                    b.Property<int>("sala")
                        .HasColumnType("integer");

                    b.Property<int>("status")
                        .HasColumnType("integer");

                    b.Property<string>("subtitulo")
                        .HasColumnType("text");

                    b.Property<int>("unidade")
                        .HasColumnType("integer");

                    b.Property<double?>("valor")
                        .HasColumnType("double precision");

                    b.HasKey("id");

                    b.ToTable("Agendas");
                });

            modelBuilder.Entity("ClinicaAPI.Models.ClienteModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("AreaSession")
                        .HasColumnType("text");

                    b.Property<bool>("Ativo")
                        .HasColumnType("boolean");

                    b.Property<string>("Celular")
                        .HasColumnType("text");

                    b.Property<DateTime>("ClienteDesde")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Cpf")
                        .HasColumnType("text");

                    b.Property<DateTime>("DtInclusao")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateOnly>("DtNascim")
                        .HasColumnType("date");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Foto")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Identidade")
                        .HasColumnType("text");

                    b.Property<string>("Mae")
                        .HasColumnType("text");

                    b.Property<string>("MaeCelular")
                        .HasColumnType("text");

                    b.Property<string>("MaeCpf")
                        .HasColumnType("text");

                    b.Property<string>("MaeEmail")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("MaeEndereco")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("MaeIdentidade")
                        .HasColumnType("text");

                    b.Property<bool>("MaeRestric")
                        .HasColumnType("boolean");

                    b.Property<string>("MaeTelComercial")
                        .HasColumnType("text");

                    b.Property<string>("MaeTelFixo")
                        .HasColumnType("text");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Pai")
                        .HasColumnType("text");

                    b.Property<string>("PaiCelular")
                        .HasColumnType("text");

                    b.Property<string>("PaiCpf")
                        .HasColumnType("text");

                    b.Property<string>("PaiEmail")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PaiEndereco")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PaiIdentidade")
                        .HasColumnType("text");

                    b.Property<bool>("PaiRestric")
                        .HasColumnType("boolean");

                    b.Property<string>("PaiTelComercial")
                        .HasColumnType("text");

                    b.Property<string>("PaiTelFixo")
                        .HasColumnType("text");

                    b.Property<int>("RespFinanc")
                        .HasColumnType("integer");

                    b.Property<bool>("SaiSozinho")
                        .HasColumnType("boolean");

                    b.Property<string>("TelComercial")
                        .HasColumnType("text");

                    b.Property<string>("TelFixo")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("ClinicaAPI.Models.DocumentoModel", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("arquivo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<byte[]>("arquivoPDF")
                        .IsRequired()
                        .HasColumnType("bytea");

                    b.Property<string>("cliOuProf")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("descricao")
                        .HasColumnType("text");

                    b.Property<DateTime>("dtInclusao")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("idPessoa")
                        .HasColumnType("integer");

                    b.Property<string>("tipo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("Documentos");
                });

            modelBuilder.Entity("ClinicaAPI.Models.DonoSalaModel", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("area")
                        .HasColumnType("text");

                    b.Property<string>("configRept")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateOnly?>("dataFim")
                        .HasColumnType("date");

                    b.Property<DateOnly>("dataInicio")
                        .HasColumnType("date");

                    b.Property<string>("diaSemana")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("idProfissional")
                        .HasColumnType("integer");

                    b.Property<string>("periodo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("sala")
                        .HasColumnType("integer");

                    b.Property<int>("unidade")
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.ToTable("DonoSalas");
                });

            modelBuilder.Entity("ClinicaAPI.Models.EscolaModel", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<int?>("anoLetivo")
                        .HasColumnType("integer");

                    b.Property<string>("escola")
                        .HasColumnType("text");

                    b.Property<int>("idCliente")
                        .HasColumnType("integer");

                    b.Property<int>("periodo")
                        .HasColumnType("integer");

                    b.Property<string>("professor")
                        .HasColumnType("text");

                    b.Property<string>("serie")
                        .HasColumnType("text");

                    b.Property<int?>("telEscola")
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.ToTable("Escolas");
                });

            modelBuilder.Entity("ClinicaAPI.Models.FileModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<byte[]>("Content")
                        .IsRequired()
                        .HasColumnType("bytea");

                    b.Property<string>("ContentType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTimeOffset>("UploadDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Files");
                });

            modelBuilder.Entity("ClinicaAPI.Models.FinanceiroModel", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<DateOnly>("data")
                        .HasColumnType("date");

                    b.Property<string>("descricao")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("idCliente")
                        .HasColumnType("integer");

                    b.Property<int>("idFuncAlt")
                        .HasColumnType("integer");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("recibo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("refAgenda")
                        .HasColumnType("integer");

                    b.Property<bool?>("selecionada")
                        .HasColumnType("boolean");

                    b.Property<double>("valor")
                        .HasColumnType("double precision");

                    b.HasKey("id");

                    b.ToTable("Financeiros");
                });

            modelBuilder.Entity("ClinicaAPI.Models.FormacaoModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("AreasRelacionadas")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateOnly?>("DtConclusao")
                        .HasColumnType("date");

                    b.Property<int>("IdFuncionario")
                        .HasColumnType("integer");

                    b.Property<string>("Instituicao")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Nivel")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("NomeFormacao")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Registro")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Formacaos");
                });

            modelBuilder.Entity("ClinicaAPI.Models.InfoModel", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("destinat")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("dtFim")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("dtInicio")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("idFuncAlt")
                        .HasColumnType("integer");

                    b.Property<string>("nomeInfo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("subtitulo")
                        .HasColumnType("text");

                    b.Property<string>("tipoInfo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("Infos");
                });

            modelBuilder.Entity("ClinicaAPI.Models.PerfilModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool?>("Coord")
                        .HasColumnType("boolean");

                    b.Property<string>("Descricao")
                        .HasColumnType("text");

                    b.Property<bool?>("Dir")
                        .HasColumnType("boolean");

                    b.Property<bool?>("Equipe")
                        .HasColumnType("boolean");

                    b.Property<string>("Help")
                        .HasColumnType("text");

                    b.Property<bool?>("Secr")
                        .HasColumnType("boolean");

                    b.Property<bool?>("SiMesmo")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.ToTable("Perfils");
                });

            modelBuilder.Entity("ClinicaAPI.Models.ProntuarioModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DtInsercao")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("IdCliente")
                        .HasColumnType("integer");

                    b.Property<int>("IdColab")
                        .HasColumnType("integer");

                    b.Property<string>("Texto")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Prontuarios");
                });

            modelBuilder.Entity("ClinicaAPI.Models.UserModel", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("areaSession")
                        .HasColumnType("text");

                    b.Property<bool>("ativo")
                        .HasColumnType("boolean");

                    b.Property<string>("celular")
                        .HasColumnType("text");

                    b.Property<string>("cpf")
                        .HasColumnType("text");

                    b.Property<DateOnly>("dtAdmis")
                        .HasColumnType("date");

                    b.Property<DateOnly?>("dtDeslig")
                        .HasColumnType("date");

                    b.Property<DateOnly>("dtNasc")
                        .HasColumnType("date");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("endereco")
                        .HasColumnType("text");

                    b.Property<string>("foto")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("idPerfil")
                        .HasColumnType("integer");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("rg")
                        .HasColumnType("text");

                    b.Property<string>("senhaHash")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("senhaProv")
                        .HasColumnType("text");

                    b.Property<string>("telFixo")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ClinicaAPI.Models.ValorModel", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<DateOnly>("data")
                        .HasColumnType("date");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("selecionada")
                        .HasColumnType("boolean");

                    b.Property<double>("valor")
                        .HasColumnType("double precision");

                    b.HasKey("id");

                    b.ToTable("Valores");
                });
#pragma warning restore 612, 618
        }
    }
}
