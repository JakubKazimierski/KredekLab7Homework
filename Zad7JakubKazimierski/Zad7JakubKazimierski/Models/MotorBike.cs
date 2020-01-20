using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Zad7JakubKazimierski.Models
{
    public class MotorBike
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MBikeId { get; set; }
        public string MBikeModel { get; set; }
        public string MBikeProducer { get; set; }
        public int DateOfProduction { get; set; }
        public int MBikePrice { get; set; }
    }
}
