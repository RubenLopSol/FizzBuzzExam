using System.Net;
using System.ServiceModel.Web;


namespace FizzBuzz.CrossCutting.Utilities.Error_Handling
{
    public interface IErrorHandlin
    {
         WebFaultException<MessageResource> CreateWebFaultException(string errorMessage, HttpStatusCode statusCode);
       
    }
}
