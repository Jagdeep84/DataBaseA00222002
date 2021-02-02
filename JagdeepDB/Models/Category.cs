using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using JagdeepDB.Interface;

namespace JagdeepDB.Models
{
    public class Category: KeyAutoIncrement
    {
        
        public int ID { get; set; }
    
        public string categoryName { get; set; }

        [StringLength(4000)]
        public string description { get; set; }
        
    }
}
