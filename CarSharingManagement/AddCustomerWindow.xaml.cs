using CarSharingManagement.Entities;
using Microsoft.Identity.Client;
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
    /// Logika interakcji dla klasy AddCustomerWindow.xaml
    /// </summary>
    public partial class AddCustomerWindow : Window
    {
        DatabaseContext DBContext;
        bool isMod;
        Customer toMod;
        String Name, Surname, Email;

        public AddCustomerWindow()
        {
            InitializeComponent();
            isMod = false;
            DBContext = new DatabaseContext();
        }

        public AddCustomerWindow(Customer customer)
        {
            InitializeComponent();

            isMod = true;
            toMod = customer;

            DBContext = new DatabaseContext();

            this.CustomerNameTextBox.Text = customer.CustomerName;
            this.CustomerSurnameTextBox.Text = customer.CustomerSurname;
            this.CustomerEmailTextBox.Text = customer.CustomerEmail;
        }

        private void ApplyButton_Click(object sender, RoutedEventArgs e)
        {
            if(isMod)
            {
                toMod.CustomerName = Name;
                toMod.CustomerSurname = Surname;
                toMod.CustomerEmail = Email;

                DBContext.Update(toMod);
            }
            else
            {
                Customer toAdd = new Customer(Name, Surname, Email);
                DBContext.Add(toAdd);
            }
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

        private void CustomerNameTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            this.Name = CustomerNameTextBox.Text;
        }

        private void CustomerSurnameTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            this.Surname = CustomerSurnameTextBox.Text;
        }

        private void CustomerEmailTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            this.Email = CustomerEmailTextBox.Text;
        }
    }
}
