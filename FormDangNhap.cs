using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace BTL
{
    public partial class FormDangNhap: Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void btnDN_Click(object sender, EventArgs e)
        {
            string taiKhoan = txtTDN.Text.Trim();
            string matKhau = txtMK.Text.Trim();
            string filePath = "taikhoan.txt";

            if (taiKhoan == "" || matKhau == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!File.Exists(filePath))
            {
                MessageBox.Show("Chưa có tài khoản nào được đăng ký!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool dangNhapThanhCong = false;

            try
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    string[] parts = line.Split('|');
                    if (parts.Length >= 2 && parts[0] == taiKhoan && parts[1] == matKhau)
                    {
                        dangNhapThanhCong = true;
                        break;
                    }
                }

                if (dangNhapThanhCong)
                {
                    //MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();

                    Form1 formCo = new Form1();
                    formCo.ShowDialog();

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đọc file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkDK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormDangKy formDK = new FormDangKy();
            formDK.ShowDialog();
        }

        private void linkQMK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormKhoiPhucTK formKPTK = new FormKhoiPhucTK();
            formKPTK.ShowDialog();
        }
    }
}
