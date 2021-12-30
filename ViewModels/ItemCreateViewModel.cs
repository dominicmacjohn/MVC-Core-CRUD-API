using System.ComponentModel.DataAnnotations;

namespace MVC_Core_CRUD_API.ViewModels
{
    public class ItemCreateViewModel
    {
        [Required]
        public string Name { get; set; }
    }
}