namespace Group4Ap
{
	partial class FormServices
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
			this.MTField = new System.Windows.Forms.TextBox();
			this.TDVField = new System.Windows.Forms.TextBox();
			this.MDVField = new System.Windows.Forms.TextBox();
			this.lblHoTen = new System.Windows.Forms.Label();
			this.lblMSV = new System.Windows.Forms.Label();
			this.lblTitle = new System.Windows.Forms.Label();
			this.hotelManagementDataSet = new Group4Ap.HotelManagementDataSet();
			this.guestsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.guestsTableAdapter = new Group4Ap.HotelManagementDataSetTableAdapters.GuestsTableAdapter();
			this.btnThoat = new System.Windows.Forms.Button();
			this.btnSua = new System.Windows.Forms.Button();
			this.btnXoa = new System.Windows.Forms.Button();
			this.btnLuu = new System.Windows.Forms.Button();
			this.btnTao = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.pHIEUNHAPBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.lOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.doDongHaiAPMidtermsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.label2 = new System.Windows.Forms.Label();
			this.GField = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.hotelManagementDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.servicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.servicesTableAdapter = new Group4Ap.HotelManagementDataSetTableAdapters.ServicesTableAdapter();
			this.serviceIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.serviceNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.hotelManagementDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.guestsBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pHIEUNHAPBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.doDongHaiAPMidtermsDataSetBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.hotelManagementDataSetBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// MTField
			// 
			this.MTField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MTField.Location = new System.Drawing.Point(266, 258);
			this.MTField.Multiline = true;
			this.MTField.Name = "MTField";
			this.MTField.Size = new System.Drawing.Size(370, 74);
			this.MTField.TabIndex = 88;
			// 
			// TDVField
			// 
			this.TDVField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TDVField.Location = new System.Drawing.Point(266, 146);
			this.TDVField.Name = "TDVField";
			this.TDVField.Size = new System.Drawing.Size(370, 34);
			this.TDVField.TabIndex = 72;
			// 
			// MDVField
			// 
			this.MDVField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MDVField.Location = new System.Drawing.Point(266, 90);
			this.MDVField.Name = "MDVField";
			this.MDVField.Size = new System.Drawing.Size(370, 34);
			this.MDVField.TabIndex = 70;
			// 
			// lblHoTen
			// 
			this.lblHoTen.AutoSize = true;
			this.lblHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.lblHoTen.Location = new System.Drawing.Point(99, 146);
			this.lblHoTen.Name = "lblHoTen";
			this.lblHoTen.Size = new System.Drawing.Size(137, 29);
			this.lblHoTen.TabIndex = 74;
			this.lblHoTen.Text = "Tên dịch vụ";
			// 
			// lblMSV
			// 
			this.lblMSV.AutoSize = true;
			this.lblMSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.lblMSV.Location = new System.Drawing.Point(99, 90);
			this.lblMSV.Name = "lblMSV";
			this.lblMSV.Size = new System.Drawing.Size(127, 29);
			this.lblMSV.TabIndex = 73;
			this.lblMSV.Text = "Mã dịch vụ";
			// 
			// lblTitle
			// 
			this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblTitle.AutoSize = true;
			this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
			this.lblTitle.Location = new System.Drawing.Point(381, 9);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(539, 46);
			this.lblTitle.TabIndex = 71;
			this.lblTitle.Text = "Danh sách thông tin dịch vụ";
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
			// btnThoat
			// 
			this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThoat.Location = new System.Drawing.Point(802, 231);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(235, 50);
			this.btnThoat.TabIndex = 82;
			this.btnThoat.Text = "Thoát";
			this.btnThoat.UseVisualStyleBackColor = true;
			this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
			// 
			// btnSua
			// 
			this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSua.Location = new System.Drawing.Point(685, 175);
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
			this.btnXoa.Location = new System.Drawing.Point(926, 175);
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
			this.btnLuu.Location = new System.Drawing.Point(926, 110);
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
			this.btnTao.Location = new System.Drawing.Point(685, 110);
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
            this.serviceIDDataGridViewTextBoxColumn,
            this.serviceNameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.servicesBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(76, 350);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(1085, 248);
			this.dataGridView1.TabIndex = 77;
			// 
			// pHIEUNHAPBindingSource
			// 
			this.pHIEUNHAPBindingSource.DataMember = "PHIEUNHAP";
			// 
			// lOPBindingSource
			// 
			this.lOPBindingSource.DataMember = "LOP";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.label2.Location = new System.Drawing.Point(97, 259);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 29);
			this.label2.TabIndex = 85;
			this.label2.Text = "Mô tả";
			// 
			// GField
			// 
			this.GField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.GField.Location = new System.Drawing.Point(266, 202);
			this.GField.Name = "GField";
			this.GField.Size = new System.Drawing.Size(370, 34);
			this.GField.TabIndex = 83;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.label1.Location = new System.Drawing.Point(99, 207);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(122, 29);
			this.label1.TabIndex = 84;
			this.label1.Text = "Giá (VND)";
			// 
			// hotelManagementDataSetBindingSource
			// 
			this.hotelManagementDataSetBindingSource.DataSource = this.hotelManagementDataSet;
			this.hotelManagementDataSetBindingSource.Position = 0;
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
			// serviceIDDataGridViewTextBoxColumn
			// 
			this.serviceIDDataGridViewTextBoxColumn.DataPropertyName = "ServiceID";
			this.serviceIDDataGridViewTextBoxColumn.HeaderText = "ServiceID";
			this.serviceIDDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.serviceIDDataGridViewTextBoxColumn.Name = "serviceIDDataGridViewTextBoxColumn";
			this.serviceIDDataGridViewTextBoxColumn.Width = 125;
			// 
			// serviceNameDataGridViewTextBoxColumn
			// 
			this.serviceNameDataGridViewTextBoxColumn.DataPropertyName = "ServiceName";
			this.serviceNameDataGridViewTextBoxColumn.HeaderText = "ServiceName";
			this.serviceNameDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.serviceNameDataGridViewTextBoxColumn.Name = "serviceNameDataGridViewTextBoxColumn";
			this.serviceNameDataGridViewTextBoxColumn.Width = 125;
			// 
			// priceDataGridViewTextBoxColumn
			// 
			this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
			this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
			this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
			this.priceDataGridViewTextBoxColumn.Width = 125;
			// 
			// descriptionDataGridViewTextBoxColumn
			// 
			this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
			this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
			this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
			this.descriptionDataGridViewTextBoxColumn.Width = 125;
			// 
			// FormServices
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1236, 610);
			this.Controls.Add(this.MTField);
			this.Controls.Add(this.TDVField);
			this.Controls.Add(this.MDVField);
			this.Controls.Add(this.lblHoTen);
			this.Controls.Add(this.lblMSV);
			this.Controls.Add(this.lblTitle);
			this.Controls.Add(this.btnThoat);
			this.Controls.Add(this.btnSua);
			this.Controls.Add(this.btnXoa);
			this.Controls.Add(this.btnLuu);
			this.Controls.Add(this.btnTao);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.GField);
			this.Controls.Add(this.label1);
			this.Name = "FormServices";
			this.Text = "FormServices";
			this.Load += new System.EventHandler(this.FormServices_Load);
			((System.ComponentModel.ISupportInitialize)(this.hotelManagementDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.guestsBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pHIEUNHAPBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.doDongHaiAPMidtermsDataSetBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.hotelManagementDataSetBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox MTField;
		private System.Windows.Forms.TextBox TDVField;
		private System.Windows.Forms.TextBox MDVField;
		private System.Windows.Forms.Label lblHoTen;
		private System.Windows.Forms.Label lblMSV;
		private System.Windows.Forms.Label lblTitle;
		private HotelManagementDataSet hotelManagementDataSet;
		private System.Windows.Forms.BindingSource guestsBindingSource;
		private HotelManagementDataSetTableAdapters.GuestsTableAdapter guestsTableAdapter;
		private System.Windows.Forms.Button btnThoat;
		private System.Windows.Forms.Button btnSua;
		private System.Windows.Forms.Button btnXoa;
		private System.Windows.Forms.Button btnLuu;
		private System.Windows.Forms.Button btnTao;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.BindingSource pHIEUNHAPBindingSource;
		private System.Windows.Forms.BindingSource lOPBindingSource;
		private System.Windows.Forms.BindingSource doDongHaiAPMidtermsDataSetBindingSource;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox GField;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.BindingSource hotelManagementDataSetBindingSource;
		private System.Windows.Forms.BindingSource servicesBindingSource;
		private HotelManagementDataSetTableAdapters.ServicesTableAdapter servicesTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn serviceIDDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn serviceNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
	}
}