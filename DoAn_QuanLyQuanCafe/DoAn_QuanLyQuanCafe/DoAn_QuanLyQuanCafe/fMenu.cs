using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAn_QuanLyQuanCafe.DAO;
using DoAn_QuanLyQuanCafe.DTO;

namespace DoAn_QuanLyQuanCafe
{
    public partial class fMenu : Form
    {
/*        Account loginAccount = AccountDAO.Instance.GetAccountByUserName(fLogin.userName);*/
        private Account loginAccount;

        public Account LoginAccount
        {
            get => loginAccount;
            set { loginAccount = value; ChangeAccount(loginAccount.Type); }
        }
        void ChangeAccount(int type)
        {
            btnAdmin.Visible = type == 1;

            labelHello.Text += LoginAccount.DisplayName ;
        }
        public fMenu(Account acc)
        {
            InitializeComponent();
            this.LoginAccount = acc;
            FirstLook();
        }
        private Form formCon = null;
        private void FirstLook()
        {
            panelAccount.Visible = false;
            panelOrder.Visible = false;
        }
        private void OpenChildForm(Form child)
        {
            if (formCon != null)
            {
                formCon.Close();
            }
            formCon = child;
            child.TopLevel = false;
            child.FormBorderStyle = FormBorderStyle.None;
            child.Dock = DockStyle.Fill;
            panelMenu.Controls.Add(child);
            panelMenu.Tag = child;
            child.BringToFront();
            child.Show();
        }
        private void HideSubMenu()
        {
            if (panelAccount.Visible == true)
                panelAccount.Visible = false;
            if (panelOrder.Visible == true)
                panelOrder.Visible = false;
        }
        private void ShowSubMenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                HideSubMenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }
        bool drag = false;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (formCon != null)
            {
                formCon.Close();

            }
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            if (formCon != null)
            {
                formCon.Close();

            }
        }

        private void subbtnInfo_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fAccountProfile(loginAccount));
        }

        private void subbtnStay_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fTableManager(loginAccount));
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelOrder);
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelAccount);
        }
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

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fAdmin());

            fAdmin f = new fAdmin();
            f.loginAccount = LoginAccount;

        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fTotal());
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fFood());
        }

        private void subbtnHome_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fHomeManager());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            fLogin login = new fLogin();
            this.Close();
            login.Show();
        }
    }
}
