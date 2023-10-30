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
    public partial class CategoryManagement : Form
    {
        DBContext db = new DBContext();
        public CategoryManagement()
        {
            InitializeComponent();
        }

        private void CategoryManagement_Load(object sender, EventArgs e)
        {
            getTableCategory();
        }
        //get Category
        private void getTableCategory()
        {
            try
            {
                string selectQuery = "select * from Category";
                SqlCommand cmd = new SqlCommand(selectQuery, db.GetConn());
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvCategory.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        //Change to NewForm

        private void btnMember_Click_1(object sender, EventArgs e)
        {
            MemberManagement mb = new MemberManagement();
            mb.StartPosition = FormStartPosition.CenterScreen;
            mb.Show();
            this.Hide();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            ProductManagement mb = new ProductManagement();
            mb.StartPosition = FormStartPosition.CenterScreen;
            mb.Show();
            this.Hide();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            OrderManagement mb = new OrderManagement();
            mb.StartPosition = FormStartPosition.CenterScreen;
            mb.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.StartPosition = FormStartPosition.CenterScreen;
            loginForm.Show();
            this.Hide();
        }

        //--------------------------------------
        private void Clear()
        {
            txtCatID.Text = "";
            txtCatName.Text = "";
            txtCatDes.Text = "";
        }

        //Add Category
        private void btnCatAdd_Click(object sender, EventArgs e)
        {
            if (txtCatID.Text == "" || txtCatDes.Text == "" || txtCatName.Text == "")
            {
                MessageBox.Show("Please fulfill value!", "Warning information", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    string insertQuery = "insert into Category values(" + txtCatID.Text + ", '" + txtCatName.Text + "', '" + txtCatDes.Text + "')";
                    SqlCommand cmd = new SqlCommand(insertQuery, db.GetConn());
                    db.OpenConn();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("This category was added successfully!",
                                    "Add New Category", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                    getTableCategory();
                    db.CloseConn();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }           
        }

        //Click to Update
        private void dgvCategory_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtCatID.Text = dgvCategory.SelectedRows[0].Cells[0].Value.ToString();
            txtCatName.Text = dgvCategory.SelectedRows[0].Cells[1].Value.ToString();
            txtCatDes.Text = dgvCategory.SelectedRows[0].Cells[2].Value.ToString();
            txtCatID.ReadOnly = true;
        }

        // Update info Category
        private void btnCatUpdate_Click(object sender, EventArgs e)
        {
            if (txtCatID.Text == "" || txtCatDes.Text == "" || txtCatName.Text == "")
            {
                MessageBox.Show("Please fulfill input!", "Warning information",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    string updateQuery = "update Category set CatName = '" + txtCatName.Text + "', CatDes = '" + txtCatDes.Text + "' where\r\nCatID = '" + txtCatID.Text + "'";
                    SqlCommand cmd = new SqlCommand(updateQuery, db.GetConn());
                    db.OpenConn();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("The category was updated successfully!",
                                    "Update Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    getTableCategory();
                    db.CloseConn();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }     
        }

        // Delete Category
        private void btnCatDelete_Click(object sender, EventArgs e)
        {
            if (txtCatID.Text == "" || txtCatDes.Text == "" || txtCatName.Text == "")
            {
                MessageBox.Show("Please choose category!", "Warning information",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    DialogResult dr = MessageBox.Show("Are you sure to delete this category?",
                                                      "Confirmation", MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        string deleteQuery = "delete Category where CatID = '" + txtCatID.Text + "'";
                        SqlCommand cmd = new SqlCommand(deleteQuery, db.GetConn());
                        db.OpenConn();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("The category was deleted successfully!",
                                        "Delete Category", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear();
                        getTableCategory();
                        db.CloseConn();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
