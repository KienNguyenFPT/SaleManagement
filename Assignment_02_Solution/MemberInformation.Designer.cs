namespace Assignment_02_Solution
{
    partial class MemberInformation
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
            btnUpdate = new Button();
            txtMemPassword = new TextBox();
            txtMemEmail = new TextBox();
            txtMemCountry = new TextBox();
            txtMemCity = new TextBox();
            txtMemCompany = new TextBox();
            txtMemID = new TextBox();
            label6 = new Label();
            label8 = new Label();
            btnLogout = new Button();
            label9 = new Label();
            label10 = new Label();
            label12 = new Label();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label11 = new Label();
            panel1 = new Panel();
            dgvMember = new DataGridView();
            dgvOrder = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMember).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).BeginInit();
            SuspendLayout();
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(21, 475);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.RightToLeft = RightToLeft.Yes;
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 62;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtMemPassword
            // 
            txtMemPassword.HideSelection = false;
            txtMemPassword.Location = new Point(168, 410);
            txtMemPassword.Name = "txtMemPassword";
            txtMemPassword.Size = new Size(202, 28);
            txtMemPassword.TabIndex = 60;
            // 
            // txtMemEmail
            // 
            txtMemEmail.Location = new Point(168, 340);
            txtMemEmail.Name = "txtMemEmail";
            txtMemEmail.Size = new Size(202, 28);
            txtMemEmail.TabIndex = 59;
            // 
            // txtMemCountry
            // 
            txtMemCountry.Location = new Point(168, 279);
            txtMemCountry.Name = "txtMemCountry";
            txtMemCountry.Size = new Size(202, 28);
            txtMemCountry.TabIndex = 58;
            // 
            // txtMemCity
            // 
            txtMemCity.Location = new Point(168, 226);
            txtMemCity.Name = "txtMemCity";
            txtMemCity.Size = new Size(202, 28);
            txtMemCity.TabIndex = 57;
            // 
            // txtMemCompany
            // 
            txtMemCompany.Location = new Point(168, 165);
            txtMemCompany.Name = "txtMemCompany";
            txtMemCompany.Size = new Size(202, 28);
            txtMemCompany.TabIndex = 56;
            // 
            // txtMemID
            // 
            txtMemID.Location = new Point(168, 108);
            txtMemID.Name = "txtMemID";
            txtMemID.Size = new Size(202, 28);
            txtMemID.TabIndex = 55;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 172);
            label6.Name = "label6";
            label6.Size = new Size(140, 20);
            label6.TabIndex = 54;
            label6.Text = "Company Name:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(21, 347);
            label8.Name = "label8";
            label8.Size = new Size(59, 20);
            label8.TabIndex = 53;
            label8.Text = "Email:";
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnLogout.ForeColor = Color.Goldenrod;
            btnLogout.Location = new Point(10, 633);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(107, 36);
            btnLogout.TabIndex = 77;
            btnLogout.Text = "Log out";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(21, 417);
            label9.Name = "label9";
            label9.Size = new Size(87, 20);
            label9.TabIndex = 52;
            label9.Text = "Password:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(21, 233);
            label10.Name = "label10";
            label10.Size = new Size(47, 20);
            label10.TabIndex = 51;
            label10.Text = "City:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(21, 115);
            label12.Name = "label12";
            label12.Size = new Size(34, 20);
            label12.TabIndex = 49;
            label12.Text = "ID:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Black", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(309, 26);
            label7.Name = "label7";
            label7.Size = new Size(358, 38);
            label7.TabIndex = 33;
            label7.Text = "MEMBER INFORMATION";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(-103, 347);
            label5.Name = "label5";
            label5.Size = new Size(59, 20);
            label5.TabIndex = 22;
            label5.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(-103, 404);
            label4.Name = "label4";
            label4.Size = new Size(87, 20);
            label4.TabIndex = 21;
            label4.Text = "Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(-103, 223);
            label3.Name = "label3";
            label3.Size = new Size(47, 20);
            label3.TabIndex = 20;
            label3.Text = "City:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(-103, 286);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 19;
            label2.Text = "Country:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(-103, 101);
            label1.Name = "label1";
            label1.Size = new Size(34, 20);
            label1.TabIndex = 18;
            label1.Text = "ID:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(21, 286);
            label11.Name = "label11";
            label11.Size = new Size(79, 20);
            label11.TabIndex = 50;
            label11.Text = "Country:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Beige;
            panel1.Controls.Add(dgvOrder);
            panel1.Controls.Add(dgvMember);
            panel1.Controls.Add(btnUpdate);
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
            panel1.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(141, 7);
            panel1.Name = "panel1";
            panel1.Size = new Size(994, 662);
            panel1.TabIndex = 73;
            panel1.Paint += panel1_Paint;
            // 
            // dgvMember
            // 
            dgvMember.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMember.Location = new Point(412, 108);
            dgvMember.Name = "dgvMember";
            dgvMember.RowHeadersWidth = 51;
            dgvMember.RowTemplate.Height = 29;
            dgvMember.Size = new Size(574, 176);
            dgvMember.TabIndex = 63;
            dgvMember.Click += dgvMember_Click_1;
            // 
            // dgvOrder
            // 
            dgvOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrder.Location = new Point(412, 340);
            dgvOrder.Name = "dgvOrder";
            dgvOrder.RowHeadersWidth = 51;
            dgvOrder.RowTemplate.Height = 29;
            dgvOrder.Size = new Size(574, 176);
            dgvOrder.TabIndex = 64;
            // 
            // MemberInformation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1141, 676);
            Controls.Add(btnLogout);
            Controls.Add(panel1);
            Name = "MemberInformation";
            Text = "MemberInformation";
            Load += MemberInformation_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMember).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnUpdate;
        private TextBox txtMemPassword;
        private TextBox txtMemEmail;
        private TextBox txtMemCountry;
        private TextBox txtMemCity;
        private TextBox txtMemCompany;
        private TextBox txtMemID;
        private Label label6;
        private Label label8;
        private Button btnLogout;
        private Label label9;
        private Label label10;
        private Label label12;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label11;
        private Panel panel1;
        private DataGridView dgvMember;
        private DataGridView dgvOrder;
    }
}