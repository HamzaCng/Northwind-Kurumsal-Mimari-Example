using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DTO
{
    public class CategoryDTO
    {
        public int CategoryID { get; set; }
        public string CatagoryName{ get; set; }
        public string Description { get; set; }
        public byte[] Picture { get; set; }
    }
}
