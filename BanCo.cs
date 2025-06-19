using System;
using System.Drawing;

namespace BTL
{
    class BanCo
    {
        // Thuộc tính số dòng và số cột
        public int SoDong { get; private set; }
        public int SoCot { get; private set; }

        // Constructor mặc định
        public BanCo()
        {
            SoDong = 0;
            SoCot = 0;
        }

        // Constructor có tham số
        public BanCo(int soDong, int soCot)
        {
            SoDong = soDong;
            SoCot = soCot;
        }

        // Vẽ lưới bàn cờ
        public void VeBanCo(Graphics g)
        {
            // Vẽ đường dọc (cột)
            for (int i = 0; i <= SoCot; i++)
            {
                int x = i * OCo._ChieuRong;
                g.DrawLine(Program.pen, x, 0, x, SoDong * OCo._ChieuCao);
            }

            // Vẽ đường ngang (dòng)
            for (int j = 0; j <= SoDong; j++)
            {
                int y = j * OCo._ChieuCao;
                g.DrawLine(Program.pen, 0, y, SoCot * OCo._ChieuRong, y);
            }
        }

        // Vẽ quân cờ tròn (ví dụ: hình tròn tô màu - có thể là O hoặc X tùy theo dùng màu hay hình)
        public void VeQuanCo(Graphics g, Point p, SolidBrush brush)
        {
            g.FillEllipse(brush, p.X + 2, p.Y + 2, OCo._ChieuRong - 4, OCo._ChieuCao - 4);
        }

        // Vẽ quân O - vòng tròn rỗng
        public void VeQuanCoO(Graphics g, Point p, Pen pen)
        {
            g.DrawEllipse(pen, p.X + 5, p.Y + 5, OCo._ChieuRong - 10, OCo._ChieuCao - 10);
        }

        // Vẽ quân X - 2 đường chéo
        public void VeQuanCoX(Graphics g, Point p, Pen pen)
        {
            int padding = 5;
            int x1 = p.X + padding;
            int y1 = p.Y + padding;
            int x2 = p.X + OCo._ChieuRong - padding;
            int y2 = p.Y + OCo._ChieuCao - padding;

            g.DrawLine(pen, x1, y1, x2, y2); // /
            g.DrawLine(pen, x1, y2, x2, y1); // \
        }

        // Xóa quân cờ (tô lại bằng màu nền)
        public void XoaQuanCo(Graphics g, Point p, SolidBrush brush)
        {
            g.FillRectangle(brush, p.X + 1, p.Y + 1, OCo._ChieuRong - 2, OCo._ChieuCao - 2);
        }
    }
}
