namespace KiteCafe
{
    partial class FormMain
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
            this.btnStartShift = new MetroFramework.Controls.MetroButton();
            this.btnMenuItems = new MetroFramework.Controls.MetroButton();
            this.btnPOS = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // btnStartShift
            // 
            this.btnStartShift.Location = new System.Drawing.Point(47, 159);
            this.btnStartShift.Name = "btnStartShift";
            this.btnStartShift.Size = new System.Drawing.Size(178, 103);
            this.btnStartShift.TabIndex = 0;
            this.btnStartShift.Text = "Start Shift";
            this.btnStartShift.UseSelectable = true;
            // 
            // btnMenuItems
            // 
            this.btnMenuItems.Location = new System.Drawing.Point(533, 159);
            this.btnMenuItems.Name = "btnMenuItems";
            this.btnMenuItems.Size = new System.Drawing.Size(158, 103);
            this.btnMenuItems.TabIndex = 1;
            this.btnMenuItems.Text = "Menu Management";
            this.btnMenuItems.UseSelectable = true;
            this.btnMenuItems.Click += new System.EventHandler(this.btnMenuItems_Click);
            // 
            // btnPOS
            // 
            this.btnPOS.Location = new System.Drawing.Point(301, 159);
            this.btnPOS.Name = "btnPOS";
            this.btnPOS.Size = new System.Drawing.Size(163, 103);
            this.btnPOS.TabIndex = 2;
            this.btnPOS.Text = "Orders";
            this.btnPOS.UseSelectable = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 961);
            this.Controls.Add(this.btnPOS);
            this.Controls.Add(this.btnMenuItems);
            this.Controls.Add(this.btnStartShift);
            this.Name = "FormMain";
            this.Text = "Welcome, Kiter!";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnStartShift;
        private MetroFramework.Controls.MetroButton btnMenuItems;
        private MetroFramework.Controls.MetroButton btnPOS;
    }
}

