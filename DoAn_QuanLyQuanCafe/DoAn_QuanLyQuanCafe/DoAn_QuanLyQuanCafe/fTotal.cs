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
using DoAn_QuanLyQuanCafe.DAO;
using DoAn_QuanLyQuanCafe.DTO;

namespace DoAn_QuanLyQuanCafe
{
    public partial class fTotal : Form
    {
        CultureInfo ct = new CultureInfo("vi-VN");
        public fTotal()
        {
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            LoadDateTimePickerBill();
            LoadListBillByDate(dtpFromDate.Value, dtpToDate.Value);
            txbTong.Text = TongTheoNgay().ToString("c", ct);
        }

        void LoadListBillByDate(DateTime checkIn, DateTime checkOut)
        {
            dtgvBill.DataSource = BillDAO.Instance.GetListBillByDate(checkIn, checkOut);
        }
        private float Tong()
        {
            float sum = 0;
            try
            {
                for (int i = 0; i < dtgvBill.Rows.Count; i++)
                {
                    sum += float.Parse(dtgvBill.Rows[i].Cells[2].Value.ToString());
                }
            }
            catch
            {

            }
            return sum;
        }

        private float TongTheoNgay()
        {
            float sum = 0;
            try
            {
                for (int i = 0; i < dtgvBill.Rows.Count; i++)
                {
                    sum += float.Parse(dtgvBill.Rows[i].Cells[1].Value.ToString());
                }
            }
            catch
            {

            }
            return sum;
        }
        private void btnNextBillPage_Click(object sender, EventArgs e)
        {
            int page = Convert.ToInt32(txbPage.Text);

            int sumRecord = BillDAO.Instance.GetNumBillByDate(dtpFromDate.Value, dtpToDate.Value);

            if (page < sumRecord)
                page++;
            txbPage.Text = page.ToString();
            txbTong.Text = Tong().ToString("c", ct);
        }

        private void btnPreviousBillPage_Click(object sender, EventArgs e)
        {
            try {
                int page = Convert.ToInt32(txbPage.Text);

                if (page > 1)
                    page--;

                txbPage.Text = page.ToString();
                txbTong.Text = Tong().ToString("c", ct);
            }
            catch { }
        }

        private void btnFirstBillPage_Click(object sender, EventArgs e)
        {
            try
            {
                txbPage.Text = "1";
                txbTong.Text = Tong().ToString("c", ct);
            }
            catch { }
        }

        private void btnLastBillPage_Click(object sender, EventArgs e)
        {
            int sumRecord = BillDAO.Instance.GetNumBillByDate(dtpFromDate.Value, dtpToDate.Value);
            int lastPage = sumRecord / 10;
            if (sumRecord % 10 != 10)
                lastPage++;

            txbPage.Text = lastPage.ToString();
            txbTong.Text = Tong().ToString("c", ct);
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            LoadListBillByDate(dtpFromDate.Value, dtpToDate.Value);

            txbTong.Text = TongTheoNgay().ToString("c", ct);
        }
        void LoadDateTimePickerBill()
        {
            DateTime today = DateTime.Now;

            dtpFromDate.Value = new DateTime(today.Year, today.Month, 1);

            dtpToDate.Value = dtpFromDate.Value.AddMonths(1).AddDays(-1);
        }

        private void txbPage_TextChanged(object sender, EventArgs e)
        {
            dtgvBill.DataSource = BillDAO.Instance.GetListBillByDateAndPage(dtpFromDate.Value, dtpToDate.Value, Convert.ToInt32(txbPage.Text));
        }

        private void fTotal_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DoanhThuDataSet.USP_GetReport' table. You can move, or remove it, as needed.
            this.USP_GetReportTableAdapter.Fill(this.DoanhThuDataSet.USP_GetReport, dtpFromDate.Value, dtpToDate.Value);
            this.reportViewer1.RefreshReport();
        }
    }
}
