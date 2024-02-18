using RealEstate.DataAccessLayer.Abstract;
using RealEstate.DataAccessLayer.Concrete;
using RealEstate.DataAccessLayer.Repositories;
using RealEstate.EntityLayer.Entities;

namespace RealEstate.DataAccessLayer.EntityFramework
{
    public class EfFooterContactDal : GenericRepository<FooterContact>, IFooterContactDal
    {
        private readonly EstateContext _context;
        public EfFooterContactDal(EstateContext context) : base(context)
        {
            _context = context;
        }
    }
}
