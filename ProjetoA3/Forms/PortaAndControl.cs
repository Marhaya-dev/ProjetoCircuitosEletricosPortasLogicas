﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoA3.Forms
{
    public partial class PortaAndControl : UserControl
    {
        public PortaAndControl()
        {
            InitializeComponent();
        }

        private void labelEntradaA_Click(object sender, EventArgs e)
        {
            if (labelEntradaA.Text == "0" )
            {
                labelEntradaA.Text = "1";
            }
            else
            {
                labelEntradaA.Text = "0";
            }

            PortaAnd();
        }

        private void labelEntradaB_Click(object sender, EventArgs e)
        {
            if (labelEntradaB.Text == "0")
            {
                labelEntradaB.Text = "1";
            }
            else
            {
                labelEntradaB.Text = "0";
            }

            PortaAnd();
        }

        private void PortaAnd()
        {
            if (labelEntradaA.Text == "1" && labelEntradaB.Text == "1")
            {
                pictureLedGreen.Show();
                pictureLedGreen.BringToFront();
            }

            else
            {
                pictureLedGrey.Show();
                pictureLedGrey.BringToFront();
            }
        }

        private void PortaAndControl_Load(object sender, EventArgs e)
        {
            PortaAnd();
        }
    }
}
