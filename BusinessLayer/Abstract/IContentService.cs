using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IContentService
    {
        List<Content> GetList();
        List<Content> GetListById(int Id);
        void ContentAdd(Content content);
        Content GetById(int Id);
        void ContentDelete(Content content);
        void ContentUpdate(Content content);
    }
}
