using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager
    {
        GenericReporistory<Category> genericReporistory = new GenericReporistory<Category>();

        public List<Category> GetAllBL()
        {
            return genericReporistory.List();
        }

        public void CategoryAddBL(Category category)
        {
            genericReporistory.Insert(category);
        }
    }
}
