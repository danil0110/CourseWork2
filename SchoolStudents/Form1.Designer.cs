
namespace SchoolStudents
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.sideBar = new System.Windows.Forms.Panel();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.labelSex = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtClubID = new System.Windows.Forms.TextBox();
            this.labelClubID = new System.Windows.Forms.Label();
            this.txtClassID = new System.Windows.Forms.TextBox();
            this.labelClassID = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.txtEntryDate = new System.Windows.Forms.TextBox();
            this.labelEntryDate = new System.Windows.Forms.Label();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.labelMiddleName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.comboFilterBy = new System.Windows.Forms.ComboBox();
            this.checkFilter = new System.Windows.Forms.CheckBox();
            this.txtInput1 = new System.Windows.Forms.TextBox();
            this.txtInput2 = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnPreviousPage = new System.Windows.Forms.Button();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.labelTotalPageCount = new System.Windows.Forms.Label();
            this.checkPagination = new System.Windows.Forms.CheckBox();
            this.labelRecordsPerPage = new System.Windows.Forms.Label();
            this.txtRecordsPerPage = new System.Windows.Forms.TextBox();
            this.txtCurrentPage = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.sideBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.AllowUserToOrderColumns = true;
            this.dgvData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(12, 14);
            this.dgvData.MultiSelect = false;
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowTemplate.Height = 25;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(823, 302);
            this.dgvData.TabIndex = 0;
            this.dgvData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellClick);
            // 
            // sideBar
            // 
            this.sideBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sideBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sideBar.Controls.Add(this.rbFemale);
            this.sideBar.Controls.Add(this.rbMale);
            this.sideBar.Controls.Add(this.labelSex);
            this.sideBar.Controls.Add(this.btnSave);
            this.sideBar.Controls.Add(this.txtClubID);
            this.sideBar.Controls.Add(this.labelClubID);
            this.sideBar.Controls.Add(this.txtClassID);
            this.sideBar.Controls.Add(this.labelClassID);
            this.sideBar.Controls.Add(this.txtPhone);
            this.sideBar.Controls.Add(this.labelPhone);
            this.sideBar.Controls.Add(this.txtEntryDate);
            this.sideBar.Controls.Add(this.labelEntryDate);
            this.sideBar.Controls.Add(this.txtMiddleName);
            this.sideBar.Controls.Add(this.labelMiddleName);
            this.sideBar.Controls.Add(this.txtLastName);
            this.sideBar.Controls.Add(this.labelLastName);
            this.sideBar.Controls.Add(this.txtFirstName);
            this.sideBar.Controls.Add(this.labelFirstName);
            this.sideBar.Enabled = false;
            this.sideBar.Location = new System.Drawing.Point(841, 14);
            this.sideBar.Name = "sideBar";
            this.sideBar.Size = new System.Drawing.Size(277, 302);
            this.sideBar.TabIndex = 1;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(182, 100);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(65, 19);
            this.rbFemale.TabIndex = 2;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(106, 100);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(52, 19);
            this.rbMale.TabIndex = 2;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // labelSex
            // 
            this.labelSex.AutoSize = true;
            this.labelSex.Location = new System.Drawing.Point(60, 102);
            this.labelSex.Name = "labelSex";
            this.labelSex.Size = new System.Drawing.Size(28, 15);
            this.labelSex.TabIndex = 0;
            this.labelSex.Text = "Sex";
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(182, 266);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtClubID
            // 
            this.txtClubID.Location = new System.Drawing.Point(228, 154);
            this.txtClubID.MaxLength = 3;
            this.txtClubID.Name = "txtClubID";
            this.txtClubID.Size = new System.Drawing.Size(31, 23);
            this.txtClubID.TabIndex = 6;
            // 
            // labelClubID
            // 
            this.labelClubID.AutoSize = true;
            this.labelClubID.Location = new System.Drawing.Point(177, 158);
            this.labelClubID.Name = "labelClubID";
            this.labelClubID.Size = new System.Drawing.Size(44, 15);
            this.labelClubID.TabIndex = 0;
            this.labelClubID.Text = "ClubID";
            // 
            // txtClassID
            // 
            this.txtClassID.Location = new System.Drawing.Point(94, 154);
            this.txtClassID.MaxLength = 3;
            this.txtClassID.Name = "txtClassID";
            this.txtClassID.Size = new System.Drawing.Size(31, 23);
            this.txtClassID.TabIndex = 5;
            // 
            // labelClassID
            // 
            this.labelClassID.AutoSize = true;
            this.labelClassID.Location = new System.Drawing.Point(42, 158);
            this.labelClassID.Name = "labelClassID";
            this.labelClassID.Size = new System.Drawing.Size(46, 15);
            this.labelClassID.TabIndex = 0;
            this.labelClassID.Text = "ClassID";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(94, 183);
            this.txtPhone.MaxLength = 13;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(165, 23);
            this.txtPhone.TabIndex = 7;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(45, 187);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(42, 15);
            this.labelPhone.TabIndex = 0;
            this.labelPhone.Text = "Phone";
            // 
            // txtEntryDate
            // 
            this.txtEntryDate.Location = new System.Drawing.Point(94, 125);
            this.txtEntryDate.MaxLength = 10;
            this.txtEntryDate.Name = "txtEntryDate";
            this.txtEntryDate.Size = new System.Drawing.Size(165, 23);
            this.txtEntryDate.TabIndex = 4;
            // 
            // labelEntryDate
            // 
            this.labelEntryDate.AutoSize = true;
            this.labelEntryDate.Location = new System.Drawing.Point(24, 129);
            this.labelEntryDate.Name = "labelEntryDate";
            this.labelEntryDate.Size = new System.Drawing.Size(63, 15);
            this.labelEntryDate.TabIndex = 0;
            this.labelEntryDate.Text = "EntryDate";
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.Location = new System.Drawing.Point(94, 68);
            this.txtMiddleName.MaxLength = 100;
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(165, 23);
            this.txtMiddleName.TabIndex = 3;
            // 
            // labelMiddleName
            // 
            this.labelMiddleName.AutoSize = true;
            this.labelMiddleName.Location = new System.Drawing.Point(10, 72);
            this.labelMiddleName.Name = "labelMiddleName";
            this.labelMiddleName.Size = new System.Drawing.Size(78, 15);
            this.labelMiddleName.TabIndex = 0;
            this.labelMiddleName.Text = "MiddleName";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(94, 39);
            this.txtLastName.MaxLength = 100;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(165, 23);
            this.txtLastName.TabIndex = 2;
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(26, 43);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(62, 15);
            this.labelLastName.TabIndex = 0;
            this.labelLastName.Text = "LastName";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(94, 10);
            this.txtFirstName.MaxLength = 100;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(165, 23);
            this.txtFirstName.TabIndex = 1;
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(24, 14);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(64, 15);
            this.labelFirstName.TabIndex = 0;
            this.labelFirstName.Text = "FirstName";
            // 
            // btnInsert
            // 
            this.btnInsert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInsert.Location = new System.Drawing.Point(598, 321);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 0;
            this.btnInsert.TabStop = false;
            this.btnInsert.Text = "INSERT";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.Location = new System.Drawing.Point(679, 321);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.TabStop = false;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(760, 321);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.TabStop = false;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // comboFilterBy
            // 
            this.comboFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFilterBy.Enabled = false;
            this.comboFilterBy.FormattingEnabled = true;
            this.comboFilterBy.Items.AddRange(new object[] {
            "FirstName",
            "LastName",
            "MiddleName",
            "Sex",
            "EntryDate",
            "EntryDate (Range)",
            "ClassID",
            "ClubID",
            "Phone"});
            this.comboFilterBy.Location = new System.Drawing.Point(13, 349);
            this.comboFilterBy.Name = "comboFilterBy";
            this.comboFilterBy.Size = new System.Drawing.Size(142, 23);
            this.comboFilterBy.TabIndex = 9;
            this.comboFilterBy.SelectedIndexChanged += new System.EventHandler(this.comboFilterBy_SelectedIndexChanged);
            // 
            // checkFilter
            // 
            this.checkFilter.AutoSize = true;
            this.checkFilter.Location = new System.Drawing.Point(13, 324);
            this.checkFilter.Name = "checkFilter";
            this.checkFilter.Size = new System.Drawing.Size(55, 19);
            this.checkFilter.TabIndex = 10;
            this.checkFilter.Text = "Filter";
            this.checkFilter.UseVisualStyleBackColor = true;
            this.checkFilter.CheckedChanged += new System.EventHandler(this.checkFilter_CheckedChanged);
            // 
            // txtInput1
            // 
            this.txtInput1.Enabled = false;
            this.txtInput1.Location = new System.Drawing.Point(13, 378);
            this.txtInput1.MaxLength = 100;
            this.txtInput1.Name = "txtInput1";
            this.txtInput1.Size = new System.Drawing.Size(142, 23);
            this.txtInput1.TabIndex = 3;
            // 
            // txtInput2
            // 
            this.txtInput2.Location = new System.Drawing.Point(161, 378);
            this.txtInput2.MaxLength = 100;
            this.txtInput2.Name = "txtInput2";
            this.txtInput2.Size = new System.Drawing.Size(142, 23);
            this.txtInput2.TabIndex = 3;
            this.txtInput2.Visible = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(80, 322);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 11;
            this.btnRefresh.Text = "REFRESH";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnPreviousPage
            // 
            this.btnPreviousPage.Enabled = false;
            this.btnPreviousPage.Location = new System.Drawing.Point(355, 322);
            this.btnPreviousPage.Name = "btnPreviousPage";
            this.btnPreviousPage.Size = new System.Drawing.Size(31, 23);
            this.btnPreviousPage.TabIndex = 12;
            this.btnPreviousPage.Text = "<";
            this.btnPreviousPage.UseVisualStyleBackColor = true;
            this.btnPreviousPage.Click += new System.EventHandler(this.btnPreviousPage_Click);
            // 
            // btnNextPage
            // 
            this.btnNextPage.Enabled = false;
            this.btnNextPage.Location = new System.Drawing.Point(462, 322);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(31, 23);
            this.btnNextPage.TabIndex = 12;
            this.btnNextPage.Text = ">";
            this.btnNextPage.UseVisualStyleBackColor = true;
            this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
            // 
            // labelTotalPageCount
            // 
            this.labelTotalPageCount.AutoSize = true;
            this.labelTotalPageCount.Enabled = false;
            this.labelTotalPageCount.Location = new System.Drawing.Point(427, 326);
            this.labelTotalPageCount.Name = "labelTotalPageCount";
            this.labelTotalPageCount.Size = new System.Drawing.Size(19, 15);
            this.labelTotalPageCount.TabIndex = 13;
            this.labelTotalPageCount.Text = "/1";
            this.labelTotalPageCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // checkPagination
            // 
            this.checkPagination.AutoSize = true;
            this.checkPagination.Location = new System.Drawing.Point(261, 324);
            this.checkPagination.Name = "checkPagination";
            this.checkPagination.Size = new System.Drawing.Size(84, 19);
            this.checkPagination.TabIndex = 14;
            this.checkPagination.Text = "Pagination";
            this.checkPagination.UseVisualStyleBackColor = true;
            this.checkPagination.CheckedChanged += new System.EventHandler(this.checkPagination_CheckedChanged);
            // 
            // labelRecordsPerPage
            // 
            this.labelRecordsPerPage.AutoSize = true;
            this.labelRecordsPerPage.Enabled = false;
            this.labelRecordsPerPage.Location = new System.Drawing.Point(371, 357);
            this.labelRecordsPerPage.Name = "labelRecordsPerPage";
            this.labelRecordsPerPage.Size = new System.Drawing.Size(104, 15);
            this.labelRecordsPerPage.TabIndex = 15;
            this.labelRecordsPerPage.Text = "Records Per Page";
            // 
            // txtRecordsPerPage
            // 
            this.txtRecordsPerPage.Enabled = false;
            this.txtRecordsPerPage.Location = new System.Drawing.Point(402, 378);
            this.txtRecordsPerPage.MaxLength = 100;
            this.txtRecordsPerPage.Name = "txtRecordsPerPage";
            this.txtRecordsPerPage.Size = new System.Drawing.Size(42, 23);
            this.txtRecordsPerPage.TabIndex = 3;
            // 
            // txtCurrentPage
            // 
            this.txtCurrentPage.Enabled = false;
            this.txtCurrentPage.Location = new System.Drawing.Point(394, 322);
            this.txtCurrentPage.Name = "txtCurrentPage";
            this.txtCurrentPage.Size = new System.Drawing.Size(29, 23);
            this.txtCurrentPage.TabIndex = 16;
            this.txtCurrentPage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCurrentPage_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 413);
            this.Controls.Add(this.txtCurrentPage);
            this.Controls.Add(this.labelRecordsPerPage);
            this.Controls.Add(this.checkPagination);
            this.Controls.Add(this.labelTotalPageCount);
            this.Controls.Add(this.btnNextPage);
            this.Controls.Add(this.btnPreviousPage);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.checkFilter);
            this.Controls.Add(this.comboFilterBy);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.sideBar);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.txtRecordsPerPage);
            this.Controls.Add(this.txtInput2);
            this.Controls.Add(this.txtInput1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(2000, 452);
            this.MinimumSize = new System.Drawing.Size(1147, 452);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SchoolDB (Students)";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.sideBar.ResumeLayout(false);
            this.sideBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Panel sideBar;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.Label labelSex;
        private System.Windows.Forms.TextBox txtClassID;
        private System.Windows.Forms.Label labelClassID;
        private System.Windows.Forms.TextBox txtEntryDate;
        private System.Windows.Forms.Label labelEntryDate;
        private System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.Label labelMiddleName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtClubID;
        private System.Windows.Forms.Label labelClubID;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox comboFilterBy;
        private System.Windows.Forms.CheckBox checkFilter;
        private System.Windows.Forms.TextBox txtInput1;
        private System.Windows.Forms.TextBox txtInput2;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnPreviousPage;
        private System.Windows.Forms.Button btnNextPage;
        private System.Windows.Forms.Label labelTotalPageCount;
        private System.Windows.Forms.CheckBox checkPagination;
        private System.Windows.Forms.Label labelRecordsPerPage;
        private System.Windows.Forms.TextBox txtRecordsPerPage;
        private System.Windows.Forms.TextBox txtCurrentPage;
    }
}

