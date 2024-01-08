using AlisonSilvaPoeta.Interfaces.Repositories;
using AlisonSilvaPoeta.Interfaces.Repositories.Base;
using AlisonSilvaPoeta.Interfaces.Services;
using AlisonSilvaPoeta.Models;
using AlisonSilvaPoeta.Services.Services.Base;
using AlisonSilvaPoeta.ViewModels;
using AutoMapper;

namespace AlisonSilvaPoeta.Services.Services
{
    public class LivroServices : ServicesBase<LivroViewModel, Livro>, ILivroServices
    {
        private IMapper Mapper { get; set; }
        private ILivroRepository Repository { get; set; }
        public LivroServices(IMapper mapper, ILivroRepository repository) : base(mapper, repository)
        {
            Mapper = mapper;
            Repository = repository;
        }
    }
}
