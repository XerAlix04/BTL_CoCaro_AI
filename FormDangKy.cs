using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL
{
    public partial class FormDangKy: Form
    {
        public FormDangKy()
        {
            InitializeComponent();
        }

        private void btnDK_Click(object sender, EventArgs e)
        {
            string taiKhoan = txtTTK.Text.Trim();
            string matKhau = txtMKDK.Text.Trim();
            string nhapLaiMatKhau = txtXNMK.Text.Trim();
            string email = txtEmail.Text.Trim();

            // Kiểm tra dữ liệu
            if (taiKhoan == "" || matKhau == "" || nhapLaiMatKhau == "" || email == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!IsValidEmail(email))
            {
                MessageBox.Show("Email không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (matKhau != nhapLaiMatKhau)
            {
                MessageBox.Show("Mật khẩu nhập lại không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Ghi vào file
            string filePath = "taikhoan.txt"; // File nằm cùng thư mục với file .exe

            try
            {
                // Kiểm tra trùng tài khoản
                if (File.Exists(filePath))
                {
                    string[] lines = File.ReadAllLines(filePath);
                    foreach (string line in lines)
                    {
                        string[] parts = line.Split('|');
                        if (parts.Length > 0 && parts[0] == taiKhoan)
                        {
                            MessageBox.Show("Tài khoản đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }

                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine($"{taiKhoan}|{matKhau}|{email}");
                }

                MessageBox.Show("Đăng ký thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

    }
}
