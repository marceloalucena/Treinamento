using AutoMapper;
using MinhaPrimeiraAPI.Models;
using MinhaPrimeiraAPI.ViewModels;

namespace MinhaPrimeiraAPI
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Produto, ProdutoInserirViewModel>().ReverseMap();
        }
    }
}
