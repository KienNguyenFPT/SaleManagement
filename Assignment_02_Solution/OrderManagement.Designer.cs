namespace Assignment_02_Solution
{
    partial class OrderManagement
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges21 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges22 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges23 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges24 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btnMember = new Button();
            btnOrderDelete = new Button();
            btnOrderUpdate = new Button();
            btnLogout = new Button();
            btnCategory = new Button();
            label6 = new Label();
            txtDiscount = new Guna.UI2.WinForms.Guna2TextBox();
            txtQuantity = new Guna.UI2.WinForms.Guna2TextBox();
            txtProPrice = new Guna.UI2.WinForms.Guna2TextBox();
            txtOrderID = new Guna.UI2.WinForms.Guna2TextBox();
            s = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lbMemID = new Label();
            btnProduct = new Button();
            panel1 = new Panel();
            cbbMem = new ComboBox();
            btnReport = new Button();
            dgvOrderDetail = new Guna.UI2.WinForms.Guna2DataGridView();
            STT = new DataGridViewTextBoxColumn();
            ProID = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Discount = new DataGridViewTextBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
            btnAddDetail = new Button();
            cbbProID = new Guna.UI2.WinForms.Guna2ComboBox();
            dgvOrder = new Guna.UI2.WinForms.Guna2DataGridView();
            label5 = new Label();
            txtOrderDate = new Guna.UI2.WinForms.Guna2TextBox();
            label4 = new Label();
            button1 = new Button();
            label7 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).BeginInit();
            SuspendLayout();
            // 
            // btnMember
            // 
            btnMember.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnMember.ForeColor = Color.Goldenrod;
            btnMember.Location = new Point(10, 113);
            btnMember.Name = "btnMember";
            btnMember.Size = new Size(107, 36);
            btnMember.TabIndex = 70;
            btnMember.Text = "Member";
            btnMember.UseVisualStyleBackColor = true;
            btnMember.Click += btnMember_Click;
            // 
            // btnOrderDelete
            // 
            btnOrderDelete.Location = new Point(263, 551);
            btnOrderDelete.Name = "btnOrderDelete";
            btnOrderDelete.Size = new Size(94, 29);
            btnOrderDelete.TabIndex = 66;
            btnOrderDelete.Text = "Delete";
            btnOrderDelete.UseVisualStyleBackColor = true;
            btnOrderDelete.Click += btnOrderDelete_Click;
            // 
            // btnOrderUpdate
            // 
            btnOrderUpdate.Location = new Point(140, 551);
            btnOrderUpdate.Name = "btnOrderUpdate";
            btnOrderUpdate.RightToLeft = RightToLeft.Yes;
            btnOrderUpdate.Size = new Size(94, 29);
            btnOrderUpdate.TabIndex = 65;
            btnOrderUpdate.Text = "Update";
            btnOrderUpdate.UseVisualStyleBackColor = true;
            btnOrderUpdate.Click += btnOrderUpdate_Click;
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnLogout.ForeColor = Color.Goldenrod;
            btnLogout.Location = new Point(10, 633);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(107, 36);
            btnLogout.TabIndex = 73;
            btnLogout.Text = "Log out";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnCategory
            // 
            btnCategory.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnCategory.ForeColor = Color.Goldenrod;
            btnCategory.Location = new Point(10, 174);
            btnCategory.Name = "btnCategory";
            btnCategory.Size = new Size(107, 36);
            btnCategory.TabIndex = 71;
            btnCategory.Text = "Category";
            btnCategory.UseVisualStyleBackColor = true;
            btnCategory.Click += btnCategory_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(319, 304);
            label6.Name = "label6";
            label6.Size = new Size(357, 35);
            label6.TabIndex = 12;
            label6.Text = "ORDER MANAGEMENT";
            // 
            // txtDiscount
            // 
            txtDiscount.BorderRadius = 18;
            txtDiscount.CustomizableEdges = customizableEdges13;
            txtDiscount.DefaultText = "";
            txtDiscount.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtDiscount.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtDiscount.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtDiscount.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtDiscount.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtDiscount.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtDiscount.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtDiscount.Location = new Point(121, 190);
            txtDiscount.Margin = new Padding(4, 5, 4, 5);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.PasswordChar = '\0';
            txtDiscount.PlaceholderText = "";
            txtDiscount.SelectedText = "";
            txtDiscount.ShadowDecoration.CustomizableEdges = customizableEdges14;
            txtDiscount.Size = new Size(185, 34);
            txtDiscount.TabIndex = 9;
            // 
            // txtQuantity
            // 
            txtQuantity.BorderRadius = 18;
            txtQuantity.CustomizableEdges = customizableEdges15;
            txtQuantity.DefaultText = "";
            txtQuantity.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtQuantity.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtQuantity.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtQuantity.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtQuantity.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtQuantity.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtQuantity.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtQuantity.Location = new Point(121, 141);
            txtQuantity.Margin = new Padding(4, 5, 4, 5);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.PasswordChar = '\0';
            txtQuantity.PlaceholderText = "";
            txtQuantity.SelectedText = "";
            txtQuantity.ShadowDecoration.CustomizableEdges = customizableEdges16;
            txtQuantity.Size = new Size(185, 39);
            txtQuantity.TabIndex = 8;
            // 
            // txtProPrice
            // 
            txtProPrice.BorderRadius = 18;
            txtProPrice.CustomizableEdges = customizableEdges17;
            txtProPrice.DefaultText = "";
            txtProPrice.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtProPrice.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtProPrice.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtProPrice.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtProPrice.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtProPrice.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtProPrice.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtProPrice.Location = new Point(121, 97);
            txtProPrice.Margin = new Padding(4, 5, 4, 5);
            txtProPrice.Name = "txtProPrice";
            txtProPrice.PasswordChar = '\0';
            txtProPrice.PlaceholderText = "";
            txtProPrice.SelectedText = "";
            txtProPrice.ShadowDecoration.CustomizableEdges = customizableEdges18;
            txtProPrice.Size = new Size(185, 34);
            txtProPrice.TabIndex = 7;
            txtProPrice.TextChanged += txtProWeight_TextChanged;
            // 
            // txtOrderID
            // 
            txtOrderID.BorderRadius = 18;
            txtOrderID.CustomizableEdges = customizableEdges19;
            txtOrderID.DefaultText = "";
            txtOrderID.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtOrderID.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtOrderID.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtOrderID.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtOrderID.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtOrderID.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtOrderID.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtOrderID.Location = new Point(157, 374);
            txtOrderID.Margin = new Padding(4, 5, 4, 5);
            txtOrderID.Name = "txtOrderID";
            txtOrderID.PasswordChar = '\0';
            txtOrderID.PlaceholderText = "";
            txtOrderID.SelectedText = "";
            txtOrderID.ShadowDecoration.CustomizableEdges = customizableEdges20;
            txtOrderID.Size = new Size(200, 36);
            txtOrderID.TabIndex = 6;
            // 
            // s
            // 
            s.AutoSize = true;
            s.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            s.Location = new Point(11, 201);
            s.Name = "s";
            s.Size = new Size(90, 23);
            s.TabIndex = 5;
            s.Text = "Discount:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(9, 157);
            label3.Name = "label3";
            label3.Size = new Size(92, 23);
            label3.TabIndex = 4;
            label3.Text = "Quantity:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(10, 119);
            label2.Name = "label2";
            label2.Size = new Size(61, 23);
            label2.TabIndex = 3;
            label2.Text = "Price:";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(9, 387);
            label1.Name = "label1";
            label1.Size = new Size(95, 23);
            label1.TabIndex = 2;
            label1.Text = "Order ID:";
            label1.Click += label1_Click;
            // 
            // lbMemID
            // 
            lbMemID.AutoSize = true;
            lbMemID.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbMemID.Location = new Point(10, 448);
            lbMemID.Name = "lbMemID";
            lbMemID.Size = new Size(114, 23);
            lbMemID.TabIndex = 0;
            lbMemID.Text = "Member ID:";
            // 
            // btnProduct
            // 
            btnProduct.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnProduct.ForeColor = Color.Goldenrod;
            btnProduct.Location = new Point(10, 232);
            btnProduct.Name = "btnProduct";
            btnProduct.Size = new Size(107, 36);
            btnProduct.TabIndex = 72;
            btnProduct.Text = "Product";
            btnProduct.UseVisualStyleBackColor = true;
            btnProduct.Click += btnProduct_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Goldenrod;
            panel1.Controls.Add(cbbMem);
            panel1.Controls.Add(btnReport);
            panel1.Controls.Add(dgvOrderDetail);
            panel1.Controls.Add(btnAddDetail);
            panel1.Controls.Add(cbbProID);
            panel1.Controls.Add(dgvOrder);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtOrderDate);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(btnOrderDelete);
            panel1.Controls.Add(btnOrderUpdate);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtDiscount);
            panel1.Controls.Add(txtQuantity);
            panel1.Controls.Add(txtProPrice);
            panel1.Controls.Add(txtOrderID);
            panel1.Controls.Add(s);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lbMemID);
            panel1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            panel1.Location = new Point(141, 7);
            panel1.Name = "panel1";
            panel1.Size = new Size(990, 662);
            panel1.TabIndex = 69;
            panel1.Paint += panel1_Paint;
            // 
            // cbbMem
            // 
            cbbMem.FormattingEnabled = true;
            cbbMem.Location = new Point(157, 440);
            cbbMem.Name = "cbbMem";
            cbbMem.Size = new Size(195, 31);
            cbbMem.TabIndex = 114;
            // 
            // btnReport
            // 
            btnReport.Location = new Point(880, 604);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(94, 29);
            btnReport.TabIndex = 113;
            btnReport.Text = "Report";
            btnReport.UseVisualStyleBackColor = true;
            btnReport.Click += btnReport_Click;
            // 
            // dgvOrderDetail
            // 
            dataGridViewCellStyle7.BackColor = Color.White;
            dgvOrderDetail.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle8.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = Color.White;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dgvOrderDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dgvOrderDetail.ColumnHeadersHeight = 24;
            dgvOrderDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvOrderDetail.Columns.AddRange(new DataGridViewColumn[] { STT, ProID, Price, Quantity, Discount, Amount });
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.White;
            dataGridViewCellStyle9.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle9.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            dgvOrderDetail.DefaultCellStyle = dataGridViewCellStyle9;
            dgvOrderDetail.GridColor = Color.FromArgb(231, 229, 255);
            dgvOrderDetail.Location = new Point(382, 55);
            dgvOrderDetail.Name = "dgvOrderDetail";
            dgvOrderDetail.RowHeadersVisible = false;
            dgvOrderDetail.RowHeadersWidth = 51;
            dgvOrderDetail.RowTemplate.Height = 29;
            dgvOrderDetail.Size = new Size(592, 222);
            dgvOrderDetail.TabIndex = 112;
            dgvOrderDetail.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvOrderDetail.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvOrderDetail.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvOrderDetail.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvOrderDetail.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvOrderDetail.ThemeStyle.BackColor = Color.White;
            dgvOrderDetail.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvOrderDetail.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvOrderDetail.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvOrderDetail.ThemeStyle.HeaderStyle.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dgvOrderDetail.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvOrderDetail.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvOrderDetail.ThemeStyle.HeaderStyle.Height = 24;
            dgvOrderDetail.ThemeStyle.ReadOnly = false;
            dgvOrderDetail.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvOrderDetail.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvOrderDetail.ThemeStyle.RowsStyle.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dgvOrderDetail.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvOrderDetail.ThemeStyle.RowsStyle.Height = 29;
            dgvOrderDetail.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvOrderDetail.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgvOrderDetail.CellContentClick += dgvOrderDetail_CellContentClick;
            dgvOrderDetail.Click += dgvOrderDetail_Click;
            // 
            // STT
            // 
            STT.HeaderText = "STT";
            STT.MinimumWidth = 6;
            STT.Name = "STT";
            // 
            // ProID
            // 
            ProID.HeaderText = "ProID";
            ProID.MinimumWidth = 6;
            ProID.Name = "ProID";
            // 
            // Price
            // 
            Price.HeaderText = "Price";
            Price.MinimumWidth = 6;
            Price.Name = "Price";
            // 
            // Quantity
            // 
            Quantity.HeaderText = "Quantity";
            Quantity.MinimumWidth = 6;
            Quantity.Name = "Quantity";
            // 
            // Discount
            // 
            Discount.HeaderText = "Discount";
            Discount.MinimumWidth = 6;
            Discount.Name = "Discount";
            // 
            // Amount
            // 
            Amount.HeaderText = "Amount";
            Amount.MinimumWidth = 6;
            Amount.Name = "Amount";
            // 
            // btnAddDetail
            // 
            btnAddDetail.Location = new Point(91, 248);
            btnAddDetail.Name = "btnAddDetail";
            btnAddDetail.Size = new Size(143, 29);
            btnAddDetail.TabIndex = 111;
            btnAddDetail.Text = "Add Detail";
            btnAddDetail.UseVisualStyleBackColor = true;
            btnAddDetail.Click += btnAddDetail_Click;
            // 
            // cbbProID
            // 
            cbbProID.BackColor = Color.Transparent;
            cbbProID.CustomizableEdges = customizableEdges21;
            cbbProID.DrawMode = DrawMode.OwnerDrawFixed;
            cbbProID.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbProID.FocusedColor = Color.FromArgb(94, 148, 255);
            cbbProID.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbbProID.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cbbProID.ForeColor = Color.FromArgb(68, 88, 112);
            cbbProID.ItemHeight = 30;
            cbbProID.Location = new Point(124, 53);
            cbbProID.Name = "cbbProID";
            cbbProID.ShadowDecoration.CustomizableEdges = customizableEdges22;
            cbbProID.Size = new Size(182, 36);
            cbbProID.TabIndex = 108;
            // 
            // dgvOrder
            // 
            dataGridViewCellStyle10.BackColor = Color.White;
            dgvOrder.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle11.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = Color.White;
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            dgvOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dgvOrder.ColumnHeadersHeight = 24;
            dgvOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = Color.White;
            dataGridViewCellStyle12.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle12.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle12.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.False;
            dgvOrder.DefaultCellStyle = dataGridViewCellStyle12;
            dgvOrder.GridColor = Color.FromArgb(231, 229, 255);
            dgvOrder.Location = new Point(380, 374);
            dgvOrder.Name = "dgvOrder";
            dgvOrder.RowHeadersVisible = false;
            dgvOrder.RowHeadersWidth = 51;
            dgvOrder.RowTemplate.Height = 29;
            dgvOrder.Size = new Size(594, 206);
            dgvOrder.TabIndex = 103;
            dgvOrder.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvOrder.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvOrder.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvOrder.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvOrder.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvOrder.ThemeStyle.BackColor = Color.White;
            dgvOrder.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvOrder.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvOrder.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvOrder.ThemeStyle.HeaderStyle.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dgvOrder.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvOrder.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvOrder.ThemeStyle.HeaderStyle.Height = 24;
            dgvOrder.ThemeStyle.ReadOnly = false;
            dgvOrder.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvOrder.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvOrder.ThemeStyle.RowsStyle.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dgvOrder.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvOrder.ThemeStyle.RowsStyle.Height = 29;
            dgvOrder.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvOrder.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgvOrder.Click += dgvOrder_Click_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(382, 17);
            label5.Name = "label5";
            label5.Size = new Size(245, 35);
            label5.TabIndex = 105;
            label5.Text = "ORDER DETAIL";
            // 
            // txtOrderDate
            // 
            txtOrderDate.BorderRadius = 18;
            txtOrderDate.CustomizableEdges = customizableEdges23;
            txtOrderDate.DefaultText = "";
            txtOrderDate.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtOrderDate.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtOrderDate.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtOrderDate.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtOrderDate.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtOrderDate.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtOrderDate.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtOrderDate.Location = new Point(157, 490);
            txtOrderDate.Margin = new Padding(4, 5, 4, 5);
            txtOrderDate.Name = "txtOrderDate";
            txtOrderDate.PasswordChar = '\0';
            txtOrderDate.PlaceholderText = "";
            txtOrderDate.SelectedText = "";
            txtOrderDate.ShadowDecoration.CustomizableEdges = customizableEdges24;
            txtOrderDate.Size = new Size(200, 39);
            txtOrderDate.TabIndex = 95;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(9, 66);
            label4.Name = "label4";
            label4.Size = new Size(109, 23);
            label4.TabIndex = 93;
            label4.Text = "Product ID:";
            // 
            // button1
            // 
            button1.Location = new Point(30, 551);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 89;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(9, 506);
            label7.Name = "label7";
            label7.Size = new Size(115, 23);
            label7.TabIndex = 84;
            label7.Text = "Date Order:";
            // 
            // OrderManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1141, 676);
            Controls.Add(btnMember);
            Controls.Add(btnLogout);
            Controls.Add(btnCategory);
            Controls.Add(btnProduct);
            Controls.Add(panel1);
            Name = "OrderManagement";
            Text = "OrderManagement";
            Load += OrderManagement_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetail).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnMember;
        private Button btnOrderDelete;
        private Button btnOrderUpdate;
        private Button btnLogout;
        private Button btnCategory;
        private Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txtDiscount;
        private Guna.UI2.WinForms.Guna2TextBox txtQuantity;
        private Guna.UI2.WinForms.Guna2TextBox txtProPrice;
        private Guna.UI2.WinForms.Guna2TextBox txtOrderID;
        private Label s;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label lbMemID;
        private Button btnProduct;
        private Panel panel1;
        private Label label7;
        private Button button1;
        private Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtOrderDate;
        private Guna.UI2.WinForms.Guna2DataGridView dgvOrder;
        private Label label5;
        private Guna.UI2.WinForms.Guna2ComboBox cbbProID;
        private Button btnAddDetail;
        private Guna.UI2.WinForms.Guna2DataGridView dgvOrderDetail;
        private DataGridViewTextBoxColumn STT;
        private DataGridViewTextBoxColumn ProID;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Discount;
        private DataGridViewTextBoxColumn Amount;
        private Button btnReport;
        private ComboBox cbbMem;
    }
}