
namespace DoAn_QuanLyQuanCafe
{
    partial class fMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMenu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnTotal = new System.Windows.Forms.Button();
            this.panelAccount = new System.Windows.Forms.Panel();
            this.subbtnInfo = new System.Windows.Forms.Button();
            this.btnAccount = new System.Windows.Forms.Button();
            this.btnFood = new System.Windows.Forms.Button();
            this.panelOrder = new System.Windows.Forms.Panel();
            this.subbtnHome = new System.Windows.Forms.Button();
            this.subbtnStay = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.movePanel = new System.Windows.Forms.Panel();
            this.labelHello = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelAccount.SuspendLayout();
            this.panelOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnAdmin);
            this.panel1.Controls.Add(this.btnTotal);
            this.panel1.Controls.Add(this.panelAccount);
            this.panel1.Controls.Add(this.btnAccount);
            this.panel1.Controls.Add(this.btnFood);
            this.panel1.Controls.Add(this.panelOrder);
            this.panel1.Controls.Add(this.btnOrder);
            this.panel1.Location = new System.Drawing.Point(15, 175);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(190, 480);
            this.panel1.TabIndex = 1;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Image = global::DoAn_QuanLyQuanCafe.Properties.Resources.logout;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 366);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(190, 46);
            this.btnLogout.TabIndex = 10;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.Image = global::DoAn_QuanLyQuanCafe.Properties.Resources.Admin1;
            this.btnAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdmin.Location = new System.Drawing.Point(0, 320);
            this.btnAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(190, 46);
            this.btnAdmin.TabIndex = 1;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnTotal
            // 
            this.btnTotal.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTotal.Image = global::DoAn_QuanLyQuanCafe.Properties.Resources.money2;
            this.btnTotal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTotal.Location = new System.Drawing.Point(0, 274);
            this.btnTotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(190, 46);
            this.btnTotal.TabIndex = 9;
            this.btnTotal.Text = "Total";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // panelAccount
            // 
            this.panelAccount.Controls.Add(this.subbtnInfo);
            this.panelAccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAccount.Location = new System.Drawing.Point(0, 229);
            this.panelAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelAccount.Name = "panelAccount";
            this.panelAccount.Size = new System.Drawing.Size(190, 45);
            this.panelAccount.TabIndex = 5;
            // 
            // subbtnInfo
            // 
            this.subbtnInfo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.subbtnInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.subbtnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subbtnInfo.Image = global::DoAn_QuanLyQuanCafe.Properties.Resources.personal;
            this.subbtnInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.subbtnInfo.Location = new System.Drawing.Point(0, 0);
            this.subbtnInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.subbtnInfo.Name = "subbtnInfo";
            this.subbtnInfo.Size = new System.Drawing.Size(190, 45);
            this.subbtnInfo.TabIndex = 7;
            this.subbtnInfo.Text = "Change Password";
            this.subbtnInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.subbtnInfo.UseVisualStyleBackColor = false;
            this.subbtnInfo.Click += new System.EventHandler(this.subbtnInfo_Click);
            // 
            // btnAccount
            // 
            this.btnAccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccount.Image = global::DoAn_QuanLyQuanCafe.Properties.Resources.person1;
            this.btnAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccount.Location = new System.Drawing.Point(0, 183);
            this.btnAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(190, 46);
            this.btnAccount.TabIndex = 6;
            this.btnAccount.Text = "Account";
            this.btnAccount.UseVisualStyleBackColor = true;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // btnFood
            // 
            this.btnFood.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFood.Image = global::DoAn_QuanLyQuanCafe.Properties.Resources.food1;
            this.btnFood.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFood.Location = new System.Drawing.Point(0, 137);
            this.btnFood.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFood.Name = "btnFood";
            this.btnFood.Size = new System.Drawing.Size(190, 46);
            this.btnFood.TabIndex = 5;
            this.btnFood.Text = "Food";
            this.btnFood.UseVisualStyleBackColor = true;
            this.btnFood.Click += new System.EventHandler(this.btnFood_Click);
            // 
            // panelOrder
            // 
            this.panelOrder.Controls.Add(this.subbtnHome);
            this.panelOrder.Controls.Add(this.subbtnStay);
            this.panelOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelOrder.Location = new System.Drawing.Point(0, 46);
            this.panelOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelOrder.Name = "panelOrder";
            this.panelOrder.Size = new System.Drawing.Size(190, 91);
            this.panelOrder.TabIndex = 2;
            // 
            // subbtnHome
            // 
            this.subbtnHome.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.subbtnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.subbtnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subbtnHome.Image = global::DoAn_QuanLyQuanCafe.Properties.Resources.home1;
            this.subbtnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.subbtnHome.Location = new System.Drawing.Point(0, 46);
            this.subbtnHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.subbtnHome.Name = "subbtnHome";
            this.subbtnHome.Size = new System.Drawing.Size(190, 46);
            this.subbtnHome.TabIndex = 4;
            this.subbtnHome.Text = "Home";
            this.subbtnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.subbtnHome.UseVisualStyleBackColor = false;
            this.subbtnHome.Click += new System.EventHandler(this.subbtnHome_Click);
            // 
            // subbtnStay
            // 
            this.subbtnStay.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.subbtnStay.Dock = System.Windows.Forms.DockStyle.Top;
            this.subbtnStay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subbtnStay.Image = global::DoAn_QuanLyQuanCafe.Properties.Resources.table;
            this.subbtnStay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.subbtnStay.Location = new System.Drawing.Point(0, 0);
            this.subbtnStay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.subbtnStay.Name = "subbtnStay";
            this.subbtnStay.Size = new System.Drawing.Size(190, 46);
            this.subbtnStay.TabIndex = 3;
            this.subbtnStay.Text = "Stay";
            this.subbtnStay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.subbtnStay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.subbtnStay.UseVisualStyleBackColor = false;
            this.subbtnStay.Click += new System.EventHandler(this.subbtnStay_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.Image = global::DoAn_QuanLyQuanCafe.Properties.Resources.restaurant_table;
            this.btnOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrder.Location = new System.Drawing.Point(0, 0);
            this.btnOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(190, 46);
            this.btnOrder.TabIndex = 2;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.Location = new System.Drawing.Point(227, 145);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1094, 510);
            this.panelMenu.TabIndex = 2;
            // 
            // movePanel
            // 
            this.movePanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.movePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.movePanel.Location = new System.Drawing.Point(0, 0);
            this.movePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.movePanel.Name = "movePanel";
            this.movePanel.Size = new System.Drawing.Size(1333, 23);
            this.movePanel.TabIndex = 3;
            this.movePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.movePanel_MouseDown);
            this.movePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.movePanel_MouseMove);
            this.movePanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.movePanel_MouseUp);
            // 
            // labelHello
            // 
            this.labelHello.AutoSize = true;
            this.labelHello.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHello.Location = new System.Drawing.Point(16, 145);
            this.labelHello.Name = "labelHello";
            this.labelHello.Size = new System.Drawing.Size(45, 29);
            this.labelHello.TabIndex = 4;
            this.labelHello.Text = "Hi:";
            // 
            // fMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1333, 677);
            this.Controls.Add(this.labelHello);
            this.Controls.Add(this.movePanel);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fMenu";
            this.Text = "fMenu";
            this.panel1.ResumeLayout(false);
            this.panelAccount.ResumeLayout(false);
            this.panelOrder.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel movePanel;
        private System.Windows.Forms.Panel panelOrder;
        private System.Windows.Forms.Button subbtnHome;
        private System.Windows.Forms.Button subbtnStay;
        private System.Windows.Forms.Button btnFood;
        private System.Windows.Forms.Button btnAccount;
        private System.Windows.Forms.Panel panelAccount;
        private System.Windows.Forms.Button subbtnInfo;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label labelHello;
    }
}