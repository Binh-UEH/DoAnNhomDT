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
    public partial class fLinhKien : Form
    {
        public fLinhKien()
        {
            InitializeComponent();
            Panel savedPanel = PanelHolder.SavedPanel;
            if (savedPanel != null)
            {
                // Thêm panel vào Form2
                this.Controls.Add(savedPanel);
            }
        }

        private void fLinhKien_Load(object sender, EventArgs e)
        {

        }
    }
}
