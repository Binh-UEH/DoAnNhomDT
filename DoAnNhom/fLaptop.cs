﻿using System;
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
    public partial class fLaptop : Form
    {
        public fLaptop()
        {

            InitializeComponent();
            Panel savedPanel = PanelHolder.SavedPanel;
            if (savedPanel != null)
            {
                this.Controls.Add(savedPanel);
            }
        }

        private void fLaptop_Load(object sender, EventArgs e)
        {

        }
    }
}
