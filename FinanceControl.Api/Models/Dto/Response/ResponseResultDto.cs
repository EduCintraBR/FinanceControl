namespace FinanceControl.Api.Models.Dto.Response
{
    public class ResponseResultDto<TDto> : ResponseDto where TDto : class
    {
        public TDto? Result { get; set; }
    }
}
