using FizzBuzz.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace FizzBuzzExam
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IFizzBuzzApiService
    {

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/GetFizzBuzz", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<FizzBuzzModel.FizzBuzzResponse> GetFizzBuzz(FizzBuzzModel.FizzBuzzRequest request);
      
    }    
}
