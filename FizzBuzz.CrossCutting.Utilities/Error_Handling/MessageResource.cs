
using System.Net;
using System.Runtime.Serialization;
using System.ServiceModel.Web;


namespace FizzBuzz.CrossCutting.Utilities.Error_Handling
{
    [DataContract]
    public class MessageResource
    {
        [DataMember]
        public string ErrorMessage { get; set; }

        public MessageResource(string errorMessage)
        {
            ErrorMessage = errorMessage;
        }

        [DataContract] // Status Code: 400 (Bad Request)
        public class BadRequestException : WebFaultException<MessageResource>
        {
            public BadRequestException(string errorMessage) : base(new MessageResource(errorMessage), HttpStatusCode.BadRequest)
            {
            }
        }

        [DataContract] // Status Code: 404 (Not Found)
        public class NotFoundException : WebFaultException<MessageResource>
        {
            public NotFoundException(string errorMessage) : base(new MessageResource(errorMessage), HttpStatusCode.NotFound)
            {
            }
        }

        [DataContract] // Status Code: 500 (Internal Server Error)
        public class InternalServerErrorException : WebFaultException<MessageResource>
        {
            public InternalServerErrorException(string errorMessage) : base(new MessageResource(errorMessage), HttpStatusCode.InternalServerError)
            {
            }
        }

        [DataContract] // Status Code: 300 (Multiple Choices)
        public class MultipleChoicesException : WebFaultException<MessageResource>
        {
            public MultipleChoicesException(string errorMessage) : base(new MessageResource(errorMessage), HttpStatusCode.Ambiguous)
            {
            }
        }
    }
}
