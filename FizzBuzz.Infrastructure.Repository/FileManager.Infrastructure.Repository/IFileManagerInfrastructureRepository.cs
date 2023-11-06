using FizzBuzz.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Infrastructure.Repository.FileManager.Infrastructure.Repository
{
    public interface IFileManagerInfrastructureRepository
    {
        bool CreateFile(string filePath);
        List<FizzBuzzModel.FizzBuzzResponse> Print(FizzBuzzModel.FizzBuzzRequest request, string Limit, string FilePath);
    }
}
