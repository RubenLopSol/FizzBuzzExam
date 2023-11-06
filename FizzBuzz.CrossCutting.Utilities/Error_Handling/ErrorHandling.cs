using System.Net;
using System.ServiceModel.Web;


namespace FizzBuzz.CrossCutting.Utilities.Error_Handling
{
    public class ErrorHandling : IErrorHandlin
    {
        public WebFaultException<MessageResource> CreateWebFaultException(string errorMessage, HttpStatusCode statusCode)
        {
            var error = new MessageResource(errorMessage);
            return new WebFaultException<MessageResource>(error, statusCode);
        }
    }
}
