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
    public partial class RoomInfo : Form
    {
        public RoomInfo()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\project\Hotel\Hotel\HotelDatabase.mdf;Integrated Security=True;Connect Timeout=30");

        public void populate()
        {
            con.Open();
            string Myquuery = "select * from Room_tbl";
            SqlDataAdapter da = new SqlDataAdapter(Myquuery, con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridViewRoom.DataSource = ds.Tables[0];
            con.Close();
        }
        private void AddRoom_Click(object sender, EventArgs e)
        {
            string isFree;
            if (Yesradio.Checked == true)
                isFree = "free";
            else
                isFree = "busy";
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Room_tbl values ('" + roomNo.Text + "','" + roomPhone.Text + "','" + isFree + "')", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Room Successfully Added");
            con.Close();
            populate();
        }

       
        private void RoomInfo_Load(object sender, EventArgs e)
        {
            datelbl.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
            populate();
        }

        private void edit_Click(object sender, EventArgs e)
        {
            string isFree;
            if (Yesradio.Checked == true)
                isFree = "free";
            else
                isFree = "busy";
            con.Open();
            string Myquuery = "UPDATE Room_tbl set RoomId='" + roomNo.Text + "',RoomPhone='" + roomPhone.Text + "',RoomFree='" + isFree + "' where RoomId=" + roomNo.Text + ";";
            SqlCommand cmd = new SqlCommand(Myquuery, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Room successfully Edited");

            con.Close();
            populate();
        }

        private void dataGridViewRoom_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           roomNo.Text = dataGridViewRoom.SelectedRows[0].Cells[0].Value.ToString();
            roomPhone.Text = dataGridViewRoom.SelectedRows[0].Cells[1].Value.ToString();
            
        }

        private void delete_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "delete from Room_tbl where RoomId = " + roomNo.Text + "";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Room Successfully Deleted ");
            con.Close();
            populate();
        }

        private void searchRBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void RoomSearch_Click(object sender, EventArgs e)
        {
            con.Open();
            string Myquuery = "select * from Room_tbl where RoomId='" + searchRBox.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(Myquuery, con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridViewRoom.DataSource = ds.Tables[0];
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

        private void datelbl_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            datelbl.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
