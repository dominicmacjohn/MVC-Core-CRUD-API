
using AutoMapper;
using MVC_Core_CRUD_API.Models;
using MVC_Core_CRUD_API.ViewModels;

namespace MVC_Core_CRUD_API.Mappings
{
    public class ItemsProfile: Profile
    {
        public ItemsProfile()
        {
            CreateMap<Item, ItemViewModel>();
            CreateMap<Item, ItemCreateViewModel>().ReverseMap();
        }
    }
}
