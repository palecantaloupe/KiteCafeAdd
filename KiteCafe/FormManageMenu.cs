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
    public partial class FormManageMenu : MetroFramework.Forms.MetroForm
    {
        KiteCafeEntities context = new KiteCafeEntities();
        

        public FormManageMenu()
        {
            InitializeComponent();
        }

        private void tileAddMenuItem_Click(object sender, EventArgs e)
        {
            {
                using (FormAddMenuItem AEForm = new FormAddMenuItem())
                {
                    AEForm.ShowDialog();
                }
            }
                    
        }

        private void FormManageMenu_Load(object sender, EventArgs e)
        {
            //PopulateGrid();
        }

        //public void PopulateGrid()
        //{
        //    gridMenuItem.DataSource = context.MenuItems.Select
        //    (x => new { x.MenuItemID, x.Name, x.Price, x.CategoryID, x.Description }).ToList();
        //}
    }
}