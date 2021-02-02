using JagdeepDB.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JagdeepDB.Models
{
   public class Shipper: KeyAutoIncrement
    {
        public int ID { get; set; }
        public string companyName { get; set; }
        [Phone]
        public string phone { get; set; }

    }
}
