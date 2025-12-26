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
    public partial class LabForm : Form
    {
        public LabForm()
        {
            InitializeComponent();
            DisplayLab();
            PatientNameData();
        }
        SqlConnection Connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Jc\Downloads\BARANGGAY CLINIC\BARANGGAY CLINIC\BarangayClinic.mdf"";Integrated Security=True;Connect Timeout=30");
        
        private void DisplayLab()
        {
            Connect.Open();
            string query = "Select * from LabTable";
            SqlDataAdapter sda = new SqlDataAdapter(query, Connect);
            SqlCommandBuilder scb = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            LabDGV.DataSource = ds.Tables[0];
            Connect.Close();
        }

        private void Clear()
        {
            PatientIDCB.SelectedIndex = -1;
            WeightTB1.Text = "";
            FastingBloodSugarTB2.Text = "";
            BloodPressureTB3.Text = "";

            key = 0;

        }

        private void PatientNameData()
        {
            Connect.Open();
            SqlCommand com = new SqlCommand("Select PatientLastName, CONCAT(PatientLastName, ', ', PatientFirstName) as PatientName from PatientTable", Connect);
            SqlDataReader sdr;
            sdr = com.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("PatientLastName", typeof(string));
            dt.Load(sdr);
            PatientIDCB.ValueMember = "PatientLastName";
            PatientIDCB.DisplayMember = "PatientName";
            PatientIDCB.DataSource = dt;
            Connect.Close();
        }
        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (WeightTB1.Text == "" || FastingBloodSugarTB2.Text == "" || BloodPressureTB3.Text == "")
            {
                MessageBox.Show("You need to fill up all the data");
            }
            else
            {
                try
                {
                    Connect.Open();
                    SqlCommand com = new SqlCommand("INSERT INTO LabTable(PatientName, Weight, Fasting_Blood_Sugar, Blood_Pressure, Date_of_Visit) VALUES (@PN, @W, @FBS, @BP, @DOV)", Connect);
                    com.Parameters.AddWithValue("@PN", PatientIDCB.Text);
                    com.Parameters.AddWithValue("@W", WeightTB1.Text);
                    com.Parameters.AddWithValue("@FBS", FastingBloodSugarTB2.Text);
                    com.Parameters.AddWithValue("@BP", BloodPressureTB3.Text);
                    com.Parameters.AddWithValue("@DOV", DateOfVisit.Value.Date);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Lab Successfully Added!");
                    Connect.Close();
                    DisplayLab();
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

        private void LabDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            PatientIDCB.Text = LabDGV.Rows[e.RowIndex].Cells[1].Value.ToString();
            WeightTB1.Text = LabDGV.Rows[e.RowIndex].Cells[2].Value.ToString();
            FastingBloodSugarTB2.Text = LabDGV.Rows[e.RowIndex].Cells[3].Value.ToString();
            BloodPressureTB3.Text = LabDGV.Rows[e.RowIndex].Cells[4].Value.ToString();


            if (WeightTB1.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(LabID.Text = LabDGV.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (WeightTB1.Text == "" || FastingBloodSugarTB2.Text == "" || BloodPressureTB3.Text == "")
            {
                MessageBox.Show("You need to fill up all the data");
            }
            else
            {
                try
                {
                    Connect.Open();
                    SqlCommand com = new SqlCommand("update LabTable set PatientName = @PN, Weight = @W, Fasting_Blood_Sugar = @FBS, Blood_Pressure = @BP where LabID=@Lkey", Connect);
                    com.Parameters.AddWithValue("@PN", PatientIDCB.Text);
                    com.Parameters.AddWithValue("@W", WeightTB1.Text);
                    com.Parameters.AddWithValue("@FBS", FastingBloodSugarTB2.Text);
                    com.Parameters.AddWithValue("@BP", BloodPressureTB3.Text);
                    com.Parameters.AddWithValue("@Lkey", key);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Lab Successfully Updated!");
                    Connect.Close();
                    DisplayLab();
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
                        SqlCommand com = new SqlCommand("Delete from LabTable WHERE LabId = @Lkey", Connect);
                        com.Parameters.AddWithValue("@Lkey", key);
                        com.ExecuteNonQuery();
                    }
                    Connect.Close();
                    DisplayLab();
                    Clear();
                }
                catch (Exception EXCEPT)
                {
                    MessageBox.Show(EXCEPT.Message);
                    Connect.Close();
                }
            }
        }

        private void BloodPressureTB3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '/' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void FastingBloodSugarTB2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void WeightTB1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
            string searchText = SearchFunctionTB.Text;

            using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Jc\Downloads\BARANGGAY CLINIC\BARANGGAY CLINIC\BarangayClinic.mdf"";Integrated Security=True;Connect Timeout=30"))
            {
                connection.Open();

                string query = "SELECT * FROM LabTable WHERE PatientName LIKE @searchText";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@searchText", "%" + searchText + "%");

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    LabDGV.DataSource = dt;
                }

                connection.Close();
            }
        }
    }
}
