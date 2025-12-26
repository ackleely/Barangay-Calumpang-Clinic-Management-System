using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Brgy_Clinic_Design
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        SqlConnection Connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Jc\Downloads\BARANGGAY CLINIC\BARANGGAY CLINIC\BarangayClinic.mdf"";Integrated Security=True;Connect Timeout=30");

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (UserCB.SelectedIndex == -1)
            {
                MessageBox.Show("Select Your Position");
            }
            else if (UserCB.SelectedIndex == 0)
            {
                if (UsernameTB.Text == "" || PasswordTB.Text == "")
                {
                    MessageBox.Show("Enter Admin Name and Password");
                }
                else if (UsernameTB.Text == "12345" && PasswordTB.Text == "AdminPassword")
                {
                    MainForm obj = new MainForm();
                    obj.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong Admin Name and Password");
                }
            }
            else
            {
                if (UsernameTB.Text == "" || PasswordTB.Text == "")
                {
                    MessageBox.Show("Enter Volunteer Nurse Name and Password");
                }
                else
                {
                    Connect.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from NurseTable where NurseId='" + UsernameTB.Text + "' and NursePassword='" + PasswordTB.Text + "'", Connect);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        MainForm2 obj = new MainForm2();
                        obj.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Nurse not Found");
                    }
                    Connect.Close();
                }
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            PasswordTB.Text = "";
        }

        private void PasswordCB_CheckedChanged(object sender, EventArgs e)
        {
            if (PasswordCB.Checked)
            {
                PasswordTB.PasswordChar = '\0';
            }
            else
            {
                PasswordTB.PasswordChar = '*';
            }
        }

        private void PasswordTB_TextChanged(object sender, EventArgs e)
        {
            if (PasswordCB.Checked)
            {
                PasswordTB.PasswordChar = '\0';
            }
            else
            {
                PasswordTB.PasswordChar = '*';
            }
        }

        private void UsernameTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
