using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Web.Api.Core.Data.Interfaces
{
    public interface IBaseRepository<T> where T : Entity
    {
        Task<List<T>> ObterTodos();
        Task Adicionar(T model);
        Task Excluir(T model);
    }
}
