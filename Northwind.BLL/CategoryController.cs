using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Northwind.DAL;
using Northwind.DTO;

namespace Northwind.BLL
{
    public class CategoryController
    {
        CategoryManagment _cm;
        public CategoryController()
        {
            _cm = new CategoryManagment();
        }

        public List<CategoryDTO> GetCategories()
        {
            List<Category> categories = _cm.GetCategories();
            List<CategoryDTO> categoriesDTO = new List<CategoryDTO>();

            foreach (var item in categoriesDTO)
            {
                CategoryDTO dto = new CategoryDTO();
                dto.CategoryID = item.CategoryID;
                dto.CatagoryName = item.CatagoryName;
                dto.Description = item.Description;
                dto.Picture = item.Picture;

                categoriesDTO.Add(dto);
            }

            return categoriesDTO;
        }
        
    }
}
