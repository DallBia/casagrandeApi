﻿using ClinicaAPI.DataContext;
using ClinicaAPI.Models;
using Microsoft.EntityFrameworkCore;
using ClinicaAPI.Service.EmailService;

namespace ClinicaAPI.Service.UserService
{

    public class UserService : IUserInterface
    {
        private readonly ApplicationDbContext _context;
        public UserService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ServiceResponse<List<UserModel>>> CreateUser(UserModel novoUser)
        {
            ServiceResponse<List<UserModel>> serviceResponse = new ServiceResponse<List<UserModel>>();

            try
            {
                if (novoUser == null)
                {
                    serviceResponse.Dados = null;
                    serviceResponse.Mensagem = "Informar dados...";
                    serviceResponse.Sucesso = false;
                    return serviceResponse;
                }
                _context.Add(novoUser);
                await _context.SaveChangesAsync();
                serviceResponse.Dados = _context.Users.ToList();
                if (serviceResponse.Dados.Count == 0)
                {
                    serviceResponse.Mensagem = "Nenhum dado encontrado.";

                }
            }
            catch (Exception ex)
            {
                serviceResponse.Mensagem = ex.Message;
                serviceResponse.Sucesso = false;
            }
            return serviceResponse;
        }

        public async Task<ServiceResponse<UserModel>> GetUserbyId(int Id)
        {
            ServiceResponse<UserModel> serviceResponse = new ServiceResponse<UserModel>();

            try
            {
                UserModel User = _context.Users.FirstOrDefault(x => x.id == Id);


                if (User == null)
                {
                    serviceResponse.Mensagem = "Nenhum dado encontrado.";
                    serviceResponse.Dados = null;
                    serviceResponse.Sucesso = false;
                }
                User.senhaHash = "secreta";
                serviceResponse.Dados = User;
            }
            catch (Exception ex)
            {
                serviceResponse.Mensagem = ex.Message;
                serviceResponse.Sucesso = false;
            }
            return serviceResponse;
        }

     

        public async Task<ServiceResponse<List<UserModel>>> UpdateUser(UserModel editUser)
        {
            ServiceResponse<List<UserModel>> serviceResponse = new ServiceResponse<List<UserModel>>();
            try
            {
                UserModel User = _context.Users.AsNoTracking().FirstOrDefault(x => x.id == editUser.id);


                if (User == null)
                {
                    serviceResponse.Mensagem = "Nenhum dado encontrado.";
                    serviceResponse.Dados = null;
                    serviceResponse.Sucesso = false;
                }
                else { 
                    if (editUser.nome != null)
                    {
                        User.nome = editUser.nome;
                    }
                    if (editUser.celular != null)
                    {
                        User.celular = editUser.celular;
                    }
                    if (editUser.ativo != null)
                    {
                        User.ativo = editUser.ativo;
                    }
                    if (editUser.cpf != null)
                    {
                        User.cpf = editUser.cpf;
                    }
                    if (editUser.idPerfil != null)
                    {
                        User.idPerfil = editUser.idPerfil;
                    }
                    DateOnly dataMinima = new DateOnly(1900, 1, 1);
                    if (editUser.dtDeslig != dataMinima)
                    {
                        User.dtDeslig = editUser.dtDeslig;
                    }
                    if (editUser.dtNasc != dataMinima)
                    {
                        User.dtNasc = editUser.dtNasc;
                    }
                    if (editUser.email != null)
                    {
                        User.email = editUser.email;
                    }
                    if (editUser.endereco != null)
                    {
                        User.endereco = editUser.endereco;
                    }
                    if (editUser.rg != null)
                    {
                        User.rg = editUser.rg;
                    }
                    if (editUser.telFixo != null)
                    {
                        User.telFixo = editUser.telFixo;
                    }
                }
                _context.Users.Update(User);
                await _context.SaveChangesAsync();
                foreach (var user in serviceResponse.Dados)
                {

                    user.senhaHash = "secreta";
                }
                serviceResponse.Dados = _context.Users.ToList();
            }
            catch (Exception ex)
            {
                serviceResponse.Mensagem = ex.Message;
                serviceResponse.Sucesso = false;
            }
            return serviceResponse;
        }
        public async Task<ServiceResponse<List<UserModel>>> GetUserbyNome(string Nome)
        {
            ServiceResponse<List<UserModel>> serviceResponse = new ServiceResponse<List<UserModel>>();

            try
            {
                List<UserModel> Users = _context.Users
                    .Where(x => x.nome.ToLower().Contains(Nome.ToLower()))
                    .ToList();

                if (Users.Count == 0)
                {
                    serviceResponse.Mensagem = "Nenhum dado encontrado.";
                    serviceResponse.Dados = null;
                    serviceResponse.Sucesso = false;
                }
                else
                {
                    foreach (var user in serviceResponse.Dados)
                    {
                        user.senhaHash = "secreta";
                    }
                    serviceResponse.Dados = Users;
                    serviceResponse.Sucesso = true;
                }
            }
            catch (Exception ex)
            {
                serviceResponse.Mensagem = ex.Message;
                serviceResponse.Sucesso = false;
            }
            return serviceResponse;
        }
    }
}
