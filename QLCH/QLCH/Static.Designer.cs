namespace QLCH
{
    partial class Static
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.banHangBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.qLCHDataSet4 = new QLCH.QLCHDataSet4();
            this.button1 = new System.Windows.Forms.Button();
            this.qLCHDataSet3 = new QLCH.QLCHDataSet3();
            this.banHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.banHangTableAdapter = new QLCH.QLCHDataSet3TableAdapters.BanHangTableAdapter();
            this.banHangTableAdapter1 = new QLCH.QLCHDataSet4TableAdapters.BanHangTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banHangBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLCHDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLCHDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banHangBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.DataSource = this.banHangBindingSource1;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 28);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Đơn Giá";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1031, 527);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // banHangBindingSource1
            // 
            this.banHangBindingSource1.DataMember = "BanHang";
            this.banHangBindingSource1.DataSource = this.qLCHDataSet4;
            // 
            // qLCHDataSet4
            // 
            this.qLCHDataSet4.DataSetName = "QLCHDataSet4";
            this.qLCHDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1090, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 60);
            this.button1.TabIndex = 1;
            this.button1.Text = "Sản Phẩm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // qLCHDataSet3
            // 
            this.qLCHDataSet3.DataSetName = "QLCHDataSet3";
            this.qLCHDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // banHangBindingSource
            // 
            this.banHangBindingSource.DataMember = "BanHang";
            this.banHangBindingSource.DataSource = this.qLCHDataSet3;
            // 
            // banHangTableAdapter
            // 
            this.banHangTableAdapter.ClearBeforeFill = true;
            // 
            // banHangTableAdapter1
            // 
            this.banHangTableAdapter1.ClearBeforeFill = true;
            // 
            // Static
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 605);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chart1);
            this.Name = "Static";
            this.Text = "Static";
            this.Load += new System.EventHandler(this.Static_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banHangBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLCHDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLCHDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banHangBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button1;
        private QLCHDataSet3 qLCHDataSet3;
        private System.Windows.Forms.BindingSource banHangBindingSource;
        private QLCHDataSet3TableAdapters.BanHangTableAdapter banHangTableAdapter;
        private QLCHDataSet4 qLCHDataSet4;
        private System.Windows.Forms.BindingSource banHangBindingSource1;
        private QLCHDataSet4TableAdapters.BanHangTableAdapter banHangTableAdapter1;
    }
}