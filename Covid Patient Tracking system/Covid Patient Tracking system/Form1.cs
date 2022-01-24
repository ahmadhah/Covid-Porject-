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

namespace Covid_Patient_Tracking_system
{
    public partial class Form1 : Form
    {
        SqlDataAdapter adapter;
        DataSet dataSet;
        DataTable dataTable;
        String tableN;
        SqlCommandBuilder SqlBuilder;
        

        private void LoadData()
        {
            DataGrid.ReadOnly = true;
            string ConnectionString, sql;
            SqlConnection Sqlcon;
            ConnectionString = "Data Source=DESKTOP-OPVSNAB; Initial Catalog=Covid-19; User ID = sa; Password =abc123";
            sql = " select * from " + tableN;
            Sqlcon = new SqlConnection(ConnectionString);
            adapter = new SqlDataAdapter(sql, Sqlcon);
            dataSet = new DataSet();
            label23.Visible = true;

            try
            {
                Sqlcon.Open();
                SqlBuilder = new SqlCommandBuilder(adapter); //insert update delete command bulider
                adapter.Fill(dataSet, "Table");
                dataTable = dataSet.Tables["Table"];
                Sqlcon.Close();
                DataGrid.DataSource = dataSet.Tables["Table"];
                DataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error is ===> " + ex.Message);

            }
        }

        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

            DataGrid.AutoSize = true;
            this.AutoScroll = true;
            MedicalStaffDetails.Visible = false;
            groupBox1.Visible = false;
            label23.Visible = false;
            label24.Visible = false;
        }

        private void PatientDetailsBtn_Click(object sender, EventArgs e)
        {
            PatientTreatment1.Visible = false;
            groupBox1.Visible = true;
            MedicalStaffDetails.Visible = false;
            tableN = "PatientDetails1";
            label23.Text = "Patient Details Table";
            LoadData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MedicalStaffBtn_Click(object sender, EventArgs e)
        {
            PatientTreatment1.Visible = false;
            groupBox1.Visible = false;
            MedicalStaffDetails.Visible = true;
            tableN = "MedicalStaff";
            label23.Text = "Medical Staff Table";
            LoadData();
        }

        private void PatientTreatmentBtn_Click(object sender, EventArgs e)
        {
            PatientTreatment1.Visible = true;
            groupBox1.Visible = false;
            MedicalStaffDetails.Visible = false;
            tableN = "PTreatment";
            label23.Text = "Patient Treatment Table";
            LoadData();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Addbtn.Enabled = false;
            Delete.Enabled = false;
            Save.Enabled = true;
            DataGrid.ReadOnly = false;
            label24.Visible = true;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            Addbtn.Enabled = true;
            Delete.Enabled = true;
            Save.Enabled = false;
            DataGrid.ReadOnly = true;
            label24.Visible = false;
            if (adapter.Update(dataTable) > 0)
            {
                MessageBox.Show("Record Sucessfully saved in Databse");

            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            Save.Enabled = false;
            Delete.Enabled = true;
            Add.Enabled = true;

            if (MessageBox.Show("Are your sure to delete it?", "Confirmation Box", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int rowid = DataGrid.SelectedRows[0].Index;
                DataGrid.Rows.RemoveAt(rowid);
                adapter.Update(dataTable);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                LoadData();
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {
            if (tableN == "PatientDetails1")
            {
                (DataGrid.DataSource as DataTable).DefaultView.RowFilter = string.Format("Name like '%" + textBox1.Text + "%' or Phone like '%" + textBox1.Text + "%'");
            }
            else if (tableN == "MedicalStaff")
            {
                (DataGrid.DataSource as DataTable).DefaultView.RowFilter = string.Format("Name like '%" + textBox1.Text + "%' or Department like '%" + textBox1.Text + "%'");
            }
            else
            {
                (DataGrid.DataSource as DataTable).DefaultView.RowFilter = string.Format("TPatientName like '%" + textBox1.Text + "%' or MedicalStatus like '%" + textBox1.Text + "%'");
            }
        }


        private void Addbtn_Click(object sender, EventArgs e)
        {
            string ConnectionString, Sqlcommand;
            SqlConnection sqlcon;
            SqlCommand sqlcmd;
            ConnectionString = "Data Source=DESKTOP-OPVSNAB; Initial Catalog=Covid-19; User ID = sa; Password = hahmadi123";
            Sqlcommand = $"insert into PatientDetails1(Name, City, Province, Age, Phone, Address, MedicalHistory) values('{Name.Text}', '{City.Text}', '{Province.SelectedItem.ToString()}', '{Age.Text}', '{Phone.Text}', '{Address.Text}', '{MedicalHistory.Text}')";

            try
            {
                sqlcon = new SqlConnection(ConnectionString);
                sqlcon.Open();
                sqlcmd = new SqlCommand(Sqlcommand, sqlcon);
                sqlcmd.ExecuteReader();
                sqlcon.Close();
                MessageBox.Show("New Record has been saved successfully");
                tableN = "PatientDetails1";
                LoadData();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error is ====" + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e) // add button for Medical Staff Table
        {
            string ConString, Sqlcommand;
            SqlConnection sqlcon;
            SqlCommand sqlcmd;
            ConString = "Data Source=DESKTOP-OPVSNAB; Initial Catalog=Covid-19; User ID = sa; Password = hahmadi123";
            Sqlcommand = $"insert into MedicalStaff(Name, Destination, Title, Phone, Address, Department) values('{StaffName.Text}', '{StaffDestination.Text}', '{StaffTitle.Text}', '{StaffPhone.Text}', '{StaffAddress.Text}', '{StaffDepartment.Text}')";
            try
            {
                sqlcon = new SqlConnection(ConString);
                sqlcon.Open();
                sqlcmd = new SqlCommand(Sqlcommand, sqlcon);
                sqlcmd.ExecuteReader();
                sqlcon.Close();
                MessageBox.Show("New Record has been saved successfully");
                tableN = "MedicalStaff";
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error is ====" + ex.Message);
            }
            finally
            {
                StaffName.Text = "";
                StaffDestination.Text = "";
                StaffTitle.Text = "";
                StaffPhone.Text = "";
                StaffAddress.Text = "";
                StaffDepartment.Text = "";
            }
        }



        private void TPatientAddBtn_Click(object sender, EventArgs e)
        {
            string ConString, Sqlcommand;
            SqlConnection sqlcon;
            SqlCommand sqlcmd;
            ConString = "Data Source=DESKTOP-OPVSNAB; Initial Catalog=Covid-19; User ID = sa; Password = hahmadi123";
            Sqlcommand = $"insert into PTreatment(TPatientName, MedicineName, MedicineDate, Test, TestDate, DoctorAllocated, NurseAllocated, BedNumber, MedicalStatus) values('{TPatientName.Text}', '{MedicineName.Text}', '{MedicineDate.Value.ToString("dd/MM/yyyy")}', '{Test.Text}', '{TestDate.Value.ToString("dd/MM/yyyy")}', '{DoctorAllocated.Text}', '{NurseAllocated.Text}', '{BedNumber.Text}', '{MedicalStatus.SelectedItem.ToString()}')";

            try
            {
                sqlcon = new SqlConnection(ConString);
                sqlcon.Open();
                sqlcmd = new SqlCommand(Sqlcommand, sqlcon);
                sqlcmd.ExecuteReader();
                sqlcon.Close();
                MessageBox.Show("New Record has been saved successfully");
                tableN = "PTreatment";
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error is ====" + ex.Message);
            }
            finally
            {
                TPatientName.Text = "";
                MedicineName.Text = "";
                Test.Text = "";
                DoctorAllocated.Text = "";
                NurseAllocated.Text = "";
                BedNumber.Text = "";

        }

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void contextMenuStrip2_Opening(object sender, CancelEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MedicalHistory_TextChanged(object sender, EventArgs e)
        {

        }
        private void MedicineDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void TestDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {
            
        }
    }

}
