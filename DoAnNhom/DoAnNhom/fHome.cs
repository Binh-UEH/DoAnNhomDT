using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnNhom
{

    public partial class fHome : Form
    {
        
        public fHome()
        {
            InitializeComponent();
        }

        private void btnPC_Click(object sender, EventArgs e)
        {
            this.Hide();
            PanelHolder.SetPanel(pnMenu);

            fPC fPC = new fPC();
            fPC.FormClosed += _FormClosed;
            fPC.Show();

        }
        private void _FormClosed(object sender, FormClosedEventArgs e)
        {
            // Lấy lại panel từ biến static và thêm vào Form1
            Panel savedPanel = PanelHolder.SavedPanel;
            this.Controls.Add(savedPanel);
            // Khi Form2 được đóng, hiện lại Form1
            this.Show();
        }

        private void btnLap_Click(object sender, EventArgs e)
        {
            this.Hide();
            PanelHolder.SetPanel(pnMenu);

            fLaptop fLapTop = new fLaptop();
            fLapTop.FormClosed += _FormClosed;
            fLapTop.Show();
        }

        private void btnCamera_Click(object sender, EventArgs e)
        {
            this.Hide();
            PanelHolder.SetPanel(pnMenu);

            fCamera fCam = new fCamera();
            fCam.FormClosed += _FormClosed;
            fCam.Show();

        }

        private void btnLinhKien_Click(object sender, EventArgs e)
        {
            this.Hide();
            PanelHolder.SetPanel(pnMenu);

            fLinhKien fLK = new fLinhKien();
            fLK.FormClosed += _FormClosed;
            fLK.Show();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            this.Hide();
            PanelHolder.SetPanel(pnMenu);

            fLinhKien fPay = new fLinhKien();
            fPay.FormClosed += _FormClosed;
            fPay.Show();
        }

        private void btnTTTK_Click(object sender, EventArgs e)
        {
            this.Hide();
            PanelHolder.SetPanel(pnMenu);

            fTTTK fTT = new fTTTK();
            fTT.FormClosed += _FormClosed;
            fTT.Show();
        }
    }
    public static class PanelHolder
    {
        public static Panel SavedPanel { get; private set; }

        public static void SetPanel(Panel panel)
        {
            SavedPanel = panel;
        }
    }
}
