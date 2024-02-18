using RealEstate.DataAccessLayer.Abstract;
using RealEstate.DataAccessLayer.Concrete;
using RealEstate.DataAccessLayer.Repositories;
using RealEstate.EntityLayer.Entities;

namespace RealEstate.DataAccessLayer.EntityFramework
{
    public class EfEmployeeDal : GenericRepository<Employee>, IEmployeeDal
    {
        private readonly EstateContext _context;
        public EfEmployeeDal(EstateContext context) : base(context)
        {
            _context = context;
        }
    }
}
