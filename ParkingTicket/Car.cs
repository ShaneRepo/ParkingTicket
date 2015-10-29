using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingTicket
{
    class Car
    {
        private string _make;
        private string _model;
        private string _color;
        private string _plateNumber;
        private int _minParked;
        private int _purTime;
        public Car()
        {

        }
        public string Make
        {
            get { return _make; }
            set { _make = value; }
        }
        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }
        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }
        public string PlateNumber
        {
            get { return _plateNumber; }
            set { _plateNumber = value; }
        }
        public int MinParked
        {
            get { return _minParked; }
            set { _minParked = value; }
        }
        public int PurTime
        {
            get { return _purTime; }
            set { _purTime = value; }
        }
    }
}
