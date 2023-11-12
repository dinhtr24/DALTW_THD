using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL_QLSV;
using BLL_QLSV;
using System.IO;


namespace QuanLySinhVien_DA_THD
{
    public partial class Form1 : Form
    {
        BLL bllSV = new BLL();
        List<SinhVien> SinhViens = new List<SinhVien>();
        public Form1()
        {
            InitializeComponent();
        }

        private bool DaTonTaiMSSV(string mssv)
        {
            DataRow[] existingRows = bllSV.layThongTinSV2().Select($"MaSoSinhVien = '{mssv}'");
            return existingRows.Length > 0;
        }

        private bool KiemTraThongTin()
        {
            if (tbMSSV.Text.Any(char.IsLetter) || string.IsNullOrWhiteSpace(tbMSSV.Text) || tbMSSV.Text.Length > 10)
            {
                MessageBox.Show("Mã số sinh viên không hợp lệ");
                return false;
            }
            if (tbHT.Text.Any(char.IsDigit) || tbMSSV.Text.Length > 50)
            {
                MessageBox.Show("Họ tên không hợp lệ");
                return false;
            }
            if (tbNS.Text.Any(char.IsDigit) || tbNS.Text.Length > 50)
            {
                MessageBox.Show("Nơi sinh không hợp lệ");
                return false;
            }
            if (tbSDT.Text.Any(char.IsLetter) || tbSDT.Text.Length > 11)
            {
                MessageBox.Show("Số điện thoại không hợp lệ");
                return false;
            }
            return true;
        }

        private Dictionary<string, DataGridViewRow> ThongTinSV = new Dictionary<string, DataGridViewRow>();

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (tbMSSV.Text != "" && tbHT.Text != "" && tbNS.Text != "" && tbSDT.Text != "")
            {
                if (KiemTraThongTin())
                {
                    if (ThongTinSV.ContainsKey(tbMSSV.Text) || DaTonTaiMSSV(tbMSSV.Text))
                    {
                        MessageBox.Show("Trùng mã số sinh viên");

                    }
                    else
                    {
                        SinhVien sv = new SinhVien(tbMSSV.Text, tbHT.Text, tbNS.Text, tbSDT.Text);
                        SinhViens.Add(sv);
                        dgvSinhVien.Rows.Add(tbMSSV.Text, tbHT.Text, tbNS.Text, tbSDT.Text, pbAnh.Image);
                        ThongTinSV.Add(tbMSSV.Text, dgvSinhVien.CurrentRow);
                        bllSV.addSinhVien(sv);
                        tbMSSV.Clear();
                        tbHT.Clear();
                        tbNS.Clear();
                        tbSDT.Clear();
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSinhVien.Rows[e.RowIndex];
                tbMSSV.Text = row.Cells["ColMSSV"].Value.ToString();
                tbHT.Text = row.Cells["ColHT"].Value.ToString();
                tbNS.Text = row.Cells["ColNS"].Value.ToString();
                tbSDT.Text = row.Cells["ColSDT"].Value.ToString();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSinhVien.Rows[e.RowIndex];
                if (row.Cells["ColMSSV"].Value != null && row.Cells["ColHT"].Value != null && row.Cells["ColNS"].Value != null && row.Cells["ColSDT"].Value != null)
                {
                    tbMSSV.Text = row.Cells["ColMSSV"].Value.ToString();
                    tbHT.Text = row.Cells["ColHT"].Value.ToString();
                    tbNS.Text = row.Cells["ColNS"].Value.ToString();
                    tbSDT.Text = row.Cells["ColSDT"].Value.ToString();
                }
                else
                {
                    tbMSSV.Text = "";
                    tbHT.Text = "";
                    tbNS.Text = "";
                    tbSDT.Text = "";
                }
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvSinhVien.SelectedRows.Count == 1 || dgvSinhVien.SelectedCells.Count > 1)
            {
                if (tbMSSV.Text != "" && tbHT.Text != "" && tbNS.Text != "" && tbSDT.Text != "")
                {
                    if (KiemTraThongTin())
                    {
                        if (ThongTinSV.ContainsKey(tbMSSV.Text) || DaTonTaiMSSV(tbMSSV.Text))
                        {
                            MessageBox.Show("Trùng mã số sinh viên");

                        }
                        else
                        {
                            ThongTinSV.Add(tbMSSV.Text, dgvSinhVien.CurrentRow);
                            DataGridViewRow selectedRow = dgvSinhVien.SelectedRows[0];
                            string avlb = selectedRow.Cells["ColMSSV"].Value.ToString();
                            selectedRow.Cells["ColMSSV"].Value = tbMSSV.Text;
                            selectedRow.Cells["ColHT"].Value = tbHT.Text;
                            selectedRow.Cells["ColNS"].Value = tbNS.Text;
                            selectedRow.Cells["ColSDT"].Value = tbSDT.Text;
                            SinhVien sv = new SinhVien(tbMSSV.Text, tbHT.Text, tbNS.Text, tbSDT.Text);
                            bllSV.updateSinhVien(sv, avlb);
                            tbMSSV.Clear();
                            tbHT.Clear();
                            tbNS.Clear();
                            tbSDT.Clear();
                            pbAnh.ImageLocation = null;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                }
            }
            else
            {
                if (dgvSinhVien.RowCount < 2)
                {
                    MessageBox.Show("Không có dữ liệu để sửa.");
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn dòng cần sửa.");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvSinhVien.SelectedRows.Count > 0 && dgvSinhVien.RowCount > 1)
            {
                if (dgvSinhVien.SelectedRows[0].Cells["ColMSSV"].Value == null)
                {
                    MessageBox.Show("Dòng này không có dữ liệu để xóa.");
                }
                else
                {
                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa dòng này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        bllSV.deleteSinhVien(dgvSinhVien.SelectedRows[0].Cells["ColMSSV"].Value.ToString());

                        dgvSinhVien.Rows.RemoveAt(dgvSinhVien.SelectedRows[0].Index);
                        tbMSSV.Clear();
                        tbHT.Clear();
                        tbNS.Clear();
                        tbSDT.Clear();
                        pbAnh.ImageLocation = null;
                    }
                }
            }
            else
            {
                if (dgvSinhVien.RowCount == 1 && dgvSinhVien.SelectedRows.Count <= 1)
                {
                    MessageBox.Show("Không có dữ liệu để xóa.");
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn dòng cần xóa.");
                }
            }
        }

        private void btnCA_Click(object sender, EventArgs e)
        {
            pbAnh.SizeMode = PictureBoxSizeMode.StretchImage;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files |*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileInfo fileInfo = new FileInfo(openFileDialog.FileName);
                long fileSize = fileInfo.Length;
                if (fileSize <= 60 * 1024 * 1024)
                {
                    pbAnh.ImageLocation = openFileDialog.FileName;
                }
                else
                {
                    MessageBox.Show("Kích thước ảnh vượt quá 60MB. Vui lòng chọn ảnh khác.");
                }
            }
        }
    }
}
