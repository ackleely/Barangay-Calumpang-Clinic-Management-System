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
    public partial class NurseForm : Form
    {
        public NurseForm()
        {
            InitializeComponent();
            DisplayNurse();
            NursePhoneTB.KeyPress += NursePhoneTB_KeyPress;
            CountNurse();
        }
        SqlConnection Connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Jc\Downloads\BARANGGAY CLINIC\BARANGGAY CLINIC\BarangayClinic.mdf"";Integrated Security=True;Connect Timeout=30");

        private void CountNurse()
        {
            Connect.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select count (*) from NurseTable", Connect);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            NurseLbl.Text = dt.Rows[0][0].ToString();
            Connect.Close();
        }

        private void DisplayNurse()
        {
            Connect.Open();
            string query = "Select * from NurseTable";
            SqlDataAdapter sda = new SqlDataAdapter(query, Connect);
            SqlCommandBuilder scb = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            NurseDGV.DataSource = ds.Tables[0];
            Connect.Close();
        }

        private void Clear()
        {
            NurseFirstNameTB.Text = "";
            NurseLastNameTB.Text = "";
            NursePhoneTB.Text = "";
            NurseAddressCB.SelectedIndex = -1;
            NursePasswordTB.Text = "";
            NurseGenderCB.SelectedIndex = -1;
            key = 0;

        }
        private void Add_Click(object sender, EventArgs e)
        {
            if (NurseFirstNameTB.Text == "" || NurseLastNameTB.Text == "" || NursePhoneTB.Text == "" || NurseAddressCB.SelectedIndex == -1 || NursePasswordTB.Text == "" || NurseGenderCB.SelectedIndex == -1)
            {
                MessageBox.Show("You need to fill up all the data");
            }
            else
            {
                try
                {
                    Connect.Open();
                    SqlCommand com = new SqlCommand("insert into NurseTable(NurseFirstName, NurseLastName, NursePhone, NurseAddress, NurseBirthdate, NurseGender, NursePassword)values(@NFN, @NLN, @NP, @NA, @NB, @NG, @NPA)", Connect);
                    com.Parameters.AddWithValue("@NFN", NurseFirstNameTB.Text);
                    com.Parameters.AddWithValue("@NLN", NurseLastNameTB.Text);
                    com.Parameters.AddWithValue("@NP", NursePhoneTB.Text);
                    com.Parameters.AddWithValue("@NA", NurseAddressCB.SelectedIndex.ToString());
                    com.Parameters.AddWithValue("@NB", NurseBDAY.Value.Date);
                    com.Parameters.AddWithValue("@NG", NurseGenderCB.SelectedItem.ToString());
                    com.Parameters.AddWithValue("@NPA", NursePasswordTB.Text);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Nurse Successfully Added!");
                    Delete.Enabled = true;
                    NurseDGV.Enabled = true;
                    Connect.Close();
                    DisplayNurse();
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

        private void NurseDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NurseFirstNameTB.Text = NurseDGV.Rows[e.RowIndex].Cells[1].Value.ToString();
            NurseLastNameTB.Text = NurseDGV.Rows[e.RowIndex].Cells[2].Value.ToString();
            NursePhoneTB.Text = NurseDGV.Rows[e.RowIndex].Cells[3].Value.ToString();
            NurseAddressCB.SelectedItem = NurseDGV.Rows[e.RowIndex].Cells[4].Value.ToString();
            NurseBDAY.Text = NurseDGV.Rows[e.RowIndex].Cells[5].Value.ToString();
            NurseGenderCB.SelectedItem = NurseDGV.Rows[e.RowIndex].Cells[6].Value.ToString();
            NursePasswordTB.Text = NurseDGV.Rows[e.RowIndex].Cells[7].Value.ToString();

            if (NurseFirstNameTB.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(NurseIdTB.Text = NurseDGV.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (NurseFirstNameTB.Text == "" || NurseLastNameTB.Text == "" || NursePhoneTB.Text == "" || NurseAddressCB.SelectedIndex == -1 || NursePasswordTB.Text == "" || NurseGenderCB.SelectedIndex == -1)
            {
                MessageBox.Show("You need to fill up all the data");
            }
            else
            {
                try
                {
                    Connect.Open();
                    SqlCommand com = new SqlCommand("update NurseTable set NurseFirstName = @NFN, NurseLastName = @NLN, NursePhone = @NP, NurseAddress = @NA, NurseBirthdate = @NB, NurseGender = @NG, NursePassword = @NPA where NurseId=@Nkey", Connect);
                    com.Parameters.AddWithValue("@NFN", NurseFirstNameTB.Text);
                    com.Parameters.AddWithValue("@NLN", NurseLastNameTB.Text);
                    com.Parameters.AddWithValue("@NP", NursePhoneTB.Text);
                    com.Parameters.AddWithValue("@NA", NurseAddressCB.SelectedItem.ToString());
                    com.Parameters.AddWithValue("@NB", NurseBDAY.Value.Date);
                    com.Parameters.AddWithValue("@NG", NurseGenderCB.SelectedItem.ToString());
                    com.Parameters.AddWithValue("@NPA", NursePasswordTB.Text);
                    com.Parameters.AddWithValue("@Nkey", key);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Nurse Successfully Updated!");
                    NurseGB.Hide();
                    Delete.Enabled = true;
                    NurseDGV.Enabled = true;
                    EditShowGB.Enabled = true;
                    AddShowGB.Enabled = true;
                    Connect.Close();
                    DisplayNurse();
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
                MessageBox.Show("Select a Nurse");
            }
            else
            {
                try
                {
                    Connect.Open();
                    NurseGB.Show();
                    Add.Hide();
                    Edit.Hide();
                    DialogResult result = MessageBox.Show("Are you sure, Do you want to delete?", "Delete Confirmation", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        SqlCommand com = new SqlCommand("Delete from NurseTable WHERE NurseId = @Nkey", Connect);
                        com.Parameters.AddWithValue("@Nkey", key);
                        com.ExecuteNonQuery();
                        NurseGB.Hide();
                    }
                    else
                    { 
                        NurseGB.Hide();
                    }
                    Connect.Close();
                    DisplayNurse();
                    Clear();
                }
                catch (Exception EXCEPT)
                {
                    MessageBox.Show(EXCEPT.Message);
                    Connect.Close();
                }
            }
        }

        private void NursePhoneTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void NurseFirstNameTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void NurseLastNameTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void NursePhoneTB_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void NurseForm_Load(object sender, EventArgs e)
        {
            

        }

        private void NursePasswordTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddShowGB_Click(object sender, EventArgs e)
        {
            //Enable = false
            NurseDGV.Enabled = false;
            Delete.Enabled = false;
            EditShowGB.Enabled = false;

            // show
            NurseGB.Show();
            Add.Show();

            //hide
            Edit.Hide();

            //button enabled
            AddShowGB.Enabled = true;
        }

        private void CloseGB_Click(object sender, EventArgs e)
        {
            
            NurseDGV.Enabled = true;
            AddShowGB.Enabled = true;
            EditShowGB.Enabled = true;
            Delete.Enabled = true;

            NurseGB.Hide();
        }

        private void EditShowGB_Click(object sender, EventArgs e)
        {

            if (NurseFirstNameTB.Text == "" || NurseLastNameTB.Text == "" || NursePhoneTB.Text == "" || NurseAddressCB.SelectedIndex == -1 || NursePasswordTB.Text == "" || NurseGenderCB.SelectedIndex == -1)
            {
                MessageBox.Show("You need to fill select row");
            }
            else
            {
                //disable
                AddShowGB.Enabled = false;
                NurseDGV.Enabled=false;
                Delete.Enabled = false;

                //show
                NurseGB.Show();
                Edit.Show();

                //hide
                Add.Hide();
                EditShowGB.Enabled = true;

            }

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
            string searchText = SearchFunctionTB.Text;

            using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Jc\Downloads\BARANGGAY CLINIC\BARANGGAY CLINIC\BarangayClinic.mdf"";Integrated Security=True;Connect Timeout=30"))
            {
                connection.Open();

                string query = "SELECT * FROM NurseTable WHERE NurseLastName LIKE @searchText OR NurseFirstName LIKE @searchText";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@searchText", "%" + searchText + "%");

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    NurseDGV.DataSource = dt;
                }

                connection.Close();
            }
        }

        private void NurseDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
