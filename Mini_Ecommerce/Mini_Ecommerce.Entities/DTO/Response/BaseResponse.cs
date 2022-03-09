using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Ecommerce.Entities.DTO.Response
{
    public static class BaseResponse
    {
        public static ResponseDto<T> CreateResponse<T>(string message,
           ModelStateDictionary errs, T Customer)
        {
            var errors = new Dictionary<string, string>();
            if (errs != null)
            {
                foreach (var err in errs)
                {
                    var counter = 0;
                    var key = err.Key;
                    var errVals = err.Value;
                    foreach (var errMsg in errVals.Errors)
                    {
                        errors.Add($"{(counter + 1)} - {key}", errMsg.ErrorMessage);
                        counter++;
                    }
                }
            }

            var obj = new ResponseDto<T>()
            {
                Message = message,
                Errs = errors,
                Customer = Customer
            };
            return obj;
        }
    }
}
