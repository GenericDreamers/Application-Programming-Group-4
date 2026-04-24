namespace Group4Ap
{
	partial class FormServiceOrders
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.servicesTableAdapter = new Group4Ap.HotelManagementDataSetTableAdapters.ServicesTableAdapter();
            this.hotelManagementDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelManagementDataSet = new Group4Ap.HotelManagementDataSet();
            this.servicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SOIField = new System.Windows.Forms.TextBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblMSV = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.guestsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.guestsTableAdapter = new Group4Ap.HotelManagementDataSetTableAdapters.GuestsTableAdapter();
            this.btnLuu = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ServiceOrderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GuestID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceOrdersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTao = new System.Windows.Forms.Button();
            this.doDongHaiAPMidtermsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pHIEUNHAPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.serviceOrdersTableAdapter = new Group4Ap.HotelManagementDataSetTableAdapters.ServiceOrdersTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.ODField = new System.Windows.Forms.DateTimePicker();
            this.GIDField = new System.Windows.Forms.ComboBox();
            this.SIDField = new System.Windows.Forms.ComboBox();
            this.EIDField = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.hotelManagementDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelManagementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guestsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceOrdersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doDongHaiAPMidtermsDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUNHAPBindingSource)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // servicesTableAdapter
            // 
            this.servicesTableAdapter.ClearBeforeFill = true;
            // 
            // hotelManagementDataSetBindingSource
            // 
            this.hotelManagementDataSetBindingSource.DataSource = this.hotelManagementDataSet;
            this.hotelManagementDataSetBindingSource.Position = 0;
            // 
            // hotelManagementDataSet
            // 
            this.hotelManagementDataSet.DataSetName = "HotelManagementDataSet";
            this.hotelManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // servicesBindingSource
            // 
            this.servicesBindingSource.DataMember = "Services";
            this.servicesBindingSource.DataSource = this.hotelManagementDataSetBindingSource;
            // 
            // SOIField
            // 
            this.SOIField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SOIField.Enabled = false;
            this.SOIField.Font = new System.Drawing.Font("Segoe UI Semibold", 25.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SOIField.Location = new System.Drawing.Point(33, 82);
            this.SOIField.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SOIField.Name = "SOIField";
            this.SOIField.Size = new System.Drawing.Size(479, 65);
            this.SOIField.TabIndex = 89;
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("Segoe UI Semibold", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoTen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(57)))), ((int)(((byte)(71)))));
            this.lblHoTen.Location = new System.Drawing.Point(588, 23);
            this.lblHoTen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(121, 32);
            this.lblHoTen.TabIndex = 93;
            this.lblHoTen.Text = "Mã khách";
            // 
            // lblMSV
            // 
            this.lblMSV.AutoSize = true;
            this.lblMSV.Font = new System.Drawing.Font("Segoe UI Semibold", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMSV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(57)))), ((int)(((byte)(71)))));
            this.lblMSV.Location = new System.Drawing.Point(24, 23);
            this.lblMSV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMSV.Name = "lblMSV";
            this.lblMSV.Size = new System.Drawing.Size(144, 32);
            this.lblMSV.TabIndex = 92;
            this.lblMSV.Text = "Mã sử dụng";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.White;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI Semibold", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(57)))), ((int)(((byte)(71)))));
            this.btnThoat.Location = new System.Drawing.Point(1323, 475);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(352, 78);
            this.btnThoat.TabIndex = 99;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.White;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI Semibold", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(57)))), ((int)(((byte)(71)))));
            this.btnSua.Location = new System.Drawing.Point(1323, 300);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(352, 78);
            this.btnSua.TabIndex = 98;
            this.btnSua.Text = "Sửa dữ liệu";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.White;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI Semibold", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(57)))), ((int)(((byte)(71)))));
            this.btnXoa.Location = new System.Drawing.Point(1323, 387);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(352, 78);
            this.btnXoa.TabIndex = 97;
            this.btnXoa.Text = "Xóa dữ liệu";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // guestsBindingSource
            // 
            this.guestsBindingSource.DataMember = "Guests";
            this.guestsBindingSource.DataSource = this.hotelManagementDataSet;
            // 
            // guestsTableAdapter
            // 
            this.guestsTableAdapter.ClearBeforeFill = true;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.White;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI Semibold", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(57)))), ((int)(((byte)(71)))));
            this.btnLuu.Location = new System.Drawing.Point(1323, 211);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(352, 78);
            this.btnLuu.TabIndex = 96;
            this.btnLuu.Text = "Lưu dữ liệu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(57)))), ((int)(((byte)(71)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(77)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ServiceOrderID,
            this.GuestID,
            this.serviceIDDataGridViewTextBoxColumn,
            this.EmployeeID,
            this.OrderDate});
            this.dataGridView1.DataSource = this.serviceOrdersBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(57)))), ((int)(((byte)(71)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(77)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(43, 666);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1632, 404);
            this.dataGridView1.TabIndex = 94;
            // 
            // ServiceOrderID
            // 
            this.ServiceOrderID.DataPropertyName = "ServiceOrderID";
            this.ServiceOrderID.HeaderText = "ServiceOrderID";
            this.ServiceOrderID.MinimumWidth = 6;
            this.ServiceOrderID.Name = "ServiceOrderID";
            this.ServiceOrderID.ReadOnly = true;
            // 
            // GuestID
            // 
            this.GuestID.DataPropertyName = "GuestID";
            this.GuestID.HeaderText = "GuestID";
            this.GuestID.MinimumWidth = 6;
            this.GuestID.Name = "GuestID";
            // 
            // serviceIDDataGridViewTextBoxColumn
            // 
            this.serviceIDDataGridViewTextBoxColumn.DataPropertyName = "ServiceID";
            this.serviceIDDataGridViewTextBoxColumn.HeaderText = "ServiceID";
            this.serviceIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.serviceIDDataGridViewTextBoxColumn.Name = "serviceIDDataGridViewTextBoxColumn";
            // 
            // EmployeeID
            // 
            this.EmployeeID.DataPropertyName = "EmployeeID";
            this.EmployeeID.HeaderText = "EmployeeID";
            this.EmployeeID.MinimumWidth = 6;
            this.EmployeeID.Name = "EmployeeID";
            // 
            // OrderDate
            // 
            this.OrderDate.DataPropertyName = "OrderDate";
            this.OrderDate.HeaderText = "OrderDate";
            this.OrderDate.MinimumWidth = 6;
            this.OrderDate.Name = "OrderDate";
            // 
            // serviceOrdersBindingSource
            // 
            this.serviceOrdersBindingSource.DataMember = "ServiceOrders";
            this.serviceOrdersBindingSource.DataSource = this.hotelManagementDataSetBindingSource;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(57)))), ((int)(((byte)(71)))));
            this.label2.Location = new System.Drawing.Point(588, 154);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 32);
            this.label2.TabIndex = 102;
            this.label2.Text = "Mã nhân viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(57)))), ((int)(((byte)(71)))));
            this.label1.Location = new System.Drawing.Point(24, 154);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 32);
            this.label1.TabIndex = 101;
            this.label1.Text = "Mã dịch vụ";
            // 
            // btnTao
            // 
            this.btnTao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(57)))), ((int)(((byte)(71)))));
            this.btnTao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTao.Font = new System.Drawing.Font("Segoe UI Semibold", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTao.ForeColor = System.Drawing.Color.White;
            this.btnTao.Location = new System.Drawing.Point(1323, 123);
            this.btnTao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTao.Name = "btnTao";
            this.btnTao.Size = new System.Drawing.Size(352, 78);
            this.btnTao.TabIndex = 95;
            this.btnTao.Text = "Tạo mới";
            this.btnTao.UseVisualStyleBackColor = false;
            this.btnTao.Click += new System.EventHandler(this.btnTao_Click);
            // 
            // lOPBindingSource
            // 
            this.lOPBindingSource.DataMember = "LOP";
            // 
            // pHIEUNHAPBindingSource
            // 
            this.pHIEUNHAPBindingSource.DataMember = "PHIEUNHAP";
            // 
            // serviceOrdersTableAdapter
            // 
            this.serviceOrdersTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(57)))), ((int)(((byte)(71)))));
            this.label3.Location = new System.Drawing.Point(24, 290);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 32);
            this.label3.TabIndex = 104;
            this.label3.Text = "Thời gian";
            // 
            // ODField
            // 
            this.ODField.CustomFormat = "yyyy-MM-dd";
            this.ODField.Font = new System.Drawing.Font("Segoe UI Semibold", 25.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ODField.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ODField.Location = new System.Drawing.Point(33, 357);
            this.ODField.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ODField.Name = "ODField";
            this.ODField.Size = new System.Drawing.Size(1036, 65);
            this.ODField.TabIndex = 105;
            // 
            // GIDField
            // 
            this.GIDField.Font = new System.Drawing.Font("Segoe UI Semibold", 25.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GIDField.FormattingEnabled = true;
            this.GIDField.Location = new System.Drawing.Point(597, 82);
            this.GIDField.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GIDField.Name = "GIDField";
            this.GIDField.Size = new System.Drawing.Size(472, 67);
            this.GIDField.TabIndex = 106;
            // 
            // SIDField
            // 
            this.SIDField.Font = new System.Drawing.Font("Segoe UI Semibold", 25.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SIDField.FormattingEnabled = true;
            this.SIDField.Location = new System.Drawing.Point(33, 212);
            this.SIDField.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SIDField.Name = "SIDField";
            this.SIDField.Size = new System.Drawing.Size(479, 67);
            this.SIDField.TabIndex = 107;
            // 
            // EIDField
            // 
            this.EIDField.Font = new System.Drawing.Font("Segoe UI Semibold", 25.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EIDField.FormattingEnabled = true;
            this.EIDField.Location = new System.Drawing.Point(597, 212);
            this.EIDField.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EIDField.Name = "EIDField";
            this.EIDField.Size = new System.Drawing.Size(472, 67);
            this.EIDField.TabIndex = 108;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(57)))), ((int)(((byte)(71)))));
            this.label4.Location = new System.Drawing.Point(35, 25);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(434, 46);
            this.label4.TabIndex = 118;
            this.label4.Text = "Danh sách sử dụng dịch vụ";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.Controls.Add(this.ODField);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.EIDField);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.SIDField);
            this.guna2Panel1.Controls.Add(this.lblMSV);
            this.guna2Panel1.Controls.Add(this.GIDField);
            this.guna2Panel1.Controls.Add(this.lblHoTen);
            this.guna2Panel1.Controls.Add(this.SOIField);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Location = new System.Drawing.Point(47, 118);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1112, 457);
            this.guna2Panel1.TabIndex = 119;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(57)))), ((int)(((byte)(71)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1323, 563);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(352, 78);
            this.button1.TabIndex = 120;
            this.button1.Text = "In hóa đơn";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormServiceOrders
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1740, 1102);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnTao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormServiceOrders";
            this.Text = "FormServiceOrders";
            this.Load += new System.EventHandler(this.FormServiceOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hotelManagementDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelManagementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guestsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceOrdersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doDongHaiAPMidtermsDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUNHAPBindingSource)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private HotelManagementDataSetTableAdapters.ServicesTableAdapter servicesTableAdapter;
		private System.Windows.Forms.BindingSource doDongHaiAPMidtermsDataSetBindingSource;
		private System.Windows.Forms.BindingSource lOPBindingSource;
		private System.Windows.Forms.BindingSource pHIEUNHAPBindingSource;
		private System.Windows.Forms.BindingSource hotelManagementDataSetBindingSource;
		private HotelManagementDataSet hotelManagementDataSet;
		private System.Windows.Forms.BindingSource servicesBindingSource;
		private System.Windows.Forms.TextBox SOIField;
		private System.Windows.Forms.Label lblHoTen;
		private System.Windows.Forms.Label lblMSV;
		private System.Windows.Forms.Button btnThoat;
		private System.Windows.Forms.Button btnSua;
		private System.Windows.Forms.Button btnXoa;
		private System.Windows.Forms.BindingSource guestsBindingSource;
		private HotelManagementDataSetTableAdapters.GuestsTableAdapter guestsTableAdapter;
		private System.Windows.Forms.Button btnLuu;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnTao;
		private System.Windows.Forms.BindingSource serviceOrdersBindingSource;
		private HotelManagementDataSetTableAdapters.ServiceOrdersTableAdapter serviceOrdersTableAdapter;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DateTimePicker ODField;
		private System.Windows.Forms.ComboBox GIDField;
		private System.Windows.Forms.ComboBox SIDField;
		private System.Windows.Forms.ComboBox EIDField;
		private System.Windows.Forms.DataGridViewTextBoxColumn ServiceOrderID;
		private System.Windows.Forms.DataGridViewTextBoxColumn GuestID;
		private System.Windows.Forms.DataGridViewTextBoxColumn serviceIDDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeID;
		private System.Windows.Forms.DataGridViewTextBoxColumn OrderDate;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Button button1;
    }
}