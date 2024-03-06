using AlisonSilvaIdentityUser.Components;
using AlisonSilvaIdentityUser.Models;
using AlisonSilvaIdentityUser.ViewModels;
using AutoMapper;

namespace AlisonSilvaIdentityUser
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ProdutoViewModel, Produto>()
            .ReverseMap();
            CreateMap<Produto, ProdutoViewModel>()
                .ReverseMap();

            CreateMap<ClienteViewModel, Cliente>()
                .ReverseMap();
            CreateMap<Cliente, ClienteViewModel>()
                .ReverseMap();

            CreateMap<LivroViewModel, Livro>()
                .ReverseMap();
            CreateMap<Livro, LivroViewModel>()
                .ReverseMap();

            CreateMap<EnderecoViewModel, Endereco>()
                .ReverseMap();
            CreateMap<Endereco, EnderecoViewModel>()
                .ReverseMap();

            CreateMap<ImagemViewModel, Imagens>()
                .ReverseMap();
            CreateMap<Imagens, ImagemViewModel>()
                .ReverseMap();

            CreateMap<CompraViewModel, Compra>()
                .ReverseMap();
            CreateMap<Compra, CompraViewModel>()
                .ReverseMap();

            CreateMap<ProdutoPedidoViewModel, ProdutoPedido>()
                .ReverseMap();
            CreateMap<ProdutoPedido, ProdutoPedidoViewModel>()
                .ReverseMap();

            CreateMap<DepoimentosViewModel, Models.Depoimentos>()
                .ReverseMap();
            CreateMap<Models.Depoimentos, DepoimentosViewModel>()
                .ReverseMap();
        }
    }
}
