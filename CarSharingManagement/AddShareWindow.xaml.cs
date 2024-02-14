using CarSharingManagement.Entities;
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
    /// Logika interakcji dla klasy AddShareWindow.xaml
    /// </summary>
    public partial class AddShareWindow : Window
    {
        DatabaseContext DBContext;
        Car CarToShare { get; set; }
        Customer Customer { get; set; }
        DateOnly From { get; set; }
        DateOnly To { get; set; }

        public AddShareWindow()
        {
            InitializeComponent();
            DBContext = new DatabaseContext();

            ShareCarComboBox.ItemsSource = DBContext.Cars.ToList();
            ShareCustomerComboBox.ItemsSource = DBContext.Customers.ToList();
        }

        private void ApplyButton_Click(object sender, RoutedEventArgs e)
        {
            From = DateOnly.FromDateTime(AddShareFromDataPicker.SelectedDate ?? default);
            To = DateOnly.FromDateTime(AddShareToDataPicker.SelectedDate ?? default);
            Sharing toAdd = new Sharing(this.CarToShare.CarId, this.Customer.CustomerId, From, To);
            DBContext.Add(toAdd);
            DBContext.SaveChanges();

            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void DeclineButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void ShareCarComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.CarToShare = (Car) ShareCarComboBox.SelectedItem;
        }

        private void ShareCustomerComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.Customer = (Customer)ShareCustomerComboBox.SelectedItem;
        }
    }
}
