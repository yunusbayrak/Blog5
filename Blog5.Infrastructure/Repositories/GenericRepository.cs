using Blog5.Infrastructure.Abstract;
using Blog5.Infrastructure.Concrete;
using Blog5.Infrastructure.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog5.Infrastructure.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        BlogContext context = new BlogContext();
        public ServiceResult<T> Add(T entity)
        {
            context.Add(entity);
            context.SaveChanges();
            return new ServiceResult<T>() { Status = ServiceResultStatus.SUCCESS, Data = entity };
        }

        public ServiceResult<T> GetById(int id)
        {
            var c = context.Set<T>().Find(id);
            return new ServiceResult<T>() { Status = ServiceResultStatus.SUCCESS, Data = c };
        }

        public ServiceResult<List<T>> ListAll()
        {
            var c = context.Set<T>().ToList();
            return new ServiceResult<List<T>>() { Status = ServiceResultStatus.SUCCESS, Data = c };
        }

        public ServiceResult Remove(int id)
        {
            var c = context.Set<T>().Find(id);
            context.Set<T>().Remove(c);
            context.SaveChanges();
            return new ServiceResult() { Status = ServiceResultStatus.SUCCESS };
        }

        public ServiceResult Update(T entity)
        {
            context.Update(entity);
            context.SaveChanges();
            return new ServiceResult() { Status = ServiceResultStatus.SUCCESS };
        }
    }
}
