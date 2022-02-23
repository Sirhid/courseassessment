using Data.Dto;
using Data.Repository;
using Microsoft.AspNetCore.Mvc;
using Models.Enitities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COUREASSESSMENT.Controllers
{
   // [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly IAssesementRepo _assesementRepo;
        public CourseController(IAssesementRepo assesementRepo)
        {
            _assesementRepo = assesementRepo;
        }

        [HttpGet("GetCountryDetails")]
        public async Task<IActionResult> GetCountryDetails(string PhoneNumber)
        {
            try
            {
                var response = new ResponseDTO();
                if (PhoneNumber.Length<13)
                {
                    response.Message = "Kindly make sure your Number has the counrty code in it";
                    response.statusCode = "401";
                    response.Data = null;
                    return Ok(response);
                }
                var result =await _assesementRepo.GetCountryCode(PhoneNumber);
                if (result.Count>0)
                {
                    response.Message = "Successfully Retrieved Data";
                    response.statusCode = "200";
                    response.Data = result;
                    return Ok(response);
                }
                else
                {
                    response.Message = "No data Found";
                    response.statusCode = "401";
                    response.Data = null;
                    return Ok(response);
                }
                return Ok(response);
            }
            catch (Exception ex)
            {

                throw;
            }          
        }


        [HttpPost("GetArray")]
        public async Task<IActionResult> GetArray(ArrayofNumbers arrayofNumbers)
        {
            try
            {
                var response = new ResponseDTO();

                foreach (var item in arrayofNumbers.myNumbers)
                {
                     if (item == 8)
                    {
                        double eight = item + 5 + arrayofNumbers.myNumbers.Sum();
                        response.Message = "Added Successfully";
                        response.statusCode = "00";
                        response.Data = eight;
                        return Ok(response);


                    }
                    else if (item % 2 == 0)
                    {
                        double even = item + 1 + arrayofNumbers.myNumbers.Sum();
                        response.Message = "Added Successfully";
                        response.statusCode = "00";
                        response.Data = even;
                        return Ok(response);


                    }

                    else
                    {
                        double odd = item + 2 + arrayofNumbers.myNumbers.Sum();
                        response.Message = "Added Successfully";
                        response.statusCode = "00";
                        response.Data = odd;
                        return Ok(response);


                    }
                }
                return Ok(response);
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
