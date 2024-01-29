using AlisonSilvaIdentityUser.Interfaces.Repositories;
using AlisonSilvaIdentityUser.Interfaces.Services;
using AlisonSilvaIdentityUser.Models;
using AlisonSilvaIdentityUser.Services.Services.Base;
using AlisonSilvaIdentityUser.ViewModels;
using AutoMapper;

namespace AlisonSilvaIdentityUser.Services.Services
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

        public async Task<LivroViewModel> GetLivroByProductId(int id)
        {
            Livro livro = await Repository.GetByProductId(id);

            return Mapper.Map<LivroViewModel>(livro);
        }
    }
}
