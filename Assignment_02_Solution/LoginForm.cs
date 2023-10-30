using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Assignment_02_Solution.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;


namespace Assignment_02_Solution
{
    public partial class LoginForm : Form
    {
        private readonly IConfiguration _config;
        public LoginForm()
        {
            InitializeComponent();
            _config = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
                        .AddJsonFile("appsettings.json").Build();
        }
        DBContext db = new DBContext(); 

        //btn Login
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtEmail.Text == "" || txtPassword.Text == "")
                {
                    MessageBox.Show("Please fulfill value!", "Warning Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if(cbbRole.SelectedIndex > -1) {
                        if (cbbRole.SelectedItem.ToString() == "Admin")
                        {
                            string adminEmail = _config["DefaultAdminAccount:Email"];
                            string adminPassword = _config["DefaultAdminAccount:Password"];
                            //if (txtEmail.Text.Equals("admin@fstore.com") && txtPassword.Text.Equals("admin@@"))
                            if (txtEmail.Text != adminEmail || txtPassword.Text != adminPassword)
                            {
                                MessageBox.Show("Wrong email or password. Try again!", "Warning Information",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else if (txtEmail.Text.Equals(adminEmail) && txtPassword.Text.Equals(adminPassword))
                            {
                                ProductManagement mb = new ProductManagement();
                                mb.StartPosition = FormStartPosition.CenterScreen;
                                mb.Show();
                                this.Hide();
                            }
                        }
                        else
                        {
                            string selectMemberQuery = "select * from Member where MemEmail = '" + txtEmail.Text + "' and MemPassword = '" + txtPassword.Text + "'";
                            SqlDataAdapter adapter = new SqlDataAdapter(selectMemberQuery, db.GetConn());
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            if (dt.Rows.Count > 0)
                            {
                                MemberInformation mem = new MemberInformation();
                                mem.setDataMember(dt);
                                mem.StartPosition = FormStartPosition.CenterScreen;
                                mem.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Wrong email or password!", "Warning Information",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Pleae input role!", "Warning Information",
                           MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }              
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        //btn Reset
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtEmail.Clear();
            txtPassword.Clear();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
