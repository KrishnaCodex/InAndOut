using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InAndOut.Models
{
    public class Expense
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Expense")]
        [Required(ErrorMessage ="Name should be there")]
        public string ExpenseName { get; set; }

        [Required]
        [Range(0,1000,ErrorMessage ="Expense should be less than 1000")]
        public int Amount { get; set; }
    }
}
