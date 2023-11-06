using FizzBuzz.Application.Service;
using FizzBuzz.Application.Service.FileManager.AppService;
using FizzBuzz.CrossCutting.Utilities.Error_Handling;
using FizzBuzz.CrossCutting.Utilities.GetPath;
using FizzBuzz.CrossCutting.Utilities.Limit_FizzBuzz;
using FizzBuzz.Domain.Entities;
using log4net;
using System;
using System.Collections.Generic;
using System.Net;
using System.ServiceModel.Web;


namespace FizzBuzzExam
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service1 : IFizzBuzzApiService
    {
        private readonly IFIleManagerApplicationService _fileManagerApplicationService;
        private readonly IGetPathFile _getPathFile;
        private readonly IGetLimitFB _getLimitFB;
        private readonly IFizzBuzzApplicationSErvice _fizzBuzzApplicationSErvice;
        private readonly IErrorHandlin _errorHandling;
        private readonly ILog _log;
        private string filePath = string.Empty;

        public Service1()
        {
            //FileManagerAPI();

            
        }
        public Service1(IErrorHandlin errorHandling, ILog log, IFizzBuzzApplicationSErvice fizzBuzzApplicationService, IGetLimitFB getLimitFB,
            IGetPathFile getPathFile, IFIleManagerApplicationService fileManagerApplicationService)
        {
            this._fileManagerApplicationService = fileManagerApplicationService;
            this._getPathFile = getPathFile;
            this._getLimitFB = getLimitFB;
            this._fizzBuzzApplicationSErvice = fizzBuzzApplicationService;
            this._errorHandling = errorHandling;
            this._log = log;
            _log.Info("Service1 Created");
            FileManagerAPI();
        }

        public void FileManagerAPI()
        {
            filePath = _getPathFile.GetPath();
            _fileManagerApplicationService.CreateFile(filePath);
        }

        public List<FizzBuzzModel.FizzBuzzResponse> GetFizzBuzz(FizzBuzzModel.FizzBuzzRequest request)
        {
            try
            {
                var limit = _getLimitFB.GetLimit();
                return _fizzBuzzApplicationSErvice.GetFizzBuzz(request, limit, filePath);  
            }
            catch (WebFaultException<MessageResource> ex)
            {

                var statusCode = ex.StatusCode;
                var statusCodeNumber = (int)statusCode;

                var error = _errorHandling.CreateWebFaultException(
                    $"(HTTP Status Code: {statusCodeNumber}) An error occurred: {ex.Detail.ErrorMessage}",
                statusCode);

                _log.Error($"(HTTP Status Code: {statusCodeNumber}), An error occurred: {ex.Detail.ErrorMessage}", ex);

                throw error;
            }
            catch (Exception ex)
            {
                var statusCode = HttpStatusCode.InternalServerError; // Default to 500
                var statusCodeNumber = (int)statusCode;

                var error = _errorHandling.CreateWebFaultException(
                    $"(HTTP Status Code: {statusCodeNumber}) An error occurred: {ex.Message}",
                statusCode);

                _log.Error($"(HTTP Status Code: {statusCodeNumber}), An error occurred: {ex.Message}", ex);

                throw error;
            }
            throw new NotImplementedException();
        }
    }
}
