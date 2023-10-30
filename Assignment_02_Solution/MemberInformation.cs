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
    public partial class MemberInformation : Form
    {
        private string memID;
        public MemberInformation()
        {
            InitializeComponent();          
        }

        public MemberInformation(string memID)
        {
            InitializeComponent();
            this.memID = memID;
            LoadOrder();
        }
        

        private void LoadOrder() {
            try
            {
                string query = "select * from Orders where MemID = '"+ memID +"'";
                db.OpenConn();
                SqlCommand cmd = new SqlCommand(query,db.GetConn()); 
                SqlDataAdapter orderAdapter = new SqlDataAdapter(cmd);
                DataTable orderDt = new DataTable();
                orderAdapter.Fill(orderDt);
                dgvOrder.DataSource = orderDt;
                db.CloseConn();
            }
            catch(Exception ex) {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        DBContext db = new DBContext();
        public void setDataMember(DataTable dt)
        {
            dgvMember.DataSource = dt;
        }

        public void setDataOrder(DataTable dt)
        {
            dgvOrder.DataSource = dt;
        }

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

                    string selectQuery = "select * from Member where MemID = '" + txtMemID.Text + "'";
                    SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, db.GetConn());
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvMember.DataSource = dt;

                    //setData();
                    db.CloseConn();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dgvMember_Click_1(object sender, EventArgs e)
        {
            txtMemID.Text = dgvMember.SelectedRows[0].Cells[0].Value.ToString();
            txtMemCompany.Text = dgvMember.SelectedRows[0].Cells[1].Value.ToString();
            txtMemCity.Text = dgvMember.SelectedRows[0].Cells[2].Value.ToString();
            txtMemCountry.Text = dgvMember.SelectedRows[0].Cells[3].Value.ToString();
            txtMemEmail.Text = dgvMember.SelectedRows[0].Cells[4].Value.ToString();
            txtMemPassword.Text = dgvMember.SelectedRows[0].Cells[5].Value.ToString();
            txtMemID.ReadOnly = true;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            lf.StartPosition = FormStartPosition.CenterScreen;
            lf.Show();
            this.Hide();
        }
        private void MemberInformation_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


    }
}
