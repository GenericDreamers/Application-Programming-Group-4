namespace Group4Ap
{
	partial class FormGuests
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
			this.DCField = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.EmailField = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.doDongHaiAPMidtermsDataSetBindingSource = new System.Windows.Forms.BindingSource();
			this.lOPBindingSource = new System.Windows.Forms.BindingSource();
			this.label3 = new System.Windows.Forms.Label();
			this.pHIEUNHAPBindingSource = new System.Windows.Forms.BindingSource();
			this.btnThoat = new System.Windows.Forms.Button();
			this.btnSua = new System.Windows.Forms.Button();
			this.btnXoa = new System.Windows.Forms.Button();
			this.btnLuu = new System.Windows.Forms.Button();
			this.btnTao = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.TCField = new System.Windows.Forms.TextBox();
			this.TDField = new System.Windows.Forms.TextBox();
			this.MKField = new System.Windows.Forms.TextBox();
			this.lblMaCode = new System.Windows.Forms.Label();
			this.lblHoTen = new System.Windows.Forms.Label();
			this.lblMSV = new System.Windows.Forms.Label();
			this.lblTitle = new System.Windows.Forms.Label();
			this.hotelManagementDataSet = new Group4Ap.HotelManagementDataSet();
			this.guestsBindingSource = new System.Windows.Forms.BindingSource();
			this.guestsTableAdapter = new Group4Ap.HotelManagementDataSetTableAdapters.GuestsTableAdapter();
			this.guestIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DTField = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.doDongHaiAPMidtermsDataSetBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pHIEUNHAPBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.hotelManagementDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.guestsBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// DCField
			// 
			this.DCField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DCField.Location = new System.Drawing.Point(318, 320);
			this.DCField.Name = "DCField";
			this.DCField.Size = new System.Drawing.Size(328, 34);
			this.DCField.TabIndex = 67;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.label2.Location = new System.Drawing.Point(107, 273);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(121, 29);
			this.label2.TabIndex = 66;
			this.label2.Text = "Điện thoại";
			// 
			// EmailField
			// 
			this.EmailField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.EmailField.Location = new System.Drawing.Point(318, 216);
			this.EmailField.Name = "EmailField";
			this.EmailField.Size = new System.Drawing.Size(328, 34);
			this.EmailField.TabIndex = 64;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.label1.Location = new System.Drawing.Point(109, 221);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(74, 29);
			this.label1.TabIndex = 65;
			this.label1.Text = "Email";
			// 
			// lOPBindingSource
			// 
			this.lOPBindingSource.DataMember = "LOP";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.label3.Location = new System.Drawing.Point(107, 325);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(86, 29);
			this.label3.TabIndex = 68;
			this.label3.Text = "Địa chỉ";
			// 
			// pHIEUNHAPBindingSource
			// 
			this.pHIEUNHAPBindingSource.DataMember = "PHIEUNHAP";
			// 
			// btnThoat
			// 
			this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThoat.Location = new System.Drawing.Point(812, 232);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(235, 50);
			this.btnThoat.TabIndex = 63;
			this.btnThoat.Text = "Thoát";
			this.btnThoat.UseVisualStyleBackColor = true;
			this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
			// 
			// btnSua
			// 
			this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSua.Location = new System.Drawing.Point(695, 176);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(235, 50);
			this.btnSua.TabIndex = 62;
			this.btnSua.Text = "Sửa dữ liệu";
			this.btnSua.UseVisualStyleBackColor = true;
			this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
			// 
			// btnXoa
			// 
			this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnXoa.Location = new System.Drawing.Point(936, 176);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(235, 50);
			this.btnXoa.TabIndex = 61;
			this.btnXoa.Text = "Xóa dữ liệu";
			this.btnXoa.UseVisualStyleBackColor = true;
			this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// btnLuu
			// 
			this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLuu.Location = new System.Drawing.Point(936, 111);
			this.btnLuu.Name = "btnLuu";
			this.btnLuu.Size = new System.Drawing.Size(235, 50);
			this.btnLuu.TabIndex = 60;
			this.btnLuu.Text = "Lưu dữ liệu";
			this.btnLuu.UseVisualStyleBackColor = true;
			this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
			// 
			// btnTao
			// 
			this.btnTao.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTao.Location = new System.Drawing.Point(695, 111);
			this.btnTao.Name = "btnTao";
			this.btnTao.Size = new System.Drawing.Size(235, 50);
			this.btnTao.TabIndex = 59;
			this.btnTao.Text = "Tạo mới";
			this.btnTao.UseVisualStyleBackColor = true;
			this.btnTao.Click += new System.EventHandler(this.btnTao_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.guestIDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.guestsBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(86, 364);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(1085, 271);
			this.dataGridView1.TabIndex = 58;
			// 
			// TCField
			// 
			this.TCField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TCField.Location = new System.Drawing.Point(318, 164);
			this.TCField.Name = "TCField";
			this.TCField.Size = new System.Drawing.Size(328, 34);
			this.TCField.TabIndex = 56;
			// 
			// TDField
			// 
			this.TDField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TDField.Location = new System.Drawing.Point(318, 120);
			this.TDField.Name = "TDField";
			this.TDField.Size = new System.Drawing.Size(328, 34);
			this.TDField.TabIndex = 53;
			// 
			// MKField
			// 
			this.MKField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MKField.Location = new System.Drawing.Point(318, 64);
			this.MKField.Name = "MKField";
			this.MKField.Size = new System.Drawing.Size(328, 34);
			this.MKField.TabIndex = 51;
			// 
			// lblMaCode
			// 
			this.lblMaCode.AutoSize = true;
			this.lblMaCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.lblMaCode.Location = new System.Drawing.Point(109, 169);
			this.lblMaCode.Name = "lblMaCode";
			this.lblMaCode.Size = new System.Drawing.Size(107, 29);
			this.lblMaCode.TabIndex = 57;
			this.lblMaCode.Text = "Tên cuối";
			// 
			// lblHoTen
			// 
			this.lblHoTen.AutoSize = true;
			this.lblHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.lblHoTen.Location = new System.Drawing.Point(109, 120);
			this.lblHoTen.Name = "lblHoTen";
			this.lblHoTen.Size = new System.Drawing.Size(102, 29);
			this.lblHoTen.TabIndex = 55;
			this.lblHoTen.Text = "Tên đầu";
			// 
			// lblMSV
			// 
			this.lblMSV.AutoSize = true;
			this.lblMSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.lblMSV.Location = new System.Drawing.Point(109, 64);
			this.lblMSV.Name = "lblMSV";
			this.lblMSV.Size = new System.Drawing.Size(115, 29);
			this.lblMSV.TabIndex = 54;
			this.lblMSV.Text = "Mã khách";
			// 
			// lblTitle
			// 
			this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblTitle.AutoSize = true;
			this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
			this.lblTitle.Location = new System.Drawing.Point(349, 3);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(518, 46);
			this.lblTitle.TabIndex = 52;
			this.lblTitle.Text = "Danh sách thông tin khách";
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
			// guestIDDataGridViewTextBoxColumn
			// 
			this.guestIDDataGridViewTextBoxColumn.DataPropertyName = "GuestID";
			this.guestIDDataGridViewTextBoxColumn.HeaderText = "GuestID";
			this.guestIDDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.guestIDDataGridViewTextBoxColumn.Name = "guestIDDataGridViewTextBoxColumn";
			this.guestIDDataGridViewTextBoxColumn.Width = 125;
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
			// emailDataGridViewTextBoxColumn
			// 
			this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
			this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
			this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
			this.emailDataGridViewTextBoxColumn.Width = 125;
			// 
			// phoneNumberDataGridViewTextBoxColumn
			// 
			this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
			this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
			this.phoneNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
			this.phoneNumberDataGridViewTextBoxColumn.Width = 125;
			// 
			// addressDataGridViewTextBoxColumn
			// 
			this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
			this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
			this.addressDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
			this.addressDataGridViewTextBoxColumn.Width = 125;
			// 
			// DTField
			// 
			this.DTField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DTField.Location = new System.Drawing.Point(318, 272);
			this.DTField.Name = "DTField";
			this.DTField.Size = new System.Drawing.Size(328, 34);
			this.DTField.TabIndex = 69;
			// 
			// FormGuest
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1256, 639);
			this.Controls.Add(this.DTField);
			this.Controls.Add(this.DCField);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.EmailField);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btnThoat);
			this.Controls.Add(this.btnSua);
			this.Controls.Add(this.btnXoa);
			this.Controls.Add(this.btnLuu);
			this.Controls.Add(this.btnTao);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.TCField);
			this.Controls.Add(this.TDField);
			this.Controls.Add(this.MKField);
			this.Controls.Add(this.lblMaCode);
			this.Controls.Add(this.lblHoTen);
			this.Controls.Add(this.lblMSV);
			this.Controls.Add(this.lblTitle);
			this.Name = "FormGuest";
			this.Text = "FormGuest";
			this.Load += new System.EventHandler(this.FormGuest_Load);
			((System.ComponentModel.ISupportInitialize)(this.doDongHaiAPMidtermsDataSetBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pHIEUNHAPBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.hotelManagementDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.guestsBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox DCField;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox EmailField;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.BindingSource doDongHaiAPMidtermsDataSetBindingSource;
		private System.Windows.Forms.BindingSource lOPBindingSource;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.BindingSource pHIEUNHAPBindingSource;
		private System.Windows.Forms.Button btnThoat;
		private System.Windows.Forms.Button btnSua;
		private System.Windows.Forms.Button btnXoa;
		private System.Windows.Forms.Button btnLuu;
		private System.Windows.Forms.Button btnTao;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TextBox TCField;
		private System.Windows.Forms.TextBox TDField;
		private System.Windows.Forms.TextBox MKField;
		private System.Windows.Forms.Label lblMaCode;
		private System.Windows.Forms.Label lblHoTen;
		private System.Windows.Forms.Label lblMSV;
		private System.Windows.Forms.Label lblTitle;
		private HotelManagementDataSet hotelManagementDataSet;
		private System.Windows.Forms.BindingSource guestsBindingSource;
		private HotelManagementDataSetTableAdapters.GuestsTableAdapter guestsTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn guestIDDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
		private System.Windows.Forms.TextBox DTField;
	}
}