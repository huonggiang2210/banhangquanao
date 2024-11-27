using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private Form curentFormChild;
        private void OpenChildForm(Form ChildForm)
        {
            if (curentFormChild != null)
            { curentFormChild.Close(); }
            curentFormChild = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle= FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            Panel.Body.Controls.Add(curentFormChild);
            panel_Body.Tag = ChildForm;
            ChildForm.BringToFornt();
            ChildForm.Show();

        }
   
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btncc_Click(object sender, EventArgs e)
        {

        }

        private void btmh_Click(object sender, EventArgs e)
        {

        }

        private void btnv_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
