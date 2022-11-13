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
    public partial class Reservation : Form
       
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\project\Hotel\Hotel\HotelDatabase.mdf;Integrated Security=True;Connect Timeout=30");
       
        public Reservation()
        {
            InitializeComponent();
        }
        public void populate()
        {
            con.Open();
            string Myquuery = "select * from Reservation_tbl";
            SqlDataAdapter da = new SqlDataAdapter(Myquuery, con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridViewRes.DataSource = ds.Tables[0];
            con.Close();
        }



        private void Reservation_Load(object sender, EventArgs e)
        {
            datelbl1.Text = DateTime.Now.ToLongTimeString();
            timer2.Start();
            populate();

            fillRoom();
            fillClinet();


        }

        public void fillRoom()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select RoomId from Room_tbl", con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("RoomId", typeof(int));
            dt.Load(rdr);
            roomCombo.ValueMember = "RoomId";
            roomCombo.DataSource = dt;
            con.Close();

        }
        public void fillClinet()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select ClientName from Client_tbl", con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("ClientName", typeof(string));
            dt.Load(rdr);
            clientCombo.ValueMember = "ClientName";
            clientCombo.DataSource = dt;
            con.Close();

        }

        private void dateIn_ValueChanged(object sender, EventArgs e)
        {



        }

        private void dateOut_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (ReservationId.Text == "")
            {
                MessageBox.Show("Enter the Reservation ID to be Add ");
            }
            else
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into Reservation_tbl values ('" + ReservationId.Text + "','" + clientCombo.SelectedValue.ToString() + "','" + roomCombo.SelectedValue.ToString() + "','" + dateIn.Value + "','" + dateOut.Value + "')", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Reservation Successfully Added");
                con.Close();
                populate();

            }
            
        }

  

        private void edit_Click(object sender, EventArgs e)
        {

            con.Open();
            string Myquuery = "UPDATE Reservation_tbl set ResId='" + ReservationId.Text + "',Clinet='" + clientCombo.SelectedValue.ToString() + "',Room='" + roomCombo.SelectedValue.ToString() + "',Datein='" + dateIn.Value.ToString() + "',DateOut='" + dateOut.Value.ToString() + "' where ResId=" + ReservationId.Text + ";";
            SqlCommand cmd = new SqlCommand(Myquuery, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Reservation successfully Edited");

            con.Close();
            populate();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (ReservationId.Text== "")
            {
                MessageBox.Show("Enter the Reservation ID to be deleted ");
            }
            else
            {
                con.Open();
                string query = "delete from Reservation_tbl where ResId = " + ReservationId.Text + "";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Reservation Successfully Deleted ");
                con.Close();
                populate();
            }
            
        }

     

        private void dataGridViewRes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ReservationId.Text = dataGridViewRes.SelectedRows[0].Cells[0].Value.ToString();
            clientCombo.SelectedValue = dataGridViewRes.SelectedRows[0].Cells[1].Value.ToString();
            roomCombo.SelectedValue = dataGridViewRes.SelectedRows[0].Cells[2].Value.ToString();
            dateIn.Text = dataGridViewRes.SelectedRows[0].Cells[3].Value.ToString();
            dateOut.Text = dataGridViewRes.SelectedRows[0].Cells[4].Value.ToString();

        }

        private void ResSearch_Click(object sender, EventArgs e)
        {
            con.Open();
            string Myquuery = "select * from Reservation_tbl where Clinet ='" + searchRBox.Text + "' ";
            SqlDataAdapter da = new SqlDataAdapter(Myquuery, con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridViewRes.DataSource = ds.Tables[0];
            con.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            MainFrom main = new MainFrom();
            main.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void datelbl_Click(object sender, EventArgs e)
        {

        }

        private void datelbl1_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            datelbl1.Text = DateTime.Now.ToLongTimeString();

        }
    }
}
