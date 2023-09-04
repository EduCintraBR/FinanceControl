using AutoMapper;
using FinanceControl.Api.Data;
using FinanceControl.Api.Models.Dto.Response;
using FinanceControl.Api.Services.IServices;
using Microsoft.EntityFrameworkCore;

namespace FinanceControl.Api.Services
{
    public class BaseService<TDto, TPersistencia> : IBaseService<TDto> where TDto : class where TPersistencia : class
    {
        private readonly FCDbContext _db;
        private readonly IMapper _mapper;
        private ResponseListDto<TDto> _responseListDto;
        private ResponseResultDto<TDto> _responseResultDto;

        public BaseService(FCDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
            _responseListDto = new ResponseListDto<TDto>();
            _responseResultDto = new ResponseResultDto<TDto>();
        }

        public virtual async Task<ResponseResultDto<TDto>> Alterar(TDto entity)
        {
            var objToUpdate = _mapper.Map<TPersistencia>(entity);

            var objUpdated = _db.Set<TPersistencia>().Update(objToUpdate);
            await _db.SaveChangesAsync();
            _responseResultDto.Result = _mapper.Map<TDto>(objUpdated.Entity);

            return _responseResultDto;
        }

        public virtual async Task<ResponseResultDto<TDto>> Criar(TDto entity)
        {
            try
            {
                var objToInsert = _mapper.Map<TPersistencia>(entity);

                var objAdded = await _db.Set<TPersistencia>().AddAsync(objToInsert);
                await _db.SaveChangesAsync();
                _responseResultDto.Result = _mapper.Map<TDto>(objAdded.Entity);
            }
            catch (Exception ex)
            {
                _responseResultDto.IsSuccess = false;
                _responseResultDto.Message = $"MessageError = {ex.Message} \n InnerMessageError = {ex.InnerException.Message}";
            }

            return _responseResultDto;
        }

        public virtual async Task<ResponseDto> Deletar(int id)
        {
            var response = new ResponseDto();
            try
            {
                var entity = _db.Set<TPersistencia>().Find(id);
                if (entity is null)
                {
                    throw new ArgumentException("Não foi possível realizar a exclusão, o Id é inexistente no banco de dados.");
                }

                _db.Set<TPersistencia>().Remove(entity);
                await _db.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = ex.Message;
            }

            return response;
        }

        public virtual async Task<ResponseListDto<TDto>> ListarTodos()
        {
            var list = await _db.Set<TPersistencia>().ToListAsync();
            _responseListDto.List = _mapper.Map<IEnumerable<TDto>>(list);

            return _responseListDto;
        }

        public virtual async Task<ResponseResultDto<TDto>> ObtemPorId(int id)
        {
            var cartao = _db.Set<TPersistencia>().Find(id);
            _responseResultDto.Result = _mapper.Map<TDto>(cartao);

            return _responseResultDto;
        }
    }
}
