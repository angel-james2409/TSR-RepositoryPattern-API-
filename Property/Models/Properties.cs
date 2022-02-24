using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Property.Models
{
    public class Properties
    {
        [Key]
        public int PropertyId { get; set; }

        public string Type { get; set; }
        public string Area { get; set; }

        public string Address { get; set; }
        public string ContactDetails { get; set; }

        public string EstimatedValue { get; set; }
    }
}
