
namespace Covid_Patient_Tracking_system
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Header = new System.Windows.Forms.Label();
            this.PatientDetailsBtn = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.MedicalStaffBtn = new System.Windows.Forms.Button();
            this.PatientTreatmentBtn = new System.Windows.Forms.Button();
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Addbtn = new System.Windows.Forms.Button();
            this.Province = new System.Windows.Forms.ComboBox();
            this.MedicalHistory = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Phone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Age = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.City = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MedicalStaffDetails = new System.Windows.Forms.GroupBox();
            this.StaffTitle = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.StaffDepartment = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.StaffAdd = new System.Windows.Forms.Button();
            this.StaffAddress = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.StaffPhone = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.StaffDestination = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.StaffName = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.PatientTreatment1 = new System.Windows.Forms.GroupBox();
            this.TestDate = new System.Windows.Forms.DateTimePicker();
            this.MedicineDate = new System.Windows.Forms.DateTimePicker();
            this.TPatientName = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.MedicalStatus = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.BedNumber = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.Test = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.NurseAllocated = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.TPatientAddBtn = new System.Windows.Forms.Button();
            this.DoctorAllocated = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.MedicineName = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.MedicalStaffDetails.SuspendLayout();
            this.PatientTreatment1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.AutoSize = true;
            this.Header.BackColor = System.Drawing.Color.DimGray;
            this.Header.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Header.Font = new System.Drawing.Font("Showcard Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Header.ForeColor = System.Drawing.Color.Honeydew;
            this.Header.Location = new System.Drawing.Point(370, 15);
            this.Header.Name = "Header";
            this.Header.Padding = new System.Windows.Forms.Padding(15);
            this.Header.Size = new System.Drawing.Size(536, 68);
            this.Header.TabIndex = 0;
            this.Header.Text = "Covid Patient Tracking system";
            this.Header.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Header.Click += new System.EventHandler(this.label1_Click);
            // 
            // PatientDetailsBtn
            // 
            this.PatientDetailsBtn.BackColor = System.Drawing.Color.Turquoise;
            this.PatientDetailsBtn.Font = new System.Drawing.Font("New Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PatientDetailsBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PatientDetailsBtn.Location = new System.Drawing.Point(610, 221);
            this.PatientDetailsBtn.Name = "PatientDetailsBtn";
            this.PatientDetailsBtn.Padding = new System.Windows.Forms.Padding(5);
            this.PatientDetailsBtn.Size = new System.Drawing.Size(103, 52);
            this.PatientDetailsBtn.TabIndex = 1;
            this.PatientDetailsBtn.Text = "Patient Details";
            this.PatientDetailsBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.PatientDetailsBtn.UseVisualStyleBackColor = false;
            this.PatientDetailsBtn.Click += new System.EventHandler(this.PatientDetailsBtn_Click);
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.SkyBlue;
            this.Search.Font = new System.Drawing.Font("Georgia", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Search.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Search.Location = new System.Drawing.Point(936, 145);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(79, 36);
            this.Search.TabIndex = 2;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Delete
            // 
            this.Delete.AutoSize = true;
            this.Delete.BackColor = System.Drawing.Color.Crimson;
            this.Delete.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Delete.ForeColor = System.Drawing.Color.LavenderBlush;
            this.Delete.Location = new System.Drawing.Point(420, 562);
            this.Delete.Name = "Delete";
            this.Delete.Padding = new System.Windows.Forms.Padding(3);
            this.Delete.Size = new System.Drawing.Size(96, 43);
            this.Delete.TabIndex = 4;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Save
            // 
            this.Save.AutoSize = true;
            this.Save.BackColor = System.Drawing.Color.Khaki;
            this.Save.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Save.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Save.Location = new System.Drawing.Point(420, 508);
            this.Save.Name = "Save";
            this.Save.Padding = new System.Windows.Forms.Padding(5);
            this.Save.Size = new System.Drawing.Size(96, 35);
            this.Save.TabIndex = 5;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Add
            // 
            this.Add.AutoSize = true;
            this.Add.BackColor = System.Drawing.Color.LimeGreen;
            this.Add.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Add.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Add.Location = new System.Drawing.Point(420, 444);
            this.Add.Name = "Add";
            this.Add.Padding = new System.Windows.Forms.Padding(5);
            this.Add.Size = new System.Drawing.Size(112, 43);
            this.Add.TabIndex = 6;
            this.Add.Text = " Edit / Update";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // MedicalStaffBtn
            // 
            this.MedicalStaffBtn.BackColor = System.Drawing.Color.Turquoise;
            this.MedicalStaffBtn.Font = new System.Drawing.Font("New Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MedicalStaffBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MedicalStaffBtn.Location = new System.Drawing.Point(784, 224);
            this.MedicalStaffBtn.Name = "MedicalStaffBtn";
            this.MedicalStaffBtn.Size = new System.Drawing.Size(103, 54);
            this.MedicalStaffBtn.TabIndex = 9;
            this.MedicalStaffBtn.Text = "Medical Staff Details";
            this.MedicalStaffBtn.UseVisualStyleBackColor = false;
            this.MedicalStaffBtn.Click += new System.EventHandler(this.MedicalStaffBtn_Click);
            // 
            // PatientTreatmentBtn
            // 
            this.PatientTreatmentBtn.BackColor = System.Drawing.Color.Turquoise;
            this.PatientTreatmentBtn.Font = new System.Drawing.Font("New Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PatientTreatmentBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PatientTreatmentBtn.Location = new System.Drawing.Point(970, 222);
            this.PatientTreatmentBtn.Name = "PatientTreatmentBtn";
            this.PatientTreatmentBtn.Size = new System.Drawing.Size(103, 54);
            this.PatientTreatmentBtn.TabIndex = 10;
            this.PatientTreatmentBtn.Text = "Patient Treatment";
            this.PatientTreatmentBtn.UseVisualStyleBackColor = false;
            this.PatientTreatmentBtn.Click += new System.EventHandler(this.PatientTreatmentBtn_Click);
            // 
            // DataGrid
            // 
            this.DataGrid.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.DataGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataGrid.Location = new System.Drawing.Point(567, 387);
            this.DataGrid.Name = "DataGrid";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DataGrid.RowTemplate.Height = 25;
            this.DataGrid.Size = new System.Drawing.Size(506, 328);
            this.DataGrid.TabIndex = 11;
            this.DataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Lavender;
            this.textBox1.Location = new System.Drawing.Point(610, 154);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(306, 23);
            this.textBox1.TabIndex = 12;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.GhostWhite;
            this.groupBox1.Controls.Add(this.Addbtn);
            this.groupBox1.Controls.Add(this.Province);
            this.groupBox1.Controls.Add(this.MedicalHistory);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.Address);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.Phone);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Age);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.City);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Name);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.groupBox1.Location = new System.Drawing.Point(38, 159);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(361, 532);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Patient Details";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Addbtn
            // 
            this.Addbtn.Image = ((System.Drawing.Image)(resources.GetObject("Addbtn.Image")));
            this.Addbtn.Location = new System.Drawing.Point(118, 487);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(74, 37);
            this.Addbtn.TabIndex = 15;
            this.Addbtn.UseVisualStyleBackColor = true;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // Province
            // 
            this.Province.FormattingEnabled = true;
            this.Province.Items.AddRange(new object[] {
            "Punjab",
            "Sindh ",
            "KPK",
            "Balochistan",
            "Fata"});
            this.Province.Location = new System.Drawing.Point(108, 153);
            this.Province.Name = "Province";
            this.Province.Size = new System.Drawing.Size(121, 28);
            this.Province.TabIndex = 14;
            this.Province.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // MedicalHistory
            // 
            this.MedicalHistory.Location = new System.Drawing.Point(161, 361);
            this.MedicalHistory.Name = "MedicalHistory";
            this.MedicalHistory.Size = new System.Drawing.Size(134, 96);
            this.MedicalHistory.TabIndex = 13;
            this.MedicalHistory.Text = "";
            this.MedicalHistory.TextChanged += new System.EventHandler(this.MedicalHistory_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(8, 389);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Medical History";
            // 
            // Address
            // 
            this.Address.Location = new System.Drawing.Point(97, 299);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(256, 28);
            this.Address.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(13, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Address";
            // 
            // Phone
            // 
            this.Phone.Location = new System.Drawing.Point(118, 229);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(177, 28);
            this.Phone.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(8, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Phone No";
            // 
            // Age
            // 
            this.Age.Location = new System.Drawing.Point(267, 86);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(71, 28);
            this.Age.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(205, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Age";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(8, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Province";
            // 
            // City
            // 
            this.City.Location = new System.Drawing.Point(72, 89);
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(100, 28);
            this.City.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(17, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "City";
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(142, 42);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(196, 28);
            this.Name.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(8, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name of Patient";
            this.label1.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // MedicalStaffDetails
            // 
            this.MedicalStaffDetails.BackColor = System.Drawing.Color.GhostWhite;
            this.MedicalStaffDetails.Controls.Add(this.StaffTitle);
            this.MedicalStaffDetails.Controls.Add(this.label11);
            this.MedicalStaffDetails.Controls.Add(this.StaffDepartment);
            this.MedicalStaffDetails.Controls.Add(this.label8);
            this.MedicalStaffDetails.Controls.Add(this.StaffAdd);
            this.MedicalStaffDetails.Controls.Add(this.StaffAddress);
            this.MedicalStaffDetails.Controls.Add(this.label9);
            this.MedicalStaffDetails.Controls.Add(this.StaffPhone);
            this.MedicalStaffDetails.Controls.Add(this.label10);
            this.MedicalStaffDetails.Controls.Add(this.StaffDestination);
            this.MedicalStaffDetails.Controls.Add(this.label13);
            this.MedicalStaffDetails.Controls.Add(this.StaffName);
            this.MedicalStaffDetails.Controls.Add(this.label14);
            this.MedicalStaffDetails.Cursor = System.Windows.Forms.Cursors.Default;
            this.MedicalStaffDetails.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.MedicalStaffDetails.ForeColor = System.Drawing.SystemColors.MenuText;
            this.MedicalStaffDetails.Location = new System.Drawing.Point(38, 154);
            this.MedicalStaffDetails.Name = "MedicalStaffDetails";
            this.MedicalStaffDetails.Padding = new System.Windows.Forms.Padding(5);
            this.MedicalStaffDetails.Size = new System.Drawing.Size(361, 462);
            this.MedicalStaffDetails.TabIndex = 14;
            this.MedicalStaffDetails.TabStop = false;
            this.MedicalStaffDetails.Text = "Medical Staff Details";
            // 
            // StaffTitle
            // 
            this.StaffTitle.Location = new System.Drawing.Point(161, 135);
            this.StaffTitle.Name = "StaffTitle";
            this.StaffTitle.Size = new System.Drawing.Size(158, 28);
            this.StaffTitle.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label11.Location = new System.Drawing.Point(38, 143);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 20);
            this.label11.TabIndex = 18;
            this.label11.Text = "Title";
            // 
            // StaffDepartment
            // 
            this.StaffDepartment.Location = new System.Drawing.Point(154, 336);
            this.StaffDepartment.Name = "StaffDepartment";
            this.StaffDepartment.Size = new System.Drawing.Size(158, 28);
            this.StaffDepartment.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Location = new System.Drawing.Point(12, 344);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Department";
            // 
            // StaffAdd
            // 
            this.StaffAdd.Image = ((System.Drawing.Image)(resources.GetObject("StaffAdd.Image")));
            this.StaffAdd.Location = new System.Drawing.Point(119, 392);
            this.StaffAdd.Name = "StaffAdd";
            this.StaffAdd.Size = new System.Drawing.Size(74, 37);
            this.StaffAdd.TabIndex = 15;
            this.StaffAdd.UseVisualStyleBackColor = true;
            this.StaffAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // StaffAddress
            // 
            this.StaffAddress.Location = new System.Drawing.Point(105, 260);
            this.StaffAddress.Name = "StaffAddress";
            this.StaffAddress.Size = new System.Drawing.Size(233, 28);
            this.StaffAddress.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Location = new System.Drawing.Point(23, 263);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "Address";
            // 
            // StaffPhone
            // 
            this.StaffPhone.Location = new System.Drawing.Point(142, 195);
            this.StaffPhone.Name = "StaffPhone";
            this.StaffPhone.Size = new System.Drawing.Size(177, 28);
            this.StaffPhone.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label10.Location = new System.Drawing.Point(19, 198);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 20);
            this.label10.TabIndex = 7;
            this.label10.Text = "Phone No";
            // 
            // StaffDestination
            // 
            this.StaffDestination.Location = new System.Drawing.Point(161, 93);
            this.StaffDestination.Name = "StaffDestination";
            this.StaffDestination.Size = new System.Drawing.Size(158, 28);
            this.StaffDestination.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label13.Location = new System.Drawing.Point(19, 101);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 20);
            this.label13.TabIndex = 2;
            this.label13.Text = "Destination";
            // 
            // StaffName
            // 
            this.StaffName.Location = new System.Drawing.Point(142, 42);
            this.StaffName.Name = "StaffName";
            this.StaffName.Size = new System.Drawing.Size(196, 28);
            this.StaffName.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label14.Location = new System.Drawing.Point(35, 45);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 20);
            this.label14.TabIndex = 0;
            this.label14.Text = "Name";
            // 
            // PatientTreatment1
            // 
            this.PatientTreatment1.BackColor = System.Drawing.Color.GhostWhite;
            this.PatientTreatment1.Controls.Add(this.TestDate);
            this.PatientTreatment1.Controls.Add(this.MedicineDate);
            this.PatientTreatment1.Controls.Add(this.TPatientName);
            this.PatientTreatment1.Controls.Add(this.label22);
            this.PatientTreatment1.Controls.Add(this.MedicalStatus);
            this.PatientTreatment1.Controls.Add(this.label21);
            this.PatientTreatment1.Controls.Add(this.BedNumber);
            this.PatientTreatment1.Controls.Add(this.label20);
            this.PatientTreatment1.Controls.Add(this.Test);
            this.PatientTreatment1.Controls.Add(this.label12);
            this.PatientTreatment1.Controls.Add(this.NurseAllocated);
            this.PatientTreatment1.Controls.Add(this.label15);
            this.PatientTreatment1.Controls.Add(this.TPatientAddBtn);
            this.PatientTreatment1.Controls.Add(this.DoctorAllocated);
            this.PatientTreatment1.Controls.Add(this.label16);
            this.PatientTreatment1.Controls.Add(this.label17);
            this.PatientTreatment1.Controls.Add(this.label18);
            this.PatientTreatment1.Controls.Add(this.MedicineName);
            this.PatientTreatment1.Controls.Add(this.label19);
            this.PatientTreatment1.Cursor = System.Windows.Forms.Cursors.Default;
            this.PatientTreatment1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.PatientTreatment1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.PatientTreatment1.Location = new System.Drawing.Point(38, 154);
            this.PatientTreatment1.Name = "PatientTreatment1";
            this.PatientTreatment1.Padding = new System.Windows.Forms.Padding(5);
            this.PatientTreatment1.Size = new System.Drawing.Size(361, 612);
            this.PatientTreatment1.TabIndex = 15;
            this.PatientTreatment1.TabStop = false;
            this.PatientTreatment1.Text = "Patient Treatment Details";
            // 
            // TestDate
            // 
            this.TestDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TestDate.Location = new System.Drawing.Point(181, 240);
            this.TestDate.Name = "TestDate";
            this.TestDate.Size = new System.Drawing.Size(103, 28);
            this.TestDate.TabIndex = 27;
            this.TestDate.ValueChanged += new System.EventHandler(this.TestDate_ValueChanged);
            // 
            // MedicineDate
            // 
            this.MedicineDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.MedicineDate.Location = new System.Drawing.Point(181, 139);
            this.MedicineDate.Name = "MedicineDate";
            this.MedicineDate.Size = new System.Drawing.Size(99, 28);
            this.MedicineDate.TabIndex = 26;
            this.MedicineDate.ValueChanged += new System.EventHandler(this.MedicineDate_ValueChanged);
            // 
            // TPatientName
            // 
            this.TPatientName.Location = new System.Drawing.Point(133, 35);
            this.TPatientName.Name = "TPatientName";
            this.TPatientName.Size = new System.Drawing.Size(196, 28);
            this.TPatientName.TabIndex = 25;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label22.Location = new System.Drawing.Point(9, 38);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(100, 20);
            this.label22.TabIndex = 24;
            this.label22.Text = "PatientName";
            // 
            // MedicalStatus
            // 
            this.MedicalStatus.FormattingEnabled = true;
            this.MedicalStatus.Items.AddRange(new object[] {
            "Serious",
            "Stable",
            "Initial",
            "Recovered"});
            this.MedicalStatus.Location = new System.Drawing.Point(208, 503);
            this.MedicalStatus.Name = "MedicalStatus";
            this.MedicalStatus.Size = new System.Drawing.Size(121, 28);
            this.MedicalStatus.TabIndex = 23;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label21.Location = new System.Drawing.Point(8, 506);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(162, 20);
            this.label21.TabIndex = 22;
            this.label21.Text = "Patient Medical Status";
            // 
            // BedNumber
            // 
            this.BedNumber.Location = new System.Drawing.Point(186, 456);
            this.BedNumber.Name = "BedNumber";
            this.BedNumber.Size = new System.Drawing.Size(158, 28);
            this.BedNumber.TabIndex = 21;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label20.Location = new System.Drawing.Point(40, 456);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(103, 20);
            this.label20.TabIndex = 20;
            this.label20.Text = "Bed Allocated";
            // 
            // Test
            // 
            this.Test.Location = new System.Drawing.Point(162, 185);
            this.Test.Name = "Test";
            this.Test.Size = new System.Drawing.Size(158, 28);
            this.Test.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label12.Location = new System.Drawing.Point(41, 195);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 20);
            this.label12.TabIndex = 18;
            this.label12.Text = "Patient Test";
            // 
            // NurseAllocated
            // 
            this.NurseAllocated.Location = new System.Drawing.Point(181, 398);
            this.NurseAllocated.Name = "NurseAllocated";
            this.NurseAllocated.Size = new System.Drawing.Size(158, 28);
            this.NurseAllocated.TabIndex = 17;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label15.Location = new System.Drawing.Point(15, 382);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(154, 20);
            this.label15.TabIndex = 16;
            this.label15.Text = "Nurse Staff Allocated";
            // 
            // TPatientAddBtn
            // 
            this.TPatientAddBtn.Image = ((System.Drawing.Image)(resources.GetObject("TPatientAddBtn.Image")));
            this.TPatientAddBtn.Location = new System.Drawing.Point(133, 545);
            this.TPatientAddBtn.Name = "TPatientAddBtn";
            this.TPatientAddBtn.Size = new System.Drawing.Size(74, 37);
            this.TPatientAddBtn.TabIndex = 15;
            this.TPatientAddBtn.UseVisualStyleBackColor = true;
            this.TPatientAddBtn.Click += new System.EventHandler(this.TPatientAddBtn_Click);
            // 
            // DoctorAllocated
            // 
            this.DoctorAllocated.Location = new System.Drawing.Point(41, 328);
            this.DoctorAllocated.Name = "DoctorAllocated";
            this.DoctorAllocated.Size = new System.Drawing.Size(302, 28);
            this.DoctorAllocated.TabIndex = 10;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label16.Location = new System.Drawing.Point(15, 297);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(128, 20);
            this.label16.TabIndex = 9;
            this.label16.Text = "Doctors Allocated";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label17.Location = new System.Drawing.Point(36, 245);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(73, 20);
            this.label17.TabIndex = 7;
            this.label17.Text = "Test Date";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label18.Location = new System.Drawing.Point(20, 147);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(125, 20);
            this.label18.TabIndex = 2;
            this.label18.Text = "Date of Medicine";
            // 
            // MedicineName
            // 
            this.MedicineName.Location = new System.Drawing.Point(143, 82);
            this.MedicineName.Name = "MedicineName";
            this.MedicineName.Size = new System.Drawing.Size(196, 28);
            this.MedicineName.TabIndex = 1;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label19.Location = new System.Drawing.Point(9, 81);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(117, 20);
            this.label19.TabIndex = 0;
            this.label19.Text = "Medicine Name";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Gray;
            this.label23.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label23.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label23.Location = new System.Drawing.Point(747, 315);
            this.label23.Name = "label23";
            this.label23.Padding = new System.Windows.Forms.Padding(4);
            this.label23.Size = new System.Drawing.Size(84, 32);
            this.label23.TabIndex = 16;
            this.label23.Text = "label23";
            this.label23.Click += new System.EventHandler(this.label23_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.OliveDrab;
            this.label24.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label24.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label24.Location = new System.Drawing.Point(448, 335);
            this.label24.Name = "label24";
            this.label24.Padding = new System.Windows.Forms.Padding(4);
            this.label24.Size = new System.Drawing.Size(206, 32);
            this.label24.TabIndex = 17;
            this.label24.Text = "You are in edit mode";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1244, 733);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.PatientTreatment1);
            this.Controls.Add(this.MedicalStaffDetails);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.DataGrid);
            this.Controls.Add(this.PatientTreatmentBtn);
            this.Controls.Add(this.MedicalStaffBtn);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.PatientDetailsBtn);
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            //this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(15);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.MedicalStaffDetails.ResumeLayout(false);
            this.MedicalStaffDetails.PerformLayout();
            this.PatientTreatment1.ResumeLayout(false);
            this.PatientTreatment1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Header;
        private System.Windows.Forms.Button PatientDetailsBtn;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button MedicalStaffBtn;
        private System.Windows.Forms.Button PatientTreatmentBtn;
        private System.Windows.Forms.DataGridView DataGrid;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Phone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Age;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox City;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox MedicalHistory;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox Province;
        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.GroupBox MedicalStaffDetails;
        private System.Windows.Forms.TextBox StaffDepartment;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button StaffAdd;
        private System.Windows.Forms.TextBox StaffAddress;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox StaffPhone;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox StaffDestination;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox StaffName;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox StaffTitle;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox PatientTreatment1;
        private System.Windows.Forms.ComboBox MedicalStatus;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox BedNumber;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox Test;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox NurseAllocated;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button TPatientAddBtn;
        private System.Windows.Forms.TextBox DoctorAllocated;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox MedicineName;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox TPatientName;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.DateTimePicker TestDate;
        private System.Windows.Forms.DateTimePicker MedicineDate;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
    }
}

