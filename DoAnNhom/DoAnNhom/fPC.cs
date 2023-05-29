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
    public partial class fPC : Form
    {
        public fPC()
        {
            InitializeComponent();
            Panel savedPanel = PanelHolder.SavedPanel;

            // Kiểm tra xem panel đã được lưu trữ hay chưa
            if (savedPanel != null)
            {
                this.Controls.Add(savedPanel);
            }
        }

        private void fPC_Load(object sender, EventArgs e)
        {

        }
    }
}
