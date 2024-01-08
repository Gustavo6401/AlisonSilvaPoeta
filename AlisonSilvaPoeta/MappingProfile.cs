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

        CreateMap<LivroViewModel, Livro>()
            .ReverseMap();
        CreateMap<Livro, LivroViewModel>()
            .ReverseMap();
    }
}
