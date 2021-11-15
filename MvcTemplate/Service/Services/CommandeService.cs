using AutoMapper;
using Domain.Entities;
using Domain.Enums;
using Domain.Models;
using Domain.Models.Commande;
using Microsoft.EntityFrameworkCore.Storage;
using Repository.IRepositories;
using Repository.UnitOfWork;
using Service.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class CommandeService : ICommandeService
    {
        private readonly ICommandeRepository commandeRepository;
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;

        public CommandeService(ICommandeRepository commandeRepository, IMapper mapper, IUnitOfWork unitOfWork)
        {
            this.commandeRepository = commandeRepository;
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
        }

        public IEnumerable<FormeJuridiqueModel> GetFormeJuridiques()
        {
            return mapper.Map<IEnumerable<FormeJuridique>, IEnumerable< FormeJuridiqueModel>> (this.commandeRepository.GetFormeJuridiques());
        }
        public IEnumerable<TypeChantierModel> GetTypeChantiers()
        {
            return mapper.Map<IEnumerable<TypeChantier>, IEnumerable<TypeChantierModel>>(this.commandeRepository.GetTypeChantiers());
        }
        public IEnumerable<ZoneModel> GetZones()
        {
            return mapper.Map<IEnumerable<Zone>, IEnumerable<ZoneModel>>(this.commandeRepository.GetZones());
        }
        public IEnumerable<ArticleModel> GetArticles()
        {
            return mapper.Map<IEnumerable<Article>, IEnumerable<ArticleModel>>(this.commandeRepository.GetArticles());
        }
        public IEnumerable<DelaiPaiementModel> GetDelaiPaiements()
        {
            return mapper.Map<IEnumerable<DelaiPaiement>, IEnumerable<DelaiPaiementModel>>(this.commandeRepository.GetDelaiPaiements());
        }
        public IEnumerable<CentraleBetonModel> GetCentraleBetons()
        {
            return mapper.Map<IEnumerable<CentraleBeton>, IEnumerable<CentraleBetonModel>>(this.commandeRepository.GetCentraleBetons());
        }

        public async Task<double> GetTarifArticle(int Id)
        {
            return await commandeRepository.GetTarifArticle(Id);
        }


        public async Task<bool> CreateCommande (CommandeViewModel commandeViewModel)
        {
            using (IDbContextTransaction transaction = this.unitOfWork.BeginTransaction())
            {
                try
                {
                    Chantier chantier = mapper.Map<ChantierModel, Chantier>(commandeViewModel.Chantier);
                    var ctnId = await commandeRepository.CreateChantier(chantier);

                    commandeViewModel.Client.Client_Ctn_Id = (int)ctnId;
                    Client client = mapper.Map<ClientModel, Client>(commandeViewModel.Client);
                    var clientId = await commandeRepository.CreateClient(client);

                    commandeViewModel.Commande.IdClient = clientId;
                    commandeViewModel.Commande.Currency = "MAD";
                    commandeViewModel.Commande.IdStatut = Statuts.EnCoursDeTraitement;
                    commandeViewModel.Commande.IdChantier = ctnId;
                    commandeViewModel.Commande.DateCommande = DateTime.Now;
                    Commande commande = mapper.Map<CommandeModel, Commande>(commandeViewModel.Commande);
                    var commandeId = await commandeRepository.CreateCommande(commande);

                    foreach (var detail in commandeViewModel.DetailCommandes)
                    {
                        var Tarif = await commandeRepository.GetTarifArticle((int)detail.IdArticle);
                        detail.IdCommande = commandeId;
                        detail.Unite_Id = 1;
                        if (detail.IdArticle == 4)
                            detail.IdStatut = Statuts.EtudeEtPropositionDePrix;
                        else if ((double)detail.Montant != Tarif || Int64.Parse(commandeViewModel.Commande.Delai_Paiement) > 60)
                            detail.IdStatut = Statuts.ParametrageDesPrixPBE;
                        else
                        {
                            detail.IdStatut = Statuts.Validé;
                            var cmd = await commandeRepository.GetCommande(commandeId);
                            cmd.IdStatut = Statuts.Validé;
                        }
                    }
                    List<DetailCommande> detailCommandes = mapper.Map<List<DetailCommandeModel>, List<DetailCommande>>(commandeViewModel.DetailCommandes);
                    await commandeRepository.CreateDetailCommande(detailCommandes);

                    transaction.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    return false;
                }
            }
        }

        public async Task<IEnumerable<ClientModel>> GetClients(string Ice = null, string Cnie = null, string RS = null)
        {
            var clients = await commandeRepository.GetClients(Ice, Cnie, RS);
            return mapper.Map<IEnumerable<Client>, IEnumerable<ClientModel>>(clients);
        }

        public async Task<IEnumerable<CommandeModel>> GetCommandes(int? ClientId, DateTime? DateCommande)
        {
            var commandes = await commandeRepository.GetCommandes(ClientId, DateCommande);
            return mapper.Map<IEnumerable<Commande>, IEnumerable<CommandeModel>>(commandes);
        }
        public async Task<CommandeModel> GetCommande(int? id)
        {
            return mapper.Map<CommandeModel>(await commandeRepository.GetCommande(id));
        }
    }
}
