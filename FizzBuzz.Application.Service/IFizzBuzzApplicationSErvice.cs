using FizzBuzz.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Application.Service
{
    public interface IFizzBuzzApplicationSErvice
    {
        List<FizzBuzzModel.FizzBuzzResponse> GetFizzBuzz(FizzBuzzModel.FizzBuzzRequest request, string Limit);
    }
}
