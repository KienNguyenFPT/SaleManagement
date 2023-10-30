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
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Assignment_02_Solution
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }
        DBContext db = new DBContext();

        // Change to New Form
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

        private void button1_Click(object sender, EventArgs e)
        {
            OrderManagement orderManagement = new OrderManagement();
            orderManagement.StartPosition = FormStartPosition.CenterScreen;
            orderManagement.Show();
            this.Hide();
        }
        // ---------------------------------

        //Gen Sale report
        private void btnGen_Click(object sender, EventArgs e)
        {
            if (dtpkStart.Value > dtpkEnd.Value)
            {
                MessageBox.Show("Start date must be <= End date", "Warning information",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            try
            {
                string calQuery = "select SUM(Total) as totalSales from Orders where OrderDate >= '" + dtpkStart.Value + "' and\r\nOrderDate <= '" + dtpkEnd.Value + "'";
                SqlCommand cmd = new SqlCommand(calQuery, db.GetConn());
                db.OpenConn();
                object result = cmd.ExecuteScalar();
                saveReport(dtpkStart.Value, dtpkEnd.Value, result);
                getSale();
                db.CloseConn();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        //Save Report
        private void saveReport(DateTime start, DateTime end, Object total)
        {
            try
            {
                string addQuery = "insert into Report(StartDate,EndDate,TotalSales) values ('" + start + "','" + end + "','" + total + "')";
                SqlCommand cmd = new SqlCommand(addQuery, db.GetConn());
                db.OpenConn();
                cmd.ExecuteNonQuery();
                db.CloseConn();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void getSale()
        {
            try
            {
                string query = "select * from Report";
                SqlCommand cmd = new SqlCommand(query, db.GetConn());
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvSale.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void Report_Load(object sender, EventArgs e)
        {
            getSale();
        }
        //Sort by Descending Amount
        private void btnSort_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "select * from Report order by TotalSales desc;";
                SqlCommand cmd = new SqlCommand(query, db.GetConn());
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvSale.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            getSale();
        }
    }
}
