using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSharingManagement.Entities
{
    internal class Sharing
    {
        public int SharingId { get; set; }
        public int CarId { get; set; }
        public int UserId { get; set; }
        public DateOnly From { get; set; }
        public DateOnly To { get; set; }

        public Sharing(int CarId, int UserId, DateOnly From, DateOnly To) 
        { 
            this.CarId = CarId;
            this.UserId = UserId;
            this.From = From;
            this.To = To;
        }

        public override string ToString()
        {
            return "#" + SharingId + " Car #" + CarId + ", Customer #" + UserId + ", " + From + " - " + To; 
        }
    }
}
