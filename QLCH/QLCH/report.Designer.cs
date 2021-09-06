namespace QLCH
{
    partial class report
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.SanPhamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QLCHDataSet2 = new QLCH.QLCHDataSet2();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.QLCHDataSet1 = new QLCH.QLCHDataSet1();
            this.BanHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BanHangTableAdapter = new QLCH.QLCHDataSet1TableAdapters.BanHangTableAdapter();
            this.SanPhamTableAdapter = new QLCH.QLCHDataSet2TableAdapters.SanPhamTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SanPhamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLCHDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLCHDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BanHangBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // SanPhamBindingSource
            // 
            this.SanPhamBindingSource.DataMember = "SanPham";
            this.SanPhamBindingSource.DataSource = this.QLCHDataSet2;
            // 
            // QLCHDataSet2
            // 
            this.QLCHDataSet2.DataSetName = "QLCHDataSet2";
            this.QLCHDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.BanHangBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLCH.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(974, 416);
            this.reportViewer1.TabIndex = 0;
            // 
            // QLCHDataSet1
            // 
            this.QLCHDataSet1.DataSetName = "QLCHDataSet1";
            this.QLCHDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BanHangBindingSource
            // 
            this.BanHangBindingSource.DataMember = "BanHang";
            this.BanHangBindingSource.DataSource = this.QLCHDataSet1;
            // 
            // BanHangTableAdapter
            // 
            this.BanHangTableAdapter.ClearBeforeFill = true;
            // 
            // SanPhamTableAdapter
            // 
            this.SanPhamTableAdapter.ClearBeforeFill = true;
            // 
            // report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 468);
            this.Controls.Add(this.reportViewer1);
            this.Name = "report";
            this.Text = "report";
            this.Load += new System.EventHandler(this.report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SanPhamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLCHDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLCHDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BanHangBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource BanHangBindingSource;
        private QLCHDataSet1 QLCHDataSet1;
        private QLCHDataSet1TableAdapters.BanHangTableAdapter BanHangTableAdapter;
        private System.Windows.Forms.BindingSource SanPhamBindingSource;
        private QLCHDataSet2 QLCHDataSet2;
        private QLCHDataSet2TableAdapters.SanPhamTableAdapter SanPhamTableAdapter;
    }
}