using Northwind.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Northwind.DTO;

namespace Northwind.WinUI
{
    public partial class FormProductList : Form
    {
        CategoryController _cc;
        public FormProductList()
        {
            InitializeComponent();
            _cc = new CategoryController();
        }

        private void FormProductList_Load(object sender, EventArgs e)
        {

           List<CategoryDTO> categories = _cc.GetCategories();
            cmbCategories.DisplayMember = "CategoryName";
            cmbCategories.ValueMember = "CategoryID";
            cmbCategories.DataSource = categories;   
        }
    }
}
