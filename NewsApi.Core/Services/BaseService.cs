using AutoMapper;
using NewsApi.Core.DTOs;
using NewsApi.Core.Entities;
using NewsApi.Core.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace NewsApi.Core.Services
{
    public class BaseService<T> : IBaseService<T> where T : class, IEntity
    {
        private readonly IRepository<T> _repository;
        private readonly IMapper _mapper;

        public BaseService(IRepository<T> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task Insert(object model)
        {
            var entity = _mapper.Map<T>(model);
            await _repository.Insert(entity);
            await _repository.Save();
        }

        public async Task Update(object model, int id)
        {
            var entity = _mapper.Map<T>(model);
            entity.Id = id;
            await _repository.Update(entity);
            await _repository.Save();
        }

        public async Task<List<object>> GetAll()
        {
            var entities = await _repository.GetAll();
            return _mapper.Map<List<object>>(entities);
        }

        public async Task<object> Get(int id)
        {
            var entity = await _repository.GetByID(id);
            return _mapper.Map<object>(entity);
        }

        public async Task Delete(int id)
        {
            await _repository.Delete(id);
            await _repository.Save();
        }
    }
}
