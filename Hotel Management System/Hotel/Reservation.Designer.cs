
namespace Hotel
{
    partial class Reservation
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reservation));
            this.ReservationId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewRes = new System.Windows.Forms.DataGridView();
            this.ResSearch = new System.Windows.Forms.Button();
            this.searchRBox = new System.Windows.Forms.TextBox();
            this.delete = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.dateIn = new System.Windows.Forms.DateTimePicker();
            this.dateOut = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.datelbl1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.clientCombo = new System.Windows.Forms.ComboBox();
            this.roomCombo = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRes)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ReservationId
            // 
            this.ReservationId.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.ReservationId.ForeColor = System.Drawing.Color.DodgerBlue;
            this.ReservationId.Location = new System.Drawing.Point(10, 135);
            this.ReservationId.Name = "ReservationId";
            this.ReservationId.Size = new System.Drawing.Size(187, 27);
            this.ReservationId.TabIndex = 5;
            this.ReservationId.Text = "Reservation ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(10, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Date In";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(10, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Date Out";
            // 
            // dataGridViewRes
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.dataGridViewRes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewRes.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewRes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewRes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewRes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 12F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewRes.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewRes.Location = new System.Drawing.Point(280, 124);
            this.dataGridViewRes.Name = "dataGridViewRes";
            this.dataGridViewRes.RowTemplate.Height = 25;
            this.dataGridViewRes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRes.Size = new System.Drawing.Size(605, 256);
            this.dataGridViewRes.TabIndex = 19;
            this.dataGridViewRes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRes_CellContentClick);
            // 
            // ResSearch
            // 
            this.ResSearch.BackColor = System.Drawing.Color.DodgerBlue;
            this.ResSearch.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic);
            this.ResSearch.ForeColor = System.Drawing.Color.White;
            this.ResSearch.Location = new System.Drawing.Point(625, 93);
            this.ResSearch.Name = "ResSearch";
            this.ResSearch.Size = new System.Drawing.Size(91, 28);
            this.ResSearch.TabIndex = 18;
            this.ResSearch.Text = "Search";
            this.ResSearch.UseVisualStyleBackColor = false;
            this.ResSearch.Click += new System.EventHandler(this.ResSearch_Click);
            // 
            // searchRBox
            // 
            this.searchRBox.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.searchRBox.ForeColor = System.Drawing.Color.DodgerBlue;
            this.searchRBox.Location = new System.Drawing.Point(415, 94);
            this.searchRBox.MinimumSize = new System.Drawing.Size(157, 26);
            this.searchRBox.Multiline = true;
            this.searchRBox.Name = "searchRBox";
            this.searchRBox.Size = new System.Drawing.Size(205, 27);
            this.searchRBox.TabIndex = 17;
            this.searchRBox.Text = "Reservation  Search";
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.DodgerBlue;
            this.delete.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic);
            this.delete.ForeColor = System.Drawing.Color.White;
            this.delete.Location = new System.Drawing.Point(146, 339);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(78, 41);
            this.delete.TabIndex = 23;
            this.delete.Text = "DELETE";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // edit
            // 
            this.edit.BackColor = System.Drawing.Color.DodgerBlue;
            this.edit.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic);
            this.edit.ForeColor = System.Drawing.Color.White;
            this.edit.Location = new System.Drawing.Point(78, 339);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(63, 41);
            this.edit.TabIndex = 22;
            this.edit.Text = "EDIT";
            this.edit.UseVisualStyleBackColor = false;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.DodgerBlue;
            this.Add.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic);
            this.Add.ForeColor = System.Drawing.Color.White;
            this.Add.Location = new System.Drawing.Point(10, 339);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(63, 41);
            this.Add.TabIndex = 21;
            this.Add.Text = "ADD";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // dateIn
            // 
            this.dateIn.CalendarFont = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic);
            this.dateIn.CalendarForeColor = System.Drawing.Color.DodgerBlue;
            this.dateIn.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.dateIn.Location = new System.Drawing.Point(104, 272);
            this.dateIn.Name = "dateIn";
            this.dateIn.Size = new System.Drawing.Size(170, 21);
            this.dateIn.TabIndex = 24;
            this.dateIn.ValueChanged += new System.EventHandler(this.dateIn_ValueChanged);
            // 
            // dateOut
            // 
            this.dateOut.CalendarFont = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic);
            this.dateOut.CalendarForeColor = System.Drawing.Color.DodgerBlue;
            this.dateOut.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.dateOut.Location = new System.Drawing.Point(104, 307);
            this.dateOut.Name = "dateOut";
            this.dateOut.Size = new System.Drawing.Size(170, 21);
            this.dateOut.TabIndex = 25;
            this.dateOut.ValueChanged += new System.EventHandler(this.dateOut_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.datelbl1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(888, 87);
            this.panel1.TabIndex = 27;
            // 
            // datelbl1
            // 
            this.datelbl1.AutoSize = true;
            this.datelbl1.Font = new System.Drawing.Font("Sylfaen", 18F, System.Drawing.FontStyle.Bold);
            this.datelbl1.Location = new System.Drawing.Point(651, 56);
            this.datelbl1.Name = "datelbl1";
            this.datelbl1.Size = new System.Drawing.Size(65, 31);
            this.datelbl1.TabIndex = 28;
            this.datelbl1.Text = "Date";
            this.datelbl1.Click += new System.EventHandler(this.datelbl1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(850, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 23);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sylfaen", 21.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(224, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reservation Information";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // clientCombo
            // 
            this.clientCombo.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.clientCombo.ForeColor = System.Drawing.Color.DodgerBlue;
            this.clientCombo.FormattingEnabled = true;
            this.clientCombo.Location = new System.Drawing.Point(10, 179);
            this.clientCombo.Name = "clientCombo";
            this.clientCombo.Size = new System.Drawing.Size(187, 29);
            this.clientCombo.TabIndex = 28;
            this.clientCombo.Text = "Client Id";
            // 
            // roomCombo
            // 
            this.roomCombo.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.roomCombo.ForeColor = System.Drawing.Color.DodgerBlue;
            this.roomCombo.FormattingEnabled = true;
            this.roomCombo.Location = new System.Drawing.Point(10, 223);
            this.roomCombo.Name = "roomCombo";
            this.roomCombo.Size = new System.Drawing.Size(187, 29);
            this.roomCombo.TabIndex = 29;
            this.roomCombo.Text = "Room Id";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(722, 95);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 404);
            this.Controls.Add(this.roomCombo);
            this.Controls.Add(this.clientCombo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dateOut);
            this.Controls.Add(this.dateIn);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridViewRes);
            this.Controls.Add(this.ResSearch);
            this.Controls.Add(this.searchRBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ReservationId);
            this.Name = "Reservation";
            this.Text = "Reservation";
            this.Load += new System.EventHandler(this.Reservation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRes)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox ReservationId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridViewRes;
        private System.Windows.Forms.Button ResSearch;
        private System.Windows.Forms.TextBox searchRBox;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.DateTimePicker dateIn;
        private System.Windows.Forms.DateTimePicker dateOut;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox clientCombo;
        private System.Windows.Forms.ComboBox roomCombo;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label datelbl1;
    }
}