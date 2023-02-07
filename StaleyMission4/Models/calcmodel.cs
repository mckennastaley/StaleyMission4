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
        [Range (0,100)]
        public decimal Assignment { get; set; }
        [Required]
        [Range(0, 100)]
        public decimal GroupProject { get; set; }
        [Required]
        [Range(0, 100)]
        public decimal Quiz { get; set; }
        [Required]
        [Range(0, 100)]
        public decimal Midterm { get; set; }
        [Required]
        [Range(0, 100)]
        public decimal Final { get; set; }
        [Required]
        [Range(0, 100)]
        public decimal Intex { get; set; }

    }
}
