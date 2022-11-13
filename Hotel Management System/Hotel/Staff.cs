using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Hotel
{
    public partial class Staff : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\project\Hotel\Hotel\HotelDatabase.mdf;Integrated Security=True;Connect Timeout=30");
        public void populate()
        {
            con.Open();
            string Myquuery = "select * from Staff_tbl";
            SqlDataAdapter da = new SqlDataAdapter(Myquuery, con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridViewStaff.DataSource = ds.Tables[0];
            con.Close();
        }
        public Staff()
        {
            InitializeComponent();
        }

        private void Staff_Load(object sender, EventArgs e)
        {
            datelbl.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
            populate();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Staff_tbl values ('" + staffidF.Text + "','" + staffnameF.Text + "','" + staffphoneF.Text + "','" + staffGenderF.SelectedItem.ToString() + "','" + staffpass.Text + "')", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Staff Successfully Added");
            con.Close();
            populate();
        }

        private void edit_Click(object sender, EventArgs e)
        {
            con.Open();
            string Myquuery = "UPDATE Staff_tbl set StaffName='" + staffnameF.Text + "',StaffPhone='" + staffphoneF.Text + "',StaffPassword='" + staffpass.Text + "',gender='" + staffGenderF.SelectedItem.ToString() + "' where StaffId=" + staffidF.Text + ";";
            SqlCommand cmd = new SqlCommand(Myquuery, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Staff successfully Edited");

            con.Close();
            populate();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "delete from Staff_tbl where StaffId = " + staffidF.Text + "";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Staff Successfully Deleted ");
            con.Close();
            populate();
        }

        private void dataGridViewStaff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            staffidF.Text = dataGridViewStaff.SelectedRows[0].Cells[0].Value.ToString();
            staffnameF.Text = dataGridViewStaff.SelectedRows[0].Cells[1].Value.ToString();
            staffphoneF.Text = dataGridViewStaff.SelectedRows[0].Cells[2].Value.ToString();
            staffGenderF.Text = dataGridViewStaff.SelectedRows[0].Cells[3].Value.ToString();
            staffpass.Text = dataGridViewStaff.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void staffSearch_Click(object sender, EventArgs e)
        {
            con.Open();
            string Myquuery = "select * from Staff_tbl where StaffName='" + searchStaffF.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(Myquuery, con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridViewStaff.DataSource = ds.Tables[0];
            con.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            datelbl.Text = DateTime.Now.ToLongTimeString();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MainFrom main = new MainFrom();
            main.Show();
            this.Hide();
        }
    }
}
