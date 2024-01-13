using AlisonSilvaPoeta.Models;
using AlisonSilvaPoeta.ViewModels;
using AutoMapper;

namespace AlisonSilvaPoeta;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Usuario, UsuarioViewModel>()
            .ReverseMap();
        CreateMap<UsuarioViewModel, Usuario>()
            .ReverseMap();

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

        CreateMap<CompraViewModel, Compra>()
            .ReverseMap();
        CreateMap<Compra, CompraViewModel>()
            .ReverseMap();

        CreateMap<ProdutoPedidoViewModel, ProdutoPedido>()
            .ReverseMap();
        CreateMap<ProdutoPedido, ProdutoPedidoViewModel>()
            .ReverseMap();
    }
}
