using AutoMapper;
using Domain.Authentication;
using Domain.Entities;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Entities to Models mapping
            CreateMap<ApplicationUser, UserModel>();
            CreateMap<Client, ClientModel>();
            CreateMap<Chantier, ChantierModel>();
            CreateMap<Commande, CommandeModel>();
            CreateMap<DetailCommande, DetailCommandeModel>();
            CreateMap<CentraleBeton, CentraleBetonModel>();


            // Models to Entities mapping
            CreateMap<UserModel, ApplicationUser>();
            CreateMap<ClientModel, Client>();
            CreateMap<ChantierModel, Chantier>();
            CreateMap<CommandeModel, Commande>();
            CreateMap<DetailCommandeModel, DetailCommande>();
            CreateMap<CentraleBetonModel, CentraleBeton>();
        }
    }
}
