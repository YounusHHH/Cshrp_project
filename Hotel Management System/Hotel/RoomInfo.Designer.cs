
namespace Hotel
{
    partial class RoomInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomInfo));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.datelbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.roomPhone = new System.Windows.Forms.TextBox();
            this.roomNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Yesradio = new System.Windows.Forms.RadioButton();
            this.Noradio = new System.Windows.Forms.RadioButton();
            this.delete = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.AddRoom = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridViewRoom = new System.Windows.Forms.DataGridView();
            this.RoomSearch = new System.Windows.Forms.Button();
            this.searchRBox = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoom)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.datelbl);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(706, 87);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(671, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 23);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // datelbl
            // 
            this.datelbl.AutoSize = true;
            this.datelbl.Font = new System.Drawing.Font("Sylfaen", 18F, System.Drawing.FontStyle.Bold);
            this.datelbl.Location = new System.Drawing.Point(568, 60);
            this.datelbl.Name = "datelbl";
            this.datelbl.Size = new System.Drawing.Size(65, 31);
            this.datelbl.TabIndex = 2;
            this.datelbl.Text = "Date";
            this.datelbl.Click += new System.EventHandler(this.datelbl_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sylfaen", 21.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(224, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Room Information";
            // 
            // roomPhone
            // 
            this.roomPhone.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.roomPhone.ForeColor = System.Drawing.Color.DodgerBlue;
            this.roomPhone.Location = new System.Drawing.Point(10, 178);
            this.roomPhone.Name = "roomPhone";
            this.roomPhone.Size = new System.Drawing.Size(172, 27);
            this.roomPhone.TabIndex = 4;
            this.roomPhone.Text = "Room Phone";
            // 
            // roomNo
            // 
            this.roomNo.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.roomNo.ForeColor = System.Drawing.Color.DodgerBlue;
            this.roomNo.Location = new System.Drawing.Point(10, 127);
            this.roomNo.Name = "roomNo";
            this.roomNo.Size = new System.Drawing.Size(172, 27);
            this.roomNo.TabIndex = 3;
            this.roomNo.Text = "Room Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(14, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Free";
            // 
            // Yesradio
            // 
            this.Yesradio.AutoSize = true;
            this.Yesradio.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Yesradio.Location = new System.Drawing.Point(74, 229);
            this.Yesradio.Name = "Yesradio";
            this.Yesradio.Size = new System.Drawing.Size(55, 25);
            this.Yesradio.TabIndex = 6;
            this.Yesradio.TabStop = true;
            this.Yesradio.Text = "Yes";
            this.Yesradio.UseVisualStyleBackColor = true;
            // 
            // Noradio
            // 
            this.Noradio.AutoSize = true;
            this.Noradio.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Noradio.Location = new System.Drawing.Point(138, 229);
            this.Noradio.Name = "Noradio";
            this.Noradio.Size = new System.Drawing.Size(51, 25);
            this.Noradio.TabIndex = 7;
            this.Noradio.TabStop = true;
            this.Noradio.Text = "No";
            this.Noradio.UseVisualStyleBackColor = true;
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.DodgerBlue;
            this.delete.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic);
            this.delete.ForeColor = System.Drawing.Color.White;
            this.delete.Location = new System.Drawing.Point(138, 281);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(81, 41);
            this.delete.TabIndex = 11;
            this.delete.Text = "DELETE";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // edit
            // 
            this.edit.BackColor = System.Drawing.Color.DodgerBlue;
            this.edit.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic);
            this.edit.ForeColor = System.Drawing.Color.White;
            this.edit.Location = new System.Drawing.Point(70, 281);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(63, 41);
            this.edit.TabIndex = 10;
            this.edit.Text = "EDIT";
            this.edit.UseVisualStyleBackColor = false;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // AddRoom
            // 
            this.AddRoom.BackColor = System.Drawing.Color.DodgerBlue;
            this.AddRoom.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic);
            this.AddRoom.ForeColor = System.Drawing.Color.White;
            this.AddRoom.Location = new System.Drawing.Point(3, 281);
            this.AddRoom.Name = "AddRoom";
            this.AddRoom.Size = new System.Drawing.Size(63, 41);
            this.AddRoom.TabIndex = 9;
            this.AddRoom.Text = "ADD";
            this.AddRoom.UseVisualStyleBackColor = false;
            this.AddRoom.Click += new System.EventHandler(this.AddRoom_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(537, 93);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dataGridViewRoom
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.dataGridViewRoom.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewRoom.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewRoom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRoom.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 12F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewRoom.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewRoom.Location = new System.Drawing.Point(225, 124);
            this.dataGridViewRoom.Name = "dataGridViewRoom";
            this.dataGridViewRoom.RowTemplate.Height = 25;
            this.dataGridViewRoom.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRoom.Size = new System.Drawing.Size(457, 256);
            this.dataGridViewRoom.TabIndex = 15;
            this.dataGridViewRoom.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRoom_CellContentClick);
            // 
            // RoomSearch
            // 
            this.RoomSearch.BackColor = System.Drawing.Color.DodgerBlue;
            this.RoomSearch.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic);
            this.RoomSearch.ForeColor = System.Drawing.Color.White;
            this.RoomSearch.Location = new System.Drawing.Point(440, 91);
            this.RoomSearch.Name = "RoomSearch";
            this.RoomSearch.Size = new System.Drawing.Size(84, 29);
            this.RoomSearch.TabIndex = 14;
            this.RoomSearch.Text = "Search";
            this.RoomSearch.UseVisualStyleBackColor = false;
            this.RoomSearch.Click += new System.EventHandler(this.RoomSearch_Click);
            // 
            // searchRBox
            // 
            this.searchRBox.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.searchRBox.ForeColor = System.Drawing.Color.DodgerBlue;
            this.searchRBox.Location = new System.Drawing.Point(231, 93);
            this.searchRBox.Name = "searchRBox";
            this.searchRBox.Size = new System.Drawing.Size(203, 27);
            this.searchRBox.TabIndex = 13;
            this.searchRBox.Text = "Search Room";
            this.searchRBox.TextChanged += new System.EventHandler(this.searchRBox_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // RoomInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 390);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridViewRoom);
            this.Controls.Add(this.RoomSearch);
            this.Controls.Add(this.searchRBox);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.AddRoom);
            this.Controls.Add(this.Noradio);
            this.Controls.Add(this.Yesradio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.roomPhone);
            this.Controls.Add(this.roomNo);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Name = "RoomInfo";
            this.Text = "RoomInfo";
            this.Load += new System.EventHandler(this.RoomInfo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox roomPhone;
        private System.Windows.Forms.TextBox roomNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton Yesradio;
        private System.Windows.Forms.RadioButton Noradio;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button AddRoom;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridViewRoom;
        private System.Windows.Forms.Button RoomSearch;
        private System.Windows.Forms.TextBox searchRBox;
        private System.Windows.Forms.Label datelbl;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}