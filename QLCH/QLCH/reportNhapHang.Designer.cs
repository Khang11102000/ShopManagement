namespace QLCH
{
    partial class reportNhapHang
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.QLCHDataSet5 = new QLCH.QLCHDataSet5();
            this.NhapHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.NhapHangTableAdapter = new QLCH.QLCHDataSet5TableAdapters.NhapHangTableAdapter();
            this.QLCHDataSet6 = new QLCH.QLCHDataSet6();
            ((System.ComponentModel.ISupportInitialize)(this.QLCHDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NhapHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLCHDataSet6)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.NhapHangBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLCH.Report4.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(55, 39);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(646, 444);
            this.reportViewer1.TabIndex = 0;
            // 
            // QLCHDataSet5
            // 
            this.QLCHDataSet5.DataSetName = "QLCHDataSet5";
            this.QLCHDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // NhapHangBindingSource
            // 
            this.NhapHangBindingSource.DataMember = "NhapHang";
            this.NhapHangBindingSource.DataSource = this.QLCHDataSet5;
            // 
            // NhapHangTableAdapter
            // 
            this.NhapHangTableAdapter.ClearBeforeFill = true;
            // 
            // QLCHDataSet6
            // 
            this.QLCHDataSet6.DataSetName = "QLCHDataSet6";
            this.QLCHDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 526);
            this.Controls.Add(this.reportViewer1);
            this.Name = "reportNhapHang";
            this.Text = "reportNhapHang";
            this.Load += new System.EventHandler(this.reportNhapHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QLCHDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NhapHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLCHDataSet6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource NhapHangBindingSource;
        private QLCHDataSet5 QLCHDataSet5;
        private QLCHDataSet5TableAdapters.NhapHangTableAdapter NhapHangTableAdapter;
        private QLCHDataSet6 QLCHDataSet6;
    }
}