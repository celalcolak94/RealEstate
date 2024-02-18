using RealEstate.DataAccessLayer.Abstract;
using RealEstate.DataAccessLayer.Concrete;
using RealEstate.DataAccessLayer.Repositories;
using RealEstate.EntityLayer.Entities;

namespace RealEstate.DataAccessLayer.EntityFramework
{
    public class EfEstateDal : GenericRepository<Estate>, IEstateDal
    {
        private readonly EstateContext _context;
        public EfEstateDal(EstateContext context) : base(context)
        {
            _context = context;
        }
    }
}
