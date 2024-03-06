using AlisonSilvaIdentityUser.Interfaces.Repositories;
using AlisonSilvaIdentityUser.Interfaces.Services;
using AlisonSilvaIdentityUser.Models;
using AlisonSilvaIdentityUser.Services.Services.Base;
using AlisonSilvaIdentityUser.ViewModels;
using AutoMapper;

namespace AlisonSilvaIdentityUser.Services.Services;

public class DepoimentoServices : ServicesBase<DepoimentosViewModel, Depoimentos>, IDepoimentoServices
{
    private readonly IMapper _mapper;
    private readonly IDepoimentoRepository _repository;

    public DepoimentoServices(IMapper mapper, IDepoimentoRepository repository) : base(mapper, repository)
    {
        _mapper = mapper;
        _repository = repository;
    }
}
