using System;
using System.Collections.Generic;
using System.Text;
using JagdeepDB.Interface;
using JagdeepDB.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JagdeepDB.Models
{
   public class Territory: KeyAutoIncrement
    {
        public int ID { get; set; }
        public Region region { get; set; }
        [StringLength(4000)]
        public string territoryDescription { get; set; }
        public ICollection<Employee>Employees { get; set; }
    }
}
