﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingTicket
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        // reserve memory for objects
        Car someCar;
        Cop someCop;
        Ticket someTicket;
        private void MainForm_Load(object sender, EventArgs e)
        {
            labelTime.Text = "0";
        }
    }
}
