
namespace NewInventory
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnMin = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnlSetting = new System.Windows.Forms.Panel();
            this.pnlSetColor = new System.Windows.Forms.Panel();
            this.btnAccount = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
            this.pnlCustomer = new System.Windows.Forms.Panel();
            this.pnlCusColor = new System.Windows.Forms.Panel();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.pnlProduct = new System.Windows.Forms.Panel();
            this.pnlProdColor = new System.Windows.Forms.Panel();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.pnlCategory = new System.Windows.Forms.Panel();
            this.pnlCatColor = new System.Windows.Forms.Panel();
            this.btnAddSupplier = new System.Windows.Forms.Button();
            this.btnAddBrand = new System.Windows.Forms.Button();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.btnMainCategory = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlDashColor = new System.Windows.Forms.Panel();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.pnlWrapper = new System.Windows.Forms.Panel();
            this.pnlAdminWrapper = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.timerCategory = new System.Windows.Forms.Timer(this.components);
            this.timerProduct = new System.Windows.Forms.Timer(this.components);
            this.timerCustomer = new System.Windows.Forms.Timer(this.components);
            this.timerSetting = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.panelLeft.SuspendLayout();
            this.pnlSetting.SuspendLayout();
            this.pnlCustomer.SuspendLayout();
            this.pnlProduct.SuspendLayout();
            this.pnlCategory.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlWrapper.SuspendLayout();
            this.pnlAdminWrapper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.panel1.Controls.Add(this.lblUsername);
            this.panel1.Controls.Add(this.btnMin);
            this.panel1.Controls.Add(this.lblHeader);
            this.panel1.Controls.Add(this.picLogo);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.MaximumSize = new System.Drawing.Size(1222, 86);
            this.panel1.MinimumSize = new System.Drawing.Size(1222, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1222, 86);
            this.panel1.TabIndex = 0;
            // 
            // lblUsername
            // 
            this.lblUsername.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(90, 4);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(237, 34);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Username";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblUsername.Visible = false;
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Image = ((System.Drawing.Image)(resources.GetObject("btnMin.Image")));
            this.btnMin.Location = new System.Drawing.Point(1153, 0);
            this.btnMin.MaximumSize = new System.Drawing.Size(32, 32);
            this.btnMin.MinimumSize = new System.Drawing.Size(32, 32);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(32, 32);
            this.btnMin.TabIndex = 2;
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHeader.Font = new System.Drawing.Font("Poppins", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(238, 14);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(894, 53);
            this.lblHeader.TabIndex = 1;
            this.lblHeader.Text = "POINT OF SALES";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(6, 8);
            this.picLogo.MaximumSize = new System.Drawing.Size(78, 65);
            this.picLogo.MinimumSize = new System.Drawing.Size(78, 65);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(78, 65);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 1;
            this.picLogo.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1188, 0);
            this.btnClose.MaximumSize = new System.Drawing.Size(32, 32);
            this.btnClose.MinimumSize = new System.Drawing.Size(32, 32);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(32, 32);
            this.btnClose.TabIndex = 1;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panelLeft
            // 
            this.panelLeft.AutoScroll = true;
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panelLeft.Controls.Add(this.btnLogout);
            this.panelLeft.Controls.Add(this.pnlSetting);
            this.panelLeft.Controls.Add(this.pnlCustomer);
            this.panelLeft.Controls.Add(this.pnlProduct);
            this.panelLeft.Controls.Add(this.pnlCategory);
            this.panelLeft.Controls.Add(this.panel2);
            this.panelLeft.Controls.Add(this.pnlWrapper);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelLeft.Location = new System.Drawing.Point(0, 86);
            this.panelLeft.MaximumSize = new System.Drawing.Size(240, 614);
            this.panelLeft.MinimumSize = new System.Drawing.Size(240, 614);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(240, 614);
            this.panelLeft.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Poppins", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 564);
            this.btnLogout.MaximumSize = new System.Drawing.Size(240, 50);
            this.btnLogout.MinimumSize = new System.Drawing.Size(240, 50);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(240, 50);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pnlSetting
            // 
            this.pnlSetting.Controls.Add(this.pnlSetColor);
            this.pnlSetting.Controls.Add(this.btnAccount);
            this.pnlSetting.Controls.Add(this.btnSetting);
            this.pnlSetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSetting.Location = new System.Drawing.Point(0, 404);
            this.pnlSetting.MaximumSize = new System.Drawing.Size(240, 100);
            this.pnlSetting.MinimumSize = new System.Drawing.Size(240, 50);
            this.pnlSetting.Name = "pnlSetting";
            this.pnlSetting.Size = new System.Drawing.Size(240, 100);
            this.pnlSetting.TabIndex = 6;
            // 
            // pnlSetColor
            // 
            this.pnlSetColor.Location = new System.Drawing.Point(1, 3);
            this.pnlSetColor.MaximumSize = new System.Drawing.Size(5, 50);
            this.pnlSetColor.MinimumSize = new System.Drawing.Size(5, 50);
            this.pnlSetColor.Name = "pnlSetColor";
            this.pnlSetColor.Size = new System.Drawing.Size(5, 50);
            this.pnlSetColor.TabIndex = 1;
            // 
            // btnAccount
            // 
            this.btnAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAccount.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnAccount.FlatAppearance.BorderSize = 0;
            this.btnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccount.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAccount.Image = ((System.Drawing.Image)(resources.GetObject("btnAccount.Image")));
            this.btnAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccount.Location = new System.Drawing.Point(0, 50);
            this.btnAccount.MaximumSize = new System.Drawing.Size(240, 50);
            this.btnAccount.MinimumSize = new System.Drawing.Size(240, 50);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnAccount.Size = new System.Drawing.Size(240, 50);
            this.btnAccount.TabIndex = 3;
            this.btnAccount.Text = "Manage Users";
            this.btnAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAccount.UseVisualStyleBackColor = false;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnSetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSetting.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Font = new System.Drawing.Font("Poppins", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetting.Image = ((System.Drawing.Image)(resources.GetObject("btnSetting.Image")));
            this.btnSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.Location = new System.Drawing.Point(0, 0);
            this.btnSetting.MaximumSize = new System.Drawing.Size(240, 50);
            this.btnSetting.MinimumSize = new System.Drawing.Size(240, 50);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSetting.Size = new System.Drawing.Size(240, 50);
            this.btnSetting.TabIndex = 1;
            this.btnSetting.Text = "Settings";
            this.btnSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSetting.UseVisualStyleBackColor = false;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // pnlCustomer
            // 
            this.pnlCustomer.Controls.Add(this.pnlCusColor);
            this.pnlCustomer.Controls.Add(this.btnAddCustomer);
            this.pnlCustomer.Controls.Add(this.btnCustomer);
            this.pnlCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCustomer.Location = new System.Drawing.Point(0, 304);
            this.pnlCustomer.MaximumSize = new System.Drawing.Size(240, 100);
            this.pnlCustomer.MinimumSize = new System.Drawing.Size(240, 50);
            this.pnlCustomer.Name = "pnlCustomer";
            this.pnlCustomer.Size = new System.Drawing.Size(240, 100);
            this.pnlCustomer.TabIndex = 5;
            // 
            // pnlCusColor
            // 
            this.pnlCusColor.Location = new System.Drawing.Point(2, 4);
            this.pnlCusColor.MaximumSize = new System.Drawing.Size(5, 50);
            this.pnlCusColor.MinimumSize = new System.Drawing.Size(5, 50);
            this.pnlCusColor.Name = "pnlCusColor";
            this.pnlCusColor.Size = new System.Drawing.Size(5, 50);
            this.pnlCusColor.TabIndex = 1;
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnAddCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddCustomer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnAddCustomer.FlatAppearance.BorderSize = 0;
            this.btnAddCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCustomer.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAddCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnAddCustomer.Image")));
            this.btnAddCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCustomer.Location = new System.Drawing.Point(0, 50);
            this.btnAddCustomer.MaximumSize = new System.Drawing.Size(240, 50);
            this.btnAddCustomer.MinimumSize = new System.Drawing.Size(240, 50);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnAddCustomer.Size = new System.Drawing.Size(240, 50);
            this.btnAddCustomer.TabIndex = 2;
            this.btnAddCustomer.Text = "Add New Customer";
            this.btnAddCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddCustomer.UseVisualStyleBackColor = false;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCustomer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnCustomer.FlatAppearance.BorderSize = 0;
            this.btnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomer.Font = new System.Drawing.Font("Poppins", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomer.Image")));
            this.btnCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomer.Location = new System.Drawing.Point(0, 0);
            this.btnCustomer.MaximumSize = new System.Drawing.Size(240, 50);
            this.btnCustomer.MinimumSize = new System.Drawing.Size(240, 50);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCustomer.Size = new System.Drawing.Size(240, 50);
            this.btnCustomer.TabIndex = 1;
            this.btnCustomer.Text = "Customer";
            this.btnCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCustomer.UseVisualStyleBackColor = false;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // pnlProduct
            // 
            this.pnlProduct.Controls.Add(this.pnlProdColor);
            this.pnlProduct.Controls.Add(this.btnAddProduct);
            this.pnlProduct.Controls.Add(this.btnProduct);
            this.pnlProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlProduct.Location = new System.Drawing.Point(0, 254);
            this.pnlProduct.MaximumSize = new System.Drawing.Size(240, 100);
            this.pnlProduct.MinimumSize = new System.Drawing.Size(240, 50);
            this.pnlProduct.Name = "pnlProduct";
            this.pnlProduct.Size = new System.Drawing.Size(240, 50);
            this.pnlProduct.TabIndex = 4;
            // 
            // pnlProdColor
            // 
            this.pnlProdColor.Location = new System.Drawing.Point(2, 4);
            this.pnlProdColor.MaximumSize = new System.Drawing.Size(5, 50);
            this.pnlProdColor.MinimumSize = new System.Drawing.Size(5, 50);
            this.pnlProdColor.Name = "pnlProdColor";
            this.pnlProdColor.Size = new System.Drawing.Size(5, 50);
            this.pnlProdColor.TabIndex = 1;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnAddProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddProduct.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnAddProduct.FlatAppearance.BorderSize = 0;
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAddProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnAddProduct.Image")));
            this.btnAddProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddProduct.Location = new System.Drawing.Point(0, 50);
            this.btnAddProduct.MaximumSize = new System.Drawing.Size(240, 50);
            this.btnAddProduct.MinimumSize = new System.Drawing.Size(240, 50);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnAddProduct.Size = new System.Drawing.Size(240, 50);
            this.btnAddProduct.TabIndex = 2;
            this.btnAddProduct.Text = "Add New Product";
            this.btnAddProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProduct.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnProduct.FlatAppearance.BorderSize = 0;
            this.btnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduct.Font = new System.Drawing.Font("Poppins", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnProduct.Image")));
            this.btnProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduct.Location = new System.Drawing.Point(0, 0);
            this.btnProduct.MaximumSize = new System.Drawing.Size(240, 50);
            this.btnProduct.MinimumSize = new System.Drawing.Size(240, 50);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnProduct.Size = new System.Drawing.Size(240, 50);
            this.btnProduct.TabIndex = 1;
            this.btnProduct.Text = "Product";
            this.btnProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProduct.UseVisualStyleBackColor = false;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // pnlCategory
            // 
            this.pnlCategory.Controls.Add(this.pnlCatColor);
            this.pnlCategory.Controls.Add(this.btnAddSupplier);
            this.pnlCategory.Controls.Add(this.btnAddBrand);
            this.pnlCategory.Controls.Add(this.btnAddCategory);
            this.pnlCategory.Controls.Add(this.btnMainCategory);
            this.pnlCategory.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCategory.Location = new System.Drawing.Point(0, 204);
            this.pnlCategory.MaximumSize = new System.Drawing.Size(240, 200);
            this.pnlCategory.MinimumSize = new System.Drawing.Size(240, 50);
            this.pnlCategory.Name = "pnlCategory";
            this.pnlCategory.Size = new System.Drawing.Size(240, 50);
            this.pnlCategory.TabIndex = 2;
            // 
            // pnlCatColor
            // 
            this.pnlCatColor.Location = new System.Drawing.Point(1, 3);
            this.pnlCatColor.MaximumSize = new System.Drawing.Size(5, 50);
            this.pnlCatColor.MinimumSize = new System.Drawing.Size(5, 50);
            this.pnlCatColor.Name = "pnlCatColor";
            this.pnlCatColor.Size = new System.Drawing.Size(5, 50);
            this.pnlCatColor.TabIndex = 1;
            // 
            // btnAddSupplier
            // 
            this.btnAddSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnAddSupplier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddSupplier.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddSupplier.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnAddSupplier.FlatAppearance.BorderSize = 0;
            this.btnAddSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSupplier.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSupplier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAddSupplier.Image = ((System.Drawing.Image)(resources.GetObject("btnAddSupplier.Image")));
            this.btnAddSupplier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddSupplier.Location = new System.Drawing.Point(0, 150);
            this.btnAddSupplier.MaximumSize = new System.Drawing.Size(240, 50);
            this.btnAddSupplier.MinimumSize = new System.Drawing.Size(240, 50);
            this.btnAddSupplier.Name = "btnAddSupplier";
            this.btnAddSupplier.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnAddSupplier.Size = new System.Drawing.Size(240, 50);
            this.btnAddSupplier.TabIndex = 4;
            this.btnAddSupplier.Text = "Add Supplier";
            this.btnAddSupplier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddSupplier.UseVisualStyleBackColor = false;
            this.btnAddSupplier.Click += new System.EventHandler(this.btnAddSupplier_Click);
            // 
            // btnAddBrand
            // 
            this.btnAddBrand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnAddBrand.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddBrand.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddBrand.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnAddBrand.FlatAppearance.BorderSize = 0;
            this.btnAddBrand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBrand.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBrand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAddBrand.Image = ((System.Drawing.Image)(resources.GetObject("btnAddBrand.Image")));
            this.btnAddBrand.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddBrand.Location = new System.Drawing.Point(0, 100);
            this.btnAddBrand.MaximumSize = new System.Drawing.Size(240, 50);
            this.btnAddBrand.MinimumSize = new System.Drawing.Size(240, 50);
            this.btnAddBrand.Name = "btnAddBrand";
            this.btnAddBrand.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnAddBrand.Size = new System.Drawing.Size(240, 50);
            this.btnAddBrand.TabIndex = 3;
            this.btnAddBrand.Text = "Add Brand";
            this.btnAddBrand.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddBrand.UseVisualStyleBackColor = false;
            this.btnAddBrand.Click += new System.EventHandler(this.btnAddBrand_Click);
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnAddCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCategory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddCategory.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnAddCategory.FlatAppearance.BorderSize = 0;
            this.btnAddCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCategory.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAddCategory.Image = ((System.Drawing.Image)(resources.GetObject("btnAddCategory.Image")));
            this.btnAddCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCategory.Location = new System.Drawing.Point(0, 50);
            this.btnAddCategory.MaximumSize = new System.Drawing.Size(240, 50);
            this.btnAddCategory.MinimumSize = new System.Drawing.Size(240, 50);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnAddCategory.Size = new System.Drawing.Size(240, 50);
            this.btnAddCategory.TabIndex = 2;
            this.btnAddCategory.Text = "Add Category";
            this.btnAddCategory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddCategory.UseVisualStyleBackColor = false;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // btnMainCategory
            // 
            this.btnMainCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnMainCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMainCategory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMainCategory.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnMainCategory.FlatAppearance.BorderSize = 0;
            this.btnMainCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMainCategory.Font = new System.Drawing.Font("Poppins", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainCategory.Image = ((System.Drawing.Image)(resources.GetObject("btnMainCategory.Image")));
            this.btnMainCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMainCategory.Location = new System.Drawing.Point(0, 0);
            this.btnMainCategory.MaximumSize = new System.Drawing.Size(240, 50);
            this.btnMainCategory.MinimumSize = new System.Drawing.Size(240, 50);
            this.btnMainCategory.Name = "btnMainCategory";
            this.btnMainCategory.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMainCategory.Size = new System.Drawing.Size(240, 50);
            this.btnMainCategory.TabIndex = 1;
            this.btnMainCategory.Text = "Category";
            this.btnMainCategory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMainCategory.UseVisualStyleBackColor = false;
            this.btnMainCategory.Click += new System.EventHandler(this.btnMainCategory_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pnlDashColor);
            this.panel2.Controls.Add(this.btnDashboard);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 154);
            this.panel2.MaximumSize = new System.Drawing.Size(240, 50);
            this.panel2.MinimumSize = new System.Drawing.Size(240, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(240, 50);
            this.panel2.TabIndex = 1;
            // 
            // pnlDashColor
            // 
            this.pnlDashColor.Location = new System.Drawing.Point(1, 0);
            this.pnlDashColor.MaximumSize = new System.Drawing.Size(5, 50);
            this.pnlDashColor.MinimumSize = new System.Drawing.Size(5, 50);
            this.pnlDashColor.Name = "pnlDashColor";
            this.pnlDashColor.Size = new System.Drawing.Size(5, 50);
            this.pnlDashColor.TabIndex = 1;
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Poppins", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(0, 0);
            this.btnDashboard.MaximumSize = new System.Drawing.Size(240, 50);
            this.btnDashboard.MinimumSize = new System.Drawing.Size(240, 50);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnDashboard.Size = new System.Drawing.Size(240, 50);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // pnlWrapper
            // 
            this.pnlWrapper.Controls.Add(this.pnlAdminWrapper);
            this.pnlWrapper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlWrapper.Location = new System.Drawing.Point(0, 0);
            this.pnlWrapper.Name = "pnlWrapper";
            this.pnlWrapper.Size = new System.Drawing.Size(240, 154);
            this.pnlWrapper.TabIndex = 0;
            // 
            // pnlAdminWrapper
            // 
            this.pnlAdminWrapper.Controls.Add(this.lblName);
            this.pnlAdminWrapper.Controls.Add(this.picImage);
            this.pnlAdminWrapper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAdminWrapper.Location = new System.Drawing.Point(0, 0);
            this.pnlAdminWrapper.Name = "pnlAdminWrapper";
            this.pnlAdminWrapper.Size = new System.Drawing.Size(240, 157);
            this.pnlAdminWrapper.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(1, 96);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(237, 37);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Full Name";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picImage
            // 
            this.picImage.Image = ((System.Drawing.Image)(resources.GetObject("picImage.Image")));
            this.picImage.Location = new System.Drawing.Point(81, 16);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(78, 60);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImage.TabIndex = 1;
            this.picImage.TabStop = false;
            // 
            // pnlMain
            // 
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlMain.Location = new System.Drawing.Point(240, 86);
            this.pnlMain.MaximumSize = new System.Drawing.Size(982, 614);
            this.pnlMain.MinimumSize = new System.Drawing.Size(982, 614);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(982, 614);
            this.pnlMain.TabIndex = 0;
            // 
            // timerCategory
            // 
            this.timerCategory.Interval = 10;
            this.timerCategory.Tick += new System.EventHandler(this.timerCategory_Tick);
            // 
            // timerProduct
            // 
            this.timerProduct.Interval = 10;
            this.timerProduct.Tick += new System.EventHandler(this.timerProduct_Tick);
            // 
            // timerCustomer
            // 
            this.timerCustomer.Interval = 10;
            this.timerCustomer.Tick += new System.EventHandler(this.timerCustomer_Tick);
            // 
            // timerSetting
            // 
            this.timerSetting.Interval = 10;
            this.timerSetting.Tick += new System.EventHandler(this.timerSetting_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 700);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximumSize = new System.Drawing.Size(1222, 700);
            this.MinimumSize = new System.Drawing.Size(1222, 700);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory System";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.panelLeft.ResumeLayout(false);
            this.pnlSetting.ResumeLayout(false);
            this.pnlCustomer.ResumeLayout(false);
            this.pnlProduct.ResumeLayout(false);
            this.pnlCategory.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.pnlWrapper.ResumeLayout(false);
            this.pnlAdminWrapper.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panelLeft;
        public System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel pnlWrapper;
        public System.Windows.Forms.PictureBox picImage;
        public System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlAdminWrapper;
        private System.Windows.Forms.Panel pnlCategory;
        public System.Windows.Forms.Button btnAddSupplier;
        public System.Windows.Forms.Button btnAddBrand;
        public System.Windows.Forms.Button btnAddCategory;
        public System.Windows.Forms.Button btnMainCategory;
        private System.Windows.Forms.Timer timerCategory;
        private System.Windows.Forms.Panel pnlDashColor;
        private System.Windows.Forms.Panel pnlCatColor;
        private System.Windows.Forms.Panel pnlProduct;
        public System.Windows.Forms.Button btnAddProduct;
        public System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Timer timerProduct;
        private System.Windows.Forms.Panel pnlProdColor;
        private System.Windows.Forms.Panel pnlCustomer;
        private System.Windows.Forms.Panel pnlCusColor;
        public System.Windows.Forms.Button btnAddCustomer;
        public System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Timer timerCustomer;
        public System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel pnlSetting;
        private System.Windows.Forms.Panel pnlSetColor;
        public System.Windows.Forms.Button btnAccount;
        public System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Timer timerSetting;
        private System.Windows.Forms.Button btnMin;
        public System.Windows.Forms.Label lblHeader;
        public System.Windows.Forms.Label lblName;
        public System.Windows.Forms.Label lblUsername;
    }
}

