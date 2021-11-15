using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain.Models
{
    public class CommandeModel
    {
        public int IdCommande { get; set; }
        public string CodeCommandeSap { get; set; }
        public int? IdClient { get; set; }
        public int? IdChantier { get; set; }
        public string CodeClientSap { get; set; }
        public string Currency { get; set; }
        public DateTime? DateCommande { get; set; }
        public decimal? MontantCommande { get; set; }
        public DateTime? DateLivraisonSouhaite { get; set; }
        public int? IdStatut { get; set; }
        public double TarifTransport { get; set; }
        public double TarifPompage { get; set; }
        public string Conditions { get; set; }
        public string Delai_Paiement { get; set; }

        public ClientModel Client { get; set; }
        public StatutModel Statut { get; set; }
        public ChantierModel Chantier { get; set; }
        public List<DetailCommandeModel> DetailCommandes { get; set; }
    }
}
