using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Models.Enitities
{
   public  class CountryDetail
    {
       
        public int? ID { get; set; }
        public int? CountryId { get; set; }
        public string? Operator { get; set; }
        public  string? OperatorCode { get; set; }
    }
}
