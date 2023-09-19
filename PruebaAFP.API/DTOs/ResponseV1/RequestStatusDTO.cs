namespace PruebaAFP.API.DTOs.ResponseV1
{
    public class RequestStatusDTO
    {
        public int Code { get; set; }
        public string Message { get; set; }

        public RequestStatusDTO()
        {
            Code = 200;
            Message = "Success";
        }
    }
}
