using Blog5.Data.Concrete;
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
    public class CategoryRepository : ICategoryDal
    {
        BlogContext context = new BlogContext();
        public ServiceResult<Category> AddCategory(Category category)
        {
            context.Add(category);
            context.SaveChanges();
            return new ServiceResult<Category>() { Status = ServiceResultStatus.SUCCESS, Data = category };
        }

        public ServiceResult<Category> GetById(int id)
        {
            var c = context.Categories.Find(id);
            return new ServiceResult<Category>() { Status = ServiceResultStatus.SUCCESS, Data = c };

        }

        public ServiceResult<List<Category>> ListAllCategories()
        {
            var c = context.Categories.ToList();
            return new ServiceResult<List<Category>>() { Status = ServiceResultStatus.SUCCESS, Data = c };

        }

        public ServiceResult RemoveCategory(int id)
        {
            var c = context.Categories.Find(id);
            context.Categories.Remove(c);
            context.SaveChanges();
            return new ServiceResult() { Status = ServiceResultStatus.SUCCESS };

        }

        public ServiceResult UpdateCategory(Category category)
        {
            context.Update(category);
            context.SaveChanges();
            return new ServiceResult() { Status = ServiceResultStatus.SUCCESS };

        }
    }
}
