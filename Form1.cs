using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL
{
    public partial class Form1 : Form
    {
        private CaroChess caroChess;
        public Graphics grs;
        private int thoiGianConLai = 30;


        public Form1()
        {
            InitializeComponent();
            caroChess = new CaroChess();
            caroChess.KhoiTaoMangOCo();
            grs=pnlBanco.CreateGraphics();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;      // Ẩn nút phóng to
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // Không cho thay đổi kích thước
        }

        private void pnlBanco_Paint(object sender, PaintEventArgs e)
        {
            caroChess.VeBanCo(grs);
            caroChess.VeLaiQuanCo(grs);
        }

        private void pnlBanco_MouseClick(object sender, MouseEventArgs e)
        {
            if (!caroChess.SanSang)
            {
                return;
            }
            if(caroChess.DanhCo(e.X, e.Y, grs))
            {
                timerTurn.Stop();
                BatDauDemThoiGian();
                if (caroChess.KiemTraChienThang())
                {
                    timerTurn.Stop();
                    lblTime.Text = "00";
                    caroChess.KetThucTroChoi();
                }
                else
                {
                    if (caroChess.CheDoChoi == 2)
                    {
                        caroChess.KhoiDongComputer(grs);
                        if (caroChess.KiemTraChienThang())
                        {
                            timerTurn.Stop();
                            lblTime.Text = "00";
                            caroChess.KetThucTroChoi();
                        }
                    }
                }
            }
            
        }

        private void btnPvP_Click(object sender, EventArgs e)
        {
            grs.Clear(pnlBanco.BackColor);
            caroChess.PvsPStart(grs);
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            
            caroChess.undo(grs);
        }

        private void btnRedo_Click(object sender, EventArgs e)
        {
            caroChess.redo(grs);
        }

        private void btnCom_Click(object sender, EventArgs e)
        {
            grs.Clear(pnlBanco.BackColor);
            caroChess.COMStart(grs);
        }

        private void btnAlphaBeta_Click(object sender, EventArgs e)
        {
            grs.Clear(pnlBanco.BackColor);
            caroChess.AlphaBetaStart(grs);
        }

        private void BatDauDemThoiGian()
        {
            timerTurn.Stop(); // dừng nếu đang chạy
            thoiGianConLai = 30;
            lblTime.Text = "30";
            timerTurn.Start();
        }

        private void timerTurn_Tick(object sender, EventArgs e)
        {
            thoiGianConLai--;
            lblTime.Text = thoiGianConLai.ToString();

            if (thoiGianConLai <= 0)
            {
                timerTurn.Stop();
                MessageBox.Show("Hết thời gian! Bạn đã thua lượt này.", "Hết giờ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                caroChess.KetThucTroChoi(); // hoặc mất lượt tùy cách bạn xử lý
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
