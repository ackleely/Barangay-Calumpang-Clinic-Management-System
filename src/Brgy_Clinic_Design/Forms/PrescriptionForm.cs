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
    public partial class PrescriptionForm : Form
    {
        public PrescriptionForm()
        {
            InitializeComponent();
            DisplayPrescription();
            NurseNameData();
            PatientNameData();
        }
        SqlConnection Connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Jc\Downloads\BARANGGAY CLINIC\BARANGGAY CLINIC\BarangayClinic.mdf"";Integrated Security=True;Connect Timeout=30");
        private void DisplayPrescription()
        {
            Connect.Open();
            string query = "Select * from PrescriptionTable";
            SqlDataAdapter sda = new SqlDataAdapter(query, Connect);
            SqlCommandBuilder scb = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            PrescriptionDGV.DataSource = ds.Tables[0];
            Connect.Close();
        }

        private void Clear()
        {
            PrescriptionMedicineTB.Text = "";
            NurseIDCB.SelectedIndex = -1;
            PatientIDCB.SelectedIndex = -1;
            PrescriptionRTB.Text = "";
            key = 0;
        }
        private void NurseNameData()
        {
            Connect.Open();
            SqlCommand com = new SqlCommand("Select NurseLastName, CONCAT(NurseLastName, ', ', NurseFirstName) as NurseName from NurseTable", Connect);
            SqlDataReader sdr;
            sdr = com.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("NurseLastName", typeof(string));
            dt.Load(sdr);
            NurseIDCB.ValueMember = "NurseLastName";
            NurseIDCB.DisplayMember = "NurseName";
            NurseIDCB.DataSource = dt;
            Connect.Close();
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
        private void Add_Click(object sender, EventArgs e)
        {
            if (NurseIDCB.SelectedIndex == -1 || PatientIDCB.SelectedIndex == -1)
            {
                MessageBox.Show("You need to fill up all the data");
            }
            else
            {
                try
                {
                    Connect.Open();
                    SqlCommand com = new SqlCommand("insert into PrescriptionTable(NurseName, PatientName, Medicines)values(@NN, @PN, @M)", Connect);

                    com.Parameters.AddWithValue("@NN", NurseIDCB.Text);
                    com.Parameters.AddWithValue("@PN", PatientIDCB.Text);
                    com.Parameters.AddWithValue("@M", PrescriptionMedicineTB.Text);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Informations Successfully Added!");
                    Connect.Close();
                    DisplayPrescription();
                    Clear();
                }
                catch (Exception EXCEPT)
                {
                    MessageBox.Show(EXCEPT.Message);
                }
            }
        }
        int key = 0;

        private void PrescriptionDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PrescriptionRTB.Text = "";
            PrescriptionRTB.Text = "                            Barangay Calumpang Clinic\n\n" + "                                    Prescription            " + "\n*************************************" + "\n" + DateTime.Now + "\n\n\n\n      Nurse: " + PrescriptionDGV.Rows[e.RowIndex].Cells[1].Value.ToString() +"\n\n\n       Patient: " + PrescriptionDGV.Rows[e.RowIndex].Cells[2].Value.ToString() + "\n\n\n         Medicines: " + PrescriptionDGV.Rows[e.RowIndex].Cells[3].Value.ToString();

        }

        private void PrescriptionDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NurseIDCB.Text = PrescriptionDGV.Rows[e.RowIndex].Cells[1].Value.ToString();
            PatientIDCB.Text = PrescriptionDGV.Rows[e.RowIndex].Cells[2].Value.ToString();
            PrescriptionMedicineTB.Text = PrescriptionDGV.Rows[e.RowIndex].Cells[3].Value.ToString();



            if (PrescriptionMedicineTB.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(PrescriptionIDTB.Text = PrescriptionDGV.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (NurseIDCB.SelectedIndex == -1 || PatientIDCB.SelectedIndex == -1)
            {
                MessageBox.Show("You need to fill up all the data");
            }
            else
            {
                try
                {
                    Connect.Open();
                    SqlCommand com = new SqlCommand("update PrescriptionTable set NurseName = @NN, PatientName = @PN, Medicines = @M where PrescriptionId = @PRkey", Connect);
                    com.Parameters.AddWithValue("@NN", NurseIDCB.Text);
                    com.Parameters.AddWithValue("@PN", PatientIDCB.Text);
                    com.Parameters.AddWithValue("@M", PrescriptionMedicineTB.Text);
                    com.Parameters.AddWithValue("@PRkey", key);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Informations Successfully Added!");
                    Connect.Close();
                    DisplayPrescription();
                    Clear();
                }
                catch (Exception EXCEPT)
                {
                    MessageBox.Show(EXCEPT.Message);
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
                        SqlCommand com = new SqlCommand("Delete from PrescriptionTable WHERE PrescriptionId = @PRkey", Connect);
                        com.Parameters.AddWithValue("@PRkey", key);
                        com.ExecuteNonQuery();
                    }
                    Connect.Close();
                    DisplayPrescription();
                    Clear();
                }
                catch (Exception EXCEPT)
                {
                    MessageBox.Show(EXCEPT.Message);
                }
            }
        }

        private void PrescriptionForm_Load(object sender, EventArgs e)
        {

        }

        private void Print_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK) 
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(PrescriptionRTB.Text + "\n", new Font("Averia", 18, FontStyle.Regular), Brushes.Black, new Point(95, 80));
            e.Graphics.DrawString("\n\t" + "Thank You!", new Font("Averia", 15, FontStyle.Bold), Brushes.Red, new Point(200, 300));
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
            string searchText = SearchFunctionTB.Text;

            using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Jc\Downloads\BARANGGAY CLINIC\BARANGGAY CLINIC\BarangayClinic.mdf"";Integrated Security=True;Connect Timeout=30"))
            {
                connection.Open();

                string query = "SELECT * FROM PrescriptionTable WHERE NurseName LIKE @searchText OR PatientName LIKE @searchText";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@searchText", "%" + searchText + "%");

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    PrescriptionDGV.DataSource = dt;
                }

                connection.Close();
            }
        }
    }
}
