
namespace Hotel
{
    partial class Staff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Staff));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.staffGenderF = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.datelbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.staffSearch = new System.Windows.Forms.Button();
            this.searchStaffF = new System.Windows.Forms.TextBox();
            this.delete = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.staffphoneF = new System.Windows.Forms.TextBox();
            this.staffnameF = new System.Windows.Forms.TextBox();
            this.staffidF = new System.Windows.Forms.TextBox();
            this.dataGridViewStaff = new System.Windows.Forms.DataGridView();
            this.staffpass = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStaff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // staffGenderF
            // 
            this.staffGenderF.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.staffGenderF.ForeColor = System.Drawing.Color.DodgerBlue;
            this.staffGenderF.FormattingEnabled = true;
            this.staffGenderF.Items.AddRange(new object[] {
            "male",
            "female"});
            this.staffGenderF.Location = new System.Drawing.Point(10, 241);
            this.staffGenderF.Name = "staffGenderF";
            this.staffGenderF.Size = new System.Drawing.Size(104, 29);
            this.staffGenderF.TabIndex = 17;
            this.staffGenderF.Text = "Gender";
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
            this.panel1.Size = new System.Drawing.Size(876, 87);
            this.panel1.TabIndex = 13;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(841, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 23);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 26;
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
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sylfaen", 21.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(292, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Staff Information";
            // 
            // staffSearch
            // 
            this.staffSearch.BackColor = System.Drawing.Color.DodgerBlue;
            this.staffSearch.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic);
            this.staffSearch.ForeColor = System.Drawing.Color.White;
            this.staffSearch.Location = new System.Drawing.Point(574, 93);
            this.staffSearch.Name = "staffSearch";
            this.staffSearch.Size = new System.Drawing.Size(83, 30);
            this.staffSearch.TabIndex = 22;
            this.staffSearch.Text = "Search";
            this.staffSearch.UseVisualStyleBackColor = false;
            this.staffSearch.Click += new System.EventHandler(this.staffSearch_Click);
            // 
            // searchStaffF
            // 
            this.searchStaffF.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.searchStaffF.ForeColor = System.Drawing.Color.DodgerBlue;
            this.searchStaffF.Location = new System.Drawing.Point(366, 96);
            this.searchStaffF.Name = "searchStaffF";
            this.searchStaffF.Size = new System.Drawing.Size(195, 27);
            this.searchStaffF.TabIndex = 21;
            this.searchStaffF.Text = "Search Staff";
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.DodgerBlue;
            this.delete.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic);
            this.delete.ForeColor = System.Drawing.Color.White;
            this.delete.Location = new System.Drawing.Point(146, 320);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(79, 47);
            this.delete.TabIndex = 20;
            this.delete.Text = "DELETE";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // edit
            // 
            this.edit.BackColor = System.Drawing.Color.DodgerBlue;
            this.edit.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic);
            this.edit.ForeColor = System.Drawing.Color.White;
            this.edit.Location = new System.Drawing.Point(78, 320);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(63, 47);
            this.edit.TabIndex = 19;
            this.edit.Text = "EDIT";
            this.edit.UseVisualStyleBackColor = false;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.DodgerBlue;
            this.Add.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic);
            this.Add.ForeColor = System.Drawing.Color.White;
            this.Add.Location = new System.Drawing.Point(10, 320);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(63, 47);
            this.Add.TabIndex = 18;
            this.Add.Text = "ADD";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // staffphoneF
            // 
            this.staffphoneF.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.staffphoneF.ForeColor = System.Drawing.Color.DodgerBlue;
            this.staffphoneF.Location = new System.Drawing.Point(10, 200);
            this.staffphoneF.Name = "staffphoneF";
            this.staffphoneF.Size = new System.Drawing.Size(172, 27);
            this.staffphoneF.TabIndex = 16;
            this.staffphoneF.Text = "Staff Number ";
            // 
            // staffnameF
            // 
            this.staffnameF.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.staffnameF.ForeColor = System.Drawing.Color.DodgerBlue;
            this.staffnameF.Location = new System.Drawing.Point(10, 158);
            this.staffnameF.Name = "staffnameF";
            this.staffnameF.Size = new System.Drawing.Size(172, 27);
            this.staffnameF.TabIndex = 15;
            this.staffnameF.Text = "Staff Name";
            // 
            // staffidF
            // 
            this.staffidF.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.staffidF.ForeColor = System.Drawing.Color.DodgerBlue;
            this.staffidF.Location = new System.Drawing.Point(10, 116);
            this.staffidF.Name = "staffidF";
            this.staffidF.Size = new System.Drawing.Size(172, 27);
            this.staffidF.TabIndex = 14;
            this.staffidF.Text = "Staff ID";
            // 
            // dataGridViewStaff
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.dataGridViewStaff.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewStaff.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewStaff.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewStaff.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewStaff.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewStaff.Location = new System.Drawing.Point(231, 129);
            this.dataGridViewStaff.Name = "dataGridViewStaff";
            this.dataGridViewStaff.RowTemplate.Height = 25;
            this.dataGridViewStaff.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewStaff.Size = new System.Drawing.Size(645, 256);
            this.dataGridViewStaff.TabIndex = 23;
            this.dataGridViewStaff.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStaff_CellContentClick);
            // 
            // staffpass
            // 
            this.staffpass.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.staffpass.ForeColor = System.Drawing.Color.DodgerBlue;
            this.staffpass.Location = new System.Drawing.Point(10, 283);
            this.staffpass.Name = "staffpass";
            this.staffpass.Size = new System.Drawing.Size(172, 27);
            this.staffpass.TabIndex = 25;
            this.staffpass.Text = "Password";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(663, 96);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 406);
            this.Controls.Add(this.staffpass);
            this.Controls.Add(this.staffGenderF);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.staffSearch);
            this.Controls.Add(this.searchStaffF);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.staffphoneF);
            this.Controls.Add(this.staffnameF);
            this.Controls.Add(this.staffidF);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridViewStaff);
            this.Name = "Staff";
            this.Text = "Staff";
            this.Load += new System.EventHandler(this.Staff_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStaff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox staffGenderF;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label datelbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button staffSearch;
        private System.Windows.Forms.TextBox searchStaffF;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.TextBox staffphoneF;
        private System.Windows.Forms.TextBox staffnameF;
        private System.Windows.Forms.TextBox staffidF;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridViewStaff;
        private System.Windows.Forms.TextBox staffpass;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}