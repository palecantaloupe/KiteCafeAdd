using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace KiteCafe
{
    public partial class FormAddMenuItem : MetroFramework.Forms.MetroForm
    {
        KiteCafeEntities context = new KiteCafeEntities();
        //List<int> ItemIDList = context.MenuItems.Select(x => x.MenuItemID).ToList();

        public FormAddMenuItem()
        {
            InitializeComponent();
        }

        //label methods for texboxes
        private void ValidLabel(Label lbl)
        {
            lbl.ForeColor = Color.Green;
            lbl.Text = "Valid";
            lbl.Show();
        }

        private void InvalidLabel(Label lblv)
        {
            lblv.ForeColor = Color.Red;
            lblv.Text = "Invalid";
            lblv.Show();
        }
        //regular expression method
        public bool Regexp(string re, TextBox tb, Label lbl)
        {
            Regex regex = new Regex(re);

            if (regex.IsMatch(tb.Text))
            {
                ValidLabel(lbl);
                return true;
            }
            else
            {
                InvalidLabel(lbl);
                return false;
            }
        }
        //length restraint for MenuItemID entry
        const int MaxLength = 5;


        //create new entry in MenuItems 
        private void btnSave_Click(object sender, EventArgs e)
        {
            MenuItem menuItem = new MenuItem();

            //exceptioncatching
            try
            {
                menuItem.MenuItemID = Convert.ToInt16(txtbxitemID.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid Menu Item ID String Format.");
                return;
            }

            //int MenuItemIDinput;

            //{
            //    if (Convert.ToInt16(txtbxitemID.Text) > 10000)
            //    {
            //        MenuItemIDinput = Convert.ToInt16(txtbxitemID.Text);
            //        if (doesMenuItemIDexist(MenuItemIDinput) == true)
            //        {
            //            MessageBox.Show("Menu Item ID already exists. Please use 'Edit Menu Item' function to update Item info.");
            //            return;
            //        }
            //        else
            //        {
            //            menuItem.MenuItemID = Convert.ToInt16(MenuItemIDinput);
            //        }

            //    }
            //    else
            //    {
            //        InvalidLabel(lblmessageID);
            //        return;
            //    }
            //}

            menuItem.MenuItemID = Convert.ToInt16(txtbxitemID.Text);
            menuItem.Name = txbxitemName.Text;
            menuItem.Price = Convert.ToDecimal(txbxPrice.Text);
            menuItem.Description = txbxDesc.Text;
            menuItem.CategoryID = Convert.ToInt16(txbxCategory.Text);



            if (string.IsNullOrEmpty(txtbxitemID.Text) ||
               (string.IsNullOrEmpty(txbxitemName.Text) ||
               (string.IsNullOrEmpty(txbxPrice.Text) ||
               (string.IsNullOrEmpty(txbxCategory.Text) ||
               (string.IsNullOrEmpty(txbxDesc.Text))))))

            {
                MessageBox.Show("Please enter all fields.");
                return;
            }

            context.MenuItems.Add(menuItem);
            context.SaveChanges();
            MessageBox.Show("New Item has been saved!");
            this.Close();
            
        }


        private void FormAddMenuItem_Load(object sender, EventArgs e)
        {
            //PopulateGrid();
            //ItemIDList = context.MenuItems.Select(x => x.MenuItemID).ToList();
 

        }

        //public void PopulateGrid()
        //{
        //    gridCategories.DataSource = context.MenuCategories.Select(x => new { x.CategoryID, x.MainCategory, x.SubCategory, x.ShelfCategory }).ToList();
        //}

        //check for existing MenuItemId
        //public bool doesMenuItemIDexist(int MenuItemId)
        //{
        //    foreach (int i in ItemIDList)
        //    {
        //        if (i == MenuItemId)
        //        {
        //            return true;
        //        }

        //    }
        //    return false;

        //}

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //clear textboxes
        private void clear()
        {
            txbxitemName.Clear();
            txbxPrice.Clear();
            txbxCategory.Clear();
            txbxPrice.Clear();
            txtbxitemID.Focus();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Clear unsaved details?", "Confirm Form Reset.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                clear();
            }
        }
    }
}
