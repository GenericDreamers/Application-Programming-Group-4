namespace Group4Ap
{
	partial class FormMiscSearch
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
			this.g2 = new System.Windows.Forms.GroupBox();
			this.rBtnMI = new System.Windows.Forms.RadioButton();
			this.rBtnMCV = new System.Windows.Forms.RadioButton();
			this.rBtnMLP = new System.Windows.Forms.RadioButton();
			this.rBtnMTT = new System.Windows.Forms.RadioButton();
			this.rBtnMT = new System.Windows.Forms.RadioButton();
			this.btnThoat = new System.Windows.Forms.Button();
			this.btnTim = new System.Windows.Forms.Button();
			this.SearchField = new System.Windows.Forms.ComboBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.lblTitle = new System.Windows.Forms.Label();
			this.pHIEUXUATBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.g2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pHIEUXUATBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// g2
			// 
			this.g2.Controls.Add(this.rBtnMI);
			this.g2.Controls.Add(this.rBtnMCV);
			this.g2.Controls.Add(this.rBtnMLP);
			this.g2.Controls.Add(this.rBtnMTT);
			this.g2.Controls.Add(this.rBtnMT);
			this.g2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.g2.Location = new System.Drawing.Point(79, 78);
			this.g2.Name = "g2";
			this.g2.Size = new System.Drawing.Size(814, 74);
			this.g2.TabIndex = 58;
			this.g2.TabStop = false;
			this.g2.Text = "Tìm kiếm theo";
			// 
			// rBtnMI
			// 
			this.rBtnMI.AutoSize = true;
			this.rBtnMI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.rBtnMI.Location = new System.Drawing.Point(523, 32);
			this.rBtnMI.Name = "rBtnMI";
			this.rBtnMI.Size = new System.Drawing.Size(90, 24);
			this.rBtnMI.TabIndex = 7;
			this.rBtnMI.Text = "Mã item";
			this.rBtnMI.UseVisualStyleBackColor = true;
			// 
			// rBtnMCV
			// 
			this.rBtnMCV.AutoSize = true;
			this.rBtnMCV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.rBtnMCV.Location = new System.Drawing.Point(335, 32);
			this.rBtnMCV.Name = "rBtnMCV";
			this.rBtnMCV.Size = new System.Drawing.Size(116, 24);
			this.rBtnMCV.TabIndex = 6;
			this.rBtnMCV.Text = "Mã chức vụ";
			this.rBtnMCV.UseVisualStyleBackColor = true;
			// 
			// rBtnMLP
			// 
			this.rBtnMLP.AutoSize = true;
			this.rBtnMLP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.rBtnMLP.Location = new System.Drawing.Point(147, 32);
			this.rBtnMLP.Name = "rBtnMLP";
			this.rBtnMLP.Size = new System.Drawing.Size(134, 24);
			this.rBtnMLP.TabIndex = 5;
			this.rBtnMLP.Text = "Mã loại phòng";
			this.rBtnMLP.UseVisualStyleBackColor = true;
			// 
			// rBtnMTT
			// 
			this.rBtnMTT.AutoSize = true;
			this.rBtnMTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.rBtnMTT.Location = new System.Drawing.Point(672, 32);
			this.rBtnMTT.Name = "rBtnMTT";
			this.rBtnMTT.Size = new System.Drawing.Size(136, 24);
			this.rBtnMTT.TabIndex = 4;
			this.rBtnMTT.Text = "Mã thanh toán";
			this.rBtnMTT.UseVisualStyleBackColor = true;
			// 
			// rBtnMT
			// 
			this.rBtnMT.AutoSize = true;
			this.rBtnMT.Checked = true;
			this.rBtnMT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.rBtnMT.Location = new System.Drawing.Point(6, 32);
			this.rBtnMT.Name = "rBtnMT";
			this.rBtnMT.Size = new System.Drawing.Size(81, 24);
			this.rBtnMT.TabIndex = 2;
			this.rBtnMT.TabStop = true;
			this.rBtnMT.Text = "Mã tòa";
			this.rBtnMT.UseVisualStyleBackColor = true;
			// 
			// btnThoat
			// 
			this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThoat.Location = new System.Drawing.Point(927, 156);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(235, 50);
			this.btnThoat.TabIndex = 57;
			this.btnThoat.Text = "Thoát";
			this.btnThoat.UseVisualStyleBackColor = true;
			this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
			// 
			// btnTim
			// 
			this.btnTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTim.Location = new System.Drawing.Point(927, 78);
			this.btnTim.Name = "btnTim";
			this.btnTim.Size = new System.Drawing.Size(235, 50);
			this.btnTim.TabIndex = 56;
			this.btnTim.Text = "Tìm kiếm";
			this.btnTim.UseVisualStyleBackColor = true;
			this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
			// 
			// SearchField
			// 
			this.SearchField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.SearchField.FormattingEnabled = true;
			this.SearchField.Location = new System.Drawing.Point(79, 169);
			this.SearchField.Name = "SearchField";
			this.SearchField.Size = new System.Drawing.Size(814, 37);
			this.SearchField.TabIndex = 55;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(43, 230);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(1119, 271);
			this.dataGridView1.TabIndex = 54;
			// 
			// lblTitle
			// 
			this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblTitle.AutoSize = true;
			this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
			this.lblTitle.Location = new System.Drawing.Point(360, 9);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(863, 46);
			this.lblTitle.TabIndex = 53;
			this.lblTitle.Text = "Tìm kiếm thông tin khác (form này chưa chốt)";
			// 
			// pHIEUXUATBindingSource
			// 
			this.pHIEUXUATBindingSource.DataMember = "PHIEUXUAT";
			// 
			// FormMiscSearch
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1222, 521);
			this.Controls.Add(this.g2);
			this.Controls.Add(this.btnThoat);
			this.Controls.Add(this.btnTim);
			this.Controls.Add(this.SearchField);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.lblTitle);
			this.Name = "FormMiscSearch";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.FormMiscSearch_Load);
			this.g2.ResumeLayout(false);
			this.g2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pHIEUXUATBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox g2;
		private System.Windows.Forms.RadioButton rBtnMI;
		private System.Windows.Forms.RadioButton rBtnMCV;
		private System.Windows.Forms.RadioButton rBtnMLP;
		private System.Windows.Forms.RadioButton rBtnMTT;
		private System.Windows.Forms.RadioButton rBtnMT;
		private System.Windows.Forms.Button btnThoat;
		private System.Windows.Forms.Button btnTim;
		private System.Windows.Forms.ComboBox SearchField;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.BindingSource pHIEUXUATBindingSource;
	}
}