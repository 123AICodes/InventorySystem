using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewInventory
{
    public partial class Main : Form
    {
        DBConnect dbcon = new DBConnect();
        SqlConnection connection = new SqlConnection();
        SqlCommand command = new SqlCommand();
        public string title = "Point of Sales";
        bool Collapse;
        public string _pass;
        public string _Username;
        public Main()
        {
            InitializeComponent();
            connection = new SqlConnection(dbcon.myConnection());
            pnlCategory.Height = 50;
            pnlProduct.Height = 50;
            pnlCustomer.Height = 50;
            pnlSetting.Height = 50;
         
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you want close this application", title, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Hide();
                Login login = new Login();
                login.Show();
            }
        }
        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        #region CustomMethod
        public void DashColor(Button button)
        {
            pnlDashColor.Height = button.Height;
            pnlDashColor.Top = button.Top;
            pnlDashColor.Left = button.Left;
            pnlDashColor.BackColor = Color.FromArgb(27, 168, 254);
        }  
        public void CatColor(Button button)
        {
            pnlCatColor.Height = button.Height;
            pnlCatColor.Top = button.Top;
            pnlCatColor.Left = button.Left;
            pnlCatColor.BackColor = Color.FromArgb(27, 168, 254);
        } 
        public void prodColor(Button button)
        {
            pnlProdColor.Height = button.Height;
            pnlProdColor.Top = button.Top;
            pnlProdColor.Left = button.Left;
            pnlProdColor.BackColor = Color.FromArgb(27, 168, 254);
        } 
        public void cusColor(Button button)
        {
            pnlCusColor.Height = button.Height;
            pnlCusColor.Top = button.Top;
            pnlCusColor.Left = button.Left;
            pnlCusColor.BackColor = Color.FromArgb(27, 168, 254);
        } 
        public void setColor(Button button)
        {
            pnlSetColor.Height = button.Height;
            pnlSetColor.Top = button.Top;
            pnlSetColor.Left = button.Left;
            pnlSetColor.BackColor = Color.FromArgb(27, 168, 254);
        } 
        public void dashVisible()
        {
            pnlDashColor.Visible = true;
            pnlCatColor.Visible = false;
            pnlProdColor.Visible = false;
            pnlCusColor.Visible = false;
            pnlSetColor.Visible = false;
        }
        public void catVisible()
        {
            pnlDashColor.Visible = false;
            pnlProdColor.Visible = false;
            pnlCatColor.Visible = true;
            pnlCusColor.Visible = false;
            pnlSetColor.Visible = false;
        }
        public void cusVisible()
        {
            pnlDashColor.Visible = false;
            pnlProdColor.Visible = false;
            pnlCatColor.Visible = false;
            pnlCusColor.Visible = true;
            pnlSetColor.Visible = false;
        }
        public void proVisible()
        {
            pnlDashColor.Visible = false;
            pnlProdColor.Visible = true;
            pnlCatColor.Visible = false;
            pnlCusColor.Visible = false;
            pnlSetColor.Visible = false;

        }  
        public void setVisible()
        {
            pnlSetColor.Visible = true;
            pnlDashColor.Visible = false;
            pnlProdColor.Visible = false;
            pnlCatColor.Visible = false;
            pnlCusColor.Visible = false;

        }
        #endregion CustomMethod

        private void showForm(object form)
        {
            pnlMain.Controls.Clear();
            Form currentForm = form as Form;
            currentForm.TopLevel = false;
            currentForm.Dock = DockStyle.Fill;
            pnlMain.Tag = currentForm;
            pnlMain.Controls.Add(currentForm);
            currentForm.Show();
        }
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            DashColor(btnDashboard);
            dashVisible();
            lblHeader.Text = "MAIN DASHBOARD";
            showForm(new Dashboard());

        }
        private void btnMainCategory_Click(object sender, EventArgs e)
        {
            CatColor(btnMainCategory);
            catVisible();
            timerCategory.Start();
        }
        private void timerCategory_Tick(object sender, EventArgs e)
        {
            if (Collapse)
            {
                pnlCategory.Height += 10;
                if (pnlCategory.Height == pnlCategory.MaximumSize.Height) { Collapse = false; timerCategory.Stop(); }
            }
            else
            {
                pnlCategory.Height -= 10;
                if (pnlCategory.Height == pnlCategory.MinimumSize.Height) { Collapse = true; timerCategory.Stop(); }
            }
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            CatColor(btnAddCategory);
            catVisible();
            showForm(new Category());
            lblHeader.Text = "MANAGE PRODUCT CATEGORIES";
        }

        private void btnAddBrand_Click(object sender, EventArgs e)
        {
            CatColor(btnAddBrand);
            catVisible();
            showForm(new Brand());
            lblHeader.Text = "ADD NEW BRAND";
        }

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            CatColor(btnAddSupplier);
            catVisible();
            showForm(new Supplier());
            lblHeader.Text = "MANAGE SUPPLIERS";
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            timerProduct.Start();
            prodColor(btnProduct);
            proVisible();
        }

        private void timerProduct_Tick(object sender, EventArgs e)
        {
            if (Collapse)
            {
                pnlProduct.Height += 10;
                if (pnlProduct.Height == pnlProduct.MaximumSize.Height) { Collapse = false; timerProduct.Stop(); }
            }
            else
            {
                pnlProduct.Height -= 10;
                if (pnlProduct.Height == pnlProduct.MinimumSize.Height) { Collapse = true; timerProduct.Stop(); }
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            prodColor(btnAddProduct);
            proVisible();
            showForm(new Product());
            lblHeader.Text = "MANAGE PRODUCTS";
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            cusColor(btnCustomer);
            cusVisible();
            timerCustomer.Start();
        }

        private void timerCustomer_Tick(object sender, EventArgs e)
        {
            if (Collapse)
            {
                pnlCustomer.Height += 10;
                if (pnlCustomer.Height == pnlCustomer.MaximumSize.Height) { Collapse = false; timerCustomer.Stop(); }
            }
            else
            {
                pnlCustomer.Height -= 10;
                if (pnlCustomer.Height == pnlCustomer.MinimumSize.Height) { Collapse = true; timerCustomer.Stop(); }
            }
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            cusColor(btnAddCustomer);
            cusVisible();
            showForm(new Customer());
            lblHeader.Text = "ADD NEW CUSTOMER";
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            setColor(btnSetting);
            setVisible();
            timerSetting.Start();
        }
        private void timerSetting_Tick(object sender, EventArgs e)
        {
            if (Collapse)
            {
                pnlSetting.Height += 10;
                if (pnlSetting.Height == pnlSetting.MaximumSize.Height) { Collapse = false; timerSetting.Stop(); }
            }
            else
            {
                pnlSetting.Height -= 10;
                if (pnlSetting.Height == pnlSetting.MinimumSize.Height) { Collapse = true; timerSetting.Stop(); }
            }
        }
        private void btnAccount_Click(object sender, EventArgs e)
        {
            setColor(btnAccount);
            setVisible();
            showForm(new Users(this));
            lblHeader.Text = "MANAGE USER SETTINGS";
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DashColor(btnLogout);
            dashVisible();
            if (MessageBox.Show("Do you want close this application", title, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Hide();
                Login login = new Login();
                login.Show();
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            btnDashboard.PerformClick();
        }
    }
}
