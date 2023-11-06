using FizzBuzz.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Infrastructure.Repository
{
    public interface IFizzBuzzRepository
    {
        List<FizzBuzzModel.FizzBuzzResponse> GetFizzBuzz(FizzBuzzModel.FizzBuzzRequest request, string Limit, string FilePath);
    }
}
