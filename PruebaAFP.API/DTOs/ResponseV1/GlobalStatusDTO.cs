namespace PruebaAFP.API.DTOs.ResponseV1
{
    public class GlobalStatusDTO
    {
        public RequestStatusDTO RequestStatus { get; set; }
        public ResponseStatusDTO ResponseStatus { get; set; }

        public GlobalStatusDTO() 
        { 
            RequestStatus = new RequestStatusDTO();
            ResponseStatus = new ResponseStatusDTO();
        }
    }
}
