using AlisonSilvaPoeta.Interfaces.Repositories;
using AlisonSilvaPoeta.Interfaces.Services;
using AlisonSilvaPoeta.Models;
using AlisonSilvaPoeta.Services.Cryptograph;
using AlisonSilvaPoeta.Services.Services.Base;
using AlisonSilvaPoeta.ViewModels;
using AutoMapper;

namespace AlisonSilvaPoeta.Services.Services;

public class UsuarioServices : ServicesBase<UsuarioViewModel, Usuario>, IUsuarioServices
{
    private IMapper Mapper;
    private IUsuarioRepository Repository;
    private Sha512 Sha512;

    public UsuarioServices(IMapper mapper, IUsuarioRepository repository, Sha512 sha512) : base(mapper, repository)
    {
        Mapper = mapper;
        Repository = repository;
        Sha512 = sha512;
    }
    public override async Task Add(UsuarioViewModel vm)
    {
        vm.Senha = Sha512.Criptografar(vm.Senha);

        var entity = Mapper.Map<Usuario>(vm);

        await Repository.Add(entity);
    }

    public Task<UsuarioViewModel> Login(string email, string senha)
    {
        throw new NotImplementedException();
    }
}
