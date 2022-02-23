using Models.Enitities;
using System.Collections.Generic;
using System.Threading.Tasks;
using Data.Repository;


namespace Data.Repository
{
    public interface IAssesementRepo
    {
        Task<List<Country>> GetCountryCode(string PhoneNumber);
    }
}