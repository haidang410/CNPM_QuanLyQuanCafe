using DoAn_QuanLyQuanCafe.DAO;
using DoAn_QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_QuanLyQuanCafe
{
    public partial class fLogin : Form
    {
        public static string userName;
        public fLogin()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
             userName = txbUserName.Text;
            string password = txbPassword.Text;
            if (Login(userName, password))
            {
                Account loginAccount = AccountDAO.Instance.GetAccountByUserName(userName);
                fMenu menu = new fMenu(loginAccount);
                this.Hide();
                menu.Show();
               /* fTableManager f = new fTableManager(loginAccount);
                this.Hide();
                f.ShowDialog();
                this.Show();*/
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!");
            }
        }

        bool Login(string userName, string password)
        {
            return AccountDAO.Instance.Login(userName, password);
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
            Application.Exit();    
            }
        }

        bool drag = false;
        Point start_point = new Point(0, 0);

        private void movePanel_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            start_point = new Point(e.X, e.Y);
        }

        private void movePanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag == true)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - start_point.X, p.Y - start_point.Y);
            }
        }

        private void movePanel_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;

        }

        private void txbUserName_Enter(object sender, EventArgs e)
        {
            if(txbUserName.Text == "Tài Khoản")
            {
                txbUserName.Text = "";
                txbUserName.ForeColor = Color.FromArgb(227, 194, 165);
            }
        }

        private void txbUserName_Leave(object sender, EventArgs e)
        {
            if(txbUserName.Text == "") 
            {
                txbUserName.Text = "Tài Khoản";
                txbUserName.ForeColor = Color.FromArgb(204, 186, 177);
            }
        }

        private void txbPassword_Enter(object sender, EventArgs e)
        {
            if (txbPassword.Text == "Mật Khẩu")
            {
                txbPassword.Text = "";
                txbPassword.UseSystemPasswordChar = true;
                txbPassword.ForeColor = Color.FromArgb(227, 194, 165);
            }
        }

        private void txbPassword_Leave(object sender, EventArgs e)
        {
            if (txbPassword.Text == "")
            {
                txbPassword.UseSystemPasswordChar = false;
                txbPassword.Text = "Mật Khẩu";
                txbPassword.ForeColor = Color.FromArgb(204, 186, 177);
            }
        }
    }
}
