using FizzBuzz.Domain.Entities;
using log4net;
using System;
using System.Collections.Generic;
using System.Configuration;
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
        public List<FizzBuzzModel.FizzBuzzResponse> Print(FizzBuzzModel.FizzBuzzRequest request, string Limit, string filePath)
        {
            List<FizzBuzzModel.FizzBuzzResponse> responses = new List<FizzBuzzModel.FizzBuzzResponse>();

            int limit;

            if (!string.IsNullOrEmpty(Limit))
            {
                if (int.TryParse(Limit, out limit))
                {
                    // Use the 'Limit' parameter if provided and successfully parsed.
                }
                else
                {
                    // Handle the case where the 'Limit' parameter is not a valid integer.
                    // You can log an error or throw an exception, as appropriate.
                }
            }
            else
            {
                limit = GetLimitFromConfiguration();
            }

            for (int i = request.StartNumber; i <= request.StartNumber + limit; i++)
            {
                List<string> fizzBuzzSeries = new List<string>();

                // Your existing logic to populate fizzBuzzSeries...

                FizzBuzzModel.FizzBuzzResponse response = new FizzBuzzModel.FizzBuzzResponse
                {
                    Series = fizzBuzzSeries
                };

                responses.Add(response);
            }

            return responses;
        }

        private int GetLimitFromConfiguration()
        {
            int limit;
            if (int.TryParse(ConfigurationManager.AppSettings["FizzBuzzLimit"], out limit))
            {
                return limit;
            }

            // Default limit if not configured properly
            return 20;
        }
    }
}


