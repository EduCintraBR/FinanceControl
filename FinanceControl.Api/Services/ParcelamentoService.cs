using AutoMapper;
using FinanceControl.Api.Data;
using FinanceControl.Api.Models;
using FinanceControl.Api.Models.Dto;
using FinanceControl.Api.Models.Dto.Response;
using FinanceControl.Api.Services.IServices;
using Microsoft.EntityFrameworkCore;

namespace FinanceControl.Api.Services
{
    public class ParcelamentoService : BaseService<ParcelamentoDto, Parcelamento>, IParcelamentoService
    {
        private readonly FCDbContext _dbContext;
        private readonly IMapper _mapper;

        public ParcelamentoService(FCDbContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<ResponseDto> GerarParcelas(int idParcelamento)
        {
            var response = new ResponseDto();
            try
            {
                var parcelamento = await _dbContext.Parcelamento.FirstOrDefaultAsync(parc => parc.Id == idParcelamento);

                if (parcelamento == null) throw new ArgumentException("O Id do parcelamento informado não existe.");

                var qtdParcelas = parcelamento.QuantidadeParcelas;
                var valorParcela = parcelamento.ValorTotalCompra / qtdParcelas;
                var dataAtual = DateTime.Now;

                for (int i = 0; i < qtdParcelas; i++)
                {
                    dataAtual = dataAtual.AddMonths(1);
                    var parcela = new Parcela
                    {
                        CodParcelamento = idParcelamento,
                        MesAno = $"{dataAtual.Month}/{dataAtual.Year}",
                        ParcelaAtual = (short)(i + 1),
                        ParcelaFinal = qtdParcelas,
                        Valor = valorParcela
                    };

                    await CriaParcelaESalva(parcela);
                }
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = ex.Message;
            }

            return response;
        }

        public async Task CriaParcelaESalva(Parcela parcela)
        {
            await _dbContext.Parcela.AddAsync(parcela);
            await _dbContext.SaveChangesAsync();
        }
    }
}
