﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repository.Data;

namespace Service.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20211101094646_Artice_Fix")]
    partial class Artice_Fix
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Domain.Authentication.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Domain.Entities.Article", b =>
                {
                    b.Property<int>("Article_ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Designation")
                        .HasColumnType("nvarchar(100)");

                    b.Property<double>("Tarif");

                    b.HasKey("Article_ID");

                    b.ToTable("Article");
                });

            modelBuilder.Entity("Domain.Entities.CentraleBeton", b =>
                {
                    b.Property<int>("Ctr_ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ctr_Adresse");

                    b.Property<int?>("Ctr_CodePostal");

                    b.Property<string>("Ctr_Email")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Ctr_Gsm")
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Ctr_Latiture")
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Ctr_Longitude")
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Ctr_Nom")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Ctr_Responsable")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Ctr_Responsable_Gsm")
                        .HasColumnType("nvarchar(20)");

                    b.Property<int?>("Ctr_Ville_Id");

                    b.Property<decimal>("Rayon");

                    b.HasKey("Ctr_ID");

                    b.HasIndex("Ctr_Ville_Id");

                    b.ToTable("Centrale_Beton");
                });

            modelBuilder.Entity("Domain.Entities.Chantier", b =>
                {
                    b.Property<int>("Ctn_Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CentraleBetonCtr_ID");

                    b.Property<string>("Ctn_Adresse")
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("Ctn_Ctr_Id");

                    b.Property<string>("Ctn_Latiture")
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Ctn_Longitude")
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Ctn_Nom")
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Ctn_Tc_Id");

                    b.Property<int>("Ctn_Zone_Id");

                    b.Property<string>("Ctr_Nom");

                    b.Property<decimal>("Duree");

                    b.Property<string>("MaitreOuvrage");

                    b.Property<decimal>("Rayon");

                    b.Property<int?>("TypeChantierTc_Id");

                    b.Property<decimal>("VolumePrevisonnel");

                    b.HasKey("Ctn_Id");

                    b.HasIndex("CentraleBetonCtr_ID");

                    b.HasIndex("Ctn_Zone_Id");

                    b.HasIndex("TypeChantierTc_Id");

                    b.ToTable("Chantier");
                });

            modelBuilder.Entity("Domain.Entities.Client", b =>
                {
                    b.Property<int>("Client_Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adresse")
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("Client_Ctn_Id");

                    b.Property<string>("Cnie")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CodeClientSap")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Destinataire_Interlocuteur")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("FormeJuridique_Id");

                    b.Property<string>("Gsm")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Ice")
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("IdPays");

                    b.Property<int>("IdVille");

                    b.Property<string>("RaisonSociale")
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Client_Id");

                    b.HasIndex("Client_Ctn_Id");

                    b.HasIndex("FormeJuridique_Id");

                    b.HasIndex("IdPays");

                    b.HasIndex("IdVille");

                    b.ToTable("Client");
                });

            modelBuilder.Entity("Domain.Entities.Commande", b =>
                {
                    b.Property<int>("IdCommande")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CodeClientSap")
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("CodeCommandeSap")
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Currency");

                    b.Property<DateTime?>("DateCommande")
                        .HasColumnType("smalldatetime");

                    b.Property<DateTime?>("DateLivraisonSouhaite")
                        .HasColumnType("smalldatetime");

                    b.Property<int?>("IdClient");

                    b.Property<int?>("IdStatut");

                    b.Property<decimal?>("MontantCommande");

                    b.HasKey("IdCommande");

                    b.HasIndex("IdClient");

                    b.HasIndex("IdStatut");

                    b.ToTable("Commande");
                });

            modelBuilder.Entity("Domain.Entities.DelaiPaiement", b =>
                {
                    b.Property<int>("Delai_ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Delai_Libelle")
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Delai_ID");

                    b.ToTable("Delai_Paiement");
                });

            modelBuilder.Entity("Domain.Entities.DetailCommande", b =>
                {
                    b.Property<int>("IdDetailCommande")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CodeArticleSap")
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("CodeCommandeSap")
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime?>("DateProduction");

                    b.Property<int?>("IdArticle");

                    b.Property<int?>("IdCommande");

                    b.Property<int?>("IdUniteQuantite");

                    b.Property<decimal?>("Montant");

                    b.Property<decimal?>("PoidsNet")
                        .HasColumnType("decimal(10,2)");

                    b.Property<decimal?>("PrixNet")
                        .HasColumnType("decimal(10,2)");

                    b.Property<decimal?>("Quantite")
                        .HasColumnType("decimal(10,2)");

                    b.Property<decimal?>("ValeurNette")
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("IdDetailCommande");

                    b.HasIndex("IdArticle");

                    b.HasIndex("IdCommande");

                    b.HasIndex("IdUniteQuantite");

                    b.ToTable("DetailCommande");
                });

            modelBuilder.Entity("Domain.Entities.FormeJuridique", b =>
                {
                    b.Property<int>("FormeJuridique_Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FormeJuridique_Libelle")
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("FormeJuridique_Id");

                    b.ToTable("Forme_Juridique");
                });

            modelBuilder.Entity("Domain.Entities.Paiement", b =>
                {
                    b.Property<int>("Paiement_Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Conditions")
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Ctn_Id");

                    b.Property<int?>("DelaiPaiementDelai_ID");

                    b.Property<int>("Delai_Paiement_Id");

                    b.HasKey("Paiement_Id");

                    b.HasIndex("Ctn_Id");

                    b.HasIndex("DelaiPaiementDelai_ID");

                    b.ToTable("Paiement");
                });

            modelBuilder.Entity("Domain.Entities.Pays", b =>
                {
                    b.Property<int>("IdPays")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CodePaysSap")
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("NomPays")
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("IdPays");

                    b.ToTable("Pays");
                });

            modelBuilder.Entity("Domain.Entities.Statut", b =>
                {
                    b.Property<int>("IdStatut")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CodeStatutSap")
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Libelle")
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("IdStatut");

                    b.ToTable("Statut");
                });

            modelBuilder.Entity("Domain.Entities.TarifBetonRef", b =>
                {
                    b.Property<int>("Tbr_Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Designation_Beton");

                    b.Property<double>("Tarif");

                    b.HasKey("Tbr_Id");

                    b.ToTable("Tarif_Ref");
                });

            modelBuilder.Entity("Domain.Entities.TarifPompeRef", b =>
                {
                    b.Property<int>("Tpr_Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LongFleche_Libelle");

                    b.Property<decimal>("LongFleche_Prix");

                    b.HasKey("Tpr_Id");

                    b.ToTable("Tarif_Pompe");
                });

            modelBuilder.Entity("Domain.Entities.TarifService", b =>
                {
                    b.Property<int>("TS_Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("TarifPompage");

                    b.Property<double>("TarifTransport");

                    b.Property<int>("Ts_Ctn_Id");

                    b.HasKey("TS_Id");

                    b.HasIndex("Ts_Ctn_Id");

                    b.ToTable("Tarif_Service");
                });

            modelBuilder.Entity("Domain.Entities.TypeChantier", b =>
                {
                    b.Property<int>("Tc_Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Tc_Libelle")
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Tc_Id");

                    b.ToTable("Type_Chantier");
                });

            modelBuilder.Entity("Domain.Entities.Unite", b =>
                {
                    b.Property<int>("IdUnite")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Libelle")
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("IdUnite");

                    b.ToTable("Unite");
                });

            modelBuilder.Entity("Domain.Entities.Ville", b =>
                {
                    b.Property<int>("IdVille")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CodePaysSap");

                    b.Property<string>("CodeVilleSap")
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("IdPays");

                    b.Property<string>("NomVille")
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("IdVille");

                    b.HasIndex("IdPays");

                    b.ToTable("Ville");
                });

            modelBuilder.Entity("Domain.Entities.Zone", b =>
                {
                    b.Property<int>("Zone_Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Zone_Libelle")
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("Zone_Prix");

                    b.HasKey("Zone_Id");

                    b.ToTable("Zone");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Domain.Entities.CentraleBeton", b =>
                {
                    b.HasOne("Domain.Entities.Ville", "VILLE")
                        .WithMany()
                        .HasForeignKey("Ctr_Ville_Id");
                });

            modelBuilder.Entity("Domain.Entities.Chantier", b =>
                {
                    b.HasOne("Domain.Entities.CentraleBeton", "CentraleBeton")
                        .WithMany()
                        .HasForeignKey("CentraleBetonCtr_ID");

                    b.HasOne("Domain.Entities.Zone", "ZONE_CHANTIER")
                        .WithMany()
                        .HasForeignKey("Ctn_Zone_Id")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Domain.Entities.TypeChantier", "TypeChantier")
                        .WithMany()
                        .HasForeignKey("TypeChantierTc_Id");
                });

            modelBuilder.Entity("Domain.Entities.Client", b =>
                {
                    b.HasOne("Domain.Entities.Chantier", "Chantier")
                        .WithMany()
                        .HasForeignKey("Client_Ctn_Id")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Domain.Entities.FormeJuridique", "FormeJuridique")
                        .WithMany()
                        .HasForeignKey("FormeJuridique_Id")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Domain.Entities.Pays", "Pays")
                        .WithMany()
                        .HasForeignKey("IdPays")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Domain.Entities.Ville", "Ville")
                        .WithMany()
                        .HasForeignKey("IdVille")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Domain.Entities.Commande", b =>
                {
                    b.HasOne("Domain.Entities.Client", "Client")
                        .WithMany()
                        .HasForeignKey("IdClient");

                    b.HasOne("Domain.Entities.Statut", "Statut")
                        .WithMany()
                        .HasForeignKey("IdStatut");
                });

            modelBuilder.Entity("Domain.Entities.DetailCommande", b =>
                {
                    b.HasOne("Domain.Entities.Article", "Article")
                        .WithMany()
                        .HasForeignKey("IdArticle");

                    b.HasOne("Domain.Entities.Commande", "Commande")
                        .WithMany()
                        .HasForeignKey("IdCommande");

                    b.HasOne("Domain.Entities.Unite", "Unite")
                        .WithMany()
                        .HasForeignKey("IdUniteQuantite");
                });

            modelBuilder.Entity("Domain.Entities.Paiement", b =>
                {
                    b.HasOne("Domain.Entities.Chantier", "Chantier")
                        .WithMany()
                        .HasForeignKey("Ctn_Id")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Domain.Entities.DelaiPaiement", "DelaiPaiement")
                        .WithMany()
                        .HasForeignKey("DelaiPaiementDelai_ID");
                });

            modelBuilder.Entity("Domain.Entities.TarifService", b =>
                {
                    b.HasOne("Domain.Entities.Chantier", "Chantier")
                        .WithMany()
                        .HasForeignKey("Ts_Ctn_Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Domain.Entities.Ville", b =>
                {
                    b.HasOne("Domain.Entities.Pays", "Pays")
                        .WithMany()
                        .HasForeignKey("IdPays");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Domain.Authentication.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Domain.Authentication.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Domain.Authentication.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Domain.Authentication.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
