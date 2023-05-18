using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewInventory
{
    public partial class Cashier : Form
    {
        string title = "Point Of Sales";
        bool Collapse;
        public string _pass;
        public string _Username;
        public Cashier()
        {
            InitializeComponent();
            pnlPayment.Height = 50;
            pnlOperation.Height = 50;
            timerTime.Start();
            getTransactionNo();
            getCartTotal();
            lblDate.Text = DateTime.Now.ToShortDateString();
        }
        private void timerTime_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }
        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        #region Custom Methods
        public void DashColor(Button button)
        {
            pnlDashColor.Height = button.Height;
            pnlDashColor.Top = button.Top;
            pnlDashColor.Left = button.Left;
            pnlDashColor.BackColor = Color.FromArgb(27, 168, 254);

        }
        public void searchColor(Button button)
        {
            pnlSearchColor.Height = button.Height;
            pnlSearchColor.Top = button.Top;
            pnlSearchColor.Left = button.Left;
            pnlSearchColor.BackColor = Color.FromArgb(27, 168, 254);

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
        public void dashVisible()
        {
            pnlDashColor.Visible = true;
            pnlSearchColor.Visible = false;
            pnlProdColor.Visible = false;
            pnlCatColor.Visible = false;

        }
        public void catVisible()
        {
            pnlCatColor.Visible = true;
            pnlDashColor.Visible = false;
            pnlSearchColor.Visible = false;
            pnlProdColor.Visible = false;
        } 
        public void shVisible()
        {
            pnlDashColor.Visible = false;
            pnlSearchColor.Visible = true;
            pnlProdColor.Visible = false;
            pnlCatColor.Visible = false;
        }
        public void prodVisible()
        {
            pnlDashColor.Visible = false;
            pnlSearchColor.Visible = false;
            pnlProdColor.Visible = true;
            pnlCatColor.Visible = false;
        }
        #endregion Custom Methods
        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want close this application", title, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Hide();
                Login login = new Login();
                login.Show();
            }
        }

        private void timerPayment_Tick(object sender, EventArgs e)
        {
            if (Collapse)
            {
                pnlPayment.Height += 10;
                if (pnlPayment.Height == pnlPayment.MaximumSize.Height) { Collapse = false; timerPayment.Stop(); }
            }
            else
            {
                pnlPayment.Height -= 10;
                if (pnlPayment.Height == pnlPayment.MinimumSize.Height) { Collapse = true; timerPayment.Stop(); }
            }
        }
        /*method to get transaction number*/
        public void getTransactionNo()
        {
           lblTransNo.Text = DateTime.Now.ToString("ddMMyy") + 100110;
        }
        private void btnTransaction_Click(object sender, EventArgs e)
        {
            DashColor(btnTransaction);
            dashVisible();
            getTransactionNo();
            lblHeader.Text = "Pending Transactions | " + lblName.Text;
        }
        /*CART-TOTAL NUMBER*/
        public void getCartTotal()
        {
            double discount = double.Parse(lblDiscount.Text);
            double sales = double.Parse(lblTotalSales.Text) + discount;
            double vat = sales * 0.12;
            double vatable = sales - vat;

            lblVat.Text = vat.ToString("#,##0.00");
            lblVatable.Text = vatable.ToString("#,##0.00");
            lblSubTotal.Text = sales.ToString("#,##0.00");
        }

        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            searchColor(btnSearchProduct);
            shVisible();
            lblHeader.Text = "Search Products | " + lblName.Text;
            SearchProduct searchProduct = new SearchProduct();
            searchProduct.Show();
        }
        private void btnPayment_Click(object sender, EventArgs e)
        {
            timerPayment.Start();
            catVisible();
            CatColor(btnPayment);
        }
        private void btnAddDiscouct_Click(object sender, EventArgs e)
        {
            catVisible();
            CatColor(btnAddDiscount);
        }

        private void btnSettlePayment_Click(object sender, EventArgs e)
        {
            catVisible();
            CatColor(btnSettlePayment);
        }
        private void timerOperation_Tick(object sender, EventArgs e)
        {
            if (Collapse)
            {
                pnlOperation.Height += 10;
                if (pnlOperation.Height == pnlOperation.MaximumSize.Height) { Collapse = false; timerOperation.Stop(); }
            }
            else
            {
                pnlOperation.Height -= 10;
                if (pnlOperation.Height == pnlOperation.MinimumSize.Height) { Collapse = true; timerOperation.Stop(); }
            }
        }
        private void btnOtherOperations_Click(object sender, EventArgs e)
        {
            timerOperation.Start();
            prodVisible();
            prodColor(btnOtherOperations);
        }

        private void btnDailySales_Click(object sender, EventArgs e)
        {
            prodVisible();
            prodColor(btnDailySales);
        }

        private void btnClearCart_Click(object sender, EventArgs e)
        {
            prodVisible();
            prodColor(btnClearCart);
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            prodVisible();
            prodColor(btnChangePassword);
        }
    }
}
