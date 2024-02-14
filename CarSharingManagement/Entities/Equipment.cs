using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSharingManagement.Entities
{
    public class Equipment
    {
        public int EquipmentId { get; set; }
        public int Seats { get; set; }
        public bool HasAirConditioner { get; set; }
        public string Description { get; set; }

        public Equipment(int Seats, bool HasAirConditioner, string Description) 
        {
            if (Seats < 0 || Seats > 9 || Description== null) 
            {
                throw new ArgumentException();
            }

            this.Seats = Seats;
            this.HasAirConditioner = HasAirConditioner;
            this.Description = Description;
        }

        public override string ToString()
        {
            String description;
            if( Description.Length > 20 )
            {
                description = Description.Substring(0, 20);
            }
            else
            {
                description = Description;
            }
            return "Seats: " + Seats + ", Air Conditioner: " + HasAirConditioner + ", description: " + description + "...";
        }
    }
}
