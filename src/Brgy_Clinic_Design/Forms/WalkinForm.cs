using Guna.UI2.WinForms;
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
using System.Windows.Input;

namespace Brgy_Clinic_Design
{
    public partial class WalkinForm : Form
    {
        public WalkinForm()
        {
            InitializeComponent();
            DisplayWalkin();
            CountWalkin();
        }
        SqlConnection Connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Jc\Downloads\BARANGGAY CLINIC\BARANGGAY CLINIC\BarangayClinic.mdf"";Integrated Security=True;Connect Timeout=30");


        private void CountWalkin()
        {
            Connect.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select count (*) from WalkinTable", Connect);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            WalkinLbl.Text = dt.Rows[0][0].ToString();
            Connect.Close();
        }

        private void DisplayWalkin()
        {
            Connect.Open();
            string query = "Select * from WalkinTable";
            SqlDataAdapter sda = new SqlDataAdapter(query, Connect);
            SqlCommandBuilder scb = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            WalkinDGV.DataSource = ds.Tables[0];
            Connect.Close();
        }

        private void Clear()
        {
            WalkinFirstNameTB.Text = "";
            WalkinLastNameTB.Text = "";
            WalkinMedicineTB.Text = "";
            key = 0;

        }
        private void Add_Click(object sender, EventArgs e)
        {
            if (WalkinFirstNameTB.Text == "" || WalkinLastNameTB.Text == "" || WalkinMedicineTB.Text == "")
            {
                MessageBox.Show("You need to fill up all the data");
            }
            else
            {
                try
                {
                    Connect.Open();
                    SqlCommand com = new SqlCommand("insert into WalkinTable(FirstName, LastName, DateOfVisit, Medicine)values(@FN, @LN, @DOV, @M)", Connect);
                    com.Parameters.AddWithValue("@FN", WalkinFirstNameTB.Text);
                    com.Parameters.AddWithValue("@LN", WalkinLastNameTB.Text);
                    com.Parameters.AddWithValue("@DOV", WalkinDOV.Value.Date);
                    com.Parameters.AddWithValue("@M", WalkinMedicineTB.Text);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Information Successfully Added!");
                    Connect.Close();
                    DisplayWalkin();
                    Clear();
                }
                catch (Exception EXCEPT)
                {
                    MessageBox.Show(EXCEPT.Message);
                    Connect.Close();
                }

            }
        }
        int key = 0;

        private void Edit_Click(object sender, EventArgs e)
        {
            if (WalkinFirstNameTB.Text == "" || WalkinLastNameTB.Text == "" || WalkinMedicineTB.Text == "")
            {
                MessageBox.Show("You need to fill up all the data");
            }
            else
            {
                try
                {
                    Connect.Open();
                    SqlCommand com = new SqlCommand("update WalkinTable set FirstName = @FN, LastName = @LN, DateOfVisit = @DOV, Medicine = @M where WalkinId = @Wkey", Connect);
                    com.Parameters.AddWithValue("@FN", WalkinFirstNameTB.Text);
                    com.Parameters.AddWithValue("@LN", WalkinLastNameTB.Text);
                    com.Parameters.AddWithValue("@DOV", WalkinDOV.Value.Date);
                    com.Parameters.AddWithValue("@M", WalkinMedicineTB.Text);
                    com.Parameters.AddWithValue("@Wkey", key);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Information Successfully Added!");
                    Connect.Close();
                    DisplayWalkin();
                    Clear();
                }
                catch (Exception EXCEPT)
                {
                    MessageBox.Show(EXCEPT.Message);
                    Connect.Close();
                }

            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Select a Column/Row");
            }
            else
            {
                try
                {
                    Connect.Open();
                    DialogResult result = MessageBox.Show("Are you sure, Do you want to delete?", "Delete Confirmation", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        SqlCommand com = new SqlCommand("Delete from WalkinTable WHERE WalkinId = @Wkey", Connect);
                        com.Parameters.AddWithValue("@Wkey", key);
                        com.ExecuteNonQuery();
                    }
                    Connect.Close();
                    DisplayWalkin();
                    Clear();
                }
                catch (Exception EXCEPT)
                {
                    MessageBox.Show(EXCEPT.Message);
                    Connect.Close();
                }
            }
        }

        private void WalkinDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            WalkinFirstNameTB.Text = WalkinDGV.Rows[e.RowIndex].Cells[1].Value.ToString();
            WalkinLastNameTB.Text = WalkinDGV.Rows[e.RowIndex].Cells[2].Value.ToString();
            WalkinDOV.Text = WalkinDGV.Rows[e.RowIndex].Cells[3].Value.ToString();
            WalkinMedicineTB.Text = WalkinDGV.Rows[e.RowIndex].Cells[4].Value.ToString();



            if (WalkinFirstNameTB.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(WalkinIDTB.Text = WalkinDGV.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
        }

        private void WalkinFirstNameTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void WalkinLastNameTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void WalkinForm_Load(object sender, EventArgs e)
        {
            

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
            string searchText = SearchFunctionTB.Text;

            using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Jc\Downloads\BARANGGAY CLINIC\BARANGGAY CLINIC\BarangayClinic.mdf"";Integrated Security=True;Connect Timeout=30"))
            {
                connection.Open();

                string query = "SELECT * FROM WalkinTable WHERE LastName LIKE @searchText OR FirstName LIKE @searchText";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@searchText", "%" + searchText + "%");

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    WalkinDGV.DataSource = dt;
                }

                connection.Close();
            }
        }
    }
}
