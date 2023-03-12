
namespace DoAn_QuanLyQuanCafe
{
    partial class fTotal
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txbTong = new System.Windows.Forms.TextBox();
            this.txbPage = new System.Windows.Forms.TextBox();
            this.dtgvBill = new System.Windows.Forms.DataGridView();
            this.DoanhThu = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnFirstBillPage = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnLastBillPage = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnNextBillPage = new System.Windows.Forms.Button();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.btnPreviousBillPage = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DoanhThuDataSet = new DoAn_QuanLyQuanCafe.DoanhThuDataSet();
            this.USP_GetReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.USP_GetReportTableAdapter = new DoAn_QuanLyQuanCafe.DoanhThuDataSetTableAdapters.USP_GetReportTableAdapter();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBill)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DoanhThuDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.USP_GetReportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txbTong);
            this.tabPage2.Controls.Add(this.txbPage);
            this.tabPage2.Controls.Add(this.dtgvBill);
            this.tabPage2.Controls.Add(this.DoanhThu);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.btnFirstBillPage);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.btnLastBillPage);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.btnNextBillPage);
            this.tabPage2.Controls.Add(this.dtpFromDate);
            this.tabPage2.Controls.Add(this.dtpToDate);
            this.tabPage2.Controls.Add(this.btnPreviousBillPage);
            this.tabPage2.Controls.Add(this.btnThongKe);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1119, 479);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Doanh Thu";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txbTong
            // 
            this.txbTong.Location = new System.Drawing.Point(154, 347);
            this.txbTong.Name = "txbTong";
            this.txbTong.ReadOnly = true;
            this.txbTong.Size = new System.Drawing.Size(153, 22);
            this.txbTong.TabIndex = 30;
            // 
            // txbPage
            // 
            this.txbPage.Location = new System.Drawing.Point(118, 442);
            this.txbPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbPage.Name = "txbPage";
            this.txbPage.Size = new System.Drawing.Size(65, 22);
            this.txbPage.TabIndex = 24;
            this.txbPage.Text = "1";
            this.txbPage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbPage.TextChanged += new System.EventHandler(this.txbPage_TextChanged);
            // 
            // dtgvBill
            // 
            this.dtgvBill.AllowUserToAddRows = false;
            this.dtgvBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvBill.Location = new System.Drawing.Point(313, 5);
            this.dtgvBill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgvBill.Name = "dtgvBill";
            this.dtgvBill.RowHeadersWidth = 51;
            this.dtgvBill.RowTemplate.Height = 24;
            this.dtgvBill.Size = new System.Drawing.Size(803, 459);
            this.dtgvBill.TabIndex = 20;
            // 
            // DoanhThu
            // 
            this.DoanhThu.AutoSize = true;
            this.DoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoanhThu.Location = new System.Drawing.Point(8, 349);
            this.DoanhThu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DoanhThu.Name = "DoanhThu";
            this.DoanhThu.Size = new System.Drawing.Size(129, 20);
            this.DoanhThu.TabIndex = 29;
            this.DoanhThu.Text = "Tổng doanh thu:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(277, 29);
            this.label5.TabIndex = 25;
            this.label5.Text = "THÔNG TIN TÌM KIẾM";
            // 
            // btnFirstBillPage
            // 
            this.btnFirstBillPage.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirstBillPage.Location = new System.Drawing.Point(8, 438);
            this.btnFirstBillPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFirstBillPage.Name = "btnFirstBillPage";
            this.btnFirstBillPage.Size = new System.Drawing.Size(47, 28);
            this.btnFirstBillPage.TabIndex = 19;
            this.btnFirstBillPage.Text = "<<";
            this.btnFirstBillPage.UseVisualStyleBackColor = true;
            this.btnFirstBillPage.Click += new System.EventHandler(this.btnFirstBillPage_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 25);
            this.label7.TabIndex = 27;
            this.label7.Text = "Đến:";
            // 
            // btnLastBillPage
            // 
            this.btnLastBillPage.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLastBillPage.Location = new System.Drawing.Point(246, 438);
            this.btnLastBillPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLastBillPage.Name = "btnLastBillPage";
            this.btnLastBillPage.Size = new System.Drawing.Size(47, 28);
            this.btnLastBillPage.TabIndex = 21;
            this.btnLastBillPage.Text = ">>";
            this.btnLastBillPage.UseVisualStyleBackColor = true;
            this.btnLastBillPage.Click += new System.EventHandler(this.btnLastBillPage_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 25);
            this.label6.TabIndex = 26;
            this.label6.Text = "Từ:";
            // 
            // btnNextBillPage
            // 
            this.btnNextBillPage.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextBillPage.Location = new System.Drawing.Point(194, 438);
            this.btnNextBillPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNextBillPage.Name = "btnNextBillPage";
            this.btnNextBillPage.Size = new System.Drawing.Size(47, 28);
            this.btnNextBillPage.TabIndex = 22;
            this.btnNextBillPage.Text = ">";
            this.btnNextBillPage.UseVisualStyleBackColor = true;
            this.btnNextBillPage.Click += new System.EventHandler(this.btnNextBillPage_Click);
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.CustomFormat = "dd/MM/yyyy";
            this.dtpFromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFromDate.Location = new System.Drawing.Point(32, 110);
            this.dtpFromDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(215, 27);
            this.dtpFromDate.TabIndex = 16;
            // 
            // dtpToDate
            // 
            this.dtpToDate.CustomFormat = "dd/MM/yyyy";
            this.dtpToDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpToDate.Location = new System.Drawing.Point(32, 219);
            this.dtpToDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(215, 27);
            this.dtpToDate.TabIndex = 17;
            // 
            // btnPreviousBillPage
            // 
            this.btnPreviousBillPage.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreviousBillPage.Location = new System.Drawing.Point(60, 438);
            this.btnPreviousBillPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPreviousBillPage.Name = "btnPreviousBillPage";
            this.btnPreviousBillPage.Size = new System.Drawing.Size(47, 26);
            this.btnPreviousBillPage.TabIndex = 23;
            this.btnPreviousBillPage.Text = "<";
            this.btnPreviousBillPage.UseVisualStyleBackColor = true;
            this.btnPreviousBillPage.Click += new System.EventHandler(this.btnPreviousBillPage_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.Location = new System.Drawing.Point(64, 283);
            this.btnThongKe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(119, 41);
            this.btnThongKe.TabIndex = 18;
            this.btnThongKe.Text = "Thống Kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(2, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1127, 508);
            this.tabControl1.TabIndex = 30;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.reportViewer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1119, 479);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Báo Cáo Doanh Thu";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // reportViewer1
            // 
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.USP_GetReportBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DoAn_QuanLyQuanCafe.RpDoanhThu.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1107, 473);
            this.reportViewer1.TabIndex = 0;
            // 
            // DoanhThuDataSet
            // 
            this.DoanhThuDataSet.DataSetName = "DoanhThuDataSet";
            this.DoanhThuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // USP_GetReportBindingSource
            // 
            this.USP_GetReportBindingSource.DataMember = "USP_GetReport";
            this.USP_GetReportBindingSource.DataSource = this.DoanhThuDataSet;
            // 
            // USP_GetReportTableAdapter
            // 
            this.USP_GetReportTableAdapter.ClearBeforeFill = true;
            // 
            // fTotal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 512);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fTotal";
            this.Text = "fTotal";
            this.Load += new System.EventHandler(this.fTotal_Load);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBill)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DoanhThuDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.USP_GetReportBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txbTong;
        private System.Windows.Forms.TextBox txbPage;
        private System.Windows.Forms.DataGridView dtgvBill;
        private System.Windows.Forms.Label DoanhThu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnFirstBillPage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnLastBillPage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnNextBillPage;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.Button btnPreviousBillPage;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource USP_GetReportBindingSource;
        private DoanhThuDataSet DoanhThuDataSet;
        private DoanhThuDataSetTableAdapters.USP_GetReportTableAdapter USP_GetReportTableAdapter;
    }
}