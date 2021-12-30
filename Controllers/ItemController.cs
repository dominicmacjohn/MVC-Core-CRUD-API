using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MVC_Core_CRUD_API.Models;
using MVC_Core_CRUD_API.Repositories;
using MVC_Core_CRUD_API.ViewModels;

namespace MVC_Core_CRUD_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ItemController : ControllerBase
    {
        private readonly IItemRepository _repository;
        private readonly IMapper _mapper;

        public ItemController(IItemRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<ItemViewModel>> GetItems()
        {
            Console.WriteLine("--> Getting Items... ");
            try
            {
                var items = _repository.GetItems();

                var models = new List<ItemViewModel>();
                foreach (var item in items)
                    models.Add(_mapper.Map<ItemViewModel>(item));

                return Ok(models);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [HttpGet("{id}")]
        public ActionResult<IEnumerable<ItemViewModel>> GetItem(int id)
        {
            Console.WriteLine("--> Getting Item with id: {0} ... ", id);

            try
            {
                var item = _repository.GetItem(id);
                var model = _mapper.Map<ItemViewModel>(item);

                return Ok(model);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [HttpPost]
        public ActionResult AddItem(ItemCreateViewModel createItem)
        {
            Console.WriteLine("--> Adding Item... ");

            try
            {
                var item = _mapper.Map<Item>(createItem);
                _repository.AddItem(item);

                return _repository.SaveChanges() 
                    ? Ok() 
                    : StatusCode(500);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}