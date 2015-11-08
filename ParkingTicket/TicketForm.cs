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
    public partial class TicketForm : Form
    {
        public Ticket bTicket { set; get; }
        public TicketForm(MainForm form1) 
        {
            
            InitializeComponent();
        }
        
        private void TicketForm_Load(object sender, EventArgs e)
        {
            textBoxTicketMake.Text = bTicket.Make;
            textBoxTicketModel.Text = bTicket.Model;
            textBoxTicketColor.Text = bTicket.Color;
            textBoxTicketPlate.Text = bTicket.PlateNumber;
            textBoxTicketFine.Text = bTicket.Fine.ToString("C");
            textBoxTicketCop.Text = bTicket.CopName.ToString();
            textBoxTicketBadge.Text = bTicket.CopNumber.ToString();
            textBoxTowed.Text = bTicket.Towed.ToString();

        }
    }
}
