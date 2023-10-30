using Assignment_02_Solution.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_02_Solution
{
    public partial class MemberManagement : Form
    {
        DBContext db = new DBContext();
        public MemberManagement()
        {
            InitializeComponent();
        }

        private void MemberManagement_Load(object sender, EventArgs e)
        {
            getTableMember();
        }
        //Clear
        private void Clear()
        {
            txtMemID.Text = "";
            txtMemCompany.Text = "";
            txtMemCity.Text = "";
            txtMemCountry.Text = "";
            txtMemEmail.Text = "";
            txtMemPassword.Text = "";
        }

        //Change to new form
        private void btnProduct_Click(object sender, EventArgs e)
        {
            ProductManagement pm = new ProductManagement();
            pm.StartPosition = FormStartPosition.CenterScreen;
            pm.Show();
            this.Hide();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            CategoryManagement pm = new CategoryManagement();
            pm.StartPosition = FormStartPosition.CenterScreen;
            pm.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.StartPosition = FormStartPosition.CenterScreen;
            loginForm.Show();
            this.Hide();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            OrderManagement pm = new OrderManagement();
            pm.StartPosition = FormStartPosition.CenterScreen;  
            pm.Show();  
            this.Hide();

        }

        //--------------------------------------------------------------

        private void getTableMember()
        {
            try
            {
                string selectQuery = "select * from Member";
                SqlCommand cmd = new SqlCommand(selectQuery, db.GetConn());
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvMember.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // add Member
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMemCompany.Text == "" || txtMemCity.Text == "" || txtMemCountry.Text == "" ||
                    txtMemEmail.Text == "" || txtMemPassword.Text == "")
                {
                    MessageBox.Show("Please input all of the data!", "Warning Information",
                                     MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string insertQuery = "insert into Member values (" + txtMemID.Text + ", '" + txtMemCompany.Text + "', '" + txtMemCity.Text + "', '" + txtMemCountry.Text + "', '" + txtMemEmail.Text + "', '" + txtMemPassword.Text + "')";
                    SqlCommand sqlCommand = new SqlCommand(insertQuery, db.GetConn());
                    db.OpenConn();
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("This member was added successfully!", "Add New Member",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    getTableMember();
                    Clear();
                    db.CloseConn();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Click to Update
        private void dgvMember_Click(object sender, EventArgs e)
        {
            txtMemID.Text = dgvMember.SelectedRows[0].Cells[0].Value.ToString();
            txtMemCompany.Text = dgvMember.SelectedRows[0].Cells[1].Value.ToString();
            txtMemCity.Text = dgvMember.SelectedRows[0].Cells[2].Value.ToString();
            txtMemCountry.Text = dgvMember.SelectedRows[0].Cells[3].Value.ToString();
            txtMemEmail.Text = dgvMember.SelectedRows[0].Cells[4].Value.ToString();
            txtMemPassword.Text = dgvMember.SelectedRows[0].Cells[5].Value.ToString();
            txtMemID.ReadOnly = true;
        }

        // Update info Member 
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMemCompany.Text == "" || txtMemCity.Text == "" || txtMemCountry.Text == "" ||
                    txtMemEmail.Text == "" || txtMemPassword.Text == "")
                {
                    MessageBox.Show("Please input all of the data!", "Warning Information",
                                     MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string updateQuery = "update Member set MemCompany = '" + txtMemCompany.Text + "', MemCity = '" + txtMemCity.Text + "', MemCountry = '" + txtMemCountry.Text + "',\r\nMemEmail = '" + txtMemEmail.Text + "', MemPassword = '" + txtMemPassword.Text + "' where MemID = '" + txtMemID.Text + "'";
                    SqlCommand cmd = new SqlCommand(updateQuery, db.GetConn());
                    db.OpenConn();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("The member was updated successfully!", "Update Information",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    getTableMember();
                    db.CloseConn();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        //Delete Member
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtMemCompany.Text == "" || txtMemCity.Text == "" || txtMemCountry.Text == "" ||
                    txtMemEmail.Text == "" || txtMemPassword.Text == "")
            {
                MessageBox.Show("Please choose member!", "Warning Information",
                                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult dr = MessageBox.Show("Are you sure to delete this member?", "Confirmation",
                                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                try
                {
                    if (dr == DialogResult.Yes)
                    {
                        string deleteQuery = "delete Member where MemID = '" + txtMemID.Text + "'";
                        SqlCommand cmd = new SqlCommand(deleteQuery, db.GetConn());
                        db.OpenConn();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("The member was deleted successfully!", "Delete Member",
                                         MessageBoxButtons.OK, MessageBoxIcon.Information);
                        getTableMember();
                        Clear();
                        db.CloseConn();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void dgvMember_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}
