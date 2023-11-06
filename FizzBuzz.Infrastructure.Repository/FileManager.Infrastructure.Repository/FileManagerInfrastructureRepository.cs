using FizzBuzz.Domain.Entities;
using log4net;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Abstractions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FizzBuzz.Domain.Entities.FizzBuzzModel;

namespace FizzBuzz.Infrastructure.Repository.FileManager.Infrastructure.Repository
{
    public class FileManagerInfrastructureRepository : IFileManagerInfrastructureRepository
    {

        private readonly ILog _log;
        private readonly IFileSystem _fileWrapper;

        public FileManagerInfrastructureRepository(ILog log, IFileSystem fileWrapper)
        {
            this._log = log;
            this._fileWrapper = fileWrapper;
        }
        public bool CreateFile(string filePath)
        {
            _log.Info("FileManagerInfrastructureService Class Create method called");

            try
            {
                
                using (var fileStream = _fileWrapper.File.Create(filePath))
                {
                    
                }

                return true;
            }
            catch (Exception ex)
            {
                _log.Error("Error creating the file: " + ex.Message);
                return false;
            }

        }

        public List<FizzBuzzModel.FizzBuzzResponse> Print(FizzBuzzModel.FizzBuzzRequest request, string Limi20t, string FilePath)
        {
            throw new NotImplementedException();
        } 


    }
}
