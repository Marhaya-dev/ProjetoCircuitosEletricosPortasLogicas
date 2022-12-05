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
    public partial class PortaXorControl : UserControl
    {
        public PortaXorControl()
        {
            InitializeComponent();
        }

        private void labelEntradaA_Click(object sender, EventArgs e)
        {
            if (labelEntradaA.Text == "0")
            {
                labelEntradaA.Text = "1";
            }
            else
            {
                labelEntradaA.Text = "0";
            }

            PortaXor();
        }

        private void PortaXor()
        {
            if (labelEntradaA.Text == "0" && labelEntradaB.Text == "0")
            {
                pictureLedGrey.Show();
                pictureLedGrey.BringToFront();
            }

            else if (labelEntradaA.Text == "1" && labelEntradaB.Text == "1")
            {
                pictureLedGrey.Show();
                pictureLedGrey.BringToFront();
            }

            else
            {
                pictureLedGreen.Show();
                pictureLedGreen.BringToFront();
            }
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

            PortaXor();
        }

        private void PortaXorControl_Load(object sender, EventArgs e)
        {
            PortaXor();
        }
    }
}
