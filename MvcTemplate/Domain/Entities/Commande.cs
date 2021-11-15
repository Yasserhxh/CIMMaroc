using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain.Entities
{
    [Table("Commande")]
    public class Commande
    {
        [Key]
        public int IdCommande { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        public string CodeCommandeSap { get; set; }
        [ForeignKey("Client")]
        public int? IdClient { get; set; }
        [ForeignKey("Chantier")]
        public int? IdChantier { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        public string CodeClientSap { get; set; }
        public string Currency { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? DateCommande { get; set; }
        public decimal? MontantCommande { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? DateLivraisonSouhaite { get; set; }
        public int? IdStatut { get; set; }
        public double TarifTransport { get; set; }
        public double TarifPompage { get; set; }
        public string Conditions { get; set; }
        public string Delai_Paiement { get; set; }

        public Client Client { get; set; }
        public Statut Statut { get; set; }
        public Chantier Chantier { get; set; }
        public List<DetailCommande> DetailCommandes { get; set; }
    }
}
