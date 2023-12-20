using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Application.Result
{
    public interface IResult
    {
        bool Succsess {  get; }
        string Message { get; }
    }
}
