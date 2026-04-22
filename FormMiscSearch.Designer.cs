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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.g2 = new System.Windows.Forms.GroupBox();
            this.rBtnBA = new System.Windows.Forms.RadioButton();
            this.rBtnMCV = new System.Windows.Forms.RadioButton();
            this.rBtnMLP = new System.Windows.Forms.RadioButton();
            this.rBtnMTT = new System.Windows.Forms.RadioButton();
            this.rBtnMT = new System.Windows.Forms.RadioButton();
            this.btnThoat = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pHIEUXUATBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblTitle = new System.Windows.Forms.Label();
            this.g2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUXUATBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // g2
            // 
            this.g2.BackColor = System.Drawing.Color.White;
            this.g2.Controls.Add(this.rBtnBA);
            this.g2.Controls.Add(this.rBtnMCV);
            this.g2.Controls.Add(this.rBtnMLP);
            this.g2.Controls.Add(this.rBtnMTT);
            this.g2.Controls.Add(this.rBtnMT);
            this.g2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.g2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(57)))), ((int)(((byte)(71)))));
            this.g2.Location = new System.Drawing.Point(47, 101);
            this.g2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.g2.Name = "g2";
            this.g2.Padding = new System.Windows.Forms.Padding(20, 5, 4, 5);
            this.g2.Size = new System.Drawing.Size(1237, 157);
            this.g2.TabIndex = 58;
            this.g2.TabStop = false;
            this.g2.Text = "Xem thông tin ở bảng:";
            // 
            // rBtnBA
            // 
            this.rBtnBA.AutoSize = true;
            this.rBtnBA.Font = new System.Drawing.Font("Segoe UI Semibold", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtnBA.Location = new System.Drawing.Point(1015, 79);
            this.rBtnBA.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rBtnBA.Name = "rBtnBA";
            this.rBtnBA.Size = new System.Drawing.Size(207, 54);
            this.rBtnBA.TabIndex = 7;
            this.rBtnBA.Text = "Accounts";
            this.rBtnBA.UseVisualStyleBackColor = true;
            // 
            // rBtnMCV
            // 
            this.rBtnMCV.AutoSize = true;
            this.rBtnMCV.Font = new System.Drawing.Font("Segoe UI Semibold", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtnMCV.Location = new System.Drawing.Point(515, 79);
            this.rBtnMCV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rBtnMCV.Name = "rBtnMCV";
            this.rBtnMCV.Size = new System.Drawing.Size(205, 54);
            this.rBtnMCV.TabIndex = 6;
            this.rBtnMCV.Text = "Positions";
            this.rBtnMCV.UseVisualStyleBackColor = true;
            // 
            // rBtnMLP
            // 
            this.rBtnMLP.AutoSize = true;
            this.rBtnMLP.Font = new System.Drawing.Font("Segoe UI Semibold", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtnMLP.Location = new System.Drawing.Point(240, 79);
            this.rBtnMLP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rBtnMLP.Name = "rBtnMLP";
            this.rBtnMLP.Size = new System.Drawing.Size(247, 54);
            this.rBtnMLP.TabIndex = 5;
            this.rBtnMLP.Text = "RoomTypes";
            this.rBtnMLP.UseVisualStyleBackColor = true;
            // 
            // rBtnMTT
            // 
            this.rBtnMTT.AutoSize = true;
            this.rBtnMTT.Font = new System.Drawing.Font("Segoe UI Semibold", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtnMTT.Location = new System.Drawing.Point(762, 79);
            this.rBtnMTT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rBtnMTT.Name = "rBtnMTT";
            this.rBtnMTT.Size = new System.Drawing.Size(216, 54);
            this.rBtnMTT.TabIndex = 4;
            this.rBtnMTT.Text = "Payments";
            this.rBtnMTT.UseVisualStyleBackColor = true;
            // 
            // rBtnMT
            // 
            this.rBtnMT.AutoSize = true;
            this.rBtnMT.Checked = true;
            this.rBtnMT.Font = new System.Drawing.Font("Segoe UI Semibold", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtnMT.Location = new System.Drawing.Point(33, 79);
            this.rBtnMT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rBtnMT.Name = "rBtnMT";
            this.rBtnMT.Size = new System.Drawing.Size(169, 54);
            this.rBtnMT.TabIndex = 2;
            this.rBtnMT.TabStop = true;
            this.rBtnMT.Text = "Towers";
            this.rBtnMT.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(57)))), ((int)(((byte)(71)))));
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI Semibold", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(1327, 143);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(330, 78);
            this.btnThoat.TabIndex = 57;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(57)))), ((int)(((byte)(71)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(77)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(57)))), ((int)(((byte)(71)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(77)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(47, 268);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1636, 888);
            this.dataGridView1.TabIndex = 54;
            // 
            // pHIEUXUATBindingSource
            // 
            this.pHIEUXUATBindingSource.DataMember = "PHIEUXUAT";
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
            this.lblTitle.Size = new System.Drawing.Size(618, 71);
            this.lblTitle.TabIndex = 112;
            this.lblTitle.Text = "Tìm kiếm thông tin khác";
            // 
            // FormMiscSearch
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1740, 1200);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.g2);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
		private System.Windows.Forms.RadioButton rBtnBA;
		private System.Windows.Forms.RadioButton rBtnMCV;
		private System.Windows.Forms.RadioButton rBtnMLP;
		private System.Windows.Forms.RadioButton rBtnMTT;
		private System.Windows.Forms.RadioButton rBtnMT;
		private System.Windows.Forms.Button btnThoat;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.BindingSource pHIEUXUATBindingSource;
        private System.Windows.Forms.Label lblTitle;
    }
}