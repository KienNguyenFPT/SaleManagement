namespace Assignment_02_Solution
{
    partial class ProductManagement
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges21 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges22 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges23 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges24 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges25 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges26 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges27 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges28 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            btnFilter = new Button();
            txtFilter = new Guna.UI2.WinForms.Guna2TextBox();
            button1 = new Button();
            btnByUnit = new Button();
            btnByPrice = new Button();
            btnByName = new Button();
            btnByID = new Button();
            txtByStock = new TextBox();
            txtByPrice = new TextBox();
            txtByName = new TextBox();
            txtByID = new TextBox();
            dgvProduct = new Guna.UI2.WinForms.Guna2DataGridView();
            cbbCat = new Guna.UI2.WinForms.Guna2ComboBox();
            btnProDelete = new Button();
            btnProUpdate = new Button();
            btnProAdd = new Button();
            label6 = new Label();
            label5 = new Label();
            txtProStock = new Guna.UI2.WinForms.Guna2TextBox();
            txtProUnitPrice = new Guna.UI2.WinForms.Guna2TextBox();
            txtProWeight = new Guna.UI2.WinForms.Guna2TextBox();
            txtProName = new Guna.UI2.WinForms.Guna2TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtProID = new Guna.UI2.WinForms.Guna2TextBox();
            ID = new Label();
            btnMember = new Button();
            btnCategory = new Button();
            btnOrder = new Button();
            btnLogout = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Goldenrod;
            panel1.Controls.Add(btnFilter);
            panel1.Controls.Add(txtFilter);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnByUnit);
            panel1.Controls.Add(btnByPrice);
            panel1.Controls.Add(btnByName);
            panel1.Controls.Add(btnByID);
            panel1.Controls.Add(txtByStock);
            panel1.Controls.Add(txtByPrice);
            panel1.Controls.Add(txtByName);
            panel1.Controls.Add(txtByID);
            panel1.Controls.Add(dgvProduct);
            panel1.Controls.Add(cbbCat);
            panel1.Controls.Add(btnProDelete);
            panel1.Controls.Add(btnProUpdate);
            panel1.Controls.Add(btnProAdd);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtProStock);
            panel1.Controls.Add(txtProUnitPrice);
            panel1.Controls.Add(txtProWeight);
            panel1.Controls.Add(txtProName);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtProID);
            panel1.Controls.Add(ID);
            panel1.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.Location = new Point(143, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(990, 662);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint_1;
            // 
            // btnFilter
            // 
            btnFilter.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnFilter.Location = new Point(791, 67);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(186, 33);
            btnFilter.TabIndex = 85;
            btnFilter.Text = "Filter Category";
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += btnFilter_Click;
            // 
            // txtFilter
            // 
            txtFilter.CustomizableEdges = customizableEdges15;
            txtFilter.DefaultText = "";
            txtFilter.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtFilter.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtFilter.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtFilter.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtFilter.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtFilter.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtFilter.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtFilter.Location = new Point(561, 69);
            txtFilter.Margin = new Padding(4);
            txtFilter.Name = "txtFilter";
            txtFilter.PasswordChar = '\0';
            txtFilter.PlaceholderText = "";
            txtFilter.SelectedText = "";
            txtFilter.ShadowDecoration.CustomizableEdges = customizableEdges16;
            txtFilter.Size = new Size(206, 31);
            txtFilter.TabIndex = 84;
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(882, 628);
            button1.Name = "button1";
            button1.Size = new Size(95, 31);
            button1.TabIndex = 83;
            button1.Text = "Load";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnByUnit
            // 
            btnByUnit.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnByUnit.Location = new Point(228, 584);
            btnByUnit.Name = "btnByUnit";
            btnByUnit.Size = new Size(153, 29);
            btnByUnit.TabIndex = 82;
            btnByUnit.Text = "Search By Unit";
            btnByUnit.UseVisualStyleBackColor = true;
            btnByUnit.Click += button4_Click;
            // 
            // btnByPrice
            // 
            btnByPrice.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnByPrice.Location = new Point(228, 550);
            btnByPrice.Name = "btnByPrice";
            btnByPrice.Size = new Size(153, 29);
            btnByPrice.TabIndex = 81;
            btnByPrice.Text = "Search By Price";
            btnByPrice.UseVisualStyleBackColor = true;
            btnByPrice.Click += btnByPrice_Click;
            // 
            // btnByName
            // 
            btnByName.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnByName.Location = new Point(228, 512);
            btnByName.Name = "btnByName";
            btnByName.Size = new Size(153, 29);
            btnByName.TabIndex = 80;
            btnByName.Text = "Search By Name";
            btnByName.UseVisualStyleBackColor = true;
            btnByName.Click += btnByName_Click;
            // 
            // btnByID
            // 
            btnByID.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnByID.Location = new Point(228, 476);
            btnByID.Name = "btnByID";
            btnByID.Size = new Size(153, 29);
            btnByID.TabIndex = 79;
            btnByID.Text = "Search By ID";
            btnByID.UseVisualStyleBackColor = true;
            btnByID.Click += btnByID_Click;
            // 
            // txtByStock
            // 
            txtByStock.Location = new Point(36, 584);
            txtByStock.Name = "txtByStock";
            txtByStock.Size = new Size(183, 27);
            txtByStock.TabIndex = 78;
            txtByStock.TextChanged += textBox4_TextChanged;
            // 
            // txtByPrice
            // 
            txtByPrice.Location = new Point(36, 548);
            txtByPrice.Name = "txtByPrice";
            txtByPrice.Size = new Size(183, 27);
            txtByPrice.TabIndex = 77;
            // 
            // txtByName
            // 
            txtByName.Location = new Point(36, 512);
            txtByName.Name = "txtByName";
            txtByName.Size = new Size(183, 27);
            txtByName.TabIndex = 76;
            // 
            // txtByID
            // 
            txtByID.Location = new Point(36, 476);
            txtByID.Name = "txtByID";
            txtByID.Size = new Size(183, 27);
            txtByID.TabIndex = 75;
            // 
            // dgvProduct
            // 
            dataGridViewCellStyle4.BackColor = Color.White;
            dgvProduct.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle5.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvProduct.ColumnHeadersHeight = 24;
            dgvProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvProduct.DefaultCellStyle = dataGridViewCellStyle6;
            dgvProduct.GridColor = Color.FromArgb(231, 229, 255);
            dgvProduct.Location = new Point(410, 115);
            dgvProduct.Name = "dgvProduct";
            dgvProduct.RowHeadersVisible = false;
            dgvProduct.RowHeadersWidth = 51;
            dgvProduct.RowTemplate.Height = 29;
            dgvProduct.Size = new Size(577, 499);
            dgvProduct.TabIndex = 73;
            dgvProduct.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvProduct.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvProduct.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvProduct.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvProduct.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvProduct.ThemeStyle.BackColor = Color.White;
            dgvProduct.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvProduct.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvProduct.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvProduct.ThemeStyle.HeaderStyle.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dgvProduct.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvProduct.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvProduct.ThemeStyle.HeaderStyle.Height = 24;
            dgvProduct.ThemeStyle.ReadOnly = false;
            dgvProduct.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvProduct.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvProduct.ThemeStyle.RowsStyle.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dgvProduct.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvProduct.ThemeStyle.RowsStyle.Height = 29;
            dgvProduct.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvProduct.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgvProduct.Click += dgvProduct_Click;
            // 
            // cbbCat
            // 
            cbbCat.BackColor = Color.Transparent;
            cbbCat.CustomizableEdges = customizableEdges17;
            cbbCat.DrawMode = DrawMode.OwnerDrawFixed;
            cbbCat.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbCat.FocusedColor = Color.FromArgb(94, 148, 255);
            cbbCat.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbbCat.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            cbbCat.ForeColor = Color.FromArgb(68, 88, 112);
            cbbCat.ItemHeight = 30;
            cbbCat.Location = new Point(160, 390);
            cbbCat.Name = "cbbCat";
            cbbCat.ShadowDecoration.CustomizableEdges = customizableEdges18;
            cbbCat.Size = new Size(221, 36);
            cbbCat.TabIndex = 71;
            cbbCat.SelectedIndexChanged += cbbCat_SelectedIndexChanged;
            // 
            // btnProDelete
            // 
            btnProDelete.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnProDelete.Location = new Point(287, 441);
            btnProDelete.Name = "btnProDelete";
            btnProDelete.Size = new Size(94, 29);
            btnProDelete.TabIndex = 66;
            btnProDelete.Text = "Delete";
            btnProDelete.UseVisualStyleBackColor = true;
            btnProDelete.Click += btnProDelete_Click;
            // 
            // btnProUpdate
            // 
            btnProUpdate.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnProUpdate.Location = new Point(160, 441);
            btnProUpdate.Name = "btnProUpdate";
            btnProUpdate.RightToLeft = RightToLeft.Yes;
            btnProUpdate.Size = new Size(94, 29);
            btnProUpdate.TabIndex = 65;
            btnProUpdate.Text = "Update";
            btnProUpdate.UseVisualStyleBackColor = true;
            btnProUpdate.Click += btnProUpdate_Click;
            // 
            // btnProAdd
            // 
            btnProAdd.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnProAdd.Location = new Point(36, 441);
            btnProAdd.Name = "btnProAdd";
            btnProAdd.Size = new Size(94, 29);
            btnProAdd.TabIndex = 64;
            btnProAdd.Text = "Add";
            btnProAdd.UseVisualStyleBackColor = true;
            btnProAdd.Click += btnProAdd_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(313, 22);
            label6.Name = "label6";
            label6.Size = new Size(397, 35);
            label6.TabIndex = 12;
            label6.Text = "PRODUCT MANAGEMENT";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(36, 403);
            label5.Name = "label5";
            label5.Size = new Size(96, 23);
            label5.TabIndex = 10;
            label5.Text = "Category:";
            // 
            // txtProStock
            // 
            txtProStock.BorderRadius = 18;
            txtProStock.CustomizableEdges = customizableEdges19;
            txtProStock.DefaultText = "";
            txtProStock.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtProStock.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtProStock.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtProStock.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtProStock.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtProStock.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtProStock.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtProStock.Location = new Point(160, 329);
            txtProStock.Margin = new Padding(4, 5, 4, 5);
            txtProStock.Name = "txtProStock";
            txtProStock.PasswordChar = '\0';
            txtProStock.PlaceholderText = "";
            txtProStock.SelectedText = "";
            txtProStock.ShadowDecoration.CustomizableEdges = customizableEdges20;
            txtProStock.Size = new Size(221, 39);
            txtProStock.TabIndex = 9;
            // 
            // txtProUnitPrice
            // 
            txtProUnitPrice.BorderRadius = 18;
            txtProUnitPrice.CustomizableEdges = customizableEdges21;
            txtProUnitPrice.DefaultText = "";
            txtProUnitPrice.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtProUnitPrice.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtProUnitPrice.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtProUnitPrice.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtProUnitPrice.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtProUnitPrice.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtProUnitPrice.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtProUnitPrice.Location = new Point(158, 280);
            txtProUnitPrice.Margin = new Padding(4, 5, 4, 5);
            txtProUnitPrice.Name = "txtProUnitPrice";
            txtProUnitPrice.PasswordChar = '\0';
            txtProUnitPrice.PlaceholderText = "";
            txtProUnitPrice.SelectedText = "";
            txtProUnitPrice.ShadowDecoration.CustomizableEdges = customizableEdges22;
            txtProUnitPrice.Size = new Size(223, 39);
            txtProUnitPrice.TabIndex = 8;
            // 
            // txtProWeight
            // 
            txtProWeight.BorderRadius = 18;
            txtProWeight.CustomizableEdges = customizableEdges23;
            txtProWeight.DefaultText = "";
            txtProWeight.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtProWeight.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtProWeight.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtProWeight.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtProWeight.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtProWeight.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtProWeight.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtProWeight.Location = new Point(158, 231);
            txtProWeight.Margin = new Padding(4, 5, 4, 5);
            txtProWeight.Name = "txtProWeight";
            txtProWeight.PasswordChar = '\0';
            txtProWeight.PlaceholderText = "";
            txtProWeight.SelectedText = "";
            txtProWeight.ShadowDecoration.CustomizableEdges = customizableEdges24;
            txtProWeight.Size = new Size(223, 39);
            txtProWeight.TabIndex = 7;
            txtProWeight.TextChanged += txtProWeight_TextChanged;
            // 
            // txtProName
            // 
            txtProName.BorderRadius = 18;
            txtProName.CustomizableEdges = customizableEdges25;
            txtProName.DefaultText = "";
            txtProName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtProName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtProName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtProName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtProName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtProName.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtProName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtProName.Location = new Point(158, 173);
            txtProName.Margin = new Padding(4, 5, 4, 5);
            txtProName.Name = "txtProName";
            txtProName.PasswordChar = '\0';
            txtProName.PlaceholderText = "";
            txtProName.SelectedText = "";
            txtProName.ShadowDecoration.CustomizableEdges = customizableEdges26;
            txtProName.Size = new Size(223, 39);
            txtProName.TabIndex = 6;
            txtProName.TextChanged += guna2TextBox1_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(35, 345);
            label4.Name = "label4";
            label4.Size = new Size(118, 23);
            label4.TabIndex = 5;
            label4.Text = "UnitInStock:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(36, 296);
            label3.Name = "label3";
            label3.Size = new Size(102, 23);
            label3.TabIndex = 4;
            label3.Text = "Unit Price:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(36, 247);
            label2.Name = "label2";
            label2.Size = new Size(77, 23);
            label2.TabIndex = 3;
            label2.Text = "Weight:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(36, 189);
            label1.Name = "label1";
            label1.Size = new Size(66, 23);
            label1.TabIndex = 2;
            label1.Text = "Name:";
            // 
            // txtProID
            // 
            txtProID.BorderRadius = 18;
            txtProID.CustomizableEdges = customizableEdges27;
            txtProID.DefaultText = "";
            txtProID.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtProID.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtProID.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtProID.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtProID.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtProID.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtProID.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtProID.Location = new Point(158, 115);
            txtProID.Margin = new Padding(4, 5, 4, 5);
            txtProID.Name = "txtProID";
            txtProID.PasswordChar = '\0';
            txtProID.PlaceholderText = "";
            txtProID.SelectedText = "";
            txtProID.ShadowDecoration.CustomizableEdges = customizableEdges28;
            txtProID.Size = new Size(223, 39);
            txtProID.TabIndex = 1;
            // 
            // ID
            // 
            ID.AutoSize = true;
            ID.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ID.Location = new Point(36, 131);
            ID.Name = "ID";
            ID.Size = new Size(38, 23);
            ID.TabIndex = 0;
            ID.Text = "ID:";
            ID.Click += txtProID_Click;
            // 
            // btnMember
            // 
            btnMember.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnMember.ForeColor = Color.Goldenrod;
            btnMember.Location = new Point(12, 118);
            btnMember.Name = "btnMember";
            btnMember.Size = new Size(107, 36);
            btnMember.TabIndex = 65;
            btnMember.Text = "Member";
            btnMember.UseVisualStyleBackColor = true;
            btnMember.Click += btnMember_Click;
            // 
            // btnCategory
            // 
            btnCategory.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnCategory.ForeColor = Color.Goldenrod;
            btnCategory.Location = new Point(12, 179);
            btnCategory.Name = "btnCategory";
            btnCategory.Size = new Size(107, 36);
            btnCategory.TabIndex = 66;
            btnCategory.Text = "Category";
            btnCategory.UseVisualStyleBackColor = true;
            btnCategory.Click += btnCategory_Click;
            // 
            // btnOrder
            // 
            btnOrder.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnOrder.ForeColor = Color.Goldenrod;
            btnOrder.Location = new Point(12, 237);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(107, 36);
            btnOrder.TabIndex = 67;
            btnOrder.Text = "Order";
            btnOrder.UseVisualStyleBackColor = true;
            btnOrder.Click += btnOrder_Click;
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnLogout.ForeColor = Color.Goldenrod;
            btnLogout.Location = new Point(12, 628);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(107, 36);
            btnLogout.TabIndex = 68;
            btnLogout.Text = "Log out";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // ProductManagement
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1141, 676);
            Controls.Add(btnLogout);
            Controls.Add(btnOrder);
            Controls.Add(btnCategory);
            Controls.Add(btnMember);
            Controls.Add(panel1);
            Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "ProductManagement";
            Text = "SaleManagement";
            Load += ProductManagement_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox txtProID;
        private Label ID;
        private Guna.UI2.WinForms.Guna2TextBox txtProStock;
        private Guna.UI2.WinForms.Guna2TextBox txtProUnitPrice;
        private Guna.UI2.WinForms.Guna2TextBox txtProWeight;
        private Guna.UI2.WinForms.Guna2TextBox txtProName;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
        private Label label6;
        private Button btnProDelete;
        private Button btnProUpdate;
        private Button btnProAdd;
        private Button btnFilter;
        private Button btnMember;
        private Button btnCategory;
        private Button btnOrder;
        private Button btnLogout;
        private Guna.UI2.WinForms.Guna2ComboBox cbbCat;
        private Guna.UI2.WinForms.Guna2DataGridView dgvProduct;
        private TextBox txtByStock;
        private TextBox txtByPrice;
        private TextBox txtByName;
        private TextBox txtByID;
        private Button btnByUnit;
        private Button btnByPrice;
        private Button btnByName;
        private Button btnByID;
        private Button button1;
        private Button button2;
        private Guna.UI2.WinForms.Guna2TextBox txtFilter;
    }
}