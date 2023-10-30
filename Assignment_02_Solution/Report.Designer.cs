namespace Assignment_02_Solution
{
    partial class Report
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btnMember = new Button();
            btnLogout = new Button();
            btnCategory = new Button();
            btnProduct = new Button();
            panel1 = new Panel();
            btnGen = new Button();
            btnSort = new Button();
            dgvSale = new Guna.UI2.WinForms.Guna2DataGridView();
            dtpkEnd = new Guna.UI2.WinForms.Guna2DateTimePicker();
            dtpkStart = new Guna.UI2.WinForms.Guna2DateTimePicker();
            label1 = new Label();
            label4 = new Label();
            label6 = new Label();
            button1 = new Button();
            btnLoad = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSale).BeginInit();
            SuspendLayout();
            // 
            // btnMember
            // 
            btnMember.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnMember.ForeColor = Color.Goldenrod;
            btnMember.Location = new Point(10, 113);
            btnMember.Name = "btnMember";
            btnMember.Size = new Size(107, 36);
            btnMember.TabIndex = 75;
            btnMember.Text = "Member";
            btnMember.UseVisualStyleBackColor = true;
            btnMember.Click += btnMember_Click;
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnLogout.ForeColor = Color.Goldenrod;
            btnLogout.Location = new Point(10, 633);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(107, 36);
            btnLogout.TabIndex = 78;
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
            btnCategory.TabIndex = 76;
            btnCategory.Text = "Category";
            btnCategory.UseVisualStyleBackColor = true;
            btnCategory.Click += btnCategory_Click;
            // 
            // btnProduct
            // 
            btnProduct.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnProduct.ForeColor = Color.Goldenrod;
            btnProduct.Location = new Point(10, 232);
            btnProduct.Name = "btnProduct";
            btnProduct.Size = new Size(107, 36);
            btnProduct.TabIndex = 77;
            btnProduct.Text = "Product";
            btnProduct.UseVisualStyleBackColor = true;
            btnProduct.Click += btnProduct_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Goldenrod;
            panel1.Controls.Add(btnLoad);
            panel1.Controls.Add(btnGen);
            panel1.Controls.Add(btnSort);
            panel1.Controls.Add(dgvSale);
            panel1.Controls.Add(dtpkEnd);
            panel1.Controls.Add(dtpkStart);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label6);
            panel1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            panel1.Location = new Point(141, 7);
            panel1.Name = "panel1";
            panel1.Size = new Size(990, 662);
            panel1.TabIndex = 74;
            // 
            // btnGen
            // 
            btnGen.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnGen.ForeColor = Color.Goldenrod;
            btnGen.Location = new Point(716, 167);
            btnGen.Name = "btnGen";
            btnGen.Size = new Size(107, 36);
            btnGen.TabIndex = 106;
            btnGen.Text = "Generate";
            btnGen.UseVisualStyleBackColor = true;
            btnGen.Click += btnGen_Click;
            // 
            // btnSort
            // 
            btnSort.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnSort.ForeColor = Color.Goldenrod;
            btnSort.Location = new Point(854, 621);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(107, 36);
            btnSort.TabIndex = 105;
            btnSort.Text = "Sort";
            btnSort.UseVisualStyleBackColor = true;
            btnSort.Click += btnSort_Click;
            // 
            // dgvSale
            // 
            dataGridViewCellStyle4.BackColor = Color.White;
            dgvSale.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle5.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvSale.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvSale.ColumnHeadersHeight = 24;
            dgvSale.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvSale.DefaultCellStyle = dataGridViewCellStyle6;
            dgvSale.GridColor = Color.FromArgb(231, 229, 255);
            dgvSale.Location = new Point(63, 242);
            dgvSale.Name = "dgvSale";
            dgvSale.RowHeadersVisible = false;
            dgvSale.RowHeadersWidth = 51;
            dgvSale.RowTemplate.Height = 29;
            dgvSale.Size = new Size(787, 336);
            dgvSale.TabIndex = 104;
            dgvSale.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvSale.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvSale.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvSale.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvSale.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvSale.ThemeStyle.BackColor = Color.White;
            dgvSale.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvSale.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvSale.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvSale.ThemeStyle.HeaderStyle.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dgvSale.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvSale.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvSale.ThemeStyle.HeaderStyle.Height = 24;
            dgvSale.ThemeStyle.ReadOnly = false;
            dgvSale.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvSale.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvSale.ThemeStyle.RowsStyle.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dgvSale.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvSale.ThemeStyle.RowsStyle.Height = 29;
            dgvSale.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvSale.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // dtpkEnd
            // 
            dtpkEnd.Checked = true;
            dtpkEnd.CustomizableEdges = customizableEdges5;
            dtpkEnd.FillColor = Color.FromArgb(192, 255, 255);
            dtpkEnd.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            dtpkEnd.Format = DateTimePickerFormat.Long;
            dtpkEnd.Location = new Point(174, 155);
            dtpkEnd.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dtpkEnd.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtpkEnd.Name = "dtpkEnd";
            dtpkEnd.ShadowDecoration.CustomizableEdges = customizableEdges6;
            dtpkEnd.Size = new Size(515, 48);
            dtpkEnd.TabIndex = 97;
            dtpkEnd.Value = new DateTime(2023, 10, 30, 11, 24, 26, 82);
            // 
            // dtpkStart
            // 
            dtpkStart.Checked = true;
            dtpkStart.CustomizableEdges = customizableEdges7;
            dtpkStart.FillColor = Color.LightCyan;
            dtpkStart.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            dtpkStart.Format = DateTimePickerFormat.Long;
            dtpkStart.Location = new Point(174, 88);
            dtpkStart.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dtpkStart.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtpkStart.Name = "dtpkStart";
            dtpkStart.ShadowDecoration.CustomizableEdges = customizableEdges8;
            dtpkStart.Size = new Size(515, 48);
            dtpkStart.TabIndex = 96;
            dtpkStart.Value = new DateTime(2023, 10, 30, 11, 24, 26, 82);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(42, 180);
            label1.Name = "label1";
            label1.Size = new Size(96, 23);
            label1.TabIndex = 95;
            label1.Text = "End Date:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(42, 113);
            label4.Name = "label4";
            label4.Size = new Size(106, 23);
            label4.TabIndex = 94;
            label4.Text = "Start Date:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(248, 20);
            label6.Name = "label6";
            label6.Size = new Size(530, 35);
            label6.TabIndex = 80;
            label6.Text = "REPORT FOR SALE MANAGEMENT";
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.ForeColor = Color.Goldenrod;
            button1.Location = new Point(10, 297);
            button1.Name = "button1";
            button1.Size = new Size(107, 36);
            button1.TabIndex = 79;
            button1.Text = "Order";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnLoad
            // 
            btnLoad.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnLoad.ForeColor = Color.Goldenrod;
            btnLoad.Location = new Point(726, 621);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(107, 36);
            btnLoad.TabIndex = 107;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // Report
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1141, 676);
            Controls.Add(button1);
            Controls.Add(btnMember);
            Controls.Add(btnLogout);
            Controls.Add(btnCategory);
            Controls.Add(btnProduct);
            Controls.Add(panel1);
            Name = "Report";
            Text = "Report";
            Load += Report_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSale).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnMember;
        private Button btnLogout;
        private Button btnCategory;
        private Button btnProduct;
        private Panel panel1;
        private Button button1;
        private Label label6;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpkEnd;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpkStart;
        private Label label1;
        private Label label4;
        private Guna.UI2.WinForms.Guna2DataGridView dgvSale;
        private Button btnSort;
        private Button btnGen;
        private Button btnLoad;
    }
}