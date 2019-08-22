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
    public partial class frmStudents : BaseForm<Students>
    {
        public frmStudents()
        {
            InitializeComponent();
            rep = new StudentRepository();           
            refresh();
        }
        protected override void button1_Click(object sender, EventArgs e)
        {
            FrmStudentEdit frm = new FrmStudentEdit();
            frm.ShowDialog();
            refresh();
        }
        protected override void button2_Click(object sender, EventArgs e)
        {
            Students std = (Students)dataGridView1.SelectedRows[0].DataBoundItem;
            FrmStudentEdit frm = new FrmStudentEdit(std);
            frm.ShowDialog();
            refresh();
        }
        protected override void buttonDelete_Click(object sender, EventArgs e)
        {
            Students std = new Students();
            std = (Students)dataGridView1.SelectedRows[0].DataBoundItem;
            StudentRepository rep = new StudentRepository();
            rep.Delete(std.Id);
            refresh();
        }
    }
}
