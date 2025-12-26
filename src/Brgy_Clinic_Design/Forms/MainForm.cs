using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Brgy_Clinic_Design
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            CountPatients();
            CountNurse();
            CountWalkin();
        }
        

        SqlConnection Connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Jc\Downloads\BARANGGAY CLINIC\BARANGGAY CLINIC\BarangayClinic.mdf"";Integrated Security=True;Connect Timeout=30");


        private void CountPatients()
        {
            Connect.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select count (*) from PatientTable", Connect);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            TotalPatientstxt.Text = dt.Rows[0][0].ToString();
            Connect.Close();
        }

        private void CountNurse()
        {
            Connect.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select count (*) from NurseTable", Connect);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            NurseLbl.Text = dt.Rows[0][0].ToString();
            Connect.Close();
        }

        private void CountWalkin()
        {
            Connect.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select count (*) from WalkinTable", Connect);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            WalkinLbl.Text = dt.Rows[0][0].ToString();
            Connect.Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'barangayClinicDataSet.NurseTable' table. You can move, or remove it, as needed.
            this.nurseTableTableAdapter.Fill(this.barangayClinicDataSet.NurseTable);
            // TODO: This line of code loads data into the 'barangayClinicDataSet.PatientTable' table. You can move, or remove it, as needed.
            this.patientTableTableAdapter.Fill(this.barangayClinicDataSet.PatientTable);


        }

        private void guna2CustomGradientPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2GradientButton2_Click_1(object sender, EventArgs e)
        {
            NurseForm NURSEFORM = new NurseForm();
            NURSEFORM.TopLevel = false;
            Panel1.Controls.Add(NURSEFORM);
            NURSEFORM.BringToFront();
            NURSEFORM.Show();
        }

        private void PatientListBtn_Click(object sender, EventArgs e)
        {
            PatientForm PATIENTFORM = new PatientForm();
            PATIENTFORM.TopLevel = false;
            Panel1.Controls.Add(PATIENTFORM);
            PATIENTFORM.BringToFront();
            PATIENTFORM.Show();
        }

        private void CheckupBtn_Click(object sender, EventArgs e)
        {
            WalkinForm WALKINFORM = new WalkinForm();
            WALKINFORM.TopLevel = false;
            Panel1.Controls.Add(WALKINFORM);
            WALKINFORM.BringToFront();
            WALKINFORM.Show();
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("ARE YOU SURE YOU WANT TO EXIT?", "EXIT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LoginForm obj = new LoginForm();
                obj.Show();
                this.Hide();
            }
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            PrescriptionForm PRESCRIPTIONFORM = new PrescriptionForm();
            PRESCRIPTIONFORM.TopLevel = false;
            Panel1.Controls.Add(PRESCRIPTIONFORM);
            PRESCRIPTIONFORM.BringToFront();
            PRESCRIPTIONFORM.Show();
        }

        private void PrescriptionBtn_Click(object sender, EventArgs e)
        {
            LabForm LABFORM = new LabForm();
            LABFORM.TopLevel = false;
            Panel1.Controls.Add(LABFORM);
            LABFORM.BringToFront();
            LABFORM.Show();
        }

        private void DashboardBtn_Click(object sender, EventArgs e)
        {
            MainForm admin_sidepanel = new MainForm();
            admin_sidepanel.TopLevel = false;
            Panel1.Controls.Add(admin_sidepanel.Panel1);
            admin_sidepanel.Panel1.Dock = DockStyle.Fill;
            Panel1.Controls.Add(admin_sidepanel);
            admin_sidepanel.Dock = DockStyle.Fill;
            admin_sidepanel.Panel1.BringToFront();
            admin_sidepanel.Show();
        }

        private void guna2PictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void guna2CustomGradientPanel7_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
