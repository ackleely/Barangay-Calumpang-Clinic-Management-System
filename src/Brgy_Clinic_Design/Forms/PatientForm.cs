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
    public partial class PatientForm : Form
    {
        public PatientForm()
        {
            InitializeComponent();
            DisplayPatient();
            CountPatients();
        }
        SqlConnection Connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Jc\Downloads\BARANGGAY CLINIC\BARANGGAY CLINIC\BarangayClinic.mdf"";Integrated Security=True;Connect Timeout=30");

        private void CountPatients()
        {
            Connect.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select count (*) from PatientTable", Connect);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            PatientLbl.Text = dt.Rows[0][0].ToString();
            Connect.Close();
        }

        private void DisplayPatient()
        {
            Connect.Open();
            string query = "Select * from PatientTable";
            SqlDataAdapter sda = new SqlDataAdapter(query, Connect);
            SqlCommandBuilder scb = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            PatientDGV.DataSource = ds.Tables[0];
            Connect.Close();
        }

        private void Clear()
        {
            PatientFirstNameTB.Text = "";
            PatientLastNameTB.Text = "";
            PatientPhoneTB.Text = "";
            PatientAddressCB.SelectedIndex = -1;
            PatientAgeTB.Text = "";
            PatientGenderCB.SelectedIndex = -1;
            key = 0;

        }
        private void Add_Click(object sender, EventArgs e)
        {
            if (PatientFirstNameTB.Text == "" || PatientLastNameTB.Text == "" || PatientPhoneTB.Text == "" || PatientAddressCB.SelectedIndex == -1 || PatientAgeTB.Text == "" || PatientGenderCB.SelectedIndex == -1)
            {
                MessageBox.Show("You need to fill up all the data");
            }
            else
            {
                try
                {
                    Connect.Open();
                    SqlCommand com = new SqlCommand("insert into PatientTable(PatientFirstName, PatientLastName, PatientAge, PatientAddress, PatientDateOfVisit, PatientGender, PatientPhone)values(@PFN, @PLN, @PA, @PAD, @PDOV, @PG, @PP)", Connect);
                    com.Parameters.AddWithValue("@PFN", PatientFirstNameTB.Text);
                    com.Parameters.AddWithValue("@PLN", PatientLastNameTB.Text);
                    com.Parameters.AddWithValue("@PA", PatientAgeTB.Text);
                    com.Parameters.AddWithValue("@PAD", PatientAddressCB.SelectedItem.ToString());
                    com.Parameters.AddWithValue("@PDOV", PatientDOB.Value.Date);
                    com.Parameters.AddWithValue("@PG", PatientGenderCB.SelectedItem.ToString());
                    com.Parameters.AddWithValue("@PP", PatientPhoneTB.Text);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Patient Successfully Added!");
                    Connect.Close();
                    DisplayPatient();
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

        private void PatientDOB_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = PatientDOB.Value;
            TimeSpan ageDifference = DateTime.Now - selectedDate;

            int age = (int)(ageDifference.TotalDays / 365.25);
            PatientAgeTB.Text = age.ToString();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (PatientFirstNameTB.Text == "" || PatientLastNameTB.Text == "" || PatientPhoneTB.Text == "" || PatientAddressCB.SelectedIndex == -1 || PatientAgeTB.Text == "" || PatientGenderCB.SelectedIndex == -1)
            {
                MessageBox.Show("You need to fill up all the data");
            }
            else
            {
                try
                {
                    Connect.Open();
                    SqlCommand com = new SqlCommand("update PatientTable set PatientFirstName = @PFN, PatientLastName = @PLN, PatientAge = @PA, PatientAddress = @PAD, PatientDateOfVisit = @PDOV, PatientGender = @PG, PatientPhone = @PP where PatientId = @Pkey", Connect);
                    com.Parameters.AddWithValue("@PFN", PatientFirstNameTB.Text);
                    com.Parameters.AddWithValue("@PLN", PatientLastNameTB.Text);
                    com.Parameters.AddWithValue("@PA", PatientAgeTB.Text);
                    com.Parameters.AddWithValue("@PAD", PatientAddressCB.SelectedItem.ToString());
                    com.Parameters.AddWithValue("@PDOV", PatientDOB.Value.Date);
                    com.Parameters.AddWithValue("@PG", PatientGenderCB.SelectedItem.ToString());
                    com.Parameters.AddWithValue("@PP", PatientPhoneTB.Text);
                    com.Parameters.AddWithValue("@Pkey", key);
                    com.ExecuteNonQuery();
                    guna2GroupBox1.Hide();
                    Delete.Enabled = true;
                    PatientDGV.Enabled = true;
                    AddShowGB.Enabled = true;
                    MessageBox.Show("Patient Successfully Updated!");
                    Connect.Close();
                    DisplayPatient();
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
                MessageBox.Show("Select a Patient");
            }
            else
            {
                try
                {
                    Connect.Open();
                    guna2GroupBox1.Show();
                    DialogResult result = MessageBox.Show("Are you sure, Do you want to delete?", "Delete Confirmation", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        SqlCommand com = new SqlCommand("Delete from PatientTable WHERE PatientId = @Pkey", Connect);
                        com.Parameters.AddWithValue("@Pkey", key);
                        com.ExecuteNonQuery();
                        guna2GroupBox1.Hide();
                    }
                    else
                    {
                        guna2GroupBox1.Hide();
                    }
                    Connect.Close();
                    DisplayPatient();
                    Clear();
                }
                catch (Exception EXCEPT)
                {
                    MessageBox.Show(EXCEPT.Message);
                    Connect.Close();
                }
            }
        }

        private void PatientDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void PatientFirstNameTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void PatientLastNameTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void PatientPhoneTB_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void PatientPhoneTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void AddShowGB_Click(object sender, EventArgs e)
        {
            //Disable
            PatientDGV.Enabled = false;
            Delete.Enabled = false;
            EditShowGB.Enabled = false;

            //Show
            guna2GroupBox1.Show();

            //hide
            Edit.Hide();


        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            //Enable
            EditShowGB.Enabled = true;
            AddShowGB.Enabled = true;
            PatientDGV.Enabled = true;
            Delete.Enabled = true;


            //Hide
            guna2GroupBox1.Hide();

            
            Clear();
        }

        private void EditShowGB_Click(object sender, EventArgs e)
        {
            if (PatientFirstNameTB.Text == "" || PatientLastNameTB.Text == "" || PatientPhoneTB.Text == "" || PatientAddressCB.SelectedIndex == -1 || PatientAgeTB.Text == "" || PatientGenderCB.SelectedIndex == -1)
            {
                MessageBox.Show("You need to select row");

            }
            else
            {
                //enabled
                PatientDGV.Enabled = false;
                Delete.Enabled = false;
                AddShowGB.Enabled = false;

                //show
                guna2GroupBox1.Show();
                Edit.Show();

                //hide
                Add.Hide();
            }
            
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
            string searchText = SearchFunctionTB.Text;

            using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Jc\Downloads\BARANGGAY CLINIC\BARANGGAY CLINIC\BarangayClinic.mdf"";Integrated Security=True;Connect Timeout=30"))
            {
                connection.Open();

                string query = "SELECT * FROM PatientTable WHERE PatientLastName LIKE @searchText OR PatientFirstName LIKE @searchText";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@searchText", "%" + searchText + "%");

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    PatientDGV.DataSource = dt;
                }

                connection.Close();
            }
        }

        private void PatientDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PatientDGV_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        private void PatientDGV_CellClick_2(object sender, DataGridViewCellEventArgs e)
        {
            PatientFirstNameTB.Text = PatientDGV.Rows[e.RowIndex].Cells[1].Value.ToString();
            PatientLastNameTB.Text = PatientDGV.Rows[e.RowIndex].Cells[2].Value.ToString();
            PatientAgeTB.Text = PatientDGV.Rows[e.RowIndex].Cells[3].Value.ToString();
            PatientAddressCB.SelectedItem = PatientDGV.Rows[e.RowIndex].Cells[4].Value.ToString();
            PatientDOB.Text = PatientDGV.Rows[e.RowIndex].Cells[5].Value.ToString();
            PatientGenderCB.SelectedItem = PatientDGV.Rows[e.RowIndex].Cells[6].Value.ToString();
            PatientPhoneTB.Text = PatientDGV.Rows[e.RowIndex].Cells[7].Value.ToString();



            if (PatientFirstNameTB.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(PatientIDTB.Text = PatientDGV.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
        }
    }
}
