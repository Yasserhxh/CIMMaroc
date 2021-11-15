using Domain.Models;
using Domain.Models.Commande;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service.IServices
{
    public interface ICommandeService
    {
        IEnumerable<FormeJuridiqueModel> GetFormeJuridiques();
        IEnumerable<TypeChantierModel> GetTypeChantiers();
        IEnumerable<ZoneModel> GetZones();
        IEnumerable<ArticleModel> GetArticles();
        IEnumerable<DelaiPaiementModel> GetDelaiPaiements();
        IEnumerable<CentraleBetonModel> GetCentraleBetons();
        Task<double> GetTarifArticle(int Id);
        Task<bool> CreateCommande(CommandeViewModel commandeViewModel);
        Task<IEnumerable<ClientModel>> GetClients(string Ice = null, string Cnie = null, string RS = null);
        Task<IEnumerable<CommandeModel>> GetCommandes(int? ClientId, DateTime? DateCommande);
        Task<CommandeModel> GetCommande(int? id);
    }
}
