using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class CarsData
    {
        public ObservableCollection<Car> Cars { get; set; }
        public Car SelectedCar { get; set; }
        public CarsData()
        {
            Cars = new ObservableCollection<Car>{ new Car("Toyota", "Yelow", "2005"), new Car("Audi", "Red", "2011"), new Car("Porshe", "White", "2000") };
        }
        public void AddCar()
        {
            Cars.Add(new Car("Null","Null","0"));
        }
        public void RemoveCar()
        {
            Cars.Remove(SelectedCar);
        }
       
    }
}
