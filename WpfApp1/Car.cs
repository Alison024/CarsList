using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Car : INotifyPropertyChanged
    {
        private string manufacturer;
        private string color;
        private string year;
   

        public Car() { }
        public Car(string manuf,string color,string year)
        {
            manufacturer = manuf;
            this.color = color;
            this.year = year;
        }
        public string Manufacturer
        {
            get { return manufacturer; }
            set
            {
                manufacturer = value;
                Notify();
            }
        }
        public string Color
        {
            get { return color; }
            set
            {
                color = value;
                Notify();
            }
        }
        public string Year
        {
            get { return year; }
            set
            {
                year = value;
                Notify();
            }
        }
        protected void Notify([CallerMemberName]string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
