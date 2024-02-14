using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSharingManagement.Entities
{
    public class Mechanic
    {
        public int MechanicId { get; set; }
        public string MechanicName { get; set; }
        public string MechanicSurname { get; set; }

        public Mechanic (string MechanicName, string MechanicSurname)
        {
            if (MechanicName == null || MechanicSurname == null)
                throw new ArgumentNullException();

            this.MechanicName = MechanicName;
            this.MechanicSurname = MechanicSurname;
        }

        public override string ToString()
        {
            return MechanicName + " " + MechanicSurname + " #" + MechanicId;
        }
    }
}
