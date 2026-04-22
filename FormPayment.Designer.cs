namespace Group4Ap
{
	partial class FormPayment
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
            this.RCField = new System.Windows.Forms.TextBox();
            this.GNField = new System.Windows.Forms.TextBox();
            this.GIDField = new System.Windows.Forms.TextBox();
            this.RIDField = new System.Windows.Forms.TextBox();
            this.lblMaCode = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblMSV = new System.Windows.Forms.Label();
            this.hotelManagementDataSet = new Group4Ap.HotelManagementDataSet();
            this.guestsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.guestsTableAdapter = new Group4Ap.HotelManagementDataSetTableAdapters.GuestsTableAdapter();
            this.btnLuu = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.reserIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guestIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guestNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stayDurationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reservationInvoiceDetailsBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.hotelManagementDataSet2 = new Group4Ap.HotelManagementDataSet2();
            this.reservationInvoiceDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reservationInvoiceDetailsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pHIEUNHAPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.lOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doDongHaiAPMidtermsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.SDField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SCField = new System.Windows.Forms.TextBox();
            this.reservationInvoiceDetailsTableAdapter = new Group4Ap.HotelManagementDataSetTableAdapters.ReservationInvoiceDetailsTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.TCField = new System.Windows.Forms.TextBox();
            this.PSField = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.reservationInvoiceDetailsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.hotelManagementDataSet1 = new Group4Ap.HotelManagementDataSet1();
            this.reservationInvoiceDetailsTableAdapter1 = new Group4Ap.HotelManagementDataSet1TableAdapters.ReservationInvoiceDetailsTableAdapter();
            this.reservationInvoiceDetailsTableAdapter2 = new Group4Ap.HotelManagementDataSet2TableAdapters.ReservationInvoiceDetailsTableAdapter();
            this.lblTitle = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            ((System.ComponentModel.ISupportInitialize)(this.hotelManagementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guestsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationInvoiceDetailsBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelManagementDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationInvoiceDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationInvoiceDetailsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUNHAPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doDongHaiAPMidtermsDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationInvoiceDetailsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelManagementDataSet1)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // RCField
            // 
            this.RCField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RCField.Font = new System.Drawing.Font("Segoe UI Semibold", 25.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RCField.Location = new System.Drawing.Point(840, 187);
            this.RCField.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RCField.Name = "RCField";
            this.RCField.ReadOnly = true;
            this.RCField.Size = new System.Drawing.Size(727, 99);
            this.RCField.TabIndex = 88;
            // 
            // GNField
            // 
            this.GNField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GNField.Font = new System.Drawing.Font("Segoe UI Semibold", 25.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GNField.Location = new System.Drawing.Point(840, 70);
            this.GNField.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GNField.Name = "GNField";
            this.GNField.ReadOnly = true;
            this.GNField.Size = new System.Drawing.Size(727, 99);
            this.GNField.TabIndex = 75;
            // 
            // GIDField
            // 
            this.GIDField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GIDField.Font = new System.Drawing.Font("Segoe UI Semibold", 25.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GIDField.Location = new System.Drawing.Point(42, 187);
            this.GIDField.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GIDField.Name = "GIDField";
            this.GIDField.ReadOnly = true;
            this.GIDField.Size = new System.Drawing.Size(660, 99);
            this.GIDField.TabIndex = 72;
            // 
            // RIDField
            // 
            this.RIDField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RIDField.Font = new System.Drawing.Font("Segoe UI Semibold", 25.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RIDField.Location = new System.Drawing.Point(42, 70);
            this.RIDField.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RIDField.Name = "RIDField";
            this.RIDField.ReadOnly = true;
            this.RIDField.Size = new System.Drawing.Size(660, 99);
            this.RIDField.TabIndex = 70;
            // 
            // lblMaCode
            // 
            this.lblMaCode.AutoSize = true;
            this.lblMaCode.Font = new System.Drawing.Font("Segoe UI Semibold", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(57)))), ((int)(((byte)(71)))));
            this.lblMaCode.Location = new System.Drawing.Point(831, 12);
            this.lblMaCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaCode.Name = "lblMaCode";
            this.lblMaCode.Size = new System.Drawing.Size(189, 50);
            this.lblMaCode.TabIndex = 76;
            this.lblMaCode.Text = "Tên khách";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("Segoe UI Semibold", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoTen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(57)))), ((int)(((byte)(71)))));
            this.lblHoTen.Location = new System.Drawing.Point(35, 132);
            this.lblHoTen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(184, 50);
            this.lblHoTen.TabIndex = 74;
            this.lblHoTen.Text = "Mã khách";
            // 
            // lblMSV
            // 
            this.lblMSV.AutoSize = true;
            this.lblMSV.Font = new System.Drawing.Font("Segoe UI Semibold", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMSV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(57)))), ((int)(((byte)(71)))));
            this.lblMSV.Location = new System.Drawing.Point(33, 12);
            this.lblMSV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMSV.Name = "lblMSV";
            this.lblMSV.Size = new System.Drawing.Size(260, 50);
            this.lblMSV.TabIndex = 73;
            this.lblMSV.Text = "Mã đặt phòng";
            // 
            // hotelManagementDataSet
            // 
            this.hotelManagementDataSet.DataSetName = "HotelManagementDataSet";
            this.hotelManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(57)))), ((int)(((byte)(71)))));
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI Semibold", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(968, 464);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(492, 78);
            this.btnLuu.TabIndex = 79;
            this.btnLuu.Text = "Xác nhận thanh toán";
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
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(57)))), ((int)(((byte)(71)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(77)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.reserIDDataGridViewTextBoxColumn,
            this.guestIDDataGridViewTextBoxColumn,
            this.guestNameDataGridViewTextBoxColumn,
            this.stayDurationDataGridViewTextBoxColumn,
            this.roomCostDataGridViewTextBoxColumn,
            this.serviceCostDataGridViewTextBoxColumn,
            this.totalCostDataGridViewTextBoxColumn,
            this.PaymentStatus});
            this.dataGridView1.DataSource = this.reservationInvoiceDetailsBindingSource3;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(57)))), ((int)(((byte)(71)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(77)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(57)))), ((int)(((byte)(71)))));
            this.dataGridView1.Location = new System.Drawing.Point(47, 753);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1654, 422);
            this.dataGridView1.TabIndex = 77;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // reserIDDataGridViewTextBoxColumn
            // 
            this.reserIDDataGridViewTextBoxColumn.DataPropertyName = "ReserID";
            this.reserIDDataGridViewTextBoxColumn.HeaderText = "ReserID";
            this.reserIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.reserIDDataGridViewTextBoxColumn.Name = "reserIDDataGridViewTextBoxColumn";
            // 
            // guestIDDataGridViewTextBoxColumn
            // 
            this.guestIDDataGridViewTextBoxColumn.DataPropertyName = "GuestID";
            this.guestIDDataGridViewTextBoxColumn.HeaderText = "GuestID";
            this.guestIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.guestIDDataGridViewTextBoxColumn.Name = "guestIDDataGridViewTextBoxColumn";
            // 
            // guestNameDataGridViewTextBoxColumn
            // 
            this.guestNameDataGridViewTextBoxColumn.DataPropertyName = "GuestName";
            this.guestNameDataGridViewTextBoxColumn.HeaderText = "GuestName";
            this.guestNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.guestNameDataGridViewTextBoxColumn.Name = "guestNameDataGridViewTextBoxColumn";
            this.guestNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stayDurationDataGridViewTextBoxColumn
            // 
            this.stayDurationDataGridViewTextBoxColumn.DataPropertyName = "StayDuration";
            this.stayDurationDataGridViewTextBoxColumn.HeaderText = "StayDuration";
            this.stayDurationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stayDurationDataGridViewTextBoxColumn.Name = "stayDurationDataGridViewTextBoxColumn";
            this.stayDurationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roomCostDataGridViewTextBoxColumn
            // 
            this.roomCostDataGridViewTextBoxColumn.DataPropertyName = "RoomCost";
            this.roomCostDataGridViewTextBoxColumn.HeaderText = "RoomCost";
            this.roomCostDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.roomCostDataGridViewTextBoxColumn.Name = "roomCostDataGridViewTextBoxColumn";
            this.roomCostDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // serviceCostDataGridViewTextBoxColumn
            // 
            this.serviceCostDataGridViewTextBoxColumn.DataPropertyName = "ServiceCost";
            this.serviceCostDataGridViewTextBoxColumn.HeaderText = "ServiceCost";
            this.serviceCostDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.serviceCostDataGridViewTextBoxColumn.Name = "serviceCostDataGridViewTextBoxColumn";
            this.serviceCostDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalCostDataGridViewTextBoxColumn
            // 
            this.totalCostDataGridViewTextBoxColumn.DataPropertyName = "TotalCost";
            this.totalCostDataGridViewTextBoxColumn.HeaderText = "TotalCost";
            this.totalCostDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalCostDataGridViewTextBoxColumn.Name = "totalCostDataGridViewTextBoxColumn";
            this.totalCostDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // PaymentStatus
            // 
            this.PaymentStatus.DataPropertyName = "PaymentStatus";
            this.PaymentStatus.HeaderText = "PaymentStatus";
            this.PaymentStatus.MinimumWidth = 6;
            this.PaymentStatus.Name = "PaymentStatus";
            // 
            // reservationInvoiceDetailsBindingSource3
            // 
            this.reservationInvoiceDetailsBindingSource3.DataMember = "ReservationInvoiceDetails";
            this.reservationInvoiceDetailsBindingSource3.DataSource = this.hotelManagementDataSet2;
            // 
            // hotelManagementDataSet2
            // 
            this.hotelManagementDataSet2.DataSetName = "HotelManagementDataSet2";
            this.hotelManagementDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reservationInvoiceDetailsBindingSource
            // 
            this.reservationInvoiceDetailsBindingSource.DataMember = "ReservationInvoiceDetails";
            this.reservationInvoiceDetailsBindingSource.DataSource = this.hotelManagementDataSet;
            // 
            // reservationInvoiceDetailsBindingSource1
            // 
            this.reservationInvoiceDetailsBindingSource1.DataMember = "ReservationInvoiceDetails";
            this.reservationInvoiceDetailsBindingSource1.DataSource = this.hotelManagementDataSet;
            // 
            // pHIEUNHAPBindingSource
            // 
            this.pHIEUNHAPBindingSource.DataMember = "PHIEUNHAP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(57)))), ((int)(((byte)(71)))));
            this.label3.Location = new System.Drawing.Point(35, 368);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 50);
            this.label3.TabIndex = 87;
            this.label3.Text = "Tiền dịch vụ";
            // 
            // lOPBindingSource
            // 
            this.lOPBindingSource.DataMember = "LOP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(57)))), ((int)(((byte)(71)))));
            this.label2.Location = new System.Drawing.Point(831, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 50);
            this.label2.TabIndex = 85;
            this.label2.Text = "Tiền phòng";
            // 
            // SDField
            // 
            this.SDField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SDField.Font = new System.Drawing.Font("Segoe UI Semibold", 25.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SDField.Location = new System.Drawing.Point(42, 310);
            this.SDField.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SDField.Name = "SDField";
            this.SDField.ReadOnly = true;
            this.SDField.Size = new System.Drawing.Size(660, 99);
            this.SDField.TabIndex = 83;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(57)))), ((int)(((byte)(71)))));
            this.label1.Location = new System.Drawing.Point(35, 247);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 50);
            this.label1.TabIndex = 84;
            this.label1.Text = "Số ngày ở phòng";
            // 
            // SCField
            // 
            this.SCField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SCField.Font = new System.Drawing.Font("Segoe UI Semibold", 25.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SCField.Location = new System.Drawing.Point(42, 426);
            this.SCField.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SCField.Name = "SCField";
            this.SCField.ReadOnly = true;
            this.SCField.Size = new System.Drawing.Size(660, 99);
            this.SCField.TabIndex = 86;
            // 
            // reservationInvoiceDetailsTableAdapter
            // 
            this.reservationInvoiceDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(57)))), ((int)(((byte)(71)))));
            this.label4.Location = new System.Drawing.Point(36, 492);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 50);
            this.label4.TabIndex = 90;
            this.label4.Text = "Tổng tiền";
            // 
            // TCField
            // 
            this.TCField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TCField.Font = new System.Drawing.Font("Segoe UI Semibold", 25.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TCField.Location = new System.Drawing.Point(42, 556);
            this.TCField.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TCField.Name = "TCField";
            this.TCField.ReadOnly = true;
            this.TCField.Size = new System.Drawing.Size(660, 99);
            this.TCField.TabIndex = 89;
            // 
            // PSField
            // 
            this.PSField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PSField.Font = new System.Drawing.Font("Segoe UI Semibold", 25.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PSField.Location = new System.Drawing.Point(840, 310);
            this.PSField.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PSField.Name = "PSField";
            this.PSField.ReadOnly = true;
            this.PSField.Size = new System.Drawing.Size(727, 99);
            this.PSField.TabIndex = 92;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(57)))), ((int)(((byte)(71)))));
            this.label5.Location = new System.Drawing.Point(831, 247);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 50);
            this.label5.TabIndex = 91;
            this.label5.Text = "Tình trạng";
            // 
            // reservationInvoiceDetailsBindingSource2
            // 
            this.reservationInvoiceDetailsBindingSource2.DataMember = "ReservationInvoiceDetails";
            this.reservationInvoiceDetailsBindingSource2.DataSource = this.hotelManagementDataSet1;
            // 
            // hotelManagementDataSet1
            // 
            this.hotelManagementDataSet1.DataSetName = "HotelManagementDataSet1";
            this.hotelManagementDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reservationInvoiceDetailsTableAdapter1
            // 
            this.reservationInvoiceDetailsTableAdapter1.ClearBeforeFill = true;
            // 
            // reservationInvoiceDetailsTableAdapter2
            // 
            this.reservationInvoiceDetailsTableAdapter2.ClearBeforeFill = true;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(57)))), ((int)(((byte)(71)))));
            this.lblTitle.Location = new System.Drawing.Point(35, 25);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(559, 71);
            this.lblTitle.TabIndex = 111;
            this.lblTitle.Text = "Danh sách thanh toán";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.White;
            this.guna2Panel2.Controls.Add(this.btnLuu);
            this.guna2Panel2.Controls.Add(this.SCField);
            this.guna2Panel2.Controls.Add(this.label1);
            this.guna2Panel2.Controls.Add(this.PSField);
            this.guna2Panel2.Controls.Add(this.SDField);
            this.guna2Panel2.Controls.Add(this.label5);
            this.guna2Panel2.Controls.Add(this.label2);
            this.guna2Panel2.Controls.Add(this.label4);
            this.guna2Panel2.Controls.Add(this.label3);
            this.guna2Panel2.Controls.Add(this.TCField);
            this.guna2Panel2.Controls.Add(this.lblMSV);
            this.guna2Panel2.Controls.Add(this.RCField);
            this.guna2Panel2.Controls.Add(this.lblHoTen);
            this.guna2Panel2.Controls.Add(this.GNField);
            this.guna2Panel2.Controls.Add(this.lblMaCode);
            this.guna2Panel2.Controls.Add(this.GIDField);
            this.guna2Panel2.Controls.Add(this.RIDField);
            this.guna2Panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(57)))), ((int)(((byte)(71)))));
            this.guna2Panel2.Location = new System.Drawing.Point(47, 106);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Padding = new System.Windows.Forms.Padding(10);
            this.guna2Panel2.Size = new System.Drawing.Size(1628, 623);
            this.guna2Panel2.TabIndex = 113;
            // 
            // FormPayment
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1740, 1200);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormPayment";
            this.Text = "FormPayment";
            this.Load += new System.EventHandler(this.FormPayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hotelManagementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guestsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationInvoiceDetailsBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelManagementDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationInvoiceDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationInvoiceDetailsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUNHAPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doDongHaiAPMidtermsDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationInvoiceDetailsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelManagementDataSet1)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox RCField;
		private System.Windows.Forms.TextBox GNField;
		private System.Windows.Forms.TextBox GIDField;
		private System.Windows.Forms.TextBox RIDField;
		private System.Windows.Forms.Label lblMaCode;
		private System.Windows.Forms.Label lblHoTen;
		private System.Windows.Forms.Label lblMSV;
		private HotelManagementDataSet hotelManagementDataSet;
		private System.Windows.Forms.BindingSource guestsBindingSource;
		private HotelManagementDataSetTableAdapters.GuestsTableAdapter guestsTableAdapter;
		private System.Windows.Forms.Button btnLuu;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.BindingSource pHIEUNHAPBindingSource;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.BindingSource lOPBindingSource;
		private System.Windows.Forms.BindingSource doDongHaiAPMidtermsDataSetBindingSource;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox SDField;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox SCField;
		private System.Windows.Forms.BindingSource reservationInvoiceDetailsBindingSource;
		private HotelManagementDataSetTableAdapters.ReservationInvoiceDetailsTableAdapter reservationInvoiceDetailsTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn reserIDDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn guestIDDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn guestNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn stayDurationDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn roomCostDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn serviceCostDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn totalCostDataGridViewTextBoxColumn;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox TCField;
		private System.Windows.Forms.BindingSource reservationInvoiceDetailsBindingSource1;
		private HotelManagementDataSet1 hotelManagementDataSet1;
		private System.Windows.Forms.BindingSource reservationInvoiceDetailsBindingSource2;
		private HotelManagementDataSet1TableAdapters.ReservationInvoiceDetailsTableAdapter reservationInvoiceDetailsTableAdapter1;
		private System.Windows.Forms.DataGridViewTextBoxColumn PaymentStatus;
		private System.Windows.Forms.TextBox PSField;
		private System.Windows.Forms.Label label5;
        private HotelManagementDataSet2 hotelManagementDataSet2;
        private System.Windows.Forms.BindingSource reservationInvoiceDetailsBindingSource3;
        private HotelManagementDataSet2TableAdapters.ReservationInvoiceDetailsTableAdapter reservationInvoiceDetailsTableAdapter2;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
    }
}