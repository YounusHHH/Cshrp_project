
namespace Hotel
{
    partial class ClinetInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClinetInfo));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.datelbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.clientidtbl = new System.Windows.Forms.TextBox();
            this.ClientNameF = new System.Windows.Forms.TextBox();
            this.ClientPhoneF = new System.Windows.Forms.TextBox();
            this.ClientCountryF = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.searchNBox = new System.Windows.Forms.TextBox();
            this.ClientSearch = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(839, 100);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(798, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // datelbl
            // 
            this.datelbl.AutoSize = true;
            this.datelbl.Font = new System.Drawing.Font("Sylfaen", 18F, System.Drawing.FontStyle.Bold);
            this.datelbl.Location = new System.Drawing.Point(663, 69);
            this.datelbl.Name = "datelbl";
            this.datelbl.Size = new System.Drawing.Size(65, 31);
            this.datelbl.TabIndex = 2;
            this.datelbl.Text = "Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sylfaen", 21.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(261, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Client Information";
            // 
            // clientidtbl
            // 
            this.clientidtbl.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.clientidtbl.ForeColor = System.Drawing.Color.DodgerBlue;
            this.clientidtbl.Location = new System.Drawing.Point(12, 128);
            this.clientidtbl.Name = "clientidtbl";
            this.clientidtbl.Size = new System.Drawing.Size(200, 27);
            this.clientidtbl.TabIndex = 1;
            this.clientidtbl.Text = "Client ID";
            // 
            // ClientNameF
            // 
            this.ClientNameF.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.ClientNameF.ForeColor = System.Drawing.Color.DodgerBlue;
            this.ClientNameF.Location = new System.Drawing.Point(12, 176);
            this.ClientNameF.Name = "ClientNameF";
            this.ClientNameF.Size = new System.Drawing.Size(200, 27);
            this.ClientNameF.TabIndex = 2;
            this.ClientNameF.Text = "Client Name";
            this.ClientNameF.TextChanged += new System.EventHandler(this.ClientNameF_TextChanged);
            // 
            // ClientPhoneF
            // 
            this.ClientPhoneF.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.ClientPhoneF.ForeColor = System.Drawing.Color.DodgerBlue;
            this.ClientPhoneF.Location = new System.Drawing.Point(12, 225);
            this.ClientPhoneF.Name = "ClientPhoneF";
            this.ClientPhoneF.Size = new System.Drawing.Size(200, 27);
            this.ClientPhoneF.TabIndex = 3;
            this.ClientPhoneF.Text = "Phone Number ";
            // 
            // ClientCountryF
            // 
            this.ClientCountryF.ForeColor = System.Drawing.Color.DodgerBlue;
            this.ClientCountryF.FormattingEnabled = true;
            this.ClientCountryF.Items.AddRange(new object[] {
            "Turkey ",
            "USA",
            "UAE",
            "Iraq",
            "Canada"});
            this.ClientCountryF.Location = new System.Drawing.Point(12, 274);
            this.ClientCountryF.Name = "ClientCountryF";
            this.ClientCountryF.Size = new System.Drawing.Size(121, 29);
            this.ClientCountryF.TabIndex = 4;
            this.ClientCountryF.Text = "Country";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 47);
            this.button1.TabIndex = 6;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // edit
            // 
            this.edit.BackColor = System.Drawing.Color.DodgerBlue;
            this.edit.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic);
            this.edit.ForeColor = System.Drawing.Color.White;
            this.edit.Location = new System.Drawing.Point(91, 322);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(73, 47);
            this.edit.TabIndex = 7;
            this.edit.Text = "EDIT";
            this.edit.UseVisualStyleBackColor = false;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.DodgerBlue;
            this.delete.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic);
            this.delete.ForeColor = System.Drawing.Color.White;
            this.delete.Location = new System.Drawing.Point(170, 322);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(85, 47);
            this.delete.TabIndex = 8;
            this.delete.Text = "DELETE";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // searchNBox
            // 
            this.searchNBox.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.searchNBox.ForeColor = System.Drawing.Color.DodgerBlue;
            this.searchNBox.Location = new System.Drawing.Point(338, 110);
            this.searchNBox.Name = "searchNBox";
            this.searchNBox.Size = new System.Drawing.Size(200, 27);
            this.searchNBox.TabIndex = 9;
            this.searchNBox.Text = "Search Name";
            // 
            // ClientSearch
            // 
            this.ClientSearch.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSearch.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic);
            this.ClientSearch.ForeColor = System.Drawing.Color.White;
            this.ClientSearch.Location = new System.Drawing.Point(554, 107);
            this.ClientSearch.Name = "ClientSearch";
            this.ClientSearch.Size = new System.Drawing.Size(85, 30);
            this.ClientSearch.TabIndex = 10;
            this.ClientSearch.Text = "Search";
            this.ClientSearch.UseVisualStyleBackColor = false;
            this.ClientSearch.Click += new System.EventHandler(this.ClientSearch_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(261, 143);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(578, 226);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(645, 110);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ClinetInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 394);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ClientSearch);
            this.Controls.Add(this.searchNBox);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ClientCountryF);
            this.Controls.Add(this.ClientPhoneF);
            this.Controls.Add(this.ClientNameF);
            this.Controls.Add(this.clientidtbl);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ClinetInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClinetInfo";
            this.Load += new System.EventHandler(this.ClinetInfo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox clientidtbl;
        private System.Windows.Forms.TextBox ClientName;
        private System.Windows.Forms.TextBox ClientPhoneF;
        private System.Windows.Forms.ComboBox ClientCountryF;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.TextBox searchNBox;
        private System.Windows.Forms.Button ClientSearch;
        private System.Windows.Forms.Label datelbl;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox ClientNameF;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}