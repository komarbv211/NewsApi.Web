using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsApi.Core.Interfaces
{
    public interface IBaseService<T>
    {
        Task Insert(object model);
        Task<List<object>> GetAll();
        Task<object> Get(int id);
        Task Update(object news, int id);
        Task Delete(int id);

    }
}
