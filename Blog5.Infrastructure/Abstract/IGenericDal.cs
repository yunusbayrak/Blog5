using Blog5.Data.Concrete;
using Blog5.Infrastructure.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog5.Infrastructure.Abstract
{
    public interface IGenericDal<T> where T : class
    {
        ServiceResult<List<T>> ListAll();
        ServiceResult<T> Add(T entity);
        ServiceResult Remove(int id);
        ServiceResult Update(T entity);
        ServiceResult<T> GetById(int id);
    }
}
