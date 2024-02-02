using NewsApi.Core.Entities;
using NewsApi.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsApi.Core.Services
{
    internal class NewsService : INewsService
    {
        Task<News> INewsService.Delete(int id)
        {
            throw new NotImplementedException();
        }

        Task<News> INewsService.Get(int id)
        {
            throw new NotImplementedException();
        }

        Task<List<News>> INewsService.GetAll()
        {
            throw new NotImplementedException();
        }

        Task<News> INewsService.Update(News news)
        {
            throw new NotImplementedException();
        }
    }
}
