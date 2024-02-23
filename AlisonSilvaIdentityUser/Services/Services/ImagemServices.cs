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
        private readonly IMapper _mapper;
        private readonly IImagensRepository _repository;
        public ImagemServices(IMapper mapper, IImagensRepository repository) : base(mapper, repository)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public Task<ImagemViewModel> ConsultarPorIdProduto(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ImagemViewModel> GetImagemPadrao(int id)
        {
            Imagens imagens = await _repository.GetImagemPadrao(id);

            return _mapper.Map<Imagens, ImagemViewModel>(imagens);
        }
    }
}
