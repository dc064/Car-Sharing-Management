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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CarSharingManagement
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Car Car;
        Mechanic Mechanic;
        Equipment Equipment;
        Sharing Sharing;
        Customer Customer;
        DatabaseContext DBContext;

        public MainWindow()
        {
            InitializeComponent();

            DBContext = new DatabaseContext();

            CarList.ItemsSource = DBContext.Cars.ToList();
            CustomerList.ItemsSource = DBContext.Customers.ToList();
            MechanicList.ItemsSource = DBContext.Mechanics.ToList();
            EquipmentList.ItemsSource = DBContext.Equipments.ToList();
            SharingList.ItemsSource = DBContext.Sharings.ToList();
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void MechanicList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Mechanic = (Mechanic)MechanicList.SelectedItem;
        }

        private void AddCarButton_Click(object sender, RoutedEventArgs e)
        {
            AddCarWindow addCarWindow = new AddCarWindow();
            addCarWindow.Show();
            this.Close();
        }

        private void AddEquipmentButton_Click(object sender, RoutedEventArgs e)
        {
            AddEquipmentWindow addEquipmentWindow = new AddEquipmentWindow();
            addEquipmentWindow.Show();
            this.Close();
        }

        private void AddCustomerButton_Click(object sender, RoutedEventArgs e)
        {
            AddCustomerWindow addCustomerWindow = new AddCustomerWindow();
            addCustomerWindow.Show();
            this.Close();
        }

        private void DeleteCustomerButton_Click(object sender, RoutedEventArgs e)
        {
            if(Customer != null)
                DBContext.Remove(Customer);
            
            DBContext.SaveChanges();

            CustomerList.ItemsSource = DBContext.Customers.ToList();
        }

        private void AddMechanicButton_Click(object sender, RoutedEventArgs e)
        {
            AddMechanicWindow addMechanicWindow = new AddMechanicWindow();
            addMechanicWindow.Show();
            this.Close();
        }

        private void DeleteMechanicButton_Click(object sender, RoutedEventArgs e)
        {
            if (Mechanic != null)
                DBContext.Remove(Mechanic);

            DBContext.SaveChanges();

            MechanicList.ItemsSource = DBContext.Mechanics.ToList();
        }

        private void AddShareButton_Click(object sender, RoutedEventArgs e)
        {
            AddShareWindow addShareWindow = new AddShareWindow();
            addShareWindow.Show();
            this.Close();
        }

        private void DeleteShareButton_Click(object sender, RoutedEventArgs e)
        {
            if (Sharing != null)
                DBContext.Remove(Sharing);

            DBContext.SaveChanges();

            SharingList.ItemsSource = DBContext.Sharings.ToList();
        }

        private void CarList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Car = (Car) CarList.SelectedItem;
        }

        private void EditCarButton_Click(object sender, RoutedEventArgs e)
        {
            AddCarWindow addCarWindow = new AddCarWindow(Car);
            addCarWindow.Show();
            this.Close();
        }

        private void DeleteCarButton_Click(object sender, RoutedEventArgs e)
        {
            if(Car != null)
                DBContext.Remove(Car);

            DBContext.SaveChanges();

            CarList.ItemsSource = DBContext.Cars.ToList();
        }

        private void DeleteEquipmentButton_Click(object sender, RoutedEventArgs e)
        {
            if (Equipment != null)
                DBContext.Remove(Equipment);

            DBContext.SaveChanges();

            EquipmentList.ItemsSource = DBContext.Equipments.ToList();
        }

        private void EditCustomerButton_Click(object sender, RoutedEventArgs e)
        {
            AddCustomerWindow addCustomerWindow = new AddCustomerWindow(Customer);
            addCustomerWindow.Show();
            this.Close();
        }

        private void EditMechanicButton_Click(object sender, RoutedEventArgs e)
        {
            AddMechanicWindow addMechanicWindow = new AddMechanicWindow(Mechanic); 
            addMechanicWindow.Show();
            this.Close();
        }

        private void EditEquipmentButton_Click(object sender, RoutedEventArgs e)
        {
            AddEquipmentWindow addEquipmentWindow = new AddEquipmentWindow(Equipment);
            addEquipmentWindow.Show();
            this.Close();
        }

        private void EquipmentList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Equipment = (Equipment)EquipmentList.SelectedItem;
        }

        private void CustomerList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Customer = (Customer)CustomerList.SelectedItem;
        }

        private void SharingList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Sharing = (Sharing)SharingList.SelectedItem;
        }
    }
}
