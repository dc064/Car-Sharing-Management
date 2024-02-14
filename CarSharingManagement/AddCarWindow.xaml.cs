using CarSharingManagement.Entities;
using CarSharingManagement.Temps;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CarSharingManagement
{
    public partial class AddCarWindow : Window
    {
        DatabaseContext DBContext;
        String CarBrand, CarModel;
        CarColor CarColor;
        Equipment CarEquipment;
        Mechanic CarMechanic;
        Boolean isMod;
        Car toMod;

        public AddCarWindow()
        {
            InitializeComponent();

            DBContext = new DatabaseContext();

            List<Car> carList = DBContext.Cars.ToList();
            CarColorComboBox.ItemsSource = Enum.GetValues(typeof(CarColor)).Cast<CarColor>();
            CarEquipmentComboBox.ItemsSource = DBContext.Equipments.ToList();
            CarMechanicComboBox.ItemsSource = DBContext.Mechanics.ToList();
            isMod = false;
        }

        public AddCarWindow(Car car)
        {
            InitializeComponent();

            DBContext = new DatabaseContext();

            List<Car> carList = DBContext.Cars.ToList();
            CarColorComboBox.ItemsSource = Enum.GetValues(typeof(CarColor)).Cast<CarColor>();
            CarEquipmentComboBox.ItemsSource = DBContext.Equipments.ToList();
            CarMechanicComboBox.ItemsSource = DBContext.Mechanics.ToList();

            CarBrandTextBox.Text = car.Brand;
            CarModelTextBox.Text = car.Model;
            CarColorComboBox.SelectedItem = car.Color;
            CarEquipmentComboBox.SelectedItem = DBContext.Equipments.First(a => a.EquipmentId == car.EquipmentId);
            CarMechanicComboBox.SelectedItem = DBContext.Mechanics.First(a => a.MechanicId == car.MechanicId);
            isMod = true;

            toMod = car;
        }

        private void CarBrandTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            this.CarBrand = CarBrandTextBox.Text;
        }

        private void CarModelTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            this.CarModel = CarModelTextBox.Text;
        }

        private void CarEquipmentComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.CarEquipment = (Equipment) CarEquipmentComboBox.SelectedItem;
        }

        private void CarMechanicComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.CarMechanic = (Mechanic) CarMechanicComboBox.SelectedItem;
        }

        private void ColorComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.CarColor = (CarColor) CarColorComboBox.SelectedItem;
        }

        private void AcceptCarButton_Click(object sender, RoutedEventArgs e)
        {
            if (isMod)
            {
                toMod.Brand = CarBrandTextBox.Text;
                toMod.Model= CarModelTextBox.Text;
                toMod.Color = CarColor;
                toMod.MechanicId = CarMechanic.MechanicId;
                toMod.EquipmentId = CarEquipment.EquipmentId;

                DBContext.Update(toMod);
            }
            else
            {
                Car toAdd = new Car(this.CarBrand, this.CarModel, this.CarEquipment.EquipmentId, this.CarMechanic.MechanicId, this.CarColor);
                this.DBContext.Add(toAdd);
            }
               
            DBContext.SaveChanges();

            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void CancelCarButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
