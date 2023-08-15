namespace RestaurantManagement
{
    partial class TableManagementForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuList = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPayment = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMovement = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAddFood = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExist = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAccountInformation = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lbDiscount = new System.Windows.Forms.Label();
            this.cntDiscount = new System.Windows.Forms.NumericUpDown();
            this.btnPayment = new System.Windows.Forms.Button();
            this.cbTargetTable = new System.Windows.Forms.ComboBox();
            this.btnMovement = new System.Windows.Forms.Button();
            this.cbFoodCategory = new System.Windows.Forms.ComboBox();
            this.cbFood = new System.Windows.Forms.ComboBox();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.updownFoodQuality = new System.Windows.Forms.NumericUpDown();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cntDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updownFoodQuality)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuList,
            this.menuAccount,
            this.menuAdmin});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1047, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuList
            // 
            this.menuList.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPayment,
            this.menuMovement,
            this.menuAddFood,
            this.menuExist});
            this.menuList.Name = "menuList";
            this.menuList.Size = new System.Drawing.Size(90, 24);
            this.menuList.Text = "Danh mục";
            // 
            // menuPayment
            // 
            this.menuPayment.Name = "menuPayment";
            this.menuPayment.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.T)));
            this.menuPayment.Size = new System.Drawing.Size(260, 26);
            this.menuPayment.Text = "Thanh toán ";
            this.menuPayment.Click += new System.EventHandler(this.menuPayment_Click);
            // 
            // menuMovement
            // 
            this.menuMovement.Name = "menuMovement";
            this.menuMovement.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
            this.menuMovement.Size = new System.Drawing.Size(260, 26);
            this.menuMovement.Text = "Chuyển bàn";
            this.menuMovement.Click += new System.EventHandler(this.menuMovement_Click);
            // 
            // menuAddFood
            // 
            this.menuAddFood.Name = "menuAddFood";
            this.menuAddFood.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.A)));
            this.menuAddFood.Size = new System.Drawing.Size(260, 26);
            this.menuAddFood.Text = "Thêm món";
            this.menuAddFood.Click += new System.EventHandler(this.menuAddFood_Click);
            // 
            // menuExist
            // 
            this.menuExist.Name = "menuExist";
            this.menuExist.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Q)));
            this.menuExist.Size = new System.Drawing.Size(260, 26);
            this.menuExist.Text = "Thoát";
            this.menuExist.Click += new System.EventHandler(this.menuExist_Click);
            // 
            // menuAccount
            // 
            this.menuAccount.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAccountInformation,
            this.menuLogout});
            this.menuAccount.Name = "menuAccount";
            this.menuAccount.Size = new System.Drawing.Size(85, 24);
            this.menuAccount.Text = "Tài khoản";
            // 
            // menuAccountInformation
            // 
            this.menuAccountInformation.Name = "menuAccountInformation";
            this.menuAccountInformation.Size = new System.Drawing.Size(220, 26);
            this.menuAccountInformation.Text = "Thông tin tài khoản";
            this.menuAccountInformation.Click += new System.EventHandler(this.menuAccountInformation_Click);
            // 
            // menuLogout
            // 
            this.menuLogout.Name = "menuLogout";
            this.menuLogout.Size = new System.Drawing.Size(220, 26);
            this.menuLogout.Text = "Đăng xuất";
            this.menuLogout.Click += new System.EventHandler(this.menuLogout_Click);
            // 
            // menuAdmin
            // 
            this.menuAdmin.Name = "menuAdmin";
            this.menuAdmin.Size = new System.Drawing.Size(67, 24);
            this.menuAdmin.Text = "Admin";
            this.menuAdmin.Click += new System.EventHandler(this.menuAdmin_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Info;
            this.panel2.Controls.Add(this.txtTotal);
            this.panel2.Controls.Add(this.lbTotal);
            this.panel2.Controls.Add(this.lbDiscount);
            this.panel2.Controls.Add(this.cntDiscount);
            this.panel2.Controls.Add(this.btnPayment);
            this.panel2.Controls.Add(this.cbTargetTable);
            this.panel2.Controls.Add(this.btnMovement);
            this.panel2.Location = new System.Drawing.Point(921, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(114, 411);
            this.panel2.TabIndex = 2;
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(3, 367);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ShortcutsEnabled = false;
            this.txtTotal.Size = new System.Drawing.Size(108, 22);
            this.txtTotal.TabIndex = 6;
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.Location = new System.Drawing.Point(17, 346);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(78, 18);
            this.lbTotal.TabIndex = 5;
            this.lbTotal.Text = "Tổng tiền";
            // 
            // lbDiscount
            // 
            this.lbDiscount.AutoSize = true;
            this.lbDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiscount.Location = new System.Drawing.Point(17, 280);
            this.lbDiscount.Name = "lbDiscount";
            this.lbDiscount.Size = new System.Drawing.Size(75, 18);
            this.lbDiscount.TabIndex = 4;
            this.lbDiscount.Text = "Giảm giá";
            // 
            // cntDiscount
            // 
            this.cntDiscount.DecimalPlaces = 2;
            this.cntDiscount.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.cntDiscount.Location = new System.Drawing.Point(4, 301);
            this.cntDiscount.Name = "cntDiscount";
            this.cntDiscount.Size = new System.Drawing.Size(107, 22);
            this.cntDiscount.TabIndex = 3;
            this.cntDiscount.ValueChanged += new System.EventHandler(this.cntDiscount_ValueChanged);
            // 
            // btnPayment
            // 
            this.btnPayment.Location = new System.Drawing.Point(3, 220);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(107, 45);
            this.btnPayment.TabIndex = 2;
            this.btnPayment.Text = "Thanh toán";
            this.btnPayment.UseVisualStyleBackColor = true;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // cbTargetTable
            // 
            this.cbTargetTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTargetTable.FormattingEnabled = true;
            this.cbTargetTable.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.cbTargetTable.Location = new System.Drawing.Point(4, 123);
            this.cbTargetTable.Name = "cbTargetTable";
            this.cbTargetTable.Size = new System.Drawing.Size(108, 24);
            this.cbTargetTable.TabIndex = 1;
            // 
            // btnMovement
            // 
            this.btnMovement.Location = new System.Drawing.Point(3, 72);
            this.btnMovement.Name = "btnMovement";
            this.btnMovement.Size = new System.Drawing.Size(108, 45);
            this.btnMovement.TabIndex = 0;
            this.btnMovement.Text = "Chuyển bàn";
            this.btnMovement.UseVisualStyleBackColor = true;
            this.btnMovement.Click += new System.EventHandler(this.btnMovement_Click);
            // 
            // cbFoodCategory
            // 
            this.cbFoodCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFoodCategory.Location = new System.Drawing.Point(432, 53);
            this.cbFoodCategory.Name = "cbFoodCategory";
            this.cbFoodCategory.Size = new System.Drawing.Size(290, 24);
            this.cbFoodCategory.TabIndex = 3;
            this.cbFoodCategory.SelectedIndexChanged += new System.EventHandler(this.cbTypeFood_SelectedIndexChanged);
            // 
            // cbFood
            // 
            this.cbFood.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFood.FormattingEnabled = true;
            this.cbFood.Location = new System.Drawing.Point(432, 94);
            this.cbFood.Name = "cbFood";
            this.cbFood.Size = new System.Drawing.Size(290, 24);
            this.cbFood.TabIndex = 4;
            // 
            // btnAddFood
            // 
            this.btnAddFood.Location = new System.Drawing.Point(728, 62);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(100, 44);
            this.btnAddFood.TabIndex = 5;
            this.btnAddFood.Text = "Thêm món";
            this.btnAddFood.UseVisualStyleBackColor = true;
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.Info;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(26, 54);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(372, 410);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // updownFoodQuality
            // 
            this.updownFoodQuality.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.updownFoodQuality.Location = new System.Drawing.Point(834, 74);
            this.updownFoodQuality.Name = "updownFoodQuality";
            this.updownFoodQuality.Size = new System.Drawing.Size(56, 22);
            this.updownFoodQuality.TabIndex = 8;
            this.updownFoodQuality.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(432, 143);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(458, 321);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Món ăn";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Giá tiền";
            this.columnHeader2.Width = 70;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Số lượng";
            this.columnHeader3.Width = 70;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành tiền";
            this.columnHeader4.Width = 90;
            // 
            // TableManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 508);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.updownFoodQuality);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnAddFood);
            this.Controls.Add(this.cbFood);
            this.Controls.Add(this.cbFoodCategory);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TableManagementForm";
            this.Text = "Table Management";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cntDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updownFoodQuality)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuList;
        private System.Windows.Forms.ToolStripMenuItem menuPayment;
        private System.Windows.Forms.ToolStripMenuItem menuMovement;
        private System.Windows.Forms.ToolStripMenuItem menuAddFood;
        private System.Windows.Forms.ToolStripMenuItem menuExist;
        private System.Windows.Forms.ToolStripMenuItem menuAccount;
        private System.Windows.Forms.ToolStripMenuItem menuAccountInformation;
        private System.Windows.Forms.ToolStripMenuItem menuLogout;
        private System.Windows.Forms.ToolStripMenuItem menuAdmin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbFoodCategory;
        private System.Windows.Forms.ComboBox cbFood;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.Button btnMovement;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label lbDiscount;
        private System.Windows.Forms.NumericUpDown cntDiscount;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.ComboBox cbTargetTable;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.NumericUpDown updownFoodQuality;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}