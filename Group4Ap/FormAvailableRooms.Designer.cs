namespace Group4Ap
{
	partial class FormAvailableRooms
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
			this.pHIEUNHAPBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.doDongHaiAPMidtermsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.RTNField = new System.Windows.Forms.ComboBox();
			this.CIField = new System.Windows.Forms.DateTimePicker();
			this.label3 = new System.Windows.Forms.Label();
			this.serviceOrdersTableAdapter = new Group4Ap.HotelManagementDataSetTableAdapters.ServiceOrdersTableAdapter();
			this.label1 = new System.Windows.Forms.Label();
			this.btnTim = new System.Windows.Forms.Button();
			this.serviceOrdersBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.hotelManagementDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.hotelManagementDataSet = new Group4Ap.HotelManagementDataSet();
			this.lOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.guestsTableAdapter = new Group4Ap.HotelManagementDataSetTableAdapters.GuestsTableAdapter();
			this.guestsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.DField = new System.Windows.Forms.TextBox();
			this.lblMSV = new System.Windows.Forms.Label();
			this.lblTitle = new System.Windows.Forms.Label();
			this.btnThoat = new System.Windows.Forms.Button();
			this.servicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.servicesTableAdapter = new Group4Ap.HotelManagementDataSetTableAdapters.ServicesTableAdapter();
			this.btnXoa = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pHIEUNHAPBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.doDongHaiAPMidtermsDataSetBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.serviceOrdersBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.hotelManagementDataSetBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.hotelManagementDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.guestsBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// pHIEUNHAPBindingSource
			// 
			this.pHIEUNHAPBindingSource.DataMember = "PHIEUNHAP";
			// 
			// RTNField
			// 
			this.RTNField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.RTNField.FormattingEnabled = true;
			this.RTNField.Location = new System.Drawing.Point(352, 92);
			this.RTNField.Name = "RTNField";
			this.RTNField.Size = new System.Drawing.Size(545, 37);
			this.RTNField.TabIndex = 124;
			// 
			// CIField
			// 
			this.CIField.CustomFormat = "dd-MM-yyyy hh:mm:ss";
			this.CIField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CIField.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.CIField.Location = new System.Drawing.Point(352, 150);
			this.CIField.Name = "CIField";
			this.CIField.Size = new System.Drawing.Size(545, 34);
			this.CIField.TabIndex = 122;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.label3.Location = new System.Drawing.Point(88, 150);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(208, 29);
			this.label3.TabIndex = 121;
			this.label3.Text = "Thời gian check in";
			// 
			// serviceOrdersTableAdapter
			// 
			this.serviceOrdersTableAdapter.ClearBeforeFill = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.label1.Location = new System.Drawing.Point(88, 92);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(133, 29);
			this.label1.TabIndex = 119;
			this.label1.Text = "Loại phòng";
			// 
			// btnTim
			// 
			this.btnTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTim.Location = new System.Drawing.Point(917, 86);
			this.btnTim.Name = "btnTim";
			this.btnTim.Size = new System.Drawing.Size(235, 50);
			this.btnTim.TabIndex = 114;
			this.btnTim.Text = "Tìm kiếm";
			this.btnTim.UseVisualStyleBackColor = true;
			this.btnTim.Click += new System.EventHandler(this.btnTao_Click);
			// 
			// serviceOrdersBindingSource
			// 
			this.serviceOrdersBindingSource.DataMember = "ServiceOrders";
			this.serviceOrdersBindingSource.DataSource = this.hotelManagementDataSetBindingSource;
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
			// lOPBindingSource
			// 
			this.lOPBindingSource.DataMember = "LOP";
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(67, 272);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(1085, 248);
			this.dataGridView1.TabIndex = 113;
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
			// DField
			// 
			this.DField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DField.Location = new System.Drawing.Point(352, 208);
			this.DField.Name = "DField";
			this.DField.Size = new System.Drawing.Size(221, 34);
			this.DField.TabIndex = 109;
			// 
			// lblMSV
			// 
			this.lblMSV.AutoSize = true;
			this.lblMSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.lblMSV.Location = new System.Drawing.Point(88, 213);
			this.lblMSV.Name = "lblMSV";
			this.lblMSV.Size = new System.Drawing.Size(189, 29);
			this.lblMSV.TabIndex = 111;
			this.lblMSV.Text = "Số ngày khách ở";
			// 
			// lblTitle
			// 
			this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblTitle.AutoSize = true;
			this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
			this.lblTitle.Location = new System.Drawing.Point(249, 15);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(754, 46);
			this.lblTitle.TabIndex = 110;
			this.lblTitle.Text = "Tìm phòng trống trong khoảng thời gian";
			// 
			// btnThoat
			// 
			this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThoat.Location = new System.Drawing.Point(917, 198);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(235, 50);
			this.btnThoat.TabIndex = 118;
			this.btnThoat.Text = "Thoát";
			this.btnThoat.UseVisualStyleBackColor = true;
			this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
			// 
			// servicesBindingSource
			// 
			this.servicesBindingSource.DataMember = "Services";
			this.servicesBindingSource.DataSource = this.hotelManagementDataSetBindingSource;
			// 
			// servicesTableAdapter
			// 
			this.servicesTableAdapter.ClearBeforeFill = true;
			// 
			// btnXoa
			// 
			this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnXoa.Location = new System.Drawing.Point(917, 142);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(235, 50);
			this.btnXoa.TabIndex = 116;
			this.btnXoa.Text = "Xóa bộ lọc";
			this.btnXoa.UseVisualStyleBackColor = true;
			this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// FormAvailableRooms
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1253, 530);
			this.Controls.Add(this.RTNField);
			this.Controls.Add(this.CIField);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnTim);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.DField);
			this.Controls.Add(this.lblMSV);
			this.Controls.Add(this.lblTitle);
			this.Controls.Add(this.btnThoat);
			this.Controls.Add(this.btnXoa);
			this.Name = "FormAvailableRooms";
			this.Text = "FormAvailableRooms";
			this.Load += new System.EventHandler(this.FormAvailableRooms_Load);
			((System.ComponentModel.ISupportInitialize)(this.pHIEUNHAPBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.doDongHaiAPMidtermsDataSetBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.serviceOrdersBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.hotelManagementDataSetBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.hotelManagementDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.guestsBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.BindingSource pHIEUNHAPBindingSource;
		private System.Windows.Forms.BindingSource doDongHaiAPMidtermsDataSetBindingSource;
		private System.Windows.Forms.ComboBox RTNField;
		private System.Windows.Forms.DateTimePicker CIField;
		private System.Windows.Forms.Label label3;
		private HotelManagementDataSetTableAdapters.ServiceOrdersTableAdapter serviceOrdersTableAdapter;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnTim;
		private System.Windows.Forms.BindingSource serviceOrdersBindingSource;
		private System.Windows.Forms.BindingSource hotelManagementDataSetBindingSource;
		private HotelManagementDataSet hotelManagementDataSet;
		private System.Windows.Forms.BindingSource lOPBindingSource;
		private System.Windows.Forms.DataGridView dataGridView1;
		private HotelManagementDataSetTableAdapters.GuestsTableAdapter guestsTableAdapter;
		private System.Windows.Forms.BindingSource guestsBindingSource;
		private System.Windows.Forms.TextBox DField;
		private System.Windows.Forms.Label lblMSV;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Button btnThoat;
		private System.Windows.Forms.BindingSource servicesBindingSource;
		private HotelManagementDataSetTableAdapters.ServicesTableAdapter servicesTableAdapter;
		private System.Windows.Forms.Button btnXoa;
	}
}