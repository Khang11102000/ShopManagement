namespace QLCH
{
    partial class DangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangNhap));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonCannel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.status = new System.Windows.Forms.Label();
            this.textBoxMatKhau = new System.Windows.Forms.TextBox();
            this.textBoxDangNhap = new System.Windows.Forms.TextBox();
            this.link_DangKy = new System.Windows.Forms.LinkLabel();
            this.rdbQL = new System.Windows.Forms.RadioButton();
            this.rdbKH = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdbKH);
            this.panel1.Controls.Add(this.rdbQL);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.buttonCannel);
            this.panel1.Controls.Add(this.buttonOK);
            this.panel1.Controls.Add(this.status);
            this.panel1.Controls.Add(this.textBoxMatKhau);
            this.panel1.Controls.Add(this.textBoxDangNhap);
            this.panel1.Controls.Add(this.link_DangKy);
            this.panel1.Location = new System.Drawing.Point(433, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(438, 502);
            this.panel1.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 342);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 27;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "Username";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(438, 69);
            this.panel2.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(126, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐĂNG NHẬP";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(137, 89);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 137);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // buttonCannel
            // 
            this.buttonCannel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonCannel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCannel.Image = ((System.Drawing.Image)(resources.GetObject("buttonCannel.Image")));
            this.buttonCannel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCannel.Location = new System.Drawing.Point(246, 377);
            this.buttonCannel.Name = "buttonCannel";
            this.buttonCannel.Size = new System.Drawing.Size(150, 75);
            this.buttonCannel.TabIndex = 23;
            this.buttonCannel.Text = "Thoát";
            this.buttonCannel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCannel.UseVisualStyleBackColor = false;
            this.buttonCannel.Click += new System.EventHandler(this.buttonCannel_Click_1);
            // 
            // buttonOK
            // 
            this.buttonOK.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOK.Image = ((System.Drawing.Image)(resources.GetObject("buttonOK.Image")));
            this.buttonOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOK.Location = new System.Drawing.Point(36, 377);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(150, 75);
            this.buttonOK.TabIndex = 22;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = false;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click_1);
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.ForeColor = System.Drawing.SystemColors.Highlight;
            this.status.Location = new System.Drawing.Point(186, 376);
            this.status.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(0, 20);
            this.status.TabIndex = 21;
            // 
            // textBoxMatKhau
            // 
            this.textBoxMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMatKhau.Location = new System.Drawing.Point(36, 313);
            this.textBoxMatKhau.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMatKhau.Name = "textBoxMatKhau";
            this.textBoxMatKhau.Size = new System.Drawing.Size(360, 27);
            this.textBoxMatKhau.TabIndex = 20;
            this.textBoxMatKhau.UseSystemPasswordChar = true;
            // 
            // textBoxDangNhap
            // 
            this.textBoxDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDangNhap.Location = new System.Drawing.Point(36, 251);
            this.textBoxDangNhap.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxDangNhap.Name = "textBoxDangNhap";
            this.textBoxDangNhap.Size = new System.Drawing.Size(360, 27);
            this.textBoxDangNhap.TabIndex = 19;
            // 
            // link_DangKy
            // 
            this.link_DangKy.AutoSize = true;
            this.link_DangKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_DangKy.Location = new System.Drawing.Point(132, 463);
            this.link_DangKy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.link_DangKy.Name = "link_DangKy";
            this.link_DangKy.Size = new System.Drawing.Size(184, 20);
            this.link_DangKy.TabIndex = 18;
            this.link_DangKy.TabStop = true;
            this.link_DangKy.Text = "Bạn chưa có tài khoản?";
            this.link_DangKy.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_DangKy_LinkClicked_1);
            // 
            // rdbQL
            // 
            this.rdbQL.AutoSize = true;
            this.rdbQL.Location = new System.Drawing.Point(42, 350);
            this.rdbQL.Name = "rdbQL";
            this.rdbQL.Size = new System.Drawing.Size(83, 21);
            this.rdbQL.TabIndex = 28;
            this.rdbQL.TabStop = true;
            this.rdbQL.Text = "Quản Lý";
            this.rdbQL.UseVisualStyleBackColor = true;
            // 
            // rdbKH
            // 
            this.rdbKH.AutoSize = true;
            this.rdbKH.Location = new System.Drawing.Point(246, 350);
            this.rdbKH.Name = "rdbKH";
            this.rdbKH.Size = new System.Drawing.Size(107, 21);
            this.rdbKH.TabIndex = 29;
            this.rdbKH.TabStop = true;
            this.rdbKH.Text = "Khách Hàng";
            this.rdbKH.UseVisualStyleBackColor = true;
            // 
            // DangNhap
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonCannel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.TextBox textBoxMatKhau;
        private System.Windows.Forms.TextBox textBoxDangNhap;
        private System.Windows.Forms.LinkLabel link_DangKy;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdbKH;
        private System.Windows.Forms.RadioButton rdbQL;
    }
}

