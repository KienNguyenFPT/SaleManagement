namespace Assignment_02_Solution
{
    partial class MemberManagement
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
            dgvMember = new Guna.UI2.WinForms.Guna2DataGridView();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            txtMemPassword = new TextBox();
            txtMemEmail = new TextBox();
            txtMemCountry = new TextBox();
            txtMemCity = new TextBox();
            txtMemCompany = new TextBox();
            txtMemID = new TextBox();
            label6 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnLogout = new Button();
            btnOrder = new Button();
            btnCategory = new Button();
            btnProduct = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMember).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Beige;
            panel1.Controls.Add(dgvMember);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(txtMemPassword);
            panel1.Controls.Add(txtMemEmail);
            panel1.Controls.Add(txtMemCountry);
            panel1.Controls.Add(txtMemCity);
            panel1.Controls.Add(txtMemCompany);
            panel1.Controls.Add(txtMemID);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(143, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(990, 662);
            panel1.TabIndex = 0;
            // 
            // dgvMember
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvMember.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvMember.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvMember.ColumnHeadersHeight = 24;
            dgvMember.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvMember.DefaultCellStyle = dataGridViewCellStyle3;
            dgvMember.GridColor = Color.FromArgb(231, 229, 255);
            dgvMember.Location = new Point(459, 108);
            dgvMember.Name = "dgvMember";
            dgvMember.RowHeadersVisible = false;
            dgvMember.RowHeadersWidth = 51;
            dgvMember.RowTemplate.Height = 29;
            dgvMember.Size = new Size(527, 544);
            dgvMember.TabIndex = 64;
            dgvMember.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvMember.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvMember.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvMember.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvMember.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvMember.ThemeStyle.BackColor = Color.White;
            dgvMember.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvMember.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvMember.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvMember.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dgvMember.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvMember.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvMember.ThemeStyle.HeaderStyle.Height = 24;
            dgvMember.ThemeStyle.ReadOnly = false;
            dgvMember.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvMember.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvMember.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dgvMember.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvMember.ThemeStyle.RowsStyle.Height = 29;
            dgvMember.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvMember.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgvMember.CellContentClick += dgvMember_CellContentClick;
            dgvMember.Click += dgvMember_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(328, 476);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 63;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(193, 476);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.RightToLeft = RightToLeft.Yes;
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 62;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(55, 476);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 61;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtMemPassword
            // 
            txtMemPassword.HideSelection = false;
            txtMemPassword.Location = new Point(168, 410);
            txtMemPassword.Name = "txtMemPassword";
            txtMemPassword.Size = new Size(269, 27);
            txtMemPassword.TabIndex = 60;
            txtMemPassword.UseSystemPasswordChar = true;
            // 
            // txtMemEmail
            // 
            txtMemEmail.Location = new Point(168, 340);
            txtMemEmail.Name = "txtMemEmail";
            txtMemEmail.Size = new Size(269, 27);
            txtMemEmail.TabIndex = 59;
            // 
            // txtMemCountry
            // 
            txtMemCountry.Location = new Point(168, 279);
            txtMemCountry.Name = "txtMemCountry";
            txtMemCountry.Size = new Size(269, 27);
            txtMemCountry.TabIndex = 58;
            // 
            // txtMemCity
            // 
            txtMemCity.Location = new Point(168, 226);
            txtMemCity.Name = "txtMemCity";
            txtMemCity.Size = new Size(269, 27);
            txtMemCity.TabIndex = 57;
            // 
            // txtMemCompany
            // 
            txtMemCompany.Location = new Point(168, 165);
            txtMemCompany.Name = "txtMemCompany";
            txtMemCompany.Size = new Size(269, 27);
            txtMemCompany.TabIndex = 56;
            // 
            // txtMemID
            // 
            txtMemID.Location = new Point(168, 108);
            txtMemID.Name = "txtMemID";
            txtMemID.Size = new Size(269, 27);
            txtMemID.TabIndex = 55;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 172);
            label6.Name = "label6";
            label6.Size = new Size(119, 20);
            label6.TabIndex = 54;
            label6.Text = "Company Name:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(21, 347);
            label8.Name = "label8";
            label8.Size = new Size(49, 20);
            label8.TabIndex = 53;
            label8.Text = "Email:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(21, 417);
            label9.Name = "label9";
            label9.Size = new Size(73, 20);
            label9.TabIndex = 52;
            label9.Text = "Password:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(21, 233);
            label10.Name = "label10";
            label10.Size = new Size(37, 20);
            label10.TabIndex = 51;
            label10.Text = "City:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(21, 286);
            label11.Name = "label11";
            label11.Size = new Size(63, 20);
            label11.TabIndex = 50;
            label11.Text = "Country:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(21, 115);
            label12.Name = "label12";
            label12.Size = new Size(27, 20);
            label12.TabIndex = 49;
            label12.Text = "ID:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Black", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(309, 26);
            label7.Name = "label7";
            label7.Size = new Size(362, 38);
            label7.TabIndex = 33;
            label7.Text = "MEMBER MANAGEMENT";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(-103, 347);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 22;
            label5.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(-103, 404);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 21;
            label4.Text = "Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(-103, 223);
            label3.Name = "label3";
            label3.Size = new Size(37, 20);
            label3.TabIndex = 20;
            label3.Text = "City:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(-103, 286);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 19;
            label2.Text = "Country:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(-103, 101);
            label1.Name = "label1";
            label1.Size = new Size(27, 20);
            label1.TabIndex = 18;
            label1.Text = "ID:";
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnLogout.ForeColor = Color.Goldenrod;
            btnLogout.Location = new Point(12, 638);
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
            btnOrder.Location = new Point(12, 247);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(107, 36);
            btnOrder.TabIndex = 71;
            btnOrder.Text = "Order";
            btnOrder.UseVisualStyleBackColor = true;
            btnOrder.Click += btnOrder_Click;
            // 
            // btnCategory
            // 
            btnCategory.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnCategory.ForeColor = Color.Goldenrod;
            btnCategory.Location = new Point(12, 189);
            btnCategory.Name = "btnCategory";
            btnCategory.Size = new Size(107, 36);
            btnCategory.TabIndex = 70;
            btnCategory.Text = "Category";
            btnCategory.UseVisualStyleBackColor = true;
            btnCategory.Click += btnCategory_Click;
            // 
            // btnProduct
            // 
            btnProduct.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnProduct.ForeColor = Color.Goldenrod;
            btnProduct.Location = new Point(12, 128);
            btnProduct.Name = "btnProduct";
            btnProduct.Size = new Size(107, 36);
            btnProduct.TabIndex = 69;
            btnProduct.Text = "Product";
            btnProduct.UseVisualStyleBackColor = true;
            btnProduct.Click += btnProduct_Click;
            // 
            // MemberManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1141, 676);
            Controls.Add(btnLogout);
            Controls.Add(btnOrder);
            Controls.Add(btnCategory);
            Controls.Add(btnProduct);
            Controls.Add(panel1);
            Name = "MemberManagement";
            Text = "MemberManagement";
            Load += MemberManagement_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMember).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvMember;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private TextBox txtMemPassword;
        private TextBox txtMemEmail;
        private TextBox txtMemCountry;
        private TextBox txtMemCity;
        private TextBox txtMemCompany;
        private TextBox txtMemID;
        private Label label6;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Button btnLogout;
        private Button btnOrder;
        private Button btnCategory;
        private Button btnProduct;
    }
}