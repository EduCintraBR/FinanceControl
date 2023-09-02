namespace FinanceControl.Api.Models.Dto.Response
{
    public class ResponseDto
    {
        public bool IsSuccess { get; set; } = true;
        public string? Message { get; set; } = string.Empty;
    }
}
