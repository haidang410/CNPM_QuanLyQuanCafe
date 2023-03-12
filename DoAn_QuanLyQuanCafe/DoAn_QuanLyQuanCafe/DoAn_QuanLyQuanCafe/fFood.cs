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
    public partial class fFood : Form
    {
        BindingSource foodList = new BindingSource();
        public fFood()
        {
            InitializeComponent();
            Load();
        }
        public void Load()
        {
            LoadListFood();
            dtgvFood.DataSource = foodList;
            LoadCategoryIntoCombobox(cbFoodCategory);
            
        }

        void LoadCategoryIntoCombobox(ComboBox cb)
        {
            cb.DataSource = CategoryDAO.Instance.GetListCategory();
            cb.DisplayMember = "Name";
            cb.ValueMember = "id";
        }
        List<Food> SearchByCategory(int name)
        {
            List<Food> Ca = FoodDAO.Instance.SearchFoodByCategory(name);
            return Ca;
        }
        void LoadListFood()
        {
            foodList.DataSource = FoodDAO.Instance.GetListFood();
        }

        List<Food> SearchFoodByName(string name)
        {
            List<Food> listFood = FoodDAO.Instance.SearchFoodByName(name);

            return listFood;
        }

        private void btnSearchFood_Click_1(object sender, EventArgs e)
        {
            if(txbSearchFoodName.Text == "")
                foodList.DataSource = SearchByCategory(int.Parse(cbFoodCategory.SelectedValue.ToString()));
            else
                foodList.DataSource = SearchFoodByName(txbSearchFoodName.Text);
        }

    }
}
