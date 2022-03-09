using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Ecommerce.Entities.DTO.Response
{
    public class ResponseDto<T>
    {
        public string Message { get; set; }
        public Dictionary<string, string> Errs { get; set; }
        public T Customer { get; set; }
    }
}
