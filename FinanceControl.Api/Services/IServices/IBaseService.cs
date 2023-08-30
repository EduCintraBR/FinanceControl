namespace FinanceControl.Api.Services.IServices
{
    public interface IBaseService<TEntity> where TEntity : class
    {
        Task<TEntity> ObtemPorId(int id); 
        Task<IEnumerable<TEntity>> ListarTodos(); 
        Task<TEntity> Criar(TEntity entity);
        Task<TEntity> Alterar(int id, TEntity entity);
        Task<TEntity> Deletar(int id);
    }
}
