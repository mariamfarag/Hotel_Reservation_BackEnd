using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Models
{

    public class Result
    {
        public Result()
        {

        }
        public Result(bool succeeded, string[]? errors = null, object? data = null)
        {
            Succeeded = succeeded;
            Data = data;
            Errors = errors;
        }

        public bool Succeeded { get; set; }

        public string[]? Errors { get; set; }
        public object? Data { get; set; }

        public static Result Success(object? data = null)
        {
            return new Result(true, data: data);
        }

        public static Result Fail(string[]? errors)
        {
            return new Result(false, errors);
        }
        public static Result Fail(string? error, object? data = null)
        {
            return string.IsNullOrEmpty(error) ? new Result(false, data: data) : new Result(false, new[] { error }, data: data);
        }

        /// <summary>
        /// Authorization determines what resources a user can access, if have a valid token or not 
        /// </summary>
        /// <returns></returns>
        public static Result NotAuthorized()
        {
            return Fail("Must have valid token to access this api");
        }
    }


}
