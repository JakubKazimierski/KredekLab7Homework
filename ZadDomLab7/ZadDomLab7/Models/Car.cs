using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ZadDomLab7.Models
{
    public class Car
    {
        /// <summary>
        /// Creating columns in table Car
        /// </summary>
        [Key]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "NVARCHAR")]
        [StringLength(250)]
        [DisplayName("Model")]
        public string ModelOfCar { get; set; }

        [Required(ErrorMessage = "Producer name is required")]
        [DisplayName("Producer")]
        public string ProducerOfCar { get; set; }

        [DisplayName("Year of Production")]
        public int YearOfProductionCar { get; set; }

        [DisplayName("Price")]
        public int PriceOfCar { get; set; }


    }
}
