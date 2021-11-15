using Domain.Models;
using Domain.Models.Commande;
using Microsoft.AspNetCore.Mvc;
using Service.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Controllers
{
    public class CommandeController : Controller
    {
        private readonly ICommandeService commandeService;
        public CommandeController(ICommandeService commandeService)
        {
            this.commandeService = commandeService;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromForm] CommandeViewModel commandeViewModel)
        {
            var redirect = await commandeService.CreateCommande(commandeViewModel);
            if (redirect)
            {
                TempData["Creation"] = "OK";
                return Redirect("/Commande/ListeCommandes");
            }
            else
            {
                TempData["Creation"] = "KO";
                return Redirect("/Home/Index");
            }
        }

        public async Task<IActionResult> ListeCommandes(CommandeSearchVm vm)
        {
            vm.CLients = await commandeService.GetClients();
            vm.Commandes = await commandeService.GetCommandes(vm.IdClient, vm.DateCommande);
            return View(vm);
        }
        public async Task<IActionResult> Detail(int? Id)
        {
            var commande = await commandeService.GetCommande(Id);
            return View(commande);
        }
    }
}
