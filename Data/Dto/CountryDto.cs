using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Dto
{
// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class CountryDetail
    {
        public int CountryId { get; set; }
        public string Operator { get; set; }
        public string OperatorCode { get; set; }
    }

    public class Country
    {
        public string countryCode { get; set; }
        public string name { get; set; }
        public string countryIso { get; set; }
        public CountryDetail countryDetails { get; set; }
    }

    public class CountryDto
    {
        public string number { get; set; }
        public Country country { get; set; }
    }


}

