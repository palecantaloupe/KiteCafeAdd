namespace KiteCafe
{
    partial class FormAddMenuItem
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddMenuItem));
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.btnUpload = new MetroFramework.Controls.MetroButton();
            this.gridCategories = new MetroFramework.Controls.MetroGrid();
            this.categoryIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainCategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subCategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shelfCategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceMenuCategory = new System.Windows.Forms.BindingSource(this.components);
            this.txbxCategory = new MetroFramework.Controls.MetroTextBox();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.txbxPrice = new MetroFramework.Controls.MetroTextBox();
            this.lblCategory = new MetroFramework.Controls.MetroLabel();
            this.lblDesc = new MetroFramework.Controls.MetroLabel();
            this.lblPrice = new MetroFramework.Controls.MetroLabel();
            this.txbxitemName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtbxitemID = new MetroFramework.Controls.MetroTextBox();
            this.lblitemID = new MetroFramework.Controls.MetroLabel();
            this.txbxDesc = new MetroFramework.Controls.MetroTextBox();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.lblmessageID = new MetroFramework.Controls.MetroLabel();
            this.btnReset = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceMenuCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnCancel.Location = new System.Drawing.Point(815, 1041);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(148, 75);
            this.btnCancel.TabIndex = 38;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseSelectable = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(696, 567);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(116, 30);
            this.btnUpload.TabIndex = 37;
            this.btnUpload.Text = "Upload Photo";
            this.btnUpload.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpload.UseSelectable = true;
            // 
            // gridCategories
            // 
            this.gridCategories.AllowUserToAddRows = false;
            this.gridCategories.AllowUserToDeleteRows = false;
            this.gridCategories.AllowUserToResizeRows = false;
            this.gridCategories.AutoGenerateColumns = false;
            this.gridCategories.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridCategories.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridCategories.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridCategories.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridCategories.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.gridCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCategories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.categoryIDDataGridViewTextBoxColumn,
            this.mainCategoryDataGridViewTextBoxColumn,
            this.subCategoryDataGridViewTextBoxColumn,
            this.shelfCategoryDataGridViewTextBoxColumn});
            this.gridCategories.DataSource = this.bindingSourceMenuCategory;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridCategories.DefaultCellStyle = dataGridViewCellStyle14;
            this.gridCategories.EnableHeadersVisualStyles = false;
            this.gridCategories.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridCategories.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridCategories.Location = new System.Drawing.Point(46, 567);
            this.gridCategories.Name = "gridCategories";
            this.gridCategories.ReadOnly = true;
            this.gridCategories.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridCategories.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.gridCategories.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.DarkGray;
            this.gridCategories.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.gridCategories.RowTemplate.Height = 28;
            this.gridCategories.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridCategories.Size = new System.Drawing.Size(579, 276);
            this.gridCategories.Style = MetroFramework.MetroColorStyle.Black;
            this.gridCategories.TabIndex = 36;
            // 
            // categoryIDDataGridViewTextBoxColumn
            // 
            this.categoryIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.categoryIDDataGridViewTextBoxColumn.DataPropertyName = "CategoryID";
            this.categoryIDDataGridViewTextBoxColumn.HeaderText = "Category ID";
            this.categoryIDDataGridViewTextBoxColumn.Name = "categoryIDDataGridViewTextBoxColumn";
            this.categoryIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.categoryIDDataGridViewTextBoxColumn.Width = 94;
            // 
            // mainCategoryDataGridViewTextBoxColumn
            // 
            this.mainCategoryDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.mainCategoryDataGridViewTextBoxColumn.DataPropertyName = "MainCategory";
            this.mainCategoryDataGridViewTextBoxColumn.HeaderText = "Main Category";
            this.mainCategoryDataGridViewTextBoxColumn.Name = "mainCategoryDataGridViewTextBoxColumn";
            this.mainCategoryDataGridViewTextBoxColumn.ReadOnly = true;
            this.mainCategoryDataGridViewTextBoxColumn.Width = 107;
            // 
            // subCategoryDataGridViewTextBoxColumn
            // 
            this.subCategoryDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.subCategoryDataGridViewTextBoxColumn.DataPropertyName = "SubCategory";
            this.subCategoryDataGridViewTextBoxColumn.HeaderText = "Sub Category";
            this.subCategoryDataGridViewTextBoxColumn.Name = "subCategoryDataGridViewTextBoxColumn";
            this.subCategoryDataGridViewTextBoxColumn.ReadOnly = true;
            this.subCategoryDataGridViewTextBoxColumn.Width = 102;
            // 
            // shelfCategoryDataGridViewTextBoxColumn
            // 
            this.shelfCategoryDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.shelfCategoryDataGridViewTextBoxColumn.DataPropertyName = "ShelfCategory";
            this.shelfCategoryDataGridViewTextBoxColumn.HeaderText = "Shelf Category";
            this.shelfCategoryDataGridViewTextBoxColumn.Name = "shelfCategoryDataGridViewTextBoxColumn";
            this.shelfCategoryDataGridViewTextBoxColumn.ReadOnly = true;
            this.shelfCategoryDataGridViewTextBoxColumn.Width = 107;
            // 
            // bindingSourceMenuCategory
            // 
            this.bindingSourceMenuCategory.DataSource = typeof(KiteCafe.MenuCategory);
            // 
            // txbxCategory
            // 
            // 
            // 
            // 
            this.txbxCategory.CustomButton.Image = null;
            this.txbxCategory.CustomButton.Location = new System.Drawing.Point(278, 2);
            this.txbxCategory.CustomButton.Name = "";
            this.txbxCategory.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txbxCategory.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txbxCategory.CustomButton.TabIndex = 1;
            this.txbxCategory.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbxCategory.CustomButton.UseSelectable = true;
            this.txbxCategory.CustomButton.Visible = false;
            this.txbxCategory.Lines = new string[0];
            this.txbxCategory.Location = new System.Drawing.Point(249, 454);
            this.txbxCategory.MaxLength = 32767;
            this.txbxCategory.Name = "txbxCategory";
            this.txbxCategory.PasswordChar = '\0';
            this.txbxCategory.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbxCategory.SelectedText = "";
            this.txbxCategory.SelectionLength = 0;
            this.txbxCategory.SelectionStart = 0;
            this.txbxCategory.ShortcutsEnabled = true;
            this.txbxCategory.Size = new System.Drawing.Size(306, 30);
            this.txbxCategory.TabIndex = 33;
            this.txbxCategory.UseSelectable = true;
            this.txbxCategory.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txbxCategory.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnSave
            // 
            this.btnSave.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnSave.Location = new System.Drawing.Point(579, 1041);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(142, 75);
            this.btnSave.TabIndex = 32;
            this.btnSave.Text = "Save";
            this.btnSave.UseSelectable = true;
            // 
            // txbxPrice
            // 
            // 
            // 
            // 
            this.txbxPrice.CustomButton.Image = null;
            this.txbxPrice.CustomButton.Location = new System.Drawing.Point(278, 2);
            this.txbxPrice.CustomButton.Name = "";
            this.txbxPrice.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txbxPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txbxPrice.CustomButton.TabIndex = 1;
            this.txbxPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbxPrice.CustomButton.UseSelectable = true;
            this.txbxPrice.CustomButton.Visible = false;
            this.txbxPrice.Lines = new string[0];
            this.txbxPrice.Location = new System.Drawing.Point(912, 161);
            this.txbxPrice.MaxLength = 32767;
            this.txbxPrice.Name = "txbxPrice";
            this.txbxPrice.PasswordChar = '\0';
            this.txbxPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbxPrice.SelectedText = "";
            this.txbxPrice.SelectionLength = 0;
            this.txbxPrice.SelectionStart = 0;
            this.txbxPrice.ShortcutsEnabled = true;
            this.txbxPrice.Size = new System.Drawing.Size(306, 30);
            this.txbxPrice.TabIndex = 30;
            this.txbxPrice.UseSelectable = true;
            this.txbxPrice.WaterMarkColor = System.Drawing.Color.Silver;
            this.txbxPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblCategory.Location = new System.Drawing.Point(48, 465);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(94, 19);
            this.lblCategory.TabIndex = 29;
            this.lblCategory.Text = "Category ID:";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblDesc.Location = new System.Drawing.Point(696, 304);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(89, 19);
            this.lblDesc.TabIndex = 28;
            this.lblDesc.Text = "Description:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblPrice.Location = new System.Drawing.Point(696, 172);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(47, 19);
            this.lblPrice.TabIndex = 27;
            this.lblPrice.Text = "Price:";
            // 
            // txbxitemName
            // 
            // 
            // 
            // 
            this.txbxitemName.CustomButton.Image = null;
            this.txbxitemName.CustomButton.Location = new System.Drawing.Point(278, 2);
            this.txbxitemName.CustomButton.Name = "";
            this.txbxitemName.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txbxitemName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txbxitemName.CustomButton.TabIndex = 1;
            this.txbxitemName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbxitemName.CustomButton.UseSelectable = true;
            this.txbxitemName.CustomButton.Visible = false;
            this.txbxitemName.Lines = new string[0];
            this.txbxitemName.Location = new System.Drawing.Point(249, 304);
            this.txbxitemName.MaxLength = 32767;
            this.txbxitemName.Name = "txbxitemName";
            this.txbxitemName.PasswordChar = '\0';
            this.txbxitemName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbxitemName.SelectedText = "";
            this.txbxitemName.SelectionLength = 0;
            this.txbxitemName.SelectionStart = 0;
            this.txbxitemName.ShortcutsEnabled = true;
            this.txbxitemName.Size = new System.Drawing.Size(306, 30);
            this.txbxitemName.TabIndex = 26;
            this.txbxitemName.UseSelectable = true;
            this.txbxitemName.WaterMarkColor = System.Drawing.Color.Silver;
            this.txbxitemName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(46, 304);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(87, 19);
            this.metroLabel1.TabIndex = 25;
            this.metroLabel1.Text = "Item Name:";
            // 
            // txtbxitemID
            // 
            // 
            // 
            // 
            this.txtbxitemID.CustomButton.Image = null;
            this.txtbxitemID.CustomButton.Location = new System.Drawing.Point(278, 2);
            this.txtbxitemID.CustomButton.Name = "";
            this.txtbxitemID.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtbxitemID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtbxitemID.CustomButton.TabIndex = 1;
            this.txtbxitemID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtbxitemID.CustomButton.UseSelectable = true;
            this.txtbxitemID.CustomButton.Visible = false;
            this.txtbxitemID.Lines = new string[0];
            this.txtbxitemID.Location = new System.Drawing.Point(249, 161);
            this.txtbxitemID.MaxLength = 32767;
            this.txtbxitemID.Name = "txtbxitemID";
            this.txtbxitemID.PasswordChar = '\0';
            this.txtbxitemID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtbxitemID.SelectedText = "";
            this.txtbxitemID.SelectionLength = 0;
            this.txtbxitemID.SelectionStart = 0;
            this.txtbxitemID.ShortcutsEnabled = true;
            this.txtbxitemID.Size = new System.Drawing.Size(306, 30);
            this.txtbxitemID.TabIndex = 24;
            this.txtbxitemID.UseSelectable = true;
            this.txtbxitemID.WaterMarkColor = System.Drawing.Color.Silver;
            this.txtbxitemID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblitemID
            // 
            this.lblitemID.AutoSize = true;
            this.lblitemID.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblitemID.Location = new System.Drawing.Point(48, 172);
            this.lblitemID.Name = "lblitemID";
            this.lblitemID.Size = new System.Drawing.Size(61, 19);
            this.lblitemID.TabIndex = 23;
            this.lblitemID.Text = "Item ID:";
            // 
            // txbxDesc
            // 
            // 
            // 
            // 
            this.txbxDesc.CustomButton.Image = null;
            this.txbxDesc.CustomButton.Location = new System.Drawing.Point(128, 2);
            this.txbxDesc.CustomButton.Name = "";
            this.txbxDesc.CustomButton.Size = new System.Drawing.Size(175, 175);
            this.txbxDesc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txbxDesc.CustomButton.TabIndex = 1;
            this.txbxDesc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbxDesc.CustomButton.UseSelectable = true;
            this.txbxDesc.CustomButton.Visible = false;
            this.txbxDesc.Lines = new string[] {
        "Write Description Here."};
            this.txbxDesc.Location = new System.Drawing.Point(912, 304);
            this.txbxDesc.MaxLength = 32767;
            this.txbxDesc.Name = "txbxDesc";
            this.txbxDesc.PasswordChar = '\0';
            this.txbxDesc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbxDesc.SelectedText = "";
            this.txbxDesc.SelectionLength = 0;
            this.txbxDesc.SelectionStart = 0;
            this.txbxDesc.ShortcutsEnabled = true;
            this.txbxDesc.Size = new System.Drawing.Size(306, 180);
            this.txbxDesc.TabIndex = 39;
            this.txbxDesc.Text = "Write Description Here.";
            this.txbxDesc.UseSelectable = true;
            this.txbxDesc.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txbxDesc.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(912, 567);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(306, 276);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Black;
            this.metroTile1.TabIndex = 40;
            this.metroTile1.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile1.TileImage")));
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.UseTileImage = true;
            // 
            // lblmessageID
            // 
            this.lblmessageID.AutoSize = true;
            this.lblmessageID.Location = new System.Drawing.Point(249, 209);
            this.lblmessageID.Name = "lblmessageID";
            this.lblmessageID.Size = new System.Drawing.Size(75, 19);
            this.lblmessageID.TabIndex = 41;
            this.lblmessageID.Text = "invalidinput";
            this.lblmessageID.Visible = false;
            // 
            // btnReset
            // 
            this.btnReset.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnReset.Location = new System.Drawing.Point(337, 1041);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(142, 75);
            this.btnReset.TabIndex = 42;
            this.btnReset.Text = "Reset";
            this.btnReset.UseSelectable = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // FormAddMenuItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1300, 1300);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblmessageID);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.txbxDesc);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.gridCategories);
            this.Controls.Add(this.txbxCategory);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txbxPrice);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txbxitemName);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtbxitemID);
            this.Controls.Add(this.lblitemID);
            this.MaximumSize = new System.Drawing.Size(1300, 1300);
            this.MinimizeBox = false;
            this.Name = "FormAddMenuItem";
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "Menu Item Details";
            this.Load += new System.EventHandler(this.FormAddMenuItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridCategories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceMenuCategory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnCancel;
        private MetroFramework.Controls.MetroButton btnUpload;
        private MetroFramework.Controls.MetroGrid gridCategories;
        private MetroFramework.Controls.MetroTextBox txbxCategory;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroTextBox txbxPrice;
        private MetroFramework.Controls.MetroLabel lblCategory;
        private MetroFramework.Controls.MetroLabel lblDesc;
        private MetroFramework.Controls.MetroLabel lblPrice;
        private MetroFramework.Controls.MetroTextBox txbxitemName;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtbxitemID;
        private MetroFramework.Controls.MetroLabel lblitemID;
        private MetroFramework.Controls.MetroTextBox txbxDesc;
        private System.Windows.Forms.BindingSource bindingSourceMenuCategory;
        private MetroFramework.Controls.MetroTile metroTile1;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mainCategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subCategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shelfCategoryDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroLabel lblmessageID;
        private MetroFramework.Controls.MetroButton btnReset;
    }
}