using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Repository.Data;
using Repository.IRepositories;
using Repository.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class CommandeRepository : ICommandeRepository
    {
        private readonly ApplicationDbContext _db;
        private readonly IUnitOfWork _unitOfWork;
        public CommandeRepository(ApplicationDbContext db, IUnitOfWork unitOfWork)
        {
            _db = db;
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<FormeJuridique> GetFormeJuridiques()
        {
            return _db.FormeJuridiques.AsEnumerable();
        }
        public IEnumerable<TypeChantier> GetTypeChantiers()
        {
            return _db.TypeChantiers.AsEnumerable();
        }
        public IEnumerable<Zone> GetZones()
        {
            return _db.Zones.AsEnumerable();
        }
        public IEnumerable<Article> GetArticles()
        {
            return _db.Articles.AsEnumerable();
        }
        public IEnumerable<DelaiPaiement> GetDelaiPaiements()
        {
            return _db.DélaiPaiements.AsEnumerable();
        }
        public IEnumerable<CentraleBeton> GetCentraleBetons()
        {
            return _db.CentraleBetons.AsEnumerable();
        }

        public async Task<double> GetTarifArticle(int Id)
        {
            var Article = await _db.Articles.FirstOrDefaultAsync(x => x.Article_Id == Id);
            if (Article.Tarif != null)
                return (double)Article.Tarif;
            return 0;         
        }

        public async Task<int?> CreateChantier(Chantier chantier)
        {
            await _db.Chantiers.AddAsync(chantier);
            var confirm = await _unitOfWork.Complete();
            if (confirm > 0)
                return chantier.Ctn_Id;
            else
                return null;
        }

        public async Task<int?> CreateClient(Client client)
        {
            await _db.Clients.AddAsync(client);
            var confirm = await _unitOfWork.Complete();
            if (confirm > 0)
                return client.Client_Id;
            else
                return null;
        }

        public async Task<int?> CreateCommande(Commande commande)
        {
            await _db.Commandes.AddAsync(commande);
            var confirm = await _unitOfWork.Complete();
            if (confirm > 0)
                return commande.IdCommande;
            else
                return null;
        }
        public async Task<bool> CreateDetailCommande(List<DetailCommande> detailCommandes)
        {
            await _db.DetailCommandes.AddRangeAsync(detailCommandes);
            var confirm = await _unitOfWork.Complete();
            if (confirm > 0)
                return true;
            else
                return false;
        }

        public async Task<IEnumerable<Client>> GetClients(string Ice, string Cnie, string RS)
        {
            var query = _db.Clients.AsQueryable();
            if (Ice != null)
            {
                query = query.Where(d => d.Ice == Ice);
            }
            if (Cnie != null)
            {
                query = query.Where(d => d.Cnie == Cnie);
            }
            if (RS != null)
            {
                query = query.Where(d => d.RaisonSociale == RS);
            }
            return await query
                .Include(d => d.Chantier)
                .Include(d => d.Ville)
                .Include(d => d.Pays)
                .ToListAsync();
        }

        public async Task<IEnumerable<Commande>> GetCommandes(int? ClientId, DateTime? DateCommande)
        {
            var query = _db.Commandes.AsQueryable();
            if (ClientId.HasValue)
            {
                query = query.Where(d => d.IdClient == ClientId);
            }
            if (DateCommande.HasValue)
            {
                query = query.Where(d => d.DateCommande.Value.Date == DateCommande);
            }
            return await query
                .Include(d => d.Chantier)
                .Include(d => d.Client)
                .Include(d => d.Statut)
                .ToListAsync();
        }

        public async Task<Commande> GetCommande(int? Id)
        {
            var cmd = await _db.Commandes
                .Include(x => x.DetailCommandes)
                .ThenInclude(a => a.Article)
                .Include(x => x.DetailCommandes)
                .ThenInclude(a => a.Statut)
                .Include(d => d.Chantier).ThenInclude(d=>d.ZONE_CHANTIER)
                .Include(d => d.Client)
                .FirstOrDefaultAsync(x => x.IdCommande == Id);
            return cmd;
        }

        public async Task<double> GetTarifZone(int Id)
        {
            var Zone = await _db.Zones.FirstOrDefaultAsync(x => x.Zone_Id == Id);
            if (Zone != null)
                return (double)Zone.Zone_Prix;
            return 0;
        }
    }
}
