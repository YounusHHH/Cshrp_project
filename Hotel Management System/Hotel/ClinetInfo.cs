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
    public partial class ClinetInfo : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\project\Hotel\Hotel\HotelDatabase.mdf;Integrated Security=True;Connect Timeout=30");
        public void populate()
        {
            con.Open();
            string Myquuery = "select * from Client_tbl";
            SqlDataAdapter da = new SqlDataAdapter(Myquuery, con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }
        public ClinetInfo()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            datelbl.Text = DateTime.Now.ToLongTimeString();
        }

        private void ClinetInfo_Load(object sender, EventArgs e)
        {
            datelbl.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
            populate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Client_tbl values ('" + clientidtbl.Text + "','" + ClientNameF.Text + "','" + ClientPhoneF.Text + "','" + ClientCountryF.SelectedItem.ToString() + "')", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Client Successfully Added");
            con.Close();
            populate();

        }



        private void edit_Click(object sender, EventArgs e)
        {
            con.Open();
            string Myquuery = "UPDATE Client_tbl set ClientName='"+ ClientNameF.Text + "',ClientPhone='"+ClientPhoneF.Text+ "',ClientCountry='" + ClientCountryF.SelectedItem.ToString() + "' where ClientId="+clientidtbl.Text+";";
            SqlCommand cmd = new SqlCommand(Myquuery, con); 
            cmd.ExecuteNonQuery();
            MessageBox.Show("Client successfully Edited");

            con.Close();
            populate();

        }

        private void delete_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "delete from Client_tbl where ClientId = " + clientidtbl.Text + "";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Client Successfully Deleted ");
            con.Close();
            populate();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            clientidtbl.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            ClientNameF.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            ClientPhoneF.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            ClientCountryF.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();


        }

        private void ClientSearch_Click(object sender, EventArgs e)
        {
            con.Open();
            string Myquuery = "select * from Client_tbl where ClientName='"+ searchNBox.Text+"'";
            SqlDataAdapter da = new SqlDataAdapter(Myquuery, con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            populate();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MainFrom main = new MainFrom();
            main.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ClientNameF_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
