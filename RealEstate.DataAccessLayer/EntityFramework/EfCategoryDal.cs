using RealEstate.DataAccessLayer.Abstract;
using RealEstate.DataAccessLayer.Concrete;
using RealEstate.DataAccessLayer.Repositories;
using RealEstate.EntityLayer.Entities;

namespace RealEstate.DataAccessLayer.EntityFramework
{
    public class EfCategoryDal : GenericRepository<Category>, ICategoryDal
    {
        private readonly EstateContext _context;
        public EfCategoryDal(EstateContext context) : base(context)
        {
            _context = context;
        }
    }
}
