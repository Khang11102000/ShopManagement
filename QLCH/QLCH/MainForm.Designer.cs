namespace QLCH
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.PnMenu = new System.Windows.Forms.Panel();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.PnMenu2 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnTKCPMH = new System.Windows.Forms.Button();
            this.btnTKDTBH = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnQLNCC = new System.Windows.Forms.Button();
            this.btnQLNhanVien = new System.Windows.Forms.Button();
            this.btnQLKhachHang = new System.Windows.Forms.Button();
            this.btnQLSanPham = new System.Windows.Forms.Button();
            this.btnQLLoaiSanPham = new System.Windows.Forms.Button();
            this.btnQuanLi = new System.Windows.Forms.Button();
            this.btnMuaHang = new System.Windows.Forms.Button();
            this.btnBanHang = new System.Windows.Forms.Button();
            this.PnMenu1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.PnMain = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PnMenu.SuspendLayout();
            this.PnMenu2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.PnMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnMenu
            // 
            this.PnMenu.BackColor = System.Drawing.Color.DodgerBlue;
            this.PnMenu.Controls.Add(this.btnDangXuat);
            this.PnMenu.Controls.Add(this.PnMenu2);
            this.PnMenu.Controls.Add(this.PnMenu1);
            this.PnMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnMenu.Location = new System.Drawing.Point(0, 0);
            this.PnMenu.Name = "PnMenu";
            this.PnMenu.Size = new System.Drawing.Size(306, 1033);
            this.PnMenu.TabIndex = 1;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDangXuat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDangXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.Image = ((System.Drawing.Image)(resources.GetObject("btnDangXuat.Image")));
            this.btnDangXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangXuat.Location = new System.Drawing.Point(0, 863);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(306, 64);
            this.btnDangXuat.TabIndex = 14;
            this.btnDangXuat.Text = "Đăng Xuất";
            this.btnDangXuat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDangXuat.UseVisualStyleBackColor = false;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // PnMenu2
            // 
            this.PnMenu2.Controls.Add(this.panel2);
            this.PnMenu2.Controls.Add(this.btnThongKe);
            this.PnMenu2.Controls.Add(this.panel1);
            this.PnMenu2.Controls.Add(this.btnQuanLi);
            this.PnMenu2.Controls.Add(this.btnMuaHang);
            this.PnMenu2.Controls.Add(this.btnBanHang);
            this.PnMenu2.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnMenu2.Location = new System.Drawing.Point(0, 159);
            this.PnMenu2.Name = "PnMenu2";
            this.PnMenu2.Size = new System.Drawing.Size(306, 704);
            this.PnMenu2.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnTKCPMH);
            this.panel2.Controls.Add(this.btnTKDTBH);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 575);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(306, 126);
            this.panel2.TabIndex = 0;
            // 
            // btnTKCPMH
            // 
            this.btnTKCPMH.BackColor = System.Drawing.SystemColors.Menu;
            this.btnTKCPMH.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTKCPMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTKCPMH.Location = new System.Drawing.Point(0, 64);
            this.btnTKCPMH.Name = "btnTKCPMH";
            this.btnTKCPMH.Size = new System.Drawing.Size(306, 64);
            this.btnTKCPMH.TabIndex = 17;
            this.btnTKCPMH.Text = "Chi Phí Mua Hàng";
            this.btnTKCPMH.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTKCPMH.UseVisualStyleBackColor = false;
            this.btnTKCPMH.Click += new System.EventHandler(this.btnTKCPMH_Click_1);
            // 
            // btnTKDTBH
            // 
            this.btnTKDTBH.BackColor = System.Drawing.SystemColors.Menu;
            this.btnTKDTBH.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTKDTBH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTKDTBH.Location = new System.Drawing.Point(0, 0);
            this.btnTKDTBH.Name = "btnTKDTBH";
            this.btnTKDTBH.Size = new System.Drawing.Size(306, 64);
            this.btnTKDTBH.TabIndex = 16;
            this.btnTKDTBH.Text = "Doanh Thu Bán Hàng";
            this.btnTKDTBH.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTKDTBH.UseVisualStyleBackColor = false;
            this.btnTKDTBH.Click += new System.EventHandler(this.btnTKDTBH_Click_1);
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnThongKe.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.Image = ((System.Drawing.Image)(resources.GetObject("btnThongKe.Image")));
            this.btnThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.Location = new System.Drawing.Point(0, 511);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(306, 64);
            this.btnThongKe.TabIndex = 13;
            this.btnThongKe.Text = "Thống Kê";
            this.btnThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnQLNCC);
            this.panel1.Controls.Add(this.btnQLNhanVien);
            this.panel1.Controls.Add(this.btnQLKhachHang);
            this.panel1.Controls.Add(this.btnQLSanPham);
            this.panel1.Controls.Add(this.btnQLLoaiSanPham);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 192);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(306, 319);
            this.panel1.TabIndex = 0;
            // 
            // btnQLNCC
            // 
            this.btnQLNCC.BackColor = System.Drawing.SystemColors.Menu;
            this.btnQLNCC.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLNCC.Location = new System.Drawing.Point(0, 256);
            this.btnQLNCC.Name = "btnQLNCC";
            this.btnQLNCC.Size = new System.Drawing.Size(306, 64);
            this.btnQLNCC.TabIndex = 14;
            this.btnQLNCC.Text = "Nhà Cung Cấp";
            this.btnQLNCC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLNCC.UseVisualStyleBackColor = false;
            this.btnQLNCC.Click += new System.EventHandler(this.btnQLNCC_Click);
            // 
            // btnQLNhanVien
            // 
            this.btnQLNhanVien.BackColor = System.Drawing.SystemColors.Menu;
            this.btnQLNhanVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLNhanVien.Location = new System.Drawing.Point(0, 192);
            this.btnQLNhanVien.Name = "btnQLNhanVien";
            this.btnQLNhanVien.Size = new System.Drawing.Size(306, 64);
            this.btnQLNhanVien.TabIndex = 13;
            this.btnQLNhanVien.Text = "Nhân Viên";
            this.btnQLNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLNhanVien.UseVisualStyleBackColor = false;
            this.btnQLNhanVien.Click += new System.EventHandler(this.btnQLNhanVien_Click);
            // 
            // btnQLKhachHang
            // 
            this.btnQLKhachHang.BackColor = System.Drawing.SystemColors.Menu;
            this.btnQLKhachHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLKhachHang.Location = new System.Drawing.Point(0, 128);
            this.btnQLKhachHang.Name = "btnQLKhachHang";
            this.btnQLKhachHang.Size = new System.Drawing.Size(306, 64);
            this.btnQLKhachHang.TabIndex = 12;
            this.btnQLKhachHang.Text = "Khách Hàng";
            this.btnQLKhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLKhachHang.UseVisualStyleBackColor = false;
            this.btnQLKhachHang.Click += new System.EventHandler(this.btnQLKhachHang_Click_1);
            // 
            // btnQLSanPham
            // 
            this.btnQLSanPham.BackColor = System.Drawing.SystemColors.Menu;
            this.btnQLSanPham.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLSanPham.Location = new System.Drawing.Point(0, 64);
            this.btnQLSanPham.Name = "btnQLSanPham";
            this.btnQLSanPham.Size = new System.Drawing.Size(306, 64);
            this.btnQLSanPham.TabIndex = 11;
            this.btnQLSanPham.Text = "Sản Phẩm";
            this.btnQLSanPham.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLSanPham.UseVisualStyleBackColor = false;
            this.btnQLSanPham.Click += new System.EventHandler(this.btnQLSanPham_Click_1);
            // 
            // btnQLLoaiSanPham
            // 
            this.btnQLLoaiSanPham.BackColor = System.Drawing.SystemColors.Menu;
            this.btnQLLoaiSanPham.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLLoaiSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLLoaiSanPham.Location = new System.Drawing.Point(0, 0);
            this.btnQLLoaiSanPham.Name = "btnQLLoaiSanPham";
            this.btnQLLoaiSanPham.Size = new System.Drawing.Size(306, 64);
            this.btnQLLoaiSanPham.TabIndex = 10;
            this.btnQLLoaiSanPham.Text = "Loại Sản Phẩm";
            this.btnQLLoaiSanPham.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLLoaiSanPham.UseVisualStyleBackColor = false;
            this.btnQLLoaiSanPham.Click += new System.EventHandler(this.btnQLLoaiSanPham_Click_1);
            // 
            // btnQuanLi
            // 
            this.btnQuanLi.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnQuanLi.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQuanLi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLi.Image = ((System.Drawing.Image)(resources.GetObject("btnQuanLi.Image")));
            this.btnQuanLi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLi.Location = new System.Drawing.Point(0, 128);
            this.btnQuanLi.Name = "btnQuanLi";
            this.btnQuanLi.Size = new System.Drawing.Size(306, 64);
            this.btnQuanLi.TabIndex = 4;
            this.btnQuanLi.Text = "Quản Lí";
            this.btnQuanLi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQuanLi.UseVisualStyleBackColor = false;
            this.btnQuanLi.Click += new System.EventHandler(this.btnQuanLi_Click);
            // 
            // btnMuaHang
            // 
            this.btnMuaHang.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnMuaHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMuaHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMuaHang.Image = ((System.Drawing.Image)(resources.GetObject("btnMuaHang.Image")));
            this.btnMuaHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMuaHang.Location = new System.Drawing.Point(0, 64);
            this.btnMuaHang.Name = "btnMuaHang";
            this.btnMuaHang.Size = new System.Drawing.Size(306, 64);
            this.btnMuaHang.TabIndex = 3;
            this.btnMuaHang.Text = "Nhập Hàng";
            this.btnMuaHang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMuaHang.UseVisualStyleBackColor = false;
            this.btnMuaHang.Click += new System.EventHandler(this.btnMuaHang_Click);
            // 
            // btnBanHang
            // 
            this.btnBanHang.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnBanHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBanHang.Enabled = false;
            this.btnBanHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBanHang.Image = ((System.Drawing.Image)(resources.GetObject("btnBanHang.Image")));
            this.btnBanHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBanHang.Location = new System.Drawing.Point(0, 0);
            this.btnBanHang.Name = "btnBanHang";
            this.btnBanHang.Size = new System.Drawing.Size(306, 64);
            this.btnBanHang.TabIndex = 2;
            this.btnBanHang.Text = "Mua Hàng";
            this.btnBanHang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBanHang.UseVisualStyleBackColor = false;
            this.btnBanHang.Click += new System.EventHandler(this.btnBanHang_Click);
            // 
            // PnMenu1
            // 
            this.PnMenu1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PnMenu1.BackgroundImage")));
            this.PnMenu1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PnMenu1.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnMenu1.Location = new System.Drawing.Point(0, 0);
            this.PnMenu1.Name = "PnMenu1";
            this.PnMenu1.Size = new System.Drawing.Size(306, 159);
            this.PnMenu1.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // PnMain
            // 
            this.PnMain.BackColor = System.Drawing.Color.Transparent;
            this.PnMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PnMain.Controls.Add(this.pictureBox1);
            this.PnMain.Location = new System.Drawing.Point(105, 198);
            this.PnMain.Name = "PnMain";
            this.PnMain.Size = new System.Drawing.Size(1450, 762);
            this.PnMain.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(302, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(797, 650);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.PnMain);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(312, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1612, 1033);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1612, 153);
            this.panel4.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(941, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 32);
            this.label3.TabIndex = 9;
            this.label3.Text = "Day";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(909, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 91);
            this.label2.TabIndex = 8;
            this.label2.Text = "00/00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(485, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 91);
            this.label1.TabIndex = 7;
            this.label1.Text = "00:00:00";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 1033);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.PnMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.PnMenu.ResumeLayout(false);
            this.PnMenu2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.PnMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PnMenu;
        private System.Windows.Forms.Panel PnMenu2;
        private System.Windows.Forms.Button btnQuanLi;
        private System.Windows.Forms.Button btnMuaHang;
        private System.Windows.Forms.Button btnBanHang;
        private System.Windows.Forms.Panel PnMenu1;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnTKCPMH;
        private System.Windows.Forms.Button btnTKDTBH;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnQLNCC;
        private System.Windows.Forms.Button btnQLNhanVien;
        private System.Windows.Forms.Button btnQLKhachHang;
        private System.Windows.Forms.Button btnQLSanPham;
        private System.Windows.Forms.Button btnQLLoaiSanPham;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel PnMain;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}