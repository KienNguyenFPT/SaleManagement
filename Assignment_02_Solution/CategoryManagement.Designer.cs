namespace Assignment_02_Solution
{
    partial class CategoryManagement
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            dgvCategory = new Guna.UI2.WinForms.Guna2DataGridView();
            label7 = new Label();
            btnCatDelete = new Button();
            btnCatUpdate = new Button();
            btnCatAdd = new Button();
            txtCatDes = new TextBox();
            txtCatName = new TextBox();
            txtCatID = new TextBox();
            label6 = new Label();
            Descrip = new Label();
            label1 = new Label();
            btnLogout = new Button();
            btnOrder = new Button();
            btnProduct = new Button();
            btnMember = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategory).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Khaki;
            panel1.Controls.Add(dgvCategory);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(btnCatDelete);
            panel1.Controls.Add(btnCatUpdate);
            panel1.Controls.Add(btnCatAdd);
            panel1.Controls.Add(txtCatDes);
            panel1.Controls.Add(txtCatName);
            panel1.Controls.Add(txtCatID);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(Descrip);
            panel1.Controls.Add(label1);
            panel1.Font = new Font("Times New Roman", 10.8F, FontStyle.Italic, GraphicsUnit.Point);
            panel1.Location = new Point(143, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(990, 662);
            panel1.TabIndex = 0;
            // 
            // dgvCategory
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvCategory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 10.8F, FontStyle.Italic, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvCategory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvCategory.ColumnHeadersHeight = 24;
            dgvCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Times New Roman", 10.8F, FontStyle.Italic, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvCategory.DefaultCellStyle = dataGridViewCellStyle3;
            dgvCategory.GridColor = Color.FromArgb(231, 229, 255);
            dgvCategory.Location = new Point(482, 122);
            dgvCategory.Name = "dgvCategory";
            dgvCategory.RowHeadersVisible = false;
            dgvCategory.RowHeadersWidth = 51;
            dgvCategory.RowTemplate.Height = 29;
            dgvCategory.Size = new Size(504, 485);
            dgvCategory.TabIndex = 27;
            dgvCategory.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvCategory.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvCategory.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvCategory.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvCategory.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvCategory.ThemeStyle.BackColor = Color.White;
            dgvCategory.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvCategory.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvCategory.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvCategory.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dgvCategory.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvCategory.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvCategory.ThemeStyle.HeaderStyle.Height = 24;
            dgvCategory.ThemeStyle.ReadOnly = false;
            dgvCategory.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvCategory.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvCategory.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dgvCategory.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvCategory.ThemeStyle.RowsStyle.Height = 29;
            dgvCategory.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvCategory.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
//            dgvCategory.CellContentClick += dgvCategory_CellContentClick;
            dgvCategory.CellMouseClick += dgvCategory_CellMouseClick;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Black", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(310, 39);
            label7.Name = "label7";
            label7.Size = new Size(386, 38);
            label7.TabIndex = 26;
            label7.Text = "CATEGORY MANAGEMENT";
            // 
            // btnCatDelete
            // 
            btnCatDelete.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCatDelete.Location = new Point(320, 301);
            btnCatDelete.Name = "btnCatDelete";
            btnCatDelete.Size = new Size(94, 29);
            btnCatDelete.TabIndex = 25;
            btnCatDelete.Text = "Delete";
            btnCatDelete.UseVisualStyleBackColor = true;
            btnCatDelete.Click += btnCatDelete_Click;
            // 
            // btnCatUpdate
            // 
            btnCatUpdate.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCatUpdate.Location = new Point(192, 301);
            btnCatUpdate.Name = "btnCatUpdate";
            btnCatUpdate.RightToLeft = RightToLeft.Yes;
            btnCatUpdate.Size = new Size(94, 29);
            btnCatUpdate.TabIndex = 24;
            btnCatUpdate.Text = "Update";
            btnCatUpdate.UseVisualStyleBackColor = true;
            btnCatUpdate.Click += btnCatUpdate_Click;
            // 
            // btnCatAdd
            // 
            btnCatAdd.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCatAdd.Location = new Point(60, 301);
            btnCatAdd.Name = "btnCatAdd";
            btnCatAdd.Size = new Size(94, 29);
            btnCatAdd.TabIndex = 23;
            btnCatAdd.Text = "Add";
            btnCatAdd.UseVisualStyleBackColor = true;
            btnCatAdd.Click += btnCatAdd_Click;
            // 
            // txtCatDes
            // 
            txtCatDes.Location = new Point(174, 238);
            txtCatDes.Name = "txtCatDes";
            txtCatDes.Size = new Size(269, 28);
            txtCatDes.TabIndex = 22;
            // 
            // txtCatName
            // 
            txtCatName.Location = new Point(174, 174);
            txtCatName.Name = "txtCatName";
            txtCatName.Size = new Size(269, 28);
            txtCatName.TabIndex = 21;
            // 
            // txtCatID
            // 
            txtCatID.Location = new Point(174, 122);
            txtCatID.Name = "txtCatID";
            txtCatID.Size = new Size(269, 28);
            txtCatID.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(23, 183);
            label6.Name = "label6";
            label6.Size = new Size(66, 23);
            label6.TabIndex = 19;
            label6.Text = "Name:";
            // 
            // Descrip
            // 
            Descrip.AutoSize = true;
            Descrip.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Descrip.Location = new Point(23, 241);
            Descrip.Name = "Descrip";
            Descrip.Size = new Size(105, 23);
            Descrip.TabIndex = 18;
            Descrip.Text = "Desciption:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(23, 122);
            label1.Name = "label1";
            label1.Size = new Size(38, 23);
            label1.TabIndex = 17;
            label1.Text = "ID:";
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnLogout.ForeColor = Color.Goldenrod;
            btnLogout.Location = new Point(12, 635);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(107, 36);
            btnLogout.TabIndex = 72;
            btnLogout.Text = "Log out";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnOrder
            // 
            btnOrder.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnOrder.ForeColor = Color.Goldenrod;
            btnOrder.Location = new Point(12, 244);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(107, 36);
            btnOrder.TabIndex = 71;
            btnOrder.Text = "Order";
            btnOrder.UseVisualStyleBackColor = true;
            btnOrder.Click += btnOrder_Click;
            // 
            // btnProduct
            // 
            btnProduct.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnProduct.ForeColor = Color.Goldenrod;
            btnProduct.Location = new Point(12, 186);
            btnProduct.Name = "btnProduct";
            btnProduct.Size = new Size(107, 36);
            btnProduct.TabIndex = 70;
            btnProduct.Text = "Product";
            btnProduct.UseVisualStyleBackColor = true;
            btnProduct.Click += btnProduct_Click;
            // 
            // btnMember
            // 
            btnMember.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnMember.ForeColor = Color.Goldenrod;
            btnMember.Location = new Point(12, 126);
            btnMember.Name = "btnMember";
            btnMember.Size = new Size(107, 36);
            btnMember.TabIndex = 73;
            btnMember.Text = "Member";
            btnMember.UseVisualStyleBackColor = true;
            btnMember.Click += btnMember_Click_1;
            // 
            // CategoryManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1141, 676);
            Controls.Add(btnMember);
            Controls.Add(btnLogout);
            Controls.Add(panel1);
            Controls.Add(btnOrder);
            Controls.Add(btnProduct);
            Name = "CategoryManagement";
            Text = "CategoryManagement";
            Load += CategoryManagement_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategory).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvCategory;
        private Label label7;
        private Button btnCatDelete;
        private Button btnCatUpdate;
        private Button btnCatAdd;
        private TextBox txtCatDes;
        private TextBox txtCatName;
        private TextBox txtCatID;
        private Label label6;
        private Label Descrip;
        private Label label1;
        private Button btnLogout;
        private Button btnOrder;
        private Button btnProduct;
        private Button btnMember;
    }
}