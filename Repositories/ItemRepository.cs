using System;
using System.Linq;
using MVC_Core_CRUD_API.Data;
using MVC_Core_CRUD_API.Models;

namespace MVC_Core_CRUD_API.Repositories
{
    public interface IItemRepository
    {
        IQueryable<Item> GetItems();
        Item GetItem(int id);
        void AddItem(Item item);
        bool SaveChanges();
    }

    public class ItemRepository : IItemRepository
    {
        private readonly AppDbContext _context;

        public ItemRepository(AppDbContext context)
        {
            _context = context;
        }

        public IQueryable<Item> GetItems()
        {
            return _context.Items.AsQueryable();
        }

        public Item GetItem(int id)
        {
            return _context.Items.FirstOrDefault(q => q.Id == id);
        }

        public void AddItem(Item item)
        {
            if (item == null)
                throw new ArgumentNullException(nameof(item));

            _context.Add(item);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}
