using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using JagdeepDB.Interface;
using JagdeepDB.Models;

namespace JagdeepDB
{
   public class Order: KeyAutoIncrement
    {
        public int ID { get; set; }
        public Customer customer { get; set; }
        public Employee employee { get; set; }
       
        public float weight { get; set; }
        public string shipVia { get; set; }
        public string shipName { get; set; }
        public string shipAddress { get; set; }
        public string shipCity { get; set; }
        public string shipRegion { get; set; }
        [DataType(DataType.PostalCode)]
        public string shipPostalCode { get; set; }
        public string shipCOuntry { get; set; }
    }
}
