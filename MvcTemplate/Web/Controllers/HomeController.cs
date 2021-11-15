using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Service.IServices;
using Web.Models;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICommandeService commandeService;
        public HomeController(ICommandeService commandeService)
        {
            this.commandeService = commandeService;
        }
        public IActionResult Index()
        {
            ViewData["FormeJuridique"] = new SelectList(commandeService.GetFormeJuridiques(), "FormeJuridique_Id", "FormeJuridique_Libelle");
            ViewData["TypeChantier"] = new SelectList(commandeService.GetTypeChantiers(), "Tc_Id", "Tc_Libelle");
            ViewData["Zone"] = new SelectList(commandeService.GetZones(), "Zone_Id", "Zone_Libelle");
            ViewData["Article"] = new SelectList(commandeService.GetArticles(), "Article_Id", "Designation");
            ViewData["DelaiPaiement"] = new SelectList(commandeService.GetDelaiPaiements(), "Delai_Id", "Delai_Libelle");
            ViewData["Centrale"] = new SelectList(commandeService.GetCentraleBetons(), "Ctr_Id", "Ctr_Nom");
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public async Task<double> GetTarifArticle(int Id)
        {
            return await commandeService.GetTarifArticle(Id);
        }
    }
}
