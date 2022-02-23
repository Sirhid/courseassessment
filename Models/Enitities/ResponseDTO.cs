using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Enitities
{
    public class ResponseDTO
    {
        public string statusCode { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }
    }
}
