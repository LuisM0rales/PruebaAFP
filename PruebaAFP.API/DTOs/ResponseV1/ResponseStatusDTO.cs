namespace PruebaAFP.API.DTOs.ResponseV1
{
    public class ResponseStatusDTO
    {
        public int Code { get; set; }
        public string Message { get; set; }

        public ResponseStatusDTO() 
        { 
            Code = 0;
            Message = "Success";
        }
    }
}
