using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Application.Result
{
    public class Result : IResult
    {
        public Result( bool success , string message ) : this (success)
        {
            Message = message;
        }

        public Result(bool success)
        {
            Succsess = success;
        }


        public bool Succsess { get; }

        public string Message { get; }
    }
}
