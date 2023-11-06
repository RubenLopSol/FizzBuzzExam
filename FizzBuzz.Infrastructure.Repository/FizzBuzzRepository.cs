using FizzBuzz.Domain.Entities;
using FizzBuzz.Infrastructure.Repository.FileManager.Infrastructure.Repository;
using log4net;
using System;
using System.Collections.Generic;
using System.IO.Abstractions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Infrastructure.Repository
{
    public class FizzBuzzRepository : IFizzBuzzRepository
    {
        private IFileSystem _fileWrapper;
        private IFileManagerInfrastructureRepository _fileManagerInfrastructureRepository;
        private ILog _log;
        
        public IFileManagerInfrastructureRepository fileManagerInfrastructureRepositor
        {
            get { return _fileManagerInfrastructureRepository; }
        }
        
        public FizzBuzzRepository(IFileManagerInfrastructureRepository fileManagerInfrastructureRepositor, ILog log, IFileSystem fileWrapper)
        {
            this._fileManagerInfrastructureRepository = fileManagerInfrastructureRepositor;
            this._log = log;
            this._fileWrapper = fileWrapper;

            _log.Info("FizzBuzzRepository Created");
        }


        public List<FizzBuzzModel.FizzBuzzResponse> GetFizzBuzz(FizzBuzzModel.FizzBuzzRequest request, string Limit, string FilePath)
        {
            return _fileManagerInfrastructureRepository.Print(request, Limit, FilePath);
        }

       
    }
}
