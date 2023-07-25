using DataAccessLayer_.Abstract;
using DataAccessLayer_.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer_.EntityFramework
{
    public class EfCategoryDal : GenericRepository<Category>, ICategoryDal
    {

    }
}
