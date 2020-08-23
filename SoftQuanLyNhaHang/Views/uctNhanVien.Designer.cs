namespace SoftQuanLyNhaHang.Views
{
    partial class uctNhanVien
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnFind = new System.Windows.Forms.Button();
            this.pnlDanhSachNV = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.grDanhSachNV = new System.Windows.Forms.GroupBox();
            this.dgvDanhSachNV = new System.Windows.Forms.DataGridView();
            this.grQuanLyNV = new System.Windows.Forms.GroupBox();
            this.cmbGioiTinhNV = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpNgaySinhNV = new System.Windows.Forms.DateTimePicker();
            this.txtHolotNV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmailNV = new System.Windows.Forms.TextBox();
            this.txtDiaChiNV = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDienThoaiNV = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdNhanVien = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.btnHide = new System.Windows.Forms.Button();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoLot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grDanhSachNV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachNV)).BeginInit();
            this.grQuanLyNV.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.SystemColors.Control;
            this.btnFind.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.Location = new System.Drawing.Point(481, 275);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(96, 32);
            this.btnFind.TabIndex = 65;
            this.btnFind.Text = "Tìm kiếm ";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // pnlDanhSachNV
            // 
            this.pnlDanhSachNV.Location = new System.Drawing.Point(26, 313);
            this.pnlDanhSachNV.Name = "pnlDanhSachNV";
            this.pnlDanhSachNV.Size = new System.Drawing.Size(812, 272);
            this.pnlDanhSachNV.TabIndex = 63;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Blue;
            this.label12.Location = new System.Drawing.Point(730, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(202, 19);
            this.label12.TabIndex = 76;
            this.label12.Text = "DANH SÁCH NHÂN VIÊN";
            // 
            // grDanhSachNV
            // 
            this.grDanhSachNV.BackColor = System.Drawing.SystemColors.ControlLight;
            this.grDanhSachNV.Controls.Add(this.dgvDanhSachNV);
            this.grDanhSachNV.Location = new System.Drawing.Point(445, 55);
            this.grDanhSachNV.Name = "grDanhSachNV";
            this.grDanhSachNV.Size = new System.Drawing.Size(792, 205);
            this.grDanhSachNV.TabIndex = 75;
            this.grDanhSachNV.TabStop = false;
            // 
            // dgvDanhSachNV
            // 
            this.dgvDanhSachNV.AllowUserToAddRows = false;
            this.dgvDanhSachNV.AllowUserToDeleteRows = false;
            this.dgvDanhSachNV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachNV.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvDanhSachNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachNV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdNhanVien,
            this.HoLot,
            this.Ten,
            this.Ngaysinh,
            this.GioiTinh,
            this.DienThoai,
            this.Email,
            this.DiaChi});
            this.dgvDanhSachNV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSachNV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgvDanhSachNV.Location = new System.Drawing.Point(3, 16);
            this.dgvDanhSachNV.Name = "dgvDanhSachNV";
            this.dgvDanhSachNV.ReadOnly = true;
            this.dgvDanhSachNV.Size = new System.Drawing.Size(786, 186);
            this.dgvDanhSachNV.TabIndex = 60;
            // 
            // grQuanLyNV
            // 
            this.grQuanLyNV.Controls.Add(this.cmbGioiTinhNV);
            this.grQuanLyNV.Controls.Add(this.label4);
            this.grQuanLyNV.Controls.Add(this.dtpNgaySinhNV);
            this.grQuanLyNV.Controls.Add(this.txtHolotNV);
            this.grQuanLyNV.Controls.Add(this.label5);
            this.grQuanLyNV.Controls.Add(this.txtEmailNV);
            this.grQuanLyNV.Controls.Add(this.txtDiaChiNV);
            this.grQuanLyNV.Controls.Add(this.label10);
            this.grQuanLyNV.Controls.Add(this.txtDienThoaiNV);
            this.grQuanLyNV.Controls.Add(this.label9);
            this.grQuanLyNV.Controls.Add(this.label8);
            this.grQuanLyNV.Controls.Add(this.label3);
            this.grQuanLyNV.Controls.Add(this.txtTenNV);
            this.grQuanLyNV.Controls.Add(this.label2);
            this.grQuanLyNV.Controls.Add(this.txtIdNhanVien);
            this.grQuanLyNV.Controls.Add(this.label6);
            this.grQuanLyNV.Location = new System.Drawing.Point(12, 55);
            this.grQuanLyNV.Name = "grQuanLyNV";
            this.grQuanLyNV.Size = new System.Drawing.Size(427, 202);
            this.grQuanLyNV.TabIndex = 69;
            this.grQuanLyNV.TabStop = false;
            // 
            // cmbGioiTinhNV
            // 
            this.cmbGioiTinhNV.FormattingEnabled = true;
            this.cmbGioiTinhNV.Location = new System.Drawing.Point(289, 24);
            this.cmbGioiTinhNV.Name = "cmbGioiTinhNV";
            this.cmbGioiTinhNV.Size = new System.Drawing.Size(115, 21);
            this.cmbGioiTinhNV.TabIndex = 94;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(206, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 19);
            this.label4.TabIndex = 93;
            this.label4.Text = "Giới tính:";
            // 
            // dtpNgaySinhNV
            // 
            this.dtpNgaySinhNV.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinhNV.Location = new System.Drawing.Point(290, 54);
            this.dtpNgaySinhNV.Name = "dtpNgaySinhNV";
            this.dtpNgaySinhNV.Size = new System.Drawing.Size(114, 20);
            this.dtpNgaySinhNV.TabIndex = 81;
            // 
            // txtHolotNV
            // 
            this.txtHolotNV.Location = new System.Drawing.Point(67, 55);
            this.txtHolotNV.Name = "txtHolotNV";
            this.txtHolotNV.Size = new System.Drawing.Size(128, 20);
            this.txtHolotNV.TabIndex = 79;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(6, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 23);
            this.label5.TabIndex = 85;
            this.label5.Text = "Họ lót :";
            this.label5.UseCompatibleTextRendering = true;
            // 
            // txtEmailNV
            // 
            this.txtEmailNV.Location = new System.Drawing.Point(67, 107);
            this.txtEmailNV.Name = "txtEmailNV";
            this.txtEmailNV.Size = new System.Drawing.Size(128, 20);
            this.txtEmailNV.TabIndex = 83;
            // 
            // txtDiaChiNV
            // 
            this.txtDiaChiNV.Location = new System.Drawing.Point(67, 133);
            this.txtDiaChiNV.Name = "txtDiaChiNV";
            this.txtDiaChiNV.Size = new System.Drawing.Size(337, 20);
            this.txtDiaChiNV.TabIndex = 84;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Navy;
            this.label10.Location = new System.Drawing.Point(6, 106);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 19);
            this.label10.TabIndex = 87;
            this.label10.Text = "Email:";
            // 
            // txtDienThoaiNV
            // 
            this.txtDienThoaiNV.Location = new System.Drawing.Point(289, 83);
            this.txtDienThoaiNV.Name = "txtDienThoaiNV";
            this.txtDienThoaiNV.Size = new System.Drawing.Size(115, 20);
            this.txtDienThoaiNV.TabIndex = 82;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Navy;
            this.label9.Location = new System.Drawing.Point(6, 134);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 19);
            this.label9.TabIndex = 90;
            this.label9.Text = "Địa chỉ:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(209, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 19);
            this.label8.TabIndex = 89;
            this.label8.Text = "Điện thoại:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(206, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 19);
            this.label3.TabIndex = 88;
            this.label3.Text = "Ngày sinh :";
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(67, 81);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(128, 20);
            this.txtTenNV.TabIndex = 80;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(6, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 19);
            this.label2.TabIndex = 86;
            this.label2.Text = "Tên :";
            // 
            // txtIdNhanVien
            // 
            this.txtIdNhanVien.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtIdNhanVien.Enabled = false;
            this.txtIdNhanVien.Location = new System.Drawing.Point(67, 23);
            this.txtIdNhanVien.Name = "txtIdNhanVien";
            this.txtIdNhanVien.Size = new System.Drawing.Size(128, 20);
            this.txtIdNhanVien.TabIndex = 92;
            this.txtIdNhanVien.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(6, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 19);
            this.label6.TabIndex = 91;
            this.label6.Text = "Mã số :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(116, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 19);
            this.label1.TabIndex = 72;
            this.label1.Text = "QUẢN LÝ NHÂN VIÊN";
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.SystemColors.Control;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(264, 275);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 32);
            this.btnLuu.TabIndex = 70;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.Control;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(102, 275);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 32);
            this.btnSua.TabIndex = 71;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.Control;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(183, 275);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 32);
            this.btnXoa.TabIndex = 72;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.SystemColors.Control;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHuy.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(341, 275);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 32);
            this.btnHuy.TabIndex = 73;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.BackColor = System.Drawing.SystemColors.Control;
            this.btnThemMoi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThemMoi.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMoi.Location = new System.Drawing.Point(24, 275);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(75, 32);
            this.btnThemMoi.TabIndex = 74;
            this.btnThemMoi.Text = "Thêm ";
            this.btnThemMoi.UseVisualStyleBackColor = false;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // btnHide
            // 
            this.btnHide.BackColor = System.Drawing.SystemColors.Control;
            this.btnHide.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHide.Location = new System.Drawing.Point(583, 275);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(96, 32);
            this.btnHide.TabIndex = 65;
            this.btnHide.Text = "Ẩn ";
            this.btnHide.UseVisualStyleBackColor = false;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa Chỉ";
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // DienThoai
            // 
            this.DienThoai.DataPropertyName = "DienThoai";
            this.DienThoai.HeaderText = "Điện Thoại";
            this.DienThoai.Name = "DienThoai";
            this.DienThoai.ReadOnly = true;
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giới tính";
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.ReadOnly = true;
            // 
            // Ngaysinh
            // 
            this.Ngaysinh.DataPropertyName = "Ngaysinh";
            this.Ngaysinh.HeaderText = "Ngày Sinh";
            this.Ngaysinh.Name = "Ngaysinh";
            this.Ngaysinh.ReadOnly = true;
            // 
            // Ten
            // 
            this.Ten.DataPropertyName = "Ten";
            this.Ten.HeaderText = "Tên";
            this.Ten.Name = "Ten";
            this.Ten.ReadOnly = true;
            // 
            // HoLot
            // 
            this.HoLot.DataPropertyName = "HoLot";
            this.HoLot.HeaderText = "Họ Lót";
            this.HoLot.Name = "HoLot";
            this.HoLot.ReadOnly = true;
            // 
            // IdNhanVien
            // 
            this.IdNhanVien.DataPropertyName = "IdNhanVien";
            this.IdNhanVien.HeaderText = "Mã số";
            this.IdNhanVien.Name = "IdNhanVien";
            this.IdNhanVien.ReadOnly = true;
            // 
            // uctNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.label12);
            this.Controls.Add(this.grDanhSachNV);
            this.Controls.Add(this.grQuanLyNV);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnThemMoi);
            this.Controls.Add(this.btnHide);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.pnlDanhSachNV);
            this.Controls.Add(this.label1);
            this.Name = "uctNhanVien";
            this.Size = new System.Drawing.Size(1273, 618);
            this.Load += new System.EventHandler(this.uctNhanVien_Load);
            this.grDanhSachNV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachNV)).EndInit();
            this.grQuanLyNV.ResumeLayout(false);
            this.grQuanLyNV.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Panel pnlDanhSachNV;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox grDanhSachNV;
        private System.Windows.Forms.DataGridView dgvDanhSachNV;
        private System.Windows.Forms.GroupBox grQuanLyNV;
        private System.Windows.Forms.ComboBox cmbGioiTinhNV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpNgaySinhNV;
        private System.Windows.Forms.TextBox txtHolotNV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmailNV;
        private System.Windows.Forms.TextBox txtDiaChiNV;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDienThoaiNV;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdNhanVien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoLot;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
    }
}
