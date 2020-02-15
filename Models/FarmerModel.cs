using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FarmerSupport.Models
{
    public class FarmerModel
    {
        [Key]
        public int FarmerId { get; set; }
        public int Sunlight { get; set; }
        public int Temperature { get; set; }
        public int Humidity { get; set; }
        public int ElectricalConducitvity { get; set; }
        public int Rainfall { get; set; }
        public String Past3Months { get; set; }
        public String Next3Months { get; set; }
    }

}
