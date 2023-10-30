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
    public partial class ProductManagement : Form
    {
        DBContext db = new DBContext();
        public ProductManagement()
        {
            InitializeComponent();
        }

        // Change to Category Management Form
        private void btnCategory_Click(object sender, EventArgs e)
        {
            CategoryManagement cm = new CategoryManagement();
            cm.StartPosition = FormStartPosition.CenterScreen;
            cm.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            lf.StartPosition = FormStartPosition.CenterScreen;
            lf.Show();
            this.Hide();
        }

        private void btnMember_Click(object sender, EventArgs e)
        {
            MemberManagement cm = new MemberManagement();
            cm.StartPosition = FormStartPosition.CenterScreen;
            cm.Show();
            this.Hide();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            OrderManagement om = new OrderManagement();
            om.StartPosition = FormStartPosition.CenterScreen;
            om.Show();
            this.Hide();
        }

        //---------------------------------------------------

        //Load category
        private void getCategory()
        {
            try
            {
                string selectQuery = "select * from Category";
                SqlCommand cmd = new SqlCommand(selectQuery, db.GetConn());
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                cbbCat.DataSource = dt;
                cbbCat.ValueMember = "CatName";
                //cbbCat_Filter.DataSource = dt;
                //cbbCat_Filter.ValueMember = "CatName";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        //Load table Product 
        private void getProduct()
        {
            try
            {
                string selectQuery = "select * from Product";
                SqlCommand cmd = new SqlCommand(selectQuery, db.GetConn());
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvProduct.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getProduct();
        }
        private void ProductManagement_Load(object sender, EventArgs e)
        {
            getCategory();
            getProduct();
        }

        //Add Product
        private void btnProAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtProID.Text == "" || txtProName.Text == "" || txtProWeight.Text == "" ||
                    txtProUnitPrice.Text == "" || txtProStock.Text == "")
                {
                    MessageBox.Show("Please input all of the information", "Warning information",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string insertQuery = "insert into Product values('" + txtProID.Text + "', '" + txtProName.Text + "', '" + txtProWeight.Text + "', '" + txtProUnitPrice.Text + "', '" + txtProStock.Text + "','" + cbbCat.Text + "')";
                    SqlCommand cmd = new SqlCommand(insertQuery, db.GetConn());
                    db.OpenConn();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Insert new product successfully!", "Add new product",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    getProduct();
                    Clear();
                    db.CloseConn();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Choose object to Update
        private void dgvProduct_Click(object sender, EventArgs e)
        {
            txtProID.Text = dgvProduct.SelectedRows[0].Cells[0].Value.ToString();
            txtProName.Text = dgvProduct.SelectedRows[0].Cells[1].Value.ToString();
            txtProWeight.Text = dgvProduct.SelectedRows[0].Cells[2].Value.ToString();
            txtProUnitPrice.Text = dgvProduct.SelectedRows[0].Cells[3].Value.ToString();
            txtProStock.Text = dgvProduct.SelectedRows[0].Cells[4].Value.ToString();
            cbbCat.Text = dgvProduct.SelectedRows[0].Cells[5].Value.ToString();
            txtProID.ReadOnly = true;
        }

        //Update 
        private void btnProUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtProID.Text == "" || txtProName.Text == "" || txtProWeight.Text == "" ||
                    txtProUnitPrice.Text == "" || txtProStock.Text == "")
                {
                    MessageBox.Show("Please input all of the information", "Warning information",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string updateQuery = "update Product set ProName = '" + txtProName.Text + "', ProWeight = '" + txtProWeight.Text + "', ProPrice = '" + txtProUnitPrice.Text + "', \r\nProStock = '" + txtProStock.Text + "', ProCat = '" + cbbCat.Text + "' where ProID = '" + txtProID.Text + "'";
                    SqlCommand cmd = new SqlCommand(updateQuery, db.GetConn());
                    db.OpenConn();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Update this product successfully!", "Update infor product",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    getProduct();
                    //Clear();
                    db.CloseConn();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // delete 
        private void btnProDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtProID.Text == "" || txtProName.Text == "" || txtProWeight.Text == "" ||
                    txtProUnitPrice.Text == "" || txtProStock.Text == "")
                {
                    MessageBox.Show("Please input all of the information", "Warning information",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Are you sure to delete this product?", "Confirmation",
                                              MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                        string deleteQuery = "delete from Product where ProID = '" + txtProID.Text + "'";
                        SqlCommand cmd = new SqlCommand(deleteQuery, db.GetConn());
                        db.OpenConn();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("The product was deleted successfully!", "Delete Product",
                                         MessageBoxButtons.OK, MessageBoxIcon.Information);
                        getProduct();
                        Clear();
                        db.CloseConn();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Search by ID
        private void SearchByID()
        {
            try
            {
                string inputId = txtByID.Text;
                string searchQuery = "select * from Product where ProID = '" + txtByID.Text + "'";
                SqlCommand cmd = new SqlCommand(searchQuery, db.GetConn());
                db.OpenConn();
                //cmd.Parameters.AddWithValue("", inputId);
                cmd.ExecuteNonQuery();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvProduct.DataSource = dt;
                txtByID.Text = "";
                db.CloseConn();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void searchByPrice()
        {
            try
            {
                string searchQuery = "select * from Product where ProPrice = '" + txtByPrice.Text + "'";
                SqlCommand cmd = new SqlCommand(searchQuery, db.GetConn());
                db.OpenConn();
                //cmd.Parameters.AddWithValue("", inputId);
                cmd.ExecuteNonQuery();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvProduct.DataSource = dt;
                txtByPrice.Text = "";
                db.CloseConn();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void searchByStock()
        {
            try
            {
                string searchQuery = "select * from Product where ProStock = '" + txtByStock.Text + "'";
                SqlCommand cmd = new SqlCommand(searchQuery, db.GetConn());
                db.OpenConn();
                cmd.ExecuteNonQuery();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvProduct.DataSource = dt;
                txtByStock.Text = "";
                db.CloseConn();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void btnByID_Click(object sender, EventArgs e)
        {
            if (txtByID.Text == "")
            {
                MessageBox.Show("Please input value!", "Warning Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else SearchByID();
        }

        private void searchByName()
        {
            try
            {
                string searchQuery = "select * from Product where ProName like '%" + txtByName.Text + "%';";
                SqlCommand cmd = new SqlCommand(searchQuery, db.GetConn());
                db.OpenConn();
                cmd.ExecuteNonQuery();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvProduct.DataSource = dt;
                txtByName.Text = "";
                db.CloseConn();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnByPrice_Click(object sender, EventArgs e)
        {
            if (txtByPrice.Text == "")
            {
                MessageBox.Show("Please input value!", "Warning Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else searchByPrice();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtByStock.Text == "")
            {
                MessageBox.Show("Please input value!", "Warning Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else searchByStock();
        }

        private void btnByName_Click(object sender, EventArgs e)
        {
            if (txtByName.Text == "")
            {
                MessageBox.Show("Please input value!", "Warning Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else searchByName();
        }
        //--------------------------------------------

        //Filter Category
        private void btnFilter_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFilter.Text == "")
                {
                    MessageBox.Show("Please input value!", "Warning Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string filterQuery = "select * from Product where ProCat = '" + txtFilter.Text + "'";
                    SqlCommand cmd = new SqlCommand(filterQuery, db.GetConn());
                    db.OpenConn();
                    cmd.ExecuteNonQuery();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvProduct.DataSource = dt;
                    txtFilter.Text = "";
                    db.CloseConn();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        //Clear method
        private void Clear()
        {
            txtProID.Text = "";
            txtProName.Text = "";
            txtProWeight.Text = "";
            txtProUnitPrice.Text = "";
            txtProStock.Text = "";
            cbbCat.SelectedIndex = 0;
        }

        //Filter by Category 
        private void cbbCat_Filter_SelectedValueChanged(object sender, EventArgs e)
        {
            //string selectQuery = "select * from Product where ProCat = '" + cbbCat_Filter.Text + "'";
            //SqlCommand cmd = new SqlCommand(selectQuery, db.GetConn());
            //SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            //DataTable dt = new DataTable();
            //adapter.Fill(dt);
            //dgvProduct.DataSource = dt;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtProID_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbbCat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtProWeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
