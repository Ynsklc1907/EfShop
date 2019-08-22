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
    public partial class FrmStudentEdit : Form
    {
        int id = -1;
        public FrmStudentEdit()
        {
            InitializeComponent();
        }
        public FrmStudentEdit(Students std)
        {
            InitializeComponent();
            id = std.Id;
            txtName.Text = std.Name;
            txtSurname.Text = std.SurName;
            txtAge.Text = std.Age.ToString();
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            Students std = new Students();
            std.Name = txtName.Text;
            std.SurName = txtSurname.Text;
            std.Age = Convert.ToInt32(txtAge.Text);

            StudentRepository rep = new StudentRepository();

            if (id==-1)
            {
                rep.Add(std);
            }
            else
            {
                std.Id = id;
                rep.Update(std);
            }
            Close();
        }
    }
}
