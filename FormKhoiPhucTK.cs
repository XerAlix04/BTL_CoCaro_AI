using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BTL
{
    public partial class FormKhoiPhucTK: Form
    {
        public FormKhoiPhucTK()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string emailNhap = txtEmailKP.Text.Trim();
            string filePath = "taikhoan.txt";

            if (string.IsNullOrEmpty(emailNhap))
            {
                MessageBox.Show("Vui lòng nhập email!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!File.Exists(filePath))
            {
                MessageBox.Show("Không tìm thấy dữ liệu tài khoản!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    string[] parts = line.Split('|');
                    if (parts.Length == 3 && parts[2] == emailNhap)
                    {
                        string taiKhoan = parts[0];
                        string matKhau = parts[1];
                        MessageBox.Show($"Tài khoản: {taiKhoan}\nMật khẩu: {matKhau}", "Thông tin khôi phục", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }

                MessageBox.Show("Không tìm thấy tài khoản với email này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
