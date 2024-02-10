using AlisonSilvaIdentityUser.Interfaces.Repositories;
using AlisonSilvaIdentityUser.Interfaces.Services;
using AlisonSilvaIdentityUser.Models;
using AlisonSilvaIdentityUser.Services.Services.Base;
using AlisonSilvaIdentityUser.ViewModels;
using AutoMapper;

namespace AlisonSilvaIdentityUser.Services.Services
{
    public class ImagemServices : ServicesBase<ImagemViewModel, Imagens>, IImagemServices
    {
        private readonly IImagensRepository _repository;
        private readonly IMapper _mapper;
        public ImagemServices(IMapper mapper, IImagensRepository repository) : base(mapper, repository)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<ImagemViewModel>> ConsultarPorIdProduto(int id)
        {
            List<Imagens> listaImagens = await _repository.GetByProductId(id);

            return _mapper.Map<List<Imagens>, List<ImagemViewModel>>(listaImagens);
        }
    }
}
