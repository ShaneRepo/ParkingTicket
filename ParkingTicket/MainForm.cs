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
        Car aCar = new Car();
        Cop aCop = new Cop();
        public Ticket aTicket = new Ticket();
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

        private void buttonElapse_Click(object sender, EventArgs e)
        {
            if (parked)
            {
                aTicket.Time += 1;
                MessageBox.Show("Time elapsed 1 hour!");
            }
            else
            {
                MessageBox.Show("You must park your car first!");
            }
        }

        private void buttonInspection_Click(object sender, EventArgs e)
        {
            if (parked)
            {
                int tickTime = aTicket.Time;
                int carTime = aCar.PurTime;
                int fine = (aCar.PurTime - aTicket.Time);
                
                if (fine < 0)
                {
                    aTicket.Fine = 25.00;
                    if (fine < -1)
                    {
                        switch (fine)
                        {
                            case -2:
                                aTicket.Fine2 = 10.00;
                                break;
                            case -3:
                                aTicket.Fine2 = 20.00;
                                break;
                            case -4:
                                aTicket.Fine2 = 30.00;
                                break;
                            case -5:
                                aTicket.Fine2 = 40.00;
                                break;
                            case -6:
                                aTicket.Fine2 = 50.00;
                                break;
                            default:
                                aTicket.Fine2 = 50.00;
                                aTicket.Towed = true;
                                break;
                        }
                    }
                    
                }
                double total = aTicket.Fine + aTicket.Fine2;
                aTicket.Make = aCar.Make;
                aTicket.Model = aCar.Model;
                aTicket.Make = aCar.Make;
                aTicket.PlateNumber = aCar.PlateNumber;
                aTicket.Fine = total;
                aTicket.CopName = aCop.Name;
                aTicket.CopNumber = aCop.Number;
                aTicket.Color = aCar.Color;              
                TicketForm tickForm = new TicketForm(this);
                tickForm.bTicket = aTicket;
                tickForm.ShowDialog();
                //MessageBox.Show(fine.ToString());
                //MessageBox.Show(aTicket.Towed.ToString());
                //MessageBox.Show(total.ToString("C"));
                
            }
            else
            {
                MessageBox.Show("You must park your car first!");
            }
        }
    }
}
