
namespace QuanLySinhVien_DA_THD
{
    partial class Form1
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
            this.dgvSinhVien = new System.Windows.Forms.DataGridView();
            this.gbSinhVien = new System.Windows.Forms.GroupBox();
            this.lbMSSV = new System.Windows.Forms.Label();
            this.lbHT = new System.Windows.Forms.Label();
            this.lbNS = new System.Windows.Forms.Label();
            this.lbSDT = new System.Windows.Forms.Label();
            this.tbMSSV = new System.Windows.Forms.TextBox();
            this.tbHT = new System.Windows.Forms.TextBox();
            this.tbNS = new System.Windows.Forms.TextBox();
            this.tbSDT = new System.Windows.Forms.TextBox();
            this.pbAnh = new System.Windows.Forms.PictureBox();
            this.btnCA = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.ColMSSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColHT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAnh = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).BeginInit();
            this.gbSinhVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSinhVien
            // 
            this.dgvSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSinhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColMSSV,
            this.ColHT,
            this.ColNS,
            this.ColSDT,
            this.ColAnh});
            this.dgvSinhVien.Location = new System.Drawing.Point(12, 12);
            this.dgvSinhVien.Name = "dgvSinhVien";
            this.dgvSinhVien.RowHeadersWidth = 62;
            this.dgvSinhVien.RowTemplate.Height = 28;
            this.dgvSinhVien.Size = new System.Drawing.Size(1213, 150);
            this.dgvSinhVien.TabIndex = 0;
            this.dgvSinhVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dgvSinhVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // gbSinhVien
            // 
            this.gbSinhVien.Controls.Add(this.btnCA);
            this.gbSinhVien.Controls.Add(this.pbAnh);
            this.gbSinhVien.Controls.Add(this.tbSDT);
            this.gbSinhVien.Controls.Add(this.tbNS);
            this.gbSinhVien.Controls.Add(this.tbHT);
            this.gbSinhVien.Controls.Add(this.tbMSSV);
            this.gbSinhVien.Controls.Add(this.lbSDT);
            this.gbSinhVien.Controls.Add(this.lbNS);
            this.gbSinhVien.Controls.Add(this.lbHT);
            this.gbSinhVien.Controls.Add(this.lbMSSV);
            this.gbSinhVien.Location = new System.Drawing.Point(12, 180);
            this.gbSinhVien.Name = "gbSinhVien";
            this.gbSinhVien.Size = new System.Drawing.Size(1029, 394);
            this.gbSinhVien.TabIndex = 1;
            this.gbSinhVien.TabStop = false;
            this.gbSinhVien.Text = "Thông tin chi tiết";
            // 
            // lbMSSV
            // 
            this.lbMSSV.AutoSize = true;
            this.lbMSSV.Location = new System.Drawing.Point(20, 48);
            this.lbMSSV.Name = "lbMSSV";
            this.lbMSSV.Size = new System.Drawing.Size(117, 20);
            this.lbMSSV.TabIndex = 0;
            this.lbMSSV.Text = "Mã số sinh viên";
            // 
            // lbHT
            // 
            this.lbHT.AutoSize = true;
            this.lbHT.Location = new System.Drawing.Point(20, 130);
            this.lbHT.Name = "lbHT";
            this.lbHT.Size = new System.Drawing.Size(57, 20);
            this.lbHT.TabIndex = 1;
            this.lbHT.Text = "Họ tên";
            // 
            // lbNS
            // 
            this.lbNS.AutoSize = true;
            this.lbNS.Location = new System.Drawing.Point(20, 205);
            this.lbNS.Name = "lbNS";
            this.lbNS.Size = new System.Drawing.Size(65, 20);
            this.lbNS.TabIndex = 2;
            this.lbNS.Text = "Nơi sinh";
            // 
            // lbSDT
            // 
            this.lbSDT.AutoSize = true;
            this.lbSDT.Location = new System.Drawing.Point(20, 284);
            this.lbSDT.Name = "lbSDT";
            this.lbSDT.Size = new System.Drawing.Size(102, 20);
            this.lbSDT.TabIndex = 3;
            this.lbSDT.Text = "Số điện thoại";
            // 
            // tbMSSV
            // 
            this.tbMSSV.Location = new System.Drawing.Point(175, 42);
            this.tbMSSV.Name = "tbMSSV";
            this.tbMSSV.Size = new System.Drawing.Size(298, 26);
            this.tbMSSV.TabIndex = 4;
            // 
            // tbHT
            // 
            this.tbHT.Location = new System.Drawing.Point(175, 124);
            this.tbHT.Name = "tbHT";
            this.tbHT.Size = new System.Drawing.Size(298, 26);
            this.tbHT.TabIndex = 5;
            // 
            // tbNS
            // 
            this.tbNS.Location = new System.Drawing.Point(175, 199);
            this.tbNS.Name = "tbNS";
            this.tbNS.Size = new System.Drawing.Size(298, 26);
            this.tbNS.TabIndex = 6;
            // 
            // tbSDT
            // 
            this.tbSDT.Location = new System.Drawing.Point(175, 278);
            this.tbSDT.Name = "tbSDT";
            this.tbSDT.Size = new System.Drawing.Size(298, 26);
            this.tbSDT.TabIndex = 7;
            // 
            // pbAnh
            // 
            this.pbAnh.Location = new System.Drawing.Point(584, 42);
            this.pbAnh.Name = "pbAnh";
            this.pbAnh.Size = new System.Drawing.Size(306, 262);
            this.pbAnh.TabIndex = 8;
            this.pbAnh.TabStop = false;
            // 
            // btnCA
            // 
            this.btnCA.Location = new System.Drawing.Point(692, 329);
            this.btnCA.Name = "btnCA";
            this.btnCA.Size = new System.Drawing.Size(93, 44);
            this.btnCA.TabIndex = 9;
            this.btnCA.Text = "Chọn ảnh";
            this.btnCA.UseVisualStyleBackColor = true;
            this.btnCA.Click += new System.EventHandler(this.btnCA_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(646, 593);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(84, 36);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(736, 593);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(77, 36);
            this.btnSua.TabIndex = 11;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(819, 593);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(83, 36);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // ColMSSV
            // 
            this.ColMSSV.HeaderText = "Mã số sinh viên";
            this.ColMSSV.MinimumWidth = 8;
            this.ColMSSV.Name = "ColMSSV";
            this.ColMSSV.Width = 150;
            // 
            // ColHT
            // 
            this.ColHT.HeaderText = "Họ tên";
            this.ColHT.MinimumWidth = 8;
            this.ColHT.Name = "ColHT";
            this.ColHT.Width = 150;
            // 
            // ColNS
            // 
            this.ColNS.HeaderText = "Nơi sinh";
            this.ColNS.MinimumWidth = 8;
            this.ColNS.Name = "ColNS";
            this.ColNS.Width = 150;
            // 
            // ColSDT
            // 
            this.ColSDT.HeaderText = "Số điện thoại";
            this.ColSDT.MinimumWidth = 8;
            this.ColSDT.Name = "ColSDT";
            this.ColSDT.Width = 150;
            // 
            // ColAnh
            // 
            this.ColAnh.HeaderText = "Ảnh";
            this.ColAnh.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.ColAnh.MinimumWidth = 8;
            this.ColAnh.Name = "ColAnh";
            this.ColAnh.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 670);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.gbSinhVien);
            this.Controls.Add(this.dgvSinhVien);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).EndInit();
            this.gbSinhVien.ResumeLayout(false);
            this.gbSinhVien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSinhVien;
        private System.Windows.Forms.GroupBox gbSinhVien;
        private System.Windows.Forms.Button btnCA;
        private System.Windows.Forms.PictureBox pbAnh;
        private System.Windows.Forms.TextBox tbSDT;
        private System.Windows.Forms.TextBox tbNS;
        private System.Windows.Forms.TextBox tbHT;
        private System.Windows.Forms.TextBox tbMSSV;
        private System.Windows.Forms.Label lbSDT;
        private System.Windows.Forms.Label lbNS;
        private System.Windows.Forms.Label lbHT;
        private System.Windows.Forms.Label lbMSSV;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMSSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColHT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNS;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSDT;
        private System.Windows.Forms.DataGridViewImageColumn ColAnh;
    }
}

