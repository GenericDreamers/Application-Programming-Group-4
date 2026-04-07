namespace Group4Ap
{
	partial class FormEmployees
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
			this.guestsTableAdapter = new Group4Ap.HotelManagementDataSetTableAdapters.GuestsTableAdapter();
			this.guestsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.hotelManagementDataSet = new Group4Ap.HotelManagementDataSet();
			this.DTField = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.EmailField = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnSua = new System.Windows.Forms.Button();
			this.btnXoa = new System.Windows.Forms.Button();
			this.btnLuu = new System.Windows.Forms.Button();
			this.btnTao = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.btnThoat = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.TCField = new System.Windows.Forms.TextBox();
			this.TDField = new System.Windows.Forms.TextBox();
			this.MNVField = new System.Windows.Forms.TextBox();
			this.lblMaCode = new System.Windows.Forms.Label();
			this.lblHoTen = new System.Windows.Forms.Label();
			this.lblMSV = new System.Windows.Forms.Label();
			this.lblTitle = new System.Windows.Forms.Label();
			this.doDongHaiAPMidtermsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.lOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.pHIEUNHAPBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.employeesTableAdapter = new Group4Ap.HotelManagementDataSetTableAdapters.EmployeesTableAdapter();
			this.EmployeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PositionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DateOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.MCVField = new System.Windows.Forms.ComboBox();
			this.g1 = new System.Windows.Forms.GroupBox();
			this.rBtnMale = new System.Windows.Forms.RadioButton();
			this.rBtnFemale = new System.Windows.Forms.RadioButton();
			this.NSField = new System.Windows.Forms.DateTimePicker();
			((System.ComponentModel.ISupportInitialize)(this.guestsBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.hotelManagementDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.doDongHaiAPMidtermsDataSetBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pHIEUNHAPBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
			this.g1.SuspendLayout();
			this.SuspendLayout();
			// 
			// guestsTableAdapter
			// 
			this.guestsTableAdapter.ClearBeforeFill = true;
			// 
			// guestsBindingSource
			// 
			this.guestsBindingSource.DataMember = "Guests";
			this.guestsBindingSource.DataSource = this.hotelManagementDataSet;
			// 
			// hotelManagementDataSet
			// 
			this.hotelManagementDataSet.DataSetName = "HotelManagementDataSet";
			this.hotelManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// DTField
			// 
			this.DTField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DTField.Location = new System.Drawing.Point(199, 267);
			this.DTField.Name = "DTField";
			this.DTField.Size = new System.Drawing.Size(309, 34);
			this.DTField.TabIndex = 88;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.label2.Location = new System.Drawing.Point(43, 268);
			this.label2.Name = "label2";
			this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label2.Size = new System.Drawing.Size(121, 29);
			this.label2.TabIndex = 85;
			this.label2.Text = "Điện thoại";
			// 
			// EmailField
			// 
			this.EmailField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.EmailField.Location = new System.Drawing.Point(704, 268);
			this.EmailField.Name = "EmailField";
			this.EmailField.Size = new System.Drawing.Size(309, 34);
			this.EmailField.TabIndex = 83;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.label1.Location = new System.Drawing.Point(603, 271);
			this.label1.Name = "label1";
			this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label1.Size = new System.Drawing.Size(74, 29);
			this.label1.TabIndex = 84;
			this.label1.Text = "Email";
			// 
			// btnSua
			// 
			this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSua.Location = new System.Drawing.Point(1037, 171);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(235, 50);
			this.btnSua.TabIndex = 81;
			this.btnSua.Text = "Sửa dữ liệu";
			this.btnSua.UseVisualStyleBackColor = true;
			this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
			// 
			// btnXoa
			// 
			this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnXoa.Location = new System.Drawing.Point(1037, 232);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(235, 50);
			this.btnXoa.TabIndex = 80;
			this.btnXoa.Text = "Xóa dữ liệu";
			this.btnXoa.UseVisualStyleBackColor = true;
			this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// btnLuu
			// 
			this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLuu.Location = new System.Drawing.Point(1037, 109);
			this.btnLuu.Name = "btnLuu";
			this.btnLuu.Size = new System.Drawing.Size(235, 50);
			this.btnLuu.TabIndex = 79;
			this.btnLuu.Text = "Lưu dữ liệu";
			this.btnLuu.UseVisualStyleBackColor = true;
			this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
			// 
			// btnTao
			// 
			this.btnTao.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTao.Location = new System.Drawing.Point(1037, 47);
			this.btnTao.Name = "btnTao";
			this.btnTao.Size = new System.Drawing.Size(235, 50);
			this.btnTao.TabIndex = 78;
			this.btnTao.Text = "Tạo mới";
			this.btnTao.UseVisualStyleBackColor = true;
			this.btnTao.Click += new System.EventHandler(this.btnTao_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmployeeID,
            this.PositionID,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.Sex,
            this.DateOfBirth,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.employeesBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(21, 352);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(1278, 307);
			this.dataGridView1.TabIndex = 77;
			// 
			// btnThoat
			// 
			this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThoat.Location = new System.Drawing.Point(1037, 293);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(235, 50);
			this.btnThoat.TabIndex = 82;
			this.btnThoat.Text = "Thoát";
			this.btnThoat.UseVisualStyleBackColor = true;
			this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.label3.Location = new System.Drawing.Point(78, 207);
			this.label3.Name = "label3";
			this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label3.Size = new System.Drawing.Size(101, 29);
			this.label3.TabIndex = 87;
			this.label3.Text = "Giới tính";
			// 
			// TCField
			// 
			this.TCField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TCField.Location = new System.Drawing.Point(704, 136);
			this.TCField.Name = "TCField";
			this.TCField.Size = new System.Drawing.Size(309, 34);
			this.TCField.TabIndex = 75;
			// 
			// TDField
			// 
			this.TDField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TDField.Location = new System.Drawing.Point(199, 136);
			this.TDField.Name = "TDField";
			this.TDField.Size = new System.Drawing.Size(309, 34);
			this.TDField.TabIndex = 72;
			// 
			// MNVField
			// 
			this.MNVField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MNVField.Location = new System.Drawing.Point(199, 73);
			this.MNVField.Name = "MNVField";
			this.MNVField.Size = new System.Drawing.Size(309, 34);
			this.MNVField.TabIndex = 70;
			// 
			// lblMaCode
			// 
			this.lblMaCode.AutoSize = true;
			this.lblMaCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.lblMaCode.Location = new System.Drawing.Point(591, 136);
			this.lblMaCode.Name = "lblMaCode";
			this.lblMaCode.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblMaCode.Size = new System.Drawing.Size(107, 29);
			this.lblMaCode.TabIndex = 76;
			this.lblMaCode.Text = "Tên cuối";
			// 
			// lblHoTen
			// 
			this.lblHoTen.AutoSize = true;
			this.lblHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.lblHoTen.Location = new System.Drawing.Point(62, 136);
			this.lblHoTen.Name = "lblHoTen";
			this.lblHoTen.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblHoTen.Size = new System.Drawing.Size(102, 29);
			this.lblHoTen.TabIndex = 74;
			this.lblHoTen.Text = "Tên đầu";
			// 
			// lblMSV
			// 
			this.lblMSV.AutoSize = true;
			this.lblMSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.lblMSV.Location = new System.Drawing.Point(26, 73);
			this.lblMSV.Name = "lblMSV";
			this.lblMSV.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblMSV.Size = new System.Drawing.Size(154, 29);
			this.lblMSV.TabIndex = 73;
			this.lblMSV.Text = "Mã nhân viên";
			// 
			// lblTitle
			// 
			this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblTitle.AutoSize = true;
			this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
			this.lblTitle.Location = new System.Drawing.Point(372, 4);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(586, 46);
			this.lblTitle.TabIndex = 71;
			this.lblTitle.Text = "Danh sách thông tin nhân viên";
			// 
			// lOPBindingSource
			// 
			this.lOPBindingSource.DataMember = "LOP";
			// 
			// pHIEUNHAPBindingSource
			// 
			this.pHIEUNHAPBindingSource.DataMember = "PHIEUNHAP";
			// 
			// employeesBindingSource
			// 
			this.employeesBindingSource.DataMember = "Employees";
			this.employeesBindingSource.DataSource = this.hotelManagementDataSet;
			// 
			// employeesTableAdapter
			// 
			this.employeesTableAdapter.ClearBeforeFill = true;
			// 
			// EmployeeID
			// 
			this.EmployeeID.DataPropertyName = "EmployeeID";
			this.EmployeeID.HeaderText = "EmployeeID";
			this.EmployeeID.MinimumWidth = 6;
			this.EmployeeID.Name = "EmployeeID";
			this.EmployeeID.Width = 125;
			// 
			// PositionID
			// 
			this.PositionID.DataPropertyName = "PositionID";
			this.PositionID.HeaderText = "PositionID";
			this.PositionID.MinimumWidth = 6;
			this.PositionID.Name = "PositionID";
			this.PositionID.Width = 125;
			// 
			// firstNameDataGridViewTextBoxColumn
			// 
			this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
			this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
			this.firstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
			this.firstNameDataGridViewTextBoxColumn.Width = 125;
			// 
			// lastNameDataGridViewTextBoxColumn
			// 
			this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
			this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
			this.lastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
			this.lastNameDataGridViewTextBoxColumn.Width = 125;
			// 
			// Sex
			// 
			this.Sex.DataPropertyName = "Sex";
			this.Sex.HeaderText = "Sex";
			this.Sex.MinimumWidth = 6;
			this.Sex.Name = "Sex";
			this.Sex.Width = 125;
			// 
			// DateOfBirth
			// 
			this.DateOfBirth.DataPropertyName = "DateOfBirth";
			this.DateOfBirth.HeaderText = "DateOfBirth";
			this.DateOfBirth.MinimumWidth = 6;
			this.DateOfBirth.Name = "DateOfBirth";
			this.DateOfBirth.Width = 125;
			// 
			// phoneNumberDataGridViewTextBoxColumn
			// 
			this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
			this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
			this.phoneNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
			this.phoneNumberDataGridViewTextBoxColumn.Width = 125;
			// 
			// emailDataGridViewTextBoxColumn
			// 
			this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
			this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
			this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
			this.emailDataGridViewTextBoxColumn.Width = 125;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.label4.Location = new System.Drawing.Point(566, 73);
			this.label4.Name = "label4";
			this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label4.Size = new System.Drawing.Size(132, 29);
			this.label4.TabIndex = 90;
			this.label4.Text = "Mã chức vụ";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.label5.Location = new System.Drawing.Point(583, 207);
			this.label5.Name = "label5";
			this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label5.Size = new System.Drawing.Size(119, 29);
			this.label5.TabIndex = 92;
			this.label5.Text = "Ngày sinh";
			// 
			// MCVField
			// 
			this.MCVField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.MCVField.FormattingEnabled = true;
			this.MCVField.Location = new System.Drawing.Point(704, 69);
			this.MCVField.Name = "MCVField";
			this.MCVField.Size = new System.Drawing.Size(309, 37);
			this.MCVField.TabIndex = 93;
			// 
			// g1
			// 
			this.g1.Controls.Add(this.rBtnMale);
			this.g1.Controls.Add(this.rBtnFemale);
			this.g1.Location = new System.Drawing.Point(199, 187);
			this.g1.Name = "g1";
			this.g1.Size = new System.Drawing.Size(309, 57);
			this.g1.TabIndex = 94;
			this.g1.TabStop = false;
			// 
			// rBtnMale
			// 
			this.rBtnMale.AutoSize = true;
			this.rBtnMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.rBtnMale.Location = new System.Drawing.Point(7, 20);
			this.rBtnMale.Name = "rBtnMale";
			this.rBtnMale.Size = new System.Drawing.Size(76, 29);
			this.rBtnMale.TabIndex = 0;
			this.rBtnMale.Text = "Male";
			this.rBtnMale.UseVisualStyleBackColor = true;
			// 
			// rBtnFemale
			// 
			this.rBtnFemale.AutoSize = true;
			this.rBtnFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.rBtnFemale.Location = new System.Drawing.Point(194, 19);
			this.rBtnFemale.Name = "rBtnFemale";
			this.rBtnFemale.Size = new System.Drawing.Size(98, 29);
			this.rBtnFemale.TabIndex = 1;
			this.rBtnFemale.Text = "Female";
			this.rBtnFemale.UseVisualStyleBackColor = true;
			// 
			// NSField
			// 
			this.NSField.CustomFormat = "dd-MM-yyyy";
			this.NSField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.NSField.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.NSField.Location = new System.Drawing.Point(703, 206);
			this.NSField.Name = "NSField";
			this.NSField.Size = new System.Drawing.Size(310, 34);
			this.NSField.TabIndex = 51;
			// 
			// FormEmployees
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1327, 671);
			this.Controls.Add(this.NSField);
			this.Controls.Add(this.g1);
			this.Controls.Add(this.MCVField);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.DTField);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.EmailField);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnSua);
			this.Controls.Add(this.btnXoa);
			this.Controls.Add(this.btnLuu);
			this.Controls.Add(this.btnTao);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.btnThoat);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.TCField);
			this.Controls.Add(this.TDField);
			this.Controls.Add(this.MNVField);
			this.Controls.Add(this.lblMaCode);
			this.Controls.Add(this.lblHoTen);
			this.Controls.Add(this.lblMSV);
			this.Controls.Add(this.lblTitle);
			this.Name = "FormEmployees";
			this.Text = "FormEmployees";
			this.Load += new System.EventHandler(this.FormEmployees_Load);
			((System.ComponentModel.ISupportInitialize)(this.guestsBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.hotelManagementDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.doDongHaiAPMidtermsDataSetBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pHIEUNHAPBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
			this.g1.ResumeLayout(false);
			this.g1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private HotelManagementDataSetTableAdapters.GuestsTableAdapter guestsTableAdapter;
		private System.Windows.Forms.BindingSource guestsBindingSource;
		private HotelManagementDataSet hotelManagementDataSet;
		private System.Windows.Forms.TextBox DTField;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox EmailField;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnSua;
		private System.Windows.Forms.Button btnXoa;
		private System.Windows.Forms.Button btnLuu;
		private System.Windows.Forms.Button btnTao;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.BindingSource doDongHaiAPMidtermsDataSetBindingSource;
		private System.Windows.Forms.Button btnThoat;
		private System.Windows.Forms.BindingSource lOPBindingSource;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox TCField;
		private System.Windows.Forms.TextBox TDField;
		private System.Windows.Forms.TextBox MNVField;
		private System.Windows.Forms.Label lblMaCode;
		private System.Windows.Forms.Label lblHoTen;
		private System.Windows.Forms.BindingSource pHIEUNHAPBindingSource;
		private System.Windows.Forms.Label lblMSV;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.BindingSource employeesBindingSource;
		private HotelManagementDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeID;
		private System.Windows.Forms.DataGridViewTextBoxColumn PositionID;
		private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn Sex;
		private System.Windows.Forms.DataGridViewTextBoxColumn DateOfBirth;
		private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox MCVField;
		private System.Windows.Forms.GroupBox g1;
		private System.Windows.Forms.RadioButton rBtnMale;
		private System.Windows.Forms.RadioButton rBtnFemale;
		private System.Windows.Forms.DateTimePicker NSField;
	}
}