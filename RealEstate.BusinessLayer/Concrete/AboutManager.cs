using RealEstate.BusinessLayer.Abstract;
using RealEstate.DataAccessLayer.Abstract;
using RealEstate.EntityLayer.Entities;

namespace RealEstate.BusinessLayer.Concrete
{
    internal class AboutManager : IAboutService
    {
        private readonly IAboutDal _aboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public Task CreateAsync(About entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<About>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<About> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task RemoveAsync(About entity)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(About entity)
        {
            throw new NotImplementedException();
        }
    }
}
