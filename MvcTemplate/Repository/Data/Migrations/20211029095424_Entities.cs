using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Service.Data.Migrations
{
    public partial class Entities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Delai_Paiement",
                columns: table => new
                {
                    Delai_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Delai_Libelle = table.Column<string>(type: "nvarchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Delai_Paiement", x => x.Delai_ID);
                });

            migrationBuilder.CreateTable(
                name: "Forme_Juridique",
                columns: table => new
                {
                    FormeJuridique_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FormeJuridique_Libelle = table.Column<string>(type: "nvarchar(150)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Forme_Juridique", x => x.FormeJuridique_Id);
                });

            migrationBuilder.CreateTable(
                name: "Pays",
                columns: table => new
                {
                    IdPays = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CodePaysSap = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    NomPays = table.Column<string>(type: "nvarchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pays", x => x.IdPays);
                });

            migrationBuilder.CreateTable(
                name: "Statut",
                columns: table => new
                {
                    IdStatut = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CodeStatutSap = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    Libelle = table.Column<string>(type: "nvarchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statut", x => x.IdStatut);
                });

            migrationBuilder.CreateTable(
                name: "Tarif_Pompe",
                columns: table => new
                {
                    Tpr_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LongFleche_Libelle = table.Column<string>(nullable: true),
                    LongFleche_Prix = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tarif_Pompe", x => x.Tpr_Id);
                });

            migrationBuilder.CreateTable(
                name: "Tarif_Ref",
                columns: table => new
                {
                    Tbr_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Designation_Beton = table.Column<string>(nullable: true),
                    Tarif = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tarif_Ref", x => x.Tbr_Id);
                });

            migrationBuilder.CreateTable(
                name: "Type_Chantier",
                columns: table => new
                {
                    Tc_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Tc_Libelle = table.Column<string>(type: "nvarchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Type_Chantier", x => x.Tc_Id);
                });

            migrationBuilder.CreateTable(
                name: "Unite",
                columns: table => new
                {
                    IdUnite = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Libelle = table.Column<string>(type: "nvarchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Unite", x => x.IdUnite);
                });

            migrationBuilder.CreateTable(
                name: "Zone",
                columns: table => new
                {
                    Zone_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Zone_Libelle = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Zone_Prix = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zone", x => x.Zone_Id);
                });

            migrationBuilder.CreateTable(
                name: "Ville",
                columns: table => new
                {
                    IdVille = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CodeVilleSap = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    NomVille = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    IdPays = table.Column<int>(nullable: true),
                    CodePaysSap = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ville", x => x.IdVille);
                    table.ForeignKey(
                        name: "FK_Ville_Pays_IdPays",
                        column: x => x.IdPays,
                        principalTable: "Pays",
                        principalColumn: "IdPays",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Centrale_Beton",
                columns: table => new
                {
                    Ctr_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ctr_Nom = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Ctr_Adresse = table.Column<string>(nullable: true),
                    Ctr_CodePostal = table.Column<int>(nullable: true),
                    Ctr_Ville_Id = table.Column<int>(nullable: true),
                    Ctr_Gsm = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    Ctr_Email = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Ctr_Responsable = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Ctr_Responsable_Gsm = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    Ctr_Latiture = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    Ctr_Longitude = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    Rayon = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Centrale_Beton", x => x.Ctr_ID);
                    table.ForeignKey(
                        name: "FK_Centrale_Beton_Ville_Ctr_Ville_Id",
                        column: x => x.Ctr_Ville_Id,
                        principalTable: "Ville",
                        principalColumn: "IdVille",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Chantier",
                columns: table => new
                {
                    Ctn_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ctn_Nom = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    MaitreOuvrage = table.Column<string>(nullable: true),
                    VolumePrevisonnel = table.Column<decimal>(nullable: false),
                    Duree = table.Column<decimal>(nullable: false),
                    Ctr_Nom = table.Column<string>(nullable: true),
                    Rayon = table.Column<decimal>(nullable: false),
                    Ctn_Zone_Id = table.Column<int>(nullable: false),
                    Ctn_Tc_Id = table.Column<int>(nullable: false),
                    Ctn_Ctr_Id = table.Column<int>(nullable: false),
                    Ctn_Adresse = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    Ctn_Latiture = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    Ctn_Longitude = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    TypeChantierTc_Id = table.Column<int>(nullable: true),
                    CentraleBetonCtr_ID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chantier", x => x.Ctn_Id);
                    table.ForeignKey(
                        name: "FK_Chantier_Centrale_Beton_CentraleBetonCtr_ID",
                        column: x => x.CentraleBetonCtr_ID,
                        principalTable: "Centrale_Beton",
                        principalColumn: "Ctr_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Chantier_Zone_Ctn_Zone_Id",
                        column: x => x.Ctn_Zone_Id,
                        principalTable: "Zone",
                        principalColumn: "Zone_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Chantier_Type_Chantier_TypeChantierTc_Id",
                        column: x => x.TypeChantierTc_Id,
                        principalTable: "Type_Chantier",
                        principalColumn: "Tc_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Article",
                columns: table => new
                {
                    Article_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Designation = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Tarif = table.Column<double>(nullable: false),
                    Article_CTN_ID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Article", x => x.Article_ID);
                    table.ForeignKey(
                        name: "FK_Article_Chantier_Article_CTN_ID",
                        column: x => x.Article_CTN_ID,
                        principalTable: "Chantier",
                        principalColumn: "Ctn_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    Client_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CodeClientSap = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    FormeJuridique_Id = table.Column<int>(nullable: false),
                    Ice = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Cnie = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Gsm = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    RaisonSociale = table.Column<string>(type: "nvarchar(150)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Adresse = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    Destinataire_Interlocuteur = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    IdVille = table.Column<int>(nullable: false),
                    IdPays = table.Column<int>(nullable: false),
                    Client_Ctn_Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.Client_Id);
                    table.ForeignKey(
                        name: "FK_Client_Chantier_Client_Ctn_Id",
                        column: x => x.Client_Ctn_Id,
                        principalTable: "Chantier",
                        principalColumn: "Ctn_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Client_Forme_Juridique_FormeJuridique_Id",
                        column: x => x.FormeJuridique_Id,
                        principalTable: "Forme_Juridique",
                        principalColumn: "FormeJuridique_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Client_Pays_IdPays",
                        column: x => x.IdPays,
                        principalTable: "Pays",
                        principalColumn: "IdPays",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Client_Ville_IdVille",
                        column: x => x.IdVille,
                        principalTable: "Ville",
                        principalColumn: "IdVille",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Paiement",
                columns: table => new
                {
                    Paiement_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Conditions = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Delai_Paiement_Id = table.Column<int>(nullable: false),
                    Ctn_Id = table.Column<int>(nullable: false),
                    DelaiPaiementDelai_ID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paiement", x => x.Paiement_Id);
                    table.ForeignKey(
                        name: "FK_Paiement_Chantier_Ctn_Id",
                        column: x => x.Ctn_Id,
                        principalTable: "Chantier",
                        principalColumn: "Ctn_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Paiement_Delai_Paiement_DelaiPaiementDelai_ID",
                        column: x => x.DelaiPaiementDelai_ID,
                        principalTable: "Delai_Paiement",
                        principalColumn: "Delai_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tarif_Service",
                columns: table => new
                {
                    TS_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TarifTransport = table.Column<double>(nullable: false),
                    TarifPompage = table.Column<double>(nullable: false),
                    Ts_Ctn_Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tarif_Service", x => x.TS_Id);
                    table.ForeignKey(
                        name: "FK_Tarif_Service_Chantier_Ts_Ctn_Id",
                        column: x => x.Ts_Ctn_Id,
                        principalTable: "Chantier",
                        principalColumn: "Ctn_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Commande",
                columns: table => new
                {
                    IdCommande = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CodeCommandeSap = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    IdClient = table.Column<int>(nullable: true),
                    CodeClientSap = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    Currency = table.Column<string>(nullable: true),
                    DateCommande = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    MontantCommande = table.Column<decimal>(nullable: true),
                    DateLivraisonSouhaite = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    IdStatut = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Commande", x => x.IdCommande);
                    table.ForeignKey(
                        name: "FK_Commande_Client_IdClient",
                        column: x => x.IdClient,
                        principalTable: "Client",
                        principalColumn: "Client_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Commande_Statut_IdStatut",
                        column: x => x.IdStatut,
                        principalTable: "Statut",
                        principalColumn: "IdStatut",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DetailCommande",
                columns: table => new
                {
                    IdDetailCommande = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IdCommande = table.Column<int>(nullable: true),
                    CodeCommandeSap = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    IdArticle = table.Column<int>(nullable: true),
                    CodeArticleSap = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    Quantite = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    IdUniteQuantite = table.Column<int>(nullable: true),
                    PrixNet = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    PoidsNet = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    ValeurNette = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    Montant = table.Column<decimal>(nullable: true),
                    DateProduction = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetailCommande", x => x.IdDetailCommande);
                    table.ForeignKey(
                        name: "FK_DetailCommande_Article_IdArticle",
                        column: x => x.IdArticle,
                        principalTable: "Article",
                        principalColumn: "Article_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DetailCommande_Commande_IdCommande",
                        column: x => x.IdCommande,
                        principalTable: "Commande",
                        principalColumn: "IdCommande",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DetailCommande_Unite_IdUniteQuantite",
                        column: x => x.IdUniteQuantite,
                        principalTable: "Unite",
                        principalColumn: "IdUnite",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Article_Article_CTN_ID",
                table: "Article",
                column: "Article_CTN_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Centrale_Beton_Ctr_Ville_Id",
                table: "Centrale_Beton",
                column: "Ctr_Ville_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Chantier_CentraleBetonCtr_ID",
                table: "Chantier",
                column: "CentraleBetonCtr_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Chantier_Ctn_Zone_Id",
                table: "Chantier",
                column: "Ctn_Zone_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Chantier_TypeChantierTc_Id",
                table: "Chantier",
                column: "TypeChantierTc_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Client_Client_Ctn_Id",
                table: "Client",
                column: "Client_Ctn_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Client_FormeJuridique_Id",
                table: "Client",
                column: "FormeJuridique_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Client_IdPays",
                table: "Client",
                column: "IdPays");

            migrationBuilder.CreateIndex(
                name: "IX_Client_IdVille",
                table: "Client",
                column: "IdVille");

            migrationBuilder.CreateIndex(
                name: "IX_Commande_IdClient",
                table: "Commande",
                column: "IdClient");

            migrationBuilder.CreateIndex(
                name: "IX_Commande_IdStatut",
                table: "Commande",
                column: "IdStatut");

            migrationBuilder.CreateIndex(
                name: "IX_DetailCommande_IdArticle",
                table: "DetailCommande",
                column: "IdArticle");

            migrationBuilder.CreateIndex(
                name: "IX_DetailCommande_IdCommande",
                table: "DetailCommande",
                column: "IdCommande");

            migrationBuilder.CreateIndex(
                name: "IX_DetailCommande_IdUniteQuantite",
                table: "DetailCommande",
                column: "IdUniteQuantite");

            migrationBuilder.CreateIndex(
                name: "IX_Paiement_Ctn_Id",
                table: "Paiement",
                column: "Ctn_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Paiement_DelaiPaiementDelai_ID",
                table: "Paiement",
                column: "DelaiPaiementDelai_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Tarif_Service_Ts_Ctn_Id",
                table: "Tarif_Service",
                column: "Ts_Ctn_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Ville_IdPays",
                table: "Ville",
                column: "IdPays");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DetailCommande");

            migrationBuilder.DropTable(
                name: "Paiement");

            migrationBuilder.DropTable(
                name: "Tarif_Pompe");

            migrationBuilder.DropTable(
                name: "Tarif_Ref");

            migrationBuilder.DropTable(
                name: "Tarif_Service");

            migrationBuilder.DropTable(
                name: "Article");

            migrationBuilder.DropTable(
                name: "Commande");

            migrationBuilder.DropTable(
                name: "Unite");

            migrationBuilder.DropTable(
                name: "Delai_Paiement");

            migrationBuilder.DropTable(
                name: "Client");

            migrationBuilder.DropTable(
                name: "Statut");

            migrationBuilder.DropTable(
                name: "Chantier");

            migrationBuilder.DropTable(
                name: "Forme_Juridique");

            migrationBuilder.DropTable(
                name: "Centrale_Beton");

            migrationBuilder.DropTable(
                name: "Zone");

            migrationBuilder.DropTable(
                name: "Type_Chantier");

            migrationBuilder.DropTable(
                name: "Ville");

            migrationBuilder.DropTable(
                name: "Pays");
        }
    }
}
