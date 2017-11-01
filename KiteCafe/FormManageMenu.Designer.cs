namespace KiteCafe
{
    partial class FormManageMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManageMenu));
            this.gridMenuItem = new MetroFramework.Controls.MetroGrid();
            this.tileMenuItems = new MetroFramework.Controls.MetroTile();
            this.tileAddMenuItem = new MetroFramework.Controls.MetroTile();
            this.tileDelete = new MetroFramework.Controls.MetroTile();
            this.tileSave = new MetroFramework.Controls.MetroTile();
            this.tileEdit = new MetroFramework.Controls.MetroTile();
            this.menuItemIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceManageMenu = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridMenuItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceManageMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // gridMenuItem
            // 
            this.gridMenuItem.AllowUserToAddRows = false;
            this.gridMenuItem.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Silver;
            this.gridMenuItem.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridMenuItem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridMenuItem.AutoGenerateColumns = false;
            this.gridMenuItem.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridMenuItem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridMenuItem.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridMenuItem.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridMenuItem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridMenuItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMenuItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.menuItemIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.categoryIDDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.gridMenuItem.DataSource = this.bindingSourceManageMenu;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridMenuItem.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridMenuItem.EnableHeadersVisualStyles = false;
            this.gridMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridMenuItem.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridMenuItem.Location = new System.Drawing.Point(72, 335);
            this.gridMenuItem.MultiSelect = false;
            this.gridMenuItem.Name = "gridMenuItem";
            this.gridMenuItem.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridMenuItem.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gridMenuItem.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridMenuItem.RowTemplate.Height = 28;
            this.gridMenuItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridMenuItem.Size = new System.Drawing.Size(1031, 567);
            this.gridMenuItem.Style = MetroFramework.MetroColorStyle.Black;
            this.gridMenuItem.TabIndex = 0;
            // 
            // tileMenuItems
            // 
            this.tileMenuItems.ActiveControl = null;
            this.tileMenuItems.Location = new System.Drawing.Point(72, 121);
            this.tileMenuItems.Name = "tileMenuItems";
            this.tileMenuItems.Size = new System.Drawing.Size(166, 142);
            this.tileMenuItems.Style = MetroFramework.MetroColorStyle.Black;
            this.tileMenuItems.TabIndex = 1;
            this.tileMenuItems.Text = "View All";
            this.tileMenuItems.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tileMenuItems.TileImage = ((System.Drawing.Image)(resources.GetObject("tileMenuItems.TileImage")));
            this.tileMenuItems.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileMenuItems.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileMenuItems.UseSelectable = true;
            this.tileMenuItems.UseTileImage = true;
            // 
            // tileAddMenuItem
            // 
            this.tileAddMenuItem.ActiveControl = null;
            this.tileAddMenuItem.Location = new System.Drawing.Point(283, 121);
            this.tileAddMenuItem.Name = "tileAddMenuItem";
            this.tileAddMenuItem.Size = new System.Drawing.Size(166, 142);
            this.tileAddMenuItem.Style = MetroFramework.MetroColorStyle.Black;
            this.tileAddMenuItem.TabIndex = 2;
            this.tileAddMenuItem.Text = "Add";
            this.tileAddMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tileAddMenuItem.TileImage = ((System.Drawing.Image)(resources.GetObject("tileAddMenuItem.TileImage")));
            this.tileAddMenuItem.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileAddMenuItem.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileAddMenuItem.UseSelectable = true;
            this.tileAddMenuItem.UseTileImage = true;
            this.tileAddMenuItem.Click += new System.EventHandler(this.tileAddMenuItem_Click);
            // 
            // tileDelete
            // 
            this.tileDelete.ActiveControl = null;
            this.tileDelete.Location = new System.Drawing.Point(718, 121);
            this.tileDelete.Name = "tileDelete";
            this.tileDelete.Size = new System.Drawing.Size(166, 142);
            this.tileDelete.Style = MetroFramework.MetroColorStyle.Black;
            this.tileDelete.TabIndex = 4;
            this.tileDelete.Text = "Delete";
            this.tileDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tileDelete.TileImage = ((System.Drawing.Image)(resources.GetObject("tileDelete.TileImage")));
            this.tileDelete.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileDelete.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileDelete.UseSelectable = true;
            this.tileDelete.UseTileImage = true;
            // 
            // tileSave
            // 
            this.tileSave.ActiveControl = null;
            this.tileSave.Location = new System.Drawing.Point(928, 121);
            this.tileSave.Name = "tileSave";
            this.tileSave.Size = new System.Drawing.Size(166, 142);
            this.tileSave.Style = MetroFramework.MetroColorStyle.Black;
            this.tileSave.TabIndex = 5;
            this.tileSave.Text = "Save";
            this.tileSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tileSave.TileImage = ((System.Drawing.Image)(resources.GetObject("tileSave.TileImage")));
            this.tileSave.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileSave.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileSave.UseSelectable = true;
            this.tileSave.UseTileImage = true;
            // 
            // tileEdit
            // 
            this.tileEdit.ActiveControl = null;
            this.tileEdit.Location = new System.Drawing.Point(499, 121);
            this.tileEdit.Name = "tileEdit";
            this.tileEdit.Size = new System.Drawing.Size(166, 142);
            this.tileEdit.Style = MetroFramework.MetroColorStyle.Black;
            this.tileEdit.TabIndex = 6;
            this.tileEdit.Text = "Edit";
            this.tileEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tileEdit.TileImage = ((System.Drawing.Image)(resources.GetObject("tileEdit.TileImage")));
            this.tileEdit.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileEdit.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileEdit.UseSelectable = true;
            this.tileEdit.UseTileImage = true;
            // 
            // menuItemIDDataGridViewTextBoxColumn
            // 
            this.menuItemIDDataGridViewTextBoxColumn.DataPropertyName = "MenuItemID";
            this.menuItemIDDataGridViewTextBoxColumn.HeaderText = "MenuItemID";
            this.menuItemIDDataGridViewTextBoxColumn.Name = "menuItemIDDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // categoryIDDataGridViewTextBoxColumn
            // 
            this.categoryIDDataGridViewTextBoxColumn.DataPropertyName = "CategoryID";
            this.categoryIDDataGridViewTextBoxColumn.HeaderText = "CategoryID";
            this.categoryIDDataGridViewTextBoxColumn.Name = "categoryIDDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // bindingSourceManageMenu
            // 
            this.bindingSourceManageMenu.DataSource = typeof(KiteCafe.MenuItem);
            // 
            // FormManageMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 973);
            this.Controls.Add(this.tileEdit);
            this.Controls.Add(this.tileSave);
            this.Controls.Add(this.tileDelete);
            this.Controls.Add(this.tileAddMenuItem);
            this.Controls.Add(this.tileMenuItems);
            this.Controls.Add(this.gridMenuItem);
            this.Name = "FormManageMenu";
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "Manage Menu";
            this.TransparencyKey = System.Drawing.Color.DimGray;
            this.Load += new System.EventHandler(this.FormManageMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridMenuItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceManageMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid gridMenuItem;
        private MetroFramework.Controls.MetroTile tileMenuItems;
        private MetroFramework.Controls.MetroTile tileAddMenuItem;
        private MetroFramework.Controls.MetroTile tileDelete;
        private MetroFramework.Controls.MetroTile tileSave;
        private MetroFramework.Controls.MetroTile tileEdit;
        private System.Windows.Forms.BindingSource bindingSourceManageMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn menuItemIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
    }
}