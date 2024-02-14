using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace CarSharingManagement.Entities
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public string CustomerEmail { get; set; }

        public Customer(string CustomerName, string CustomerSurname, string CustomerEmail) 
        {
            if (CustomerName == null || CustomerEmail == null || CustomerSurname == null)
                throw new ArgumentNullException();

            this.CustomerName = CustomerName;
            this.CustomerSurname = CustomerSurname;
            this.CustomerEmail = CustomerEmail;
        }

        public override string ToString()
        {
            return CustomerName + " " + CustomerSurname + " #" + CustomerId + ", email: " + CustomerEmail;
        }
    }
}
