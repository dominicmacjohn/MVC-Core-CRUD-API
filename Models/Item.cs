using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Core_CRUD_API.Models
{
    public class Item
    {
        [Key]
        public int Id { get; set; }
        [Required] 
        public string Name { get; set; }
    }
}
