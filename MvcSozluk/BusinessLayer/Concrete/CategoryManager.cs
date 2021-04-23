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
        GenericRepository<Category> CategoryRepository = new GenericRepository<Category>();
        public List<Category> GetAllBL()
        {
            return CategoryRepository.List();
        }
        public void CatogoryAddBL(Category category)
        {
            if(category.CategoryName == "" || category.CategoryName.Length <= 3 || category.CategoryName.Length >= 51 || category.CategoryDescription == "")
            {
                // hata mesajı dönecek
            }
            else
            {
                CategoryRepository.Insert(category);
            }
        }
            
    }
}
