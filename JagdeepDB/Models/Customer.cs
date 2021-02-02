using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using JagdeepDB.Interface;

namespace JagdeepDB.Models
{
    public class Customer: KeyAutoIncrement
    {
        public int ID { get; set; }
        public string companyName { get; set; }
        public string contactTitle { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string region { get; set; }
        [DataType(DataType.PostalCode)]
        public string postalCode { get; set; }
       
        public string country { get; set; }
        [Phone]
        public string phone { get; set; }
       
        public int fax { get; set; }

    }
}
