using JagdeepDB.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using JagdeepDB.Interface;

namespace JagdeepDB
{
    public class Employee: KeyAutoIncrement
    {
        public int ID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string title { get; set; }
        public string titleOfCourtesy { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string region { get; set; }
        [DataType(DataType.PostalCode)]
        public string postalCode { get; set; }
        public string coutnry { get; set; }
        [Phone]
        public string homePhone { get; set; }
        [FileExtensions]
        public string extension { get; set; }
        [Url(ErrorMessage = "Please use valid url")]
        public string photo { get; set; }
        [StringLength(4000)]
        public string notes { get; set; }
        public string reportTo { get; set; }
        [Url(ErrorMessage = "Please use valid url")]
        public string photoPath { get; set; }
   
        public ICollection<Territory> Territories { get; set; }

        public static implicit operator Employee(Exception e)
        {
            throw new NotImplementedException();
        }
    }
}
