using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EfShop
{
    public partial class FrmCategoryEdit : Form
    {
        int id = -1;
        public FrmCategoryEdit()
        {
            InitializeComponent();
        }
        public FrmCategoryEdit(Categories cat)
        {
            InitializeComponent();
            txtName.Text = cat.Name;
            txtDescription.Text = cat.Description;
            txtCatOrder.Text = cat.CatOrder.ToString();
            id = cat.Id;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Categories cat = new Categories();
            cat.Name = txtName.Text;
            cat.Description = txtDescription.Text;
            cat.CatOrder = Convert.ToInt32(txtCatOrder.Text);
            
            CategoryRepository rep = new CategoryRepository();

            if (id==-1)
            {
                rep.Add(cat);
            }

            else
            {
                cat.Id = id;
                rep.Update(cat);
            }
            Close();
        }
    }
}
