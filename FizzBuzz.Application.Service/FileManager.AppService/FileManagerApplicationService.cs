using FizzBuzz.Infrastructure.Repository.FileManager.Infrastructure.Repository;
using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Application.Service.FileManager.AppService
{
    public class FileManagerApplicationService : IFIleManagerApplicationService
    {
        private readonly IFileManagerInfrastructureRepository _fileManagerInfrastructureRepository;
        private readonly ILog _log;

        public FileManagerApplicationService(IFileManagerInfrastructureRepository fileManagerInfrastructureRepository, ILog _log)
        {   this._fileManagerInfrastructureRepository = fileManagerInfrastructureRepository;
            this._log = _log;
            
        }

        public bool CreateFile(string filePath)
        {
            _log.Info("FileManagerApplicationService Class Create method called");
            return _fileManagerInfrastructureRepository.CreateFile(filePath);
        }
    }
}
