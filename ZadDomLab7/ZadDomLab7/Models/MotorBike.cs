using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ZadDomLab7.Models
{
    public class MotorBike
    {
        /// <summary>
        /// Creating columns in table MotorBike
        /// </summary>
        [Key]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "NVARCHAR")]
        [StringLength(250)]
        [DisplayName("Model")]
        public string ModelOfMotor { get; set; }

        [Required(ErrorMessage = "Producer name is required")]
        [DisplayName("Producer")]
        public string ProducerOfMotor { get; set; }

        [DisplayName("Year of Production")]
        public int YearOfProductionMotor { get; set; }

        [DisplayName("Price")]
        public int PriceOfMotor { get; set; }
    }
}
