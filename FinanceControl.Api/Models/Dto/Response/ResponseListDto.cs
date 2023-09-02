namespace FinanceControl.Api.Models.Dto.Response
{
    public class ResponseListDto<TDto> : ResponseDto where TDto : class
    {
        public IEnumerable<TDto> List { get; set; }
    }
}
