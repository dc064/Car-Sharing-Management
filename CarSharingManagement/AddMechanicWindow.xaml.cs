using CarSharingManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
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
    /// Logika interakcji dla klasy Window1.xaml
    /// </summary>
    public partial class AddMechanicWindow : Window
    {
        DatabaseContext DBContext;
        String Name, Surname;
        Mechanic toMod;
        Boolean isMod;
        public AddMechanicWindow()
        {
            InitializeComponent();
            this.DBContext= new DatabaseContext();

            this.isMod = false;
        }

        public AddMechanicWindow(Mechanic mechanic)
        {
            InitializeComponent();
            this.DBContext = new DatabaseContext();
            this.isMod = true;

            this.AddMechanicNameTextBox.Text = mechanic.MechanicName;
            this.AddMechanicSurnameTextBox.Text = mechanic.MechanicSurname;

            toMod = mechanic;
        }

        private void AddMechanicAddButton_Click(object sender, RoutedEventArgs e)
        {
            if (isMod)
            {
                toMod.MechanicName = Name;
                toMod.MechanicSurname = Surname;

                DBContext.Update(toMod);
            }
            else
            {
                Mechanic toAdd = new Mechanic(this.Name, this.Surname);
                DBContext.Add(toAdd);
            }
            DBContext.SaveChanges();

            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void AddMechanicNameTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            this.Name = AddMechanicNameTextBox.Text;
        }

        private void AddMechanicSurnameTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            this.Surname = AddMechanicSurnameTextBox.Text;
        }

        private void AddMechanicDeclineButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
