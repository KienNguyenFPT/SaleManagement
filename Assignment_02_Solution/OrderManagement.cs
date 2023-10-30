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
    public partial class OrderManagement : Form
    {
        DBContext db = new DBContext();
        public OrderManagement()
        {
            InitializeComponent();
        }
        //Change to new form
        private void btnMember_Click(object sender, EventArgs e)
        {
            MemberManagement memberManagement = new MemberManagement();
            memberManagement.StartPosition = FormStartPosition.CenterScreen;
            memberManagement.Show();
            this.Hide();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            CategoryManagement categoryManagement = new CategoryManagement();
            categoryManagement.StartPosition = FormStartPosition.CenterScreen;
            categoryManagement.Show();
            this.Hide();
        }
        private void btnProduct_Click(object sender, EventArgs e)
        {
            ProductManagement productManagement = new ProductManagement();
            productManagement.StartPosition = FormStartPosition.CenterScreen;
            productManagement.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.StartPosition = FormStartPosition.CenterScreen;
            loginForm.Show();
            this.Hide();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            Report rp = new Report();
            rp.StartPosition = FormStartPosition.CenterScreen;
            rp.Show();
            this.Hide();
        }

        //---------------------------------------------------

        //Load Method

        private void getOrder()
        {
            try
            {
                string selectQuery = "select * from Orders";
                SqlCommand cmd = new SqlCommand(selectQuery, db.GetConn());
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvOrder.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void getCategory()
        {
            try
            {
                string selectQuery = "select * from Category";
                SqlCommand cmd = new SqlCommand(selectQuery, db.GetConn());
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                //cbbCat.DataSource = dt;
                //cbbCat.ValueMember = "CatName";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void getOrderDetail()
        {
            try
            {
                string selectQuery = "select * from OrderDetail";
                SqlCommand cmd = new SqlCommand(selectQuery, db.GetConn());
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvOrderDetail.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void getMemID()
        {
            try
            {
                string selectQuery = "select * from Member";
                SqlCommand cmd = new SqlCommand(selectQuery, db.GetConn());
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                cbbMem.DataSource = dt;
                cbbMem.ValueMember = "MemID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void OrderManagement_Load(object sender, EventArgs e)
        {
            getMemID();
            getProID();
            getOrderID();
            getOrder();
            //getOrderDetail();
        }

        private void btnOrderLoad_Click(object sender, EventArgs e)
        {
            getOrder();
        }

        //----------------------------------------------

        //Click to Update
        //private void dgvProCat_Click(object sender, EventArgs e)
        //{
        //    txtProID.Text = dgvProCat.SelectedRows[0].Cells[1].Value.ToString();
        //    txtProPrice.Text = dgvProCat.SelectedRows[0].Cells[2].Value.ToString();
        //}

        //Add order detail
        //int grandTotal = 0, n = 0;
        //private void btnOrderAdd_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        //if (txtProID.Text == "" || txtQuantity.Text == "" || txtDiscount.Text == "" || txtProPrice.Text == "")
        //        //{
        //        //    MessageBox.Show("Please input all of the information", "Warning information",
        //        //       MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        //}
        //        //else
        //        //{
        //        //    int total = Convert.ToInt32(txtProPrice.Text) * Convert.ToInt32(txtQuantity.Text)
        //        //                                          - Convert.ToInt32(txtDiscount.Text);
        //        //    DataGridViewRow addRow = new DataGridViewRow();
        //        //    addRow.CreateCells(dgvOrderDetail);
        //        //    addRow.Cells[0].Value = ++n;
        //        //    addRow.Cells[1].Value = txtProID.Text;
        //        //    addRow.Cells[2].Value = txtProPrice.Text;
        //        //    addRow.Cells[3].Value = txtQuantity.Text;
        //        //    addRow.Cells[4].Value = txtDiscount.Text;
        //        //    addRow.Cells[5].Value = total;
        //        //    dgvOrderDetail.Rows.Add(addRow);
        //        //    grandTotal += total;
        //        //    lbAmount.Text = grandTotal + " VND";
        //        //}

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error: " + ex.Message);
        //    }
        //}
        //------------------------------------------------

        private void Clear()
        {
            txtOrderID.Text = "";
            cbbMem.Text = "";
            txtOrderDate.Text = "";
        }
        //Add order
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtOrderID.Text == "" || cbbMem.Text == "" || txtOrderDate.Text == "")
            {
                MessageBox.Show("Please fulfill input value!", "Warning information",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    string addQuery = "insert into Orders values('" + txtOrderID.Text + "','" + cbbMem.Text + "','" + txtOrderDate.Text + "', '" + grandTotal + "')";
                    SqlCommand cmd = new SqlCommand(addQuery, db.GetConn());
                    db.OpenConn();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Insert new Order successfully!", "Add new Order",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    getOrder();
                    Clear();
                    dgvOrderDetail.Rows.Clear();
                    db.CloseConn();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        //Load OrderId, proID
        private void getOrderID()
        {
            try
            {
                string selectQuery = "select * from Orders";
                SqlCommand cmd = new SqlCommand(selectQuery, db.GetConn());
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void getProID()
        {
            try
            {
                string selectQuery = "select * from Product";
                SqlCommand cmd = new SqlCommand(selectQuery, db.GetConn());
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                cbbProID.DataSource = dt;
                cbbProID.ValueMember = "ProID";
                //cbbCat_Filter.DataSource = dt;
                //cbbCat_Filter.ValueMember = "CatName";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        //Update

        private void dgvOrder_Click_1(object sender, EventArgs e)
        {
            txtOrderID.Text = dgvOrder.SelectedRows[0].Cells[0].Value.ToString();
            cbbMem.Text = dgvOrder.SelectedRows[0].Cells[1].Value.ToString();
            txtOrderDate.Text = dgvOrder.SelectedRows[0].Cells[2].Value.ToString();
            //txtOrderID.ReadOnly = true;
        }


        private void btnOrderUpdate_Click(object sender, EventArgs e)
        {
            if (txtOrderID.Text == "" || cbbMem.Text == "" || txtOrderDate.Text == "")
            {
                MessageBox.Show("Please choose object!", "Warning information",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    string updateQuery = "update Orders set MemID = '" + cbbMem.Text + "', OrderDate = '" + txtOrderDate.Text + "' where OrderID = '" + txtOrderID.Text + "'";
                    SqlCommand cmd = new SqlCommand(updateQuery, db.GetConn());
                    db.OpenConn();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("The order was updated successfully!", "Update Information",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    getOrder();
                    db.CloseConn();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnOrderDelete_Click(object sender, EventArgs e)
        {
            if (txtOrderID.Text == "" || cbbMem.Text == "" || txtOrderDate.Text == "")
            {
                MessageBox.Show("Please choose object!", "Warning information",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult dr = MessageBox.Show("Are you sure to delete this order?", "Confirmation",
                                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                try
                {
                    if (dr == DialogResult.Yes)
                    {
                        string deleteQuery = "delete Orders where OrderID = '" + txtOrderID.Text + "'";
                        SqlCommand cmd = new SqlCommand(deleteQuery, db.GetConn());
                        db.OpenConn();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("The Order was deleted successfully!", "Delete Order",
                                         MessageBoxButtons.OK, MessageBoxIcon.Information);
                        getOrder();
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
        //CRUD Detail
        int grandTotal = 0, n = 0;
        private void btnAddDetail_Click(object sender, EventArgs e)
        {
            if (cbbProID.Text == "" || txtProPrice.Text == "" || txtQuantity.Text == "" || txtDiscount.Text == "")
            {
                MessageBox.Show("Please fulfill input value!", "Warning information",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    int total = Convert.ToInt32(txtProPrice.Text) * Convert.ToInt32(txtQuantity.Text)
                                                          - Convert.ToInt32(txtDiscount.Text);
                    DataGridViewRow addRow = new DataGridViewRow();
                    addRow.CreateCells(dgvOrderDetail);
                    addRow.Cells[0].Value = ++n;
                    addRow.Cells[1].Value = cbbProID.Text;
                    addRow.Cells[2].Value = txtProPrice.Text;
                    addRow.Cells[3].Value = txtQuantity.Text;
                    addRow.Cells[4].Value = txtDiscount.Text;
                    addRow.Cells[5].Value = total;
                    dgvOrderDetail.Rows.Add(addRow);
                    grandTotal += total;

                    //Clear
                    cbbProID.Text = "";
                    txtProPrice.Text = "";
                    txtQuantity.Text = "";
                    txtDiscount.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

        }

        private void dgvOrderDetail_Click(object sender, EventArgs e)
        {
            //cbbCreated.Text = dgvOrderDetail.SelectedRows[0].Cells[0].Value.ToString();
            cbbProID.Text = dgvOrderDetail.SelectedRows[0].Cells[1].Value.ToString();
            txtProPrice.Text = dgvOrderDetail.SelectedRows[0].Cells[2].Value.ToString();
            txtQuantity.Text = dgvOrderDetail.SelectedRows[0].Cells[3].Value.ToString();
            txtDiscount.Text = dgvOrderDetail.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void btnUpdateDetail_Click(object sender, EventArgs e)
        {
            if (cbbProID.Text == "" || txtProPrice.Text == "" || txtQuantity.Text == "" || txtDiscount.Text == "")
            {
                MessageBox.Show("Please fulfill input value!", "Warning information",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

            }

        }

        private void btnDeleteDetail_Click(object sender, EventArgs e)
        {
            if (cbbProID.Text == "" || txtProPrice.Text == "" || txtQuantity.Text == "" || txtDiscount.Text == "")
            {
                MessageBox.Show("Please choose specific object!", "Warning information",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    DialogResult dr = MessageBox.Show("Are you sure to delete this Order Detail?", "Confirmation",
                                              MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                        //string deleteQuery = "delete from OrderDetail where ProID = '" +tx + "'";
                        //SqlCommand cmd = new SqlCommand(deleteQuery, db.GetConn());
                        db.OpenConn();
                        //cmd.ExecuteNonQuery();
                        MessageBox.Show("The product was deleted successfully!", "Delete Product",
                                         MessageBoxButtons.OK, MessageBoxIcon.Information);
                        getOrderDetail();
                        //Clear();
                        db.CloseConn();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        //-----------------------------------------------
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtProWeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }



        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dgvOrderDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
























        //-------------------------------------------


    }
}
