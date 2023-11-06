using FizzBuzz.Domain.Entities;
using FizzBuzz.Infrastructure.Repository;
using FizzBuzz.Infrastructure.Repository.FileManager.Infrastructure.Repository;
using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Application.Service
{
    public class FizzBuzzApplicationService
    {
        
        private IFizzBuzzRepository _fizzBuzzRepository;
        private ILog _log;
        public FizzBuzzApplicationService(IFizzBuzzRepository fizzBuzzRepository, ILog log)
        {

            this._fizzBuzzRepository = fizzBuzzRepository;
            this._log = log;

            _log.Info("FizzBuzzApplicationService Created");
        }

        public List<FizzBuzzModel.FizzBuzzResponse> GetFizzBuzz(FizzBuzzModel.FizzBuzzRequest request, string limit, string FilePath)
        {
            return _fizzBuzzRepository.GetFizzBuzz(request, limit, FilePath);
        }
    }
}
