using Data.Dto;
using Models.Enitities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Repository;

namespace Data.Repository
{
   public  class AssesementRepo : IAssesementRepo
    {
        private readonly AppDbContext _AppDbContext;

        public AssesementRepo(AppDbContext AppDbContext)
        {
            _AppDbContext = AppDbContext;
        }
        public async Task<List<Models.Enitities.Country>> GetCountryCode(string PhoneNumber)
        {
            var response = new List<Models.Enitities.Country>();
            List<Models.Enitities.Country> countries = new List<Models.Enitities.Country>()
                    {
                    new Models.Enitities.Country { CountryCode="234", CountryIso="NGA", ID=1, Name="Nigeria"},
                    new Models.Enitities.Country { CountryCode="233", CountryIso="GH", ID=2, Name="Ghana"},
                    new Models.Enitities.Country { CountryCode="229", CountryIso="BN", ID=3, Name="Benin Republic"},
                    new Models.Enitities.Country { CountryCode="225", CountryIso="CIV", ID=4, Name="Côte d'Ivoire"},
                    };

            List<Models.Enitities.CountryDetail> countriesDetails = new List<Models.Enitities.CountryDetail>()
                    {
                    new Models.Enitities.CountryDetail {  CountryId=1,Operator="MTN Nigeria",  OperatorCode="MTN NGA"},
                    new Models.Enitities.CountryDetail { CountryId=1, Operator="Airtel Nigeria", OperatorCode="ANG"},
                    new Models.Enitities.CountryDetail { CountryId=1, Operator="9 Mobile Nigeria", OperatorCode="ETN"},
                    new Models.Enitities.CountryDetail { CountryId=1, Operator="Globacom Nigeria", OperatorCode="GLO NGA"},

                    new Models.Enitities.CountryDetail { CountryId=2, Operator="Vodafone Ghana", OperatorCode="Vodafone GH"},
                    new Models.Enitities.CountryDetail { CountryId=2, Operator="MTN Ghana", OperatorCode="MTN Ghana"},
                    new Models.Enitities.CountryDetail { CountryId=2, Operator="Tigo Ghana", OperatorCode="Tigo Ghana"},

                    new Models.Enitities.CountryDetail { CountryId=3, Operator="MTN Benin", OperatorCode="MTN Benin"},
                    new Models.Enitities.CountryDetail { CountryId=3, Operator="Moov Benin", OperatorCode="Moov Benin"},

                    new Models.Enitities.CountryDetail { CountryId=4, Operator="MTN Côte d'Ivoire", OperatorCode="MTN CIV"},


                    };
            try
            {

                var country = new Models.Enitities.Country();
                var countrydetailsList = new List<Models.Enitities.CountryDetail>();
                string num = PhoneNumber.Substring(0, 3);
                var result = countries.Where(c => c.CountryCode == num).ToList();
                foreach (var item in result)
                {
                    countrydetailsList = countriesDetails.Where(c => c.CountryId == item.ID).ToList();
                    

                }
                foreach (var items in countrydetailsList)
                {
                    country.countryDetails =items;
                    //country.countryDetails.OperatorCode = items.OperatorCode;
                    //country.countryDetails.Operator = items.Operator;
                    
                    result.Add(country);

                }
                return result;

            }
            catch (Exception ex)
            {

                throw;
            }

        }

    }
}
