﻿// <auto-generated />
using System;
using Market_otomasyon.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Market_otomasyon.Migrations
{
    [DbContext(typeof(MarketDbContext))]
    [Migration("20230118080346_StokTableBarkodString")]
    partial class StokTableBarkodString
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Market_otomasyon.Moduls.Entity.Borc", b =>
                {
                    b.Property<int>("BorcID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MusteriAd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MusteriID")
                        .HasColumnType("int");

                    b.Property<double>("MusteriOdeme")
                        .HasColumnType("float");

                    b.Property<string>("MusteriSoyad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("SatinAlmaTarihi")
                        .HasColumnType("datetime2");

                    b.Property<double>("Tutar")
                        .HasColumnType("float");

                    b.HasKey("BorcID");

                    b.ToTable("Borcs");
                });

            modelBuilder.Entity("Market_otomasyon.Moduls.Entity.Musteri", b =>
                {
                    b.Property<int>("MusteriID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MusteriAd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MusteriSoyad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TelefonNo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MusteriID");

                    b.ToTable("Musteris");
                });

            modelBuilder.Entity("Market_otomasyon.Moduls.Entity.PesinSatis", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FaturaID")
                        .HasColumnType("int");

                    b.Property<double>("Tutar")
                        .HasColumnType("float");

                    b.HasKey("ID");

                    b.ToTable("PesinSatis");
                });

            modelBuilder.Entity("Market_otomasyon.Moduls.Entity.Satici", b =>
                {
                    b.Property<int>("SaticiID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("KullaniciAdi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SaticiAd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SaticiSoyad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sifre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SaticiID");

                    b.ToTable("Satıcıs");
                });

            modelBuilder.Entity("Market_otomasyon.Moduls.Entity.Satis", b =>
                {
                    b.Property<int>("SatisID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Barkod")
                        .HasColumnType("int");

                    b.Property<int>("FaturaID")
                        .HasColumnType("int");

                    b.Property<int>("Miktar")
                        .HasColumnType("int");

                    b.Property<int>("MusteriID")
                        .HasColumnType("int");

                    b.Property<DateTime>("SatinAlmaTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("SatisTipi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Tutar")
                        .HasColumnType("float");

                    b.Property<int>("UrunID")
                        .HasColumnType("int");

                    b.HasKey("SatisID");

                    b.ToTable("Satis");
                });

            modelBuilder.Entity("Market_otomasyon.Moduls.Entity.Stok", b =>
                {
                    b.Property<int>("StokID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Barkod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("BirimGirdiFiyat")
                        .HasColumnType("float");

                    b.Property<string>("Cesit")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IrsaliyeNo")
                        .HasColumnType("int");

                    b.Property<double>("SatisFiyati")
                        .HasColumnType("float");

                    b.Property<int>("StokMiktari")
                        .HasColumnType("int");

                    b.Property<string>("UrunAdi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UrunKodu")
                        .HasColumnType("int");

                    b.HasKey("StokID");

                    b.ToTable("Stoks");
                });

            modelBuilder.Entity("Market_otomasyon.Moduls.Entity.Tedarikci", b =>
                {
                    b.Property<int>("TedarikciID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Tedarikcisim")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TedarikciID");

                    b.ToTable("Tedarikcis");
                });

            modelBuilder.Entity("Market_otomasyon.Moduls.Entity.TedarikciBorc", b =>
                {
                    b.Property<int>("TedarikciBorcID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IrsaliyeNo")
                        .HasColumnType("int");

                    b.Property<double>("TedarikBorc")
                        .HasColumnType("float");

                    b.Property<double>("TedarikOdeme")
                        .HasColumnType("float");

                    b.Property<int>("TedarikciID")
                        .HasColumnType("int");

                    b.Property<string>("Tedarikcisim")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TedarikciBorcID");

                    b.ToTable("TedarikciBorcs");
                });

            modelBuilder.Entity("Market_otomasyon.Moduls.Entity.VeresiyeSatis", b =>
                {
                    b.Property<int>("VeresiyeSatisID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MusteriAd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MusteriID")
                        .HasColumnType("int");

                    b.Property<string>("MusteriSoyad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("SatinAlmaTarihi")
                        .HasColumnType("datetime2");

                    b.Property<double>("Tutar")
                        .HasColumnType("float");

                    b.HasKey("VeresiyeSatisID");

                    b.ToTable("VeresiyeSatis");
                });
#pragma warning restore 612, 618
        }
    }
}
