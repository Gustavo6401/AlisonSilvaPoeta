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
        public ImagemServices(IMapper mapper, IImagensRepository repository) : base(mapper, repository)
        {
        }

        public Task<ImagemViewModel> ConsultarPorIdProduto(int id)
        {
            throw new NotImplementedException();
        }
    }
}
