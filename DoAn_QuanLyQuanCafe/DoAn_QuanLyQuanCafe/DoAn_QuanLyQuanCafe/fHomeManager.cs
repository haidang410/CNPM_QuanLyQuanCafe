using DoAn_QuanLyQuanCafe.DAO;
using DoAn_QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_QuanLyQuanCafe
{
    public partial class fHomeManager : Form
    {

        public fHomeManager()
        {
            InitializeComponent();
            LoadCategory();
        }
        public void LoadFoodListByCategoryID(int id)
        {
            List<Food> listFood = FoodDAO.Instance.GetFoodByCategoryID(id);

            cbFood.DataSource = listFood;

            cbFood.DisplayMember = "name";
        }
        void ShowBill(int id)
        {
            lsvBill.Items.Clear();
            List<DoAn_QuanLyQuanCafe.DTO.Menu> listBillInfo = MenuDAO.Instance.GetListMenuByTable(id);

            float TotalPrice = 0;

            foreach (DoAn_QuanLyQuanCafe.DTO.Menu item in listBillInfo)
            {
                ListViewItem lsvItem = new ListViewItem(item.FoodName.ToString());
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvItem.SubItems.Add(item.Price.ToString());
                lsvItem.SubItems.Add(item.TotalPrice.ToString());

                TotalPrice += item.TotalPrice;

                lsvBill.Items.Add(lsvItem);
            }
            CultureInfo culture = new CultureInfo("vi-VN");
            txbTotalPrice.Text = TotalPrice.ToString("c", culture);
        }

        public void LoadCategory()
        {
            List<Category> listCategory = CategoryDAO.Instance.GetListCategory();

            cbCategory.DataSource = listCategory;

            cbCategory.DisplayMember = "name";
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;

            ComboBox combo = sender as ComboBox;

            if (combo.SelectedItem == null)
                return;

            Category selected = combo.SelectedItem as Category;

            id = selected.ID;

            LoadFoodListByCategoryID(id);
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            Table table = new Table(21,"Mua Về","Đang Đặt");
            table.ID = 21;
            int idBill = BillDAO.Instance.GetUnCheckBillIDByTableID(table.ID);

            int foodID = (cbFood.SelectedItem as Food).ID;

            int count = (int)nmCountFood.Value;

            if (idBill == -1)
            {
                BillDAO.Instance.InsertBill(table.ID);
                BillInfoDAO.Instance.InsertBillInfo(BillDAO.Instance.GetMaxIDBill(), foodID, count);
            }
            else
            {
                BillInfoDAO.Instance.InsertBillInfo(idBill, foodID, count);
            }
            ShowBill(table.ID);

        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            Table table = new Table(21, "Mua Về", "Đang Đặt");
            table.ID = 21;

            int idBill = BillDAO.Instance.GetUnCheckBillIDByTableID(table.ID);

            int discount = (int)nmDiscount.Value;

            double TotalPrice = Convert.ToDouble(txbTotalPrice.Text.Split(',')[0].Replace(".", ""));

            double finalTotalPrice = TotalPrice - (TotalPrice / 100) * discount;

            if (idBill != -1)
            {
                if (MessageBox.Show(string.Format("Bạn có chắc muốn thanh toán cho bàn {0}\nTổng tiền - (Tổng tiền / 100) x Giảm giá\n=> {1} - ({1} / 100) x {2} = {3}", table.Name, TotalPrice, discount, finalTotalPrice),
                    "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    BillDAO.Instance.CheckOut(idBill, discount, (float)finalTotalPrice);

                    ShowBill(table.ID);
                }
            }
        }
    }
}
