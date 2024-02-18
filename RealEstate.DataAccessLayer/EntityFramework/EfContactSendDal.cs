using RealEstate.DataAccessLayer.Abstract;
using RealEstate.DataAccessLayer.Concrete;
using RealEstate.DataAccessLayer.Repositories;
using RealEstate.EntityLayer.Entities;

namespace RealEstate.DataAccessLayer.EntityFramework
{
    public class EfContactSendDal : GenericRepository<ContactSend>, IContactSendDal
    {
        private readonly EstateContext _context;
        public EfContactSendDal(EstateContext context) : base(context)
        {
            _context = context;
        }
    }
}
