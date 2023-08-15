using CafeManagement;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagement
{
    public partial class TableManagementForm : Form
    {
        int g_tableButtonHeight = 63;
        int g_tableButtonWidth = 63;
        BindingSource bindingsource = new BindingSource();
        public TableManagementForm()
        {
            InitializeComponent();
            loadTable();
            loadFoodCategory();
            loadFoodInCategory(((FoodCategory)cbFoodCategory.SelectedValue).categoryId);
            // default: listview display table 1
            using (RestaurantManagementDBEntities db = new RestaurantManagementDBEntities())
            {
                listView1.Tag = db.RTables.Where(p => p.tableNumber == 1).SingleOrDefault();
            }
            loadListView();
        }

        #region My method
        private void loadTable()
        {
            flowLayoutPanel1.Controls.Clear();
            using (RestaurantManagementDBEntities db = new RestaurantManagementDBEntities())
            {
                var tables = db.RTables.Select(p => p).ToList();
                List<RTable> emptyTables = new List<RTable>();
                foreach (RTable table in tables)
                {
                    Button button = new Button() { Width = g_tableButtonWidth, Height = g_tableButtonHeight};
                    button.Text = "Bàn " + table.tableNumber + "\n " + table.status;
                    button.Tag = table;
                    switch (table.status)
                    {
                        case "Có người": button.BackColor = Color.LightPink; break;
                        default: button.BackColor = Color.Aqua; emptyTables.Add(table); break;
                    }
                    button.Click += btnTable_Clicked;
                    flowLayoutPanel1.Controls.Add(button);
                }
                cbTargetTable.DataSource = emptyTables;
                cbTargetTable.DisplayMember = "tablenumber";
            }
        }

        private void loadFoodCategory()
        {
            using (RestaurantManagementDBEntities db = new RestaurantManagementDBEntities())
            {
                var categoryList = db.FoodCategories.Select(p => p).ToList();
                cbFoodCategory.DataSource = categoryList;
                cbFoodCategory.DisplayMember = "categoryName";
            }
        }

        private void loadFoodInCategory(string categoryId)
        {
            using (RestaurantManagementDBEntities db = new RestaurantManagementDBEntities())
            {
                var foodList = db.Foods.Where(p => p.categoryId == categoryId).ToList();
                cbFood.DataSource = foodList;
                cbFood.DisplayMember = "foodname";
            }
        }

        private void loadListView()
        {
            listView1.Items.Clear();

            RTable table = listView1.Tag as RTable;
            int sum = 0;

            using (RestaurantManagementDBEntities db = new RestaurantManagementDBEntities())
            {
                // TODO: exchange data to much, should use stored procedure.
                var bill = db.Bills.Where(p => p.tableId == table.tableId && p.outDate == null).SingleOrDefault();
                if (bill != null)
                {
                    var foodList = db.BillInfoes.Where(p => p.billId == bill.billId).Select(p => new { name = p.Food.foodname, price = p.Food.price, quantity = p.quantity, total = p.Food.price * p.quantity }).ToList();

                    foreach (var item in foodList)
                    {
                        ListViewItem lsv = new ListViewItem(item.name);
                        lsv.SubItems.Add(item.price.ToString());
                        lsv.SubItems.Add(item.quantity.ToString());
                        lsv.SubItems.Add(item.total.ToString());
                        listView1.Items.Add(lsv);
                        sum += item.total;
                    }
                }
            }

            sum = (int)(sum * (1- cntDiscount.Value));
            txtTotal.Text = sum.ToString();
        }

        private void addFood(Bill bill, Food food, int foodQuantity)
        {
            using (RestaurantManagementDBEntities db = new RestaurantManagementDBEntities())
            {
                BillInfo billInfo = db.BillInfoes.Where(p => p.billId == bill.billId && p.categoryId == food.categoryId && p.foodId == food.foodId).SingleOrDefault();

                if (billInfo == null)
                {
                    billInfo = new BillInfo() { billId = bill.billId, categoryId = food.categoryId, foodId = food.foodId, quantity = foodQuantity };
                    db.BillInfoes.Add(billInfo);
                }
                else
                {
                    billInfo.quantity += foodQuantity;
                }
               
                db.SaveChanges();
            }
        }
        #endregion

        #region Event
        private void btnTable_Clicked(object sender, EventArgs e)
        {
            Button button = sender as Button;
            listView1.Tag = button.Tag;
            loadListView();
        }
        private void cbTypeFood_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadFoodInCategory(((FoodCategory)cbFoodCategory.SelectedValue).categoryId);
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            RTable table = listView1.Tag as RTable;
            using (RestaurantManagementDBEntities db = new RestaurantManagementDBEntities())
            {
                var bill = db.Bills.Where(p => p.tableId == table.tableId && p.outDate == null).SingleOrDefault();
                // bill is null
                if (bill == null)
                {
                    int maxId = 0;
                    if (db.Bills.Count() <= 0) maxId = 0;
                    else
                    {
                        maxId = Convert.ToInt32((db.Bills.Max(p => p.billId)).Substring(1, 3));
                    }

                    string billId = String.Format("B{0:D3}", maxId + 1);

                    bill = new Bill() { billId = billId, tableId = table.tableId, inDate = DateTime.Now, outDate = null, total = null };

                    db.Bills.Add(bill);
                    db.SaveChanges();
                }

                (db.RTables.Where(p => p.tableId == table.tableId).SingleOrDefault()).status = "Có người";
                db.SaveChanges();
                addFood(bill, (Food)cbFood.SelectedValue, (int)updownFoodQuality.Value);
            }

            loadTable();
            loadListView();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            RTable chosenTable = listView1.Tag as RTable;
            using (RestaurantManagementDBEntities db = new RestaurantManagementDBEntities())
            {
                Bill bill = db.Bills.Where(p => p.tableId == chosenTable.tableId && p.outDate == null).SingleOrDefault();
                if (bill != null)
                { 
                    bill.outDate = DateTime.Now;
                    bill.total = Convert.ToInt32(txtTotal.Text);
                    (db.RTables.Where(p => p.tableId == chosenTable.tableId).SingleOrDefault()).status = "Trống";
                    db.SaveChanges();
                }
            }
            loadTable();
            loadListView();
        }

        private void btnMovement_Click(object sender, EventArgs e)
        {
            RTable targetTable = cbTargetTable.SelectedValue as RTable;
            RTable currentTable = listView1.Tag as RTable;
            using (RestaurantManagementDBEntities db = new RestaurantManagementDBEntities())
            {
                Bill bill = db.Bills.Where(p => p.tableId == currentTable.tableId && p.outDate == null).SingleOrDefault();
                if (bill != null)
                {
                    (db.RTables.Where(p => p.tableId == currentTable.tableId).SingleOrDefault()).status = "Trống";
                    (db.RTables.Where(p => p.tableId == targetTable.tableId).SingleOrDefault()).status = "Có người";
                    bill.tableId = targetTable.tableId;
                    db.SaveChanges();
                }
            }

            loadTable();
            loadListView();
        }

        private void cntDiscount_ValueChanged(object sender, EventArgs e)
        {
            int sum = 0;
            foreach (ListViewItem item in listView1.Items)
            {
                sum += Convert.ToInt32(item.SubItems[3].Text);
            }
            sum = (int)(sum * (1 - cntDiscount.Value));
            txtTotal.Text = sum.ToString();
        }

        private void menuPayment_Click(object sender, EventArgs e)
        {
            btnPayment.PerformClick();
        }

        private void menuMovement_Click(object sender, EventArgs e)
        {
            btnMovement.PerformClick();
        }

        private void menuAddFood_Click(object sender, EventArgs e)
        {
            btnAddFood.PerformClick();
        }

        private void menuExist_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuAccountInformation_Click(object sender, EventArgs e)
        {
            AccountForm form = new AccountForm((Account)this.Tag);
            form.Show();
        }

        private void menuLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuAdmin_Click(object sender, EventArgs e)
        {
            AdminForm form = new AdminForm();
            form.Show();
        }
        #endregion
    }
}
