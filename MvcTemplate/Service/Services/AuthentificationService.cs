using AutoMapper;
using Domain.Authentication;
using Domain.Models;
using Repository.IRepositories;
using Service.IServices;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class AuthentificationService : IAuthentificationService
    {
        private readonly IAuthentificationRepository authentificationRepository;
        private readonly IMapper mapper;


        public AuthentificationService(IAuthentificationRepository authentificationRepository, IMapper mapper)
        {
            this.authentificationRepository = authentificationRepository;
            this.mapper = mapper;
        }

        public async Task<bool> Register(RegisterModel registerModel)
        {

            return await this.authentificationRepository.Register(registerModel);
        }

        public async Task<bool> Login(LoginModel loginModel)
        {
            var user = await this.authentificationRepository.Login(loginModel);

            if (user == null)
                return false;

            return true;
        }
        public async Task<bool> Logout()
        {
            return await this.authentificationRepository.Logout();
        }
    }
}
