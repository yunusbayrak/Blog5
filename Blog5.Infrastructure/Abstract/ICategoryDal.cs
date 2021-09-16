using Blog5.Data.Concrete;
using Blog5.Infrastructure.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog5.Infrastructure.Abstract
{
    public interface ICategoryDal
    {
        ServiceResult<List<Category>> ListAllCategories();
        ServiceResult<Category> AddCategory(Category category);
        ServiceResult RemoveCategory(int id);
        ServiceResult UpdateCategory(Category category);
        ServiceResult<Category> GetById(int id);
    }
}
