using Newtonsoft.Json;
using OpenQA.Selenium;
using ReadJsonTaskWithSemaphore.Command;
using ReadJsonTaskWithSemaphore.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace ReadJsonTaskWithSemaphore.ViewModels
{
   public class MainWindowViewModel:BaseViewModel
    {
        SolidColorBrush Off = new SolidColorBrush(Color.FromRgb(255, 0, 0));
        SolidColorBrush On = new SolidColorBrush(Color.FromRgb(240, 222, 45));
        public IWebElement txtProductSearch1 = null;
        public string FileName { get; set; }
        public string text { get; set; }

        public RelayCommand  StartButtonClick { get; set; }

        public MainWindowViewModel(MainWindow mainWindow)
        {
            Car car1 = new Car()
            {
                Model="X6",
                Vendor="BMW",
                Year=2021,
                ImagePath= "https://github.com/Tural072/CarGallery/blob/master/BMWx6.jpg?raw=true"
            };
            Car car2 = new Car()
            {
                Model="Camaro",
                Vendor="Chevrolet",
                Year=2021,
                ImagePath= "https://github.com/Tural072/CarGallery/blob/master/CHEVROLET-Camaro.jpg?raw=true"
            };
            Car car3 = new Car()
            {
                Model = "Camry",
                Vendor = "Toyota",
                Year = 2021,
                ImagePath = "https://github.com/Tural072/CarGallery/blob/master/TOYOTA-Camry.jpg?raw=true"
            };
            Car car4 = new Car()
            {
                Model = "XC90",
                Vendor = "Volvo",
                Year = 2021,
                ImagePath = "https://github.com/Tural072/CarGallery/blob/master/VOLVO-XC90-6792_28.jpg?raw=true"
            };
            Car car5 = new Car()
            {
                Model = "ES",
                Vendor = "Lexus",
                Year = 2021,
                ImagePath = "https://github.com/Tural072/CarGallery/blob/master/lexus-es.jpg?raw=true"
            };
            Car car6 = new Car()
            {
                Model = "S90",
                Vendor = "Volvo",
                Year = 2021,
                ImagePath = "https://github.com/Tural072/CarGallery/blob/master/volvos90.jpg?raw=true"
            };
            Car car7 = new Car()
            {
                Model = "F150-Raptor",
                Vendor = "Ford",
                Year = 2021,
                ImagePath = "https://github.com/Tural072/CarGallery/blob/master/ford-f-150-raptor.jpg?raw=true"
            };
            Car car8 = new Car()
            {
                Model = "Granchroke",
                Vendor = "Jeep",
                Year = 2021,
                ImagePath = "https://github.com/Tural072/CarGallery/blob/master/jeep-grand-cherokee.jpg?raw=true"
            };
            Car car9 = new Car()
            {
                Model = "Passat",
                Vendor = "Volkswagen",
                Year = 2021,
                ImagePath = "https://github.com/Tural072/CarGallery/blob/master/VOLKSWAGEN-Passat.jpg?raw=true"
            };
            Car car10 = new Car()
            {
                Model = "CX90",
                Vendor = "Mazda",
                Year = 2021,
                ImagePath = "https://github.com/Tural072/CarGallery/blob/master/mazda-cx-9.jpg?raw=true"
            };
            Car car11 = new Car()
            {
                Model = "X6",
                Vendor = "BMW",
                Year = 2021,
                ImagePath = "https://github.com/Tural072/CarGallery/blob/master/BMWx6.jpg?raw=true"
            };
            Car car12 = new Car()
            {
                Model = "Camaro",
                Vendor = "Chevrolet",
                Year = 2021,
                ImagePath = "https://github.com/Tural072/CarGallery/blob/master/CHEVROLET-Camaro.jpg?raw=true"
            };
            Car car13 = new Car()
            {
                Model = "Camry",
                Vendor = "Toyota",
                Year = 2021,
                ImagePath = "https://github.com/Tural072/CarGallery/blob/master/TOYOTA-Camry.jpg?raw=true"
            };
            Car car14 = new Car()
            {
                Model = "XC90",
                Vendor = "Volvo",
                Year = 2021,
                ImagePath = "https://github.com/Tural072/CarGallery/blob/master/VOLVO-XC90-6792_28.jpg?raw=true"
            };
            Car car15 = new Car()
            {
                Model = "ES",
                Vendor = "Lexus",
                Year = 2021,
                ImagePath = "https://github.com/Tural072/CarGallery/blob/master/lexus-es.jpg?raw=true"
            };
            Car car16 = new Car()
            {
                Model = "X6",
                Vendor = "BMW",
                Year = 2021,
                ImagePath = "https://github.com/Tural072/CarGallery/blob/master/BMWx6.jpg?raw=true"
            };
            Car car17 = new Car()
            {
                Model = "Camaro",
                Vendor = "Chevrolet",
                Year = 2021,
                ImagePath = "https://github.com/Tural072/CarGallery/blob/master/CHEVROLET-Camaro.jpg?raw=true"
            };
            Car car18 = new Car()
            {
                Model = "Camry",
                Vendor = "Toyota",
                Year = 2021,
                ImagePath = "https://github.com/Tural072/CarGallery/blob/master/TOYOTA-Camry.jpg?raw=true"
            };
            Car car19 = new Car()
            {
                Model = "XC90",
                Vendor = "Volvo",
                Year = 2021,
                ImagePath = "https://github.com/Tural072/CarGallery/blob/master/VOLVO-XC90-6792_28.jpg?raw=true"
            };
            Car car20 = new Car()
            {
                Model = "ES",
                Vendor = "Lexus",
                Year = 2021,
                ImagePath = "https://github.com/Tural072/CarGallery/blob/master/lexus-es.jpg?raw=true"
            };




            ObservableCollection<Car> cars = new ObservableCollection<Car>();
            ObservableCollection<Car> cars1 = new ObservableCollection<Car>();
            ObservableCollection<Car> cars2 = new ObservableCollection<Car>();
            ObservableCollection<Car> cars3 = new ObservableCollection<Car>();
            cars.Add(car1);
            cars.Add(car2);
            cars.Add(car3);
            cars.Add(car4);
            cars.Add(car5);

            StartButtonClick = new RelayCommand((sender) =>
            {
                Car car = new Car();
                car = JsonConvert.DeserializeObject<Car>("1.json");
               
                
                

            });
        }
    }
}
