using JagdeepDB.Interface;
using JagdeepDB.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace JagdeepDB
{
  public class Product: KeyAutoIncrement
    {
        public int ID { get; set; }
        public Category category { get; set; }
        public Supplier supplier { get; set; }
        public string productName { get; set; }
        public int quantityPerLabel { get; set; }
        [Range(0d, 999999.99d)]
        public decimal unitPrice { get; set; }
        public int unitsInStocks { get; set; }
        public int unitsOnOrder { get; set; }
        public int reorderLevel { get; set; }
        [Range(0d, 999999.99d)]
        public decimal dicounted { get; set; }
    }
}
