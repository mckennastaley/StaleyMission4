using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StaleyMission4.Models
{
    public class calcmodel
    {
        [Required]

        public decimal Assignment { get; set; }
        public decimal GroupProject { get; set; }
        public decimal Quiz { get; set; }
        public decimal Midterm { get; set; }
        public decimal Final { get; set; }
        public decimal Intex { get; set; }

    }
}
