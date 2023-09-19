using System.Net;

namespace PruebaAFP.API.DTOs.ResponseV1
{
    public class ResponseWrapperDTO<T>
    {
        public T Data { get; set; }

        public GlobalStatusDTO Status { get; set; }
        public ResponseWrapperDTO() 
        {
            Status = new GlobalStatusDTO();
        }

        public ResponseWrapperDTO(T data)
        {
            this.Data = data;
            Status = new GlobalStatusDTO();
        }

        public void AddRequestStatus(HttpStatusCode statusCode)
        {
            AddRequestStatus(statusCode, statusCode.ToString());
        }

        public void AddRequestStatus(HttpStatusCode statusCode, string statusMessage)
        {
            if (Status == null)
            {
                Status = new GlobalStatusDTO();
            }
            else
            {
                if (Status.RequestStatus == null)
                {
                    Status.RequestStatus = new RequestStatusDTO();
                }
            }
            Status.RequestStatus.Code = (int)statusCode;
            Status.RequestStatus.Message = statusMessage;
        }

        public void AddResponseStatus(HttpStatusCode statusCode, string statusMessage)
        {
            if (Status == null)
            {
                Status = new GlobalStatusDTO();
            }
            
            if (Status.RequestStatus == null)
            {
                Status.ResponseStatus = new ResponseStatusDTO();
            }

            Status.ResponseStatus.Code = (int)statusCode;
            Status.ResponseStatus.Message = statusMessage;
        }
    }
}
