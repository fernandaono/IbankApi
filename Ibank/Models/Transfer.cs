using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ibank.Models
{
    public class Transfer
    {
        [Key]
        public int Id { get; set; }
        public DateTime Date { get; internal set; }
        public double Amount { get; set; }
        public int From { get; set; }
        public int To { get; set; }
    }
}
