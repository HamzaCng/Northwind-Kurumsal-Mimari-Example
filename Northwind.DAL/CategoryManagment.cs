using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DAL
{
    public class CategoryManagment
    {
        NorthwindDbContext _db;
        public CategoryManagment()
        {
            _db = new NorthwindDbContext();
        }
        public List<Category> GetCategories()
        {
            return _db.Categories.ToList();
        }
    }
}
