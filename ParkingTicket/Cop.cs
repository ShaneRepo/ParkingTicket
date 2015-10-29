using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingTicket
{
    class Cop
    {
        private string _name;
        private int _number;

        public Cop() // init cop to these params
        {
            _name = "Dean Winchester";
            _number = 1986;
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int Number
        {
            get { return _number; }
            set { _number = value; }
        }
    }
}
