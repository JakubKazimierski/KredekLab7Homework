using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Zad7JakubKazimierski.Models
{
    public class Car
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CarId { get; set; }
        public string CarModel { get; set; }
        public string CarProducer { get; set; }
        public int DateOfProduction { get; set; }
        public int CarPrice { get; set; }

    }
}
