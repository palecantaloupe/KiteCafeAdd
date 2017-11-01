using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KiteCafe
{
    public partial class FormMain : MetroFramework.Forms.MetroForm
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnMenuItems_Click(object sender, EventArgs e)
        {
            FormManageMenu manageMenuForm = new FormManageMenu();
            manageMenuForm.Show();
        }
    }
}
