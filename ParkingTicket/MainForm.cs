using System;
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
    // TODO car and cop should inherit from ticket class for efficiency
    public partial class MainForm : Form
    {
        // initalize 3 objects
        Car aCar = new Car();
        Cop aCop = new Cop();
        Ticket aTicket = new Ticket();

        public MainForm()
        {
            InitializeComponent();
        }
        // reserve memory for objects
        Car someCar;
        Cop someCop;
        Ticket someTicket;
        Boolean flag = false;
        private void MainForm_Load(object sender, EventArgs e)
        {
            labelTime.Text = "0";
        }

        private void buttonParkCar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("");
        }
    }
}
