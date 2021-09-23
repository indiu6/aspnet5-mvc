using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleMvcApp.Models
{
    public class Items
    {
        [Key]
        public int Id { get; set; }
        public string Borrower { get; set; }
    }
}
