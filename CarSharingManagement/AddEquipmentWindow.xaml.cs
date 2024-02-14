using CarSharingManagement.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
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
    /// <summary>
    /// Logika interakcji dla klasy AddEquipmentWindow.xaml
    /// </summary>
    public partial class AddEquipmentWindow : Window
    {
        DatabaseContext DBContext;

        String Description;
        int Seats;
        bool AirConditioner;

        bool isMod;
        Equipment toMod;
        
        public AddEquipmentWindow()
        {
            InitializeComponent();
            this.DBContext = new DatabaseContext();
            this.SeatNumberTextBlock.Text = "Seats: " + 0;

            isMod = false;
        }

        public AddEquipmentWindow(Equipment equipment)
        {
            InitializeComponent();
            this.DBContext = new DatabaseContext();

            toMod = equipment;
            isMod = true;

            this.EquipmentDescriptionBox.Text = equipment.Description;
            this.SeatsNumberSlider.Value = equipment.Seats;
            this.SeatNumberTextBlock.Text = "Seats: " + equipment.Seats;
            this.AirConditioner = (bool)HasAirConditioner.IsChecked;
        }

        private void EquipmentDescriptionBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            this.Description = EquipmentDescriptionBox.Text;
        }

        private void DeclineButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void ApplyButton_Click(object sender, RoutedEventArgs e)
        {
            if (isMod)
            {
                toMod.Seats = this.Seats;
                toMod.HasAirConditioner = this.AirConditioner;

                DBContext.Update(toMod);
            }
            else
            {
                Equipment toAdd = new Equipment(this.Seats, this.AirConditioner, this.Description);
                this.DBContext.Add(toAdd);
            }
            DBContext.SaveChanges();

            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void HasAirConditioner_Checked(object sender, RoutedEventArgs e)
        {
            AirConditioner = (bool)HasAirConditioner.IsChecked;
        }

        private void SeatsNumberSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            this.Seats = (int)SeatsNumberSlider.Value;
            this.SeatNumberTextBlock.Text = "Seats: " + this.Seats;
        }
    }
}
