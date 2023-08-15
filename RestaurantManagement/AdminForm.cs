using RestaurantManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManagement
{
    public partial class AdminForm : Form
    {
        BindingSource bindingSource2 = new BindingSource();
        public AdminForm()
        {
            InitializeComponent();
            loadFood();
            dataGridView2.DataSource = bindingSource2;
            addBinding();
        }
        #region Method
        private void loadRevenue(DateTime startTime, DateTime endTime)
        {
            using (RestaurantManagementDBEntities db = new RestaurantManagementDBEntities())
            {
                var list = db.Bills.Where(p => p.inDate != null && p.outDate != null && DateTime.Compare(startTime, (DateTime)p.inDate) <= 0 && DateTime.Compare(endTime, (DateTime)p.outDate) >= 0)
                    .Select(p => new { tablenumber = p.RTable.tableNumber, total = p.total, inDate = p.inDate, outDate = p.outDate }).ToList();
                dataGridView1.DataSource = list;
            }
        }

        private void loadFood()
        {
            using (RestaurantManagementDBEntities db = new RestaurantManagementDBEntities())
            {
                var foodList = db.Foods.Select(p => new { categoryId = p.categoryId, price = p.price, name = p.foodname, foodId = p.foodId }).ToList();
                bindingSource2.DataSource = foodList;
            }
        }

        private void addBinding()
        {
            txtId.DataBindings.Add(new Binding("Text", dataGridView2.DataSource, "foodId", true, DataSourceUpdateMode.Never));
            txtName.DataBindings.Add(new Binding("Text", dataGridView2.DataSource, "name", true, DataSourceUpdateMode.Never));
            txtPrice.DataBindings.Add(new Binding("Text", dataGridView2.DataSource, "price", true, DataSourceUpdateMode.Never));
            
            using (RestaurantManagementDBEntities db = new RestaurantManagementDBEntities())
            {
                var categoryList = db.FoodCategories.Select(p => new { categoryId = p.categoryId}).ToList();
                cbCategory.DataSource = categoryList;
                cbCategory.DisplayMember = "categoryId";
                cbCategory.ValueMember = "categoryId";
            }
            cbCategory.DataBindings.Add(new Binding("SelectedValue", dataGridView2.DataSource, "categoryId", true, DataSourceUpdateMode.Never));
        }
        #endregion

        #region Event
        private void btnStatistics_Click(object sender, EventArgs e)
        {
            loadRevenue(dtpStartDate.Value, dtpEndDate.Value);
        }

        private void btnWatch_Click(object sender, EventArgs e)
        {
            loadFood();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (RestaurantManagementDBEntities db = new RestaurantManagementDBEntities())
            {
                string maxFoodId = db.Foods.Max(p => p.foodId);
                int temp = Convert.ToInt32(maxFoodId.Substring(1,3)) + 1;
                string newFoodId = String.Format("F" + "{0:D3}", temp);
                Food food = new Food() { foodId = newFoodId, foodname = txtName.Text, categoryId = (string)cbCategory.SelectedValue, price = Convert.ToInt32(txtPrice.Text)};
                db.Foods.Add(food);
                db.SaveChanges();
            }
        }


        #endregion

        private void btnModify_Click(object sender, EventArgs e)
        {
            using (RestaurantManagementDBEntities db = new RestaurantManagementDBEntities())
            {
                Food food = db.Foods.Where(p => p.foodId == txtId.Text && p.categoryId == (string)cbCategory.SelectedValue).SingleOrDefault();
                food.price = Convert.ToInt32(txtPrice.Text);
                food.foodname = txtName.Text;
                db.SaveChanges();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            using (RestaurantManagementDBEntities db = new RestaurantManagementDBEntities())
            {
                Food food = db.Foods.Where(p => p.foodId == txtId.Text && p.categoryId == (string)cbCategory.SelectedValue).SingleOrDefault();
                db.Foods.Remove(food);
                db.SaveChanges();
            }
        }
    }
}
