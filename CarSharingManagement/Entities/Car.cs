using CarSharingManagement.Temps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSharingManagement.Entities
{
    public class Car
    {
        public int CarId { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int EquipmentId { get; set; }
        public int MechanicId { get; set; }
        public CarColor Color { get; set; } = CarColor.Unknown;

        public Car(string Brand, string Model, int EquipmentId, int MechanicId, CarColor Color)
        {
            if (Brand == null || Model == null)
                throw new ArgumentNullException();

            this.Brand = Brand;
            this.Model = Model;
            this.Color = Color;

            this.MechanicId = MechanicId;
            this.EquipmentId = EquipmentId;
        }

        public override string ToString()
        {
            return Brand + ", " + Model + ", " + Color + " #" + CarId + " Mechanic: #" + MechanicId + " Equipment: #" + EquipmentId;
        }
    }
}
