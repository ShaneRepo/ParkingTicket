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
    // TODO add ability to read info from textbox into aCar object
    public partial class MainForm : Form
    {
        // initalize 3 objects
        Car aCar = new Car();
        Cop aCop = new Cop();
        Ticket aTicket = new Ticket();
        Boolean parked = false;
        public MainForm()
        {
            InitializeComponent();
        }
        
        private void MainForm_Load(object sender, EventArgs e)
        {
            labelTime.Text = "0";
        }

        private void buttonParkCar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You parked " + aCar.Make + " " + aCar.Model);
            parked = true;
        }

        private void buttonPurTime_Click(object sender, EventArgs e)
        {
            if (parked)
            {
                aCar.PurTime += 1;
                MessageBox.Show("You purchased an additional hour for a total of " + aCar.PurTime + " hours.");
            }
            else
            {
                MessageBox.Show("You must park your car first!");
            }
        }
    }
}
