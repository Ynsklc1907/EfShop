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
    public partial class FrmCategory : BaseForm<Categories>
    {
        public FrmCategory()
        {
            InitializeComponent();
            rep = new CategoryRepository();
            refresh();
        }
        protected override void button1_Click(object sender, EventArgs e)
        {
            FrmCategoryEdit frm = new FrmCategoryEdit();
            frm.ShowDialog();
            refresh();
        }

        protected override void button2_Click(object sender, EventArgs e)
        {
            Categories cat = (Categories)dataGridView1.SelectedRows[0].DataBoundItem;

            FrmCategoryEdit frm = new FrmCategoryEdit(cat);
            frm.ShowDialog();
            refresh();
        }

        protected override void buttonDelete_Click(object sender, EventArgs e)
        {
            Categories cat = new Categories();
            cat = (Categories)dataGridView1.SelectedRows[0].DataBoundItem;
            CategoryRepository rep = new CategoryRepository();
            rep.Delete(cat.Id);
            refresh();
        }
    }
}
